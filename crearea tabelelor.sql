drop sequence suc_seq;
drop sequence doc_seq;
drop sequence curi_seq;
drop sequence fur_seq;
drop sequence cli_seq;
drop sequence pct_seq;
drop sequence int_seq;
drop trigger trg_interactiune;
drop trigger trg_document_validare;
drop trigger trg_verifica_documente;
drop table Interactiune_Client_Punct;
drop table Colet;
drop table Curier;
drop table Document;
drop table Masina;
drop table Punct_de_ridicare;
drop table Client;
drop table Furnizor;
drop table Sucursala;

CREATE TABLE Sucursala(
id_sucursala NUMBER(4,0) CONSTRAINT suc_pk PRIMARY KEY,
nume VARCHAR2(30) CONSTRAINT suc_nume_nn NOT NULL,
oras VARCHAR2(30) CONSTRAINT suc_oras_nn NOT NULL,
nume_strada VARCHAR2(30) CONSTRAINT suc_nume_strada_nn NOT NULL,
nr_locatie NUMBER(3,0) CONSTRAINT suc_nr_loc_nn NOT NULL,
nr_telefon CHAR(10) CONSTRAINT suc_nr_tel_nn NOT NULL,
email VARCHAR2(40) CONSTRAINT suc_email_nn NOT NULL);

ALTER TABLE Sucursala ADD(
CONSTRAINT suc_nr_loc_poz CHECK(nr_locatie>0),
CONSTRAINT suc_nr_tel_u UNIQUE(nr_telefon),
CONSTRAINT suc_nr_tel_lung CHECK (LENGTH(nr_telefon)=10),
CONSTRAINT suc_nr_tel_pref CHECK(nr_telefon like '07%'),
CONSTRAINT suc_email_fmt CHECK(email like '%@%.%'));

CREATE SEQUENCE suc_seq
START WITH 1 INCREMENT BY 1 NOCACHE  NOCYCLE;


ALTER TABLE Sucursala
MODIFY id_sucursala DEFAULT suc_seq.NEXTVAL;

CREATE TABLE Curier(
id_curier NUMBER(4,0) CONSTRAINT curi_pk PRIMARY KEY,
id_sucursala NUMBER(4,0) CONSTRAINT curi_suc_fk_nn NOT NULL,
nume VARCHAR2(20) CONSTRAINT curi_nume_nn NOT NULL,
prenume VARCHAR2(30) CONSTRAINT curi_prenume_nn NOT NULL,
nr_telefon CHAR(10) CONSTRAINT curi_nr_telefon_nn NOT NULL,
cnp CHAR(13) CONSTRAINT curi_cnp_nn NOT NULL,
salariu NUMBER(5,0) CONSTRAINT curi_sal_nn NOT NULL,
data_angajare DATE CONSTRAINT curi_ang_nn NOT NULL);

ALTER TABLE Curier ADD(
CONSTRAINT curi_suc_fk FOREIGN KEY (id_sucursala) REFERENCES 
Sucursala(id_sucursala) ON DELETE CASCADE,
CONSTRAINT curi_nr_tel_u UNIQUE(nr_telefon),
CONSTRAINT curi_nr_tel_lung CHECK (LENGTH(nr_telefon)=10),
CONSTRAINT curi_nr_tel_pref CHECK(nr_telefon like '07%'),
CONSTRAINT curi_cnp_u UNIQUE(cnp),
CONSTRAINT curi_cnp_lung CHECK(LENGTH(cnp)=13),
CONSTRAINT curi_cnp_pref CHECK(SUBSTR(cnp,1,1) IN ('1','2','5','6')),
CONSTRAINT curi_sal_poz CHECK(salariu>0));

CREATE SEQUENCE curi_seq
START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

ALTER TABLE Curier
MODIFY id_curier DEFAULT curi_seq.NEXTVAL;

CREATE TABLE Masina (
serie_sasiu CHAR(17) CONSTRAINT mas_pk PRIMARY KEY,
id_sucursala NUMBER(4,0) CONSTRAINT mas_cur_fk_nn NOT NULL,
nr_inmatriculare CHAR(7) CONSTRAINT mas_nr_inm_nn NOT NULL,
capacitate NUMBER(6,2) CONSTRAINT mas_cap_nn NOT NULL,
stare_masina VARCHAR2(20) CONSTRAINT mas_stare_nn NOT NULL,
marca VARCHAR2(15) CONSTRAINT mas_marca_nn NOT NULL,
model VARCHAR2(20) CONSTRAINT mas_modul_nn NOT NULL,
km_parcursi NUMBER(6,0) DEFAULT 0
);

ALTER TABLE Masina ADD(
CONSTRAINT mas_pk_lung CHECK(LENGTH(serie_sasiu)=17),
CONSTRAINT mas_pk_exc CHECK(UPPER(serie_sasiu) NOT LIKE '%I%' AND UPPER(serie_sasiu) NOT LIKE '%Q%' AND UPPER(serie_sasiu) NOT LIKE '%O%'),
CONSTRAINT mas_suc_fk FOREIGN KEY (id_sucursala) REFERENCES Sucursala(id_sucursala) ON DELETE CASCADE,
CONSTRAINT mas_nr_inm_lung CHECK(LENGTH(nr_inmatriculare)=7),
CONSTRAINT mas_nr_inm_u UNIQUE(nr_inmatriculare),
CONSTRAINT mas_cap_poz CHECK(capacitate>0),
CONSTRAINT mas_stare CHECK(UPPER(stare_masina) IN ('DISPONIBILA','IN REPARATIE','IN LIVRARE','NEAUTORIZATA')),
CONSTRAINT mas_km_poz CHECK(km_parcursi>0) 
);

CREATE TABLE Document (
id_document NUMBER(4,0) CONSTRAINT doc_pk PRIMARY KEY,
serie_sasiu CHAR(17) CONSTRAINT doc_mas_fk_nn NOT NULL,
tip_document VARCHAR2(30) CONSTRAINT doc_tip_nn NOT NULL,
data_emiterii DATE CONSTRAINT doc_date_emit_nn NOT NULL,
timp_valabilitate NUMBER(4,0) CONSTRAINT doc_timp_val_nn NOT NULL
);

ALTER TABLE Document ADD(
CONSTRAINT doc_mas_fk FOREIGN KEY (serie_sasiu) REFERENCES Masina(serie_sasiu) ON DELETE CASCADE,
CONSTRAINT doc_mas_fk_exc CHECK(UPPER(serie_sasiu) NOT LIKE '%I%' AND UPPER(serie_sasiu) NOT LIKE '%Q%' AND UPPER(serie_sasiu) NOT LIKE '%O%'),
CONSTRAINT doc_mas_fk_lung CHECK(LENGTH(serie_sasiu)=17),
CONSTRAINT doc_timp_val_poz CHECK(timp_valabilitate>0),
CONSTRAINT doc_tip_ CHECK(UPPER(tip_document) IN ('ASIGURARE AUTO','ITP','CIV','CERTIFICAT DE INMATRICULARE','ROVIGNIETA'))
);

CREATE SEQUENCE doc_seq
START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

ALTER TABLE Document
MODIFY id_document DEFAULT doc_seq.NEXTVAL;

CREATE OR REPLACE TRIGGER trg_document_validare
BEFORE INSERT ON Document
FOR EACH ROW
DECLARE
    last_doc_date DATE;
BEGIN

    SELECT MAX(data_emiterii + timp_valabilitate)
    INTO last_doc_date
    FROM Document
    WHERE tip_document = :NEW.tip_document and serie_sasiu=:NEW.serie_sasiu;

    IF last_doc_date IS NOT NULL AND :NEW.data_emiterii <= last_doc_date THEN
        RAISE_APPLICATION_ERROR(-20001, 'Un nou document nu poate fi emis înainte ca documentul anterior sã expire.');
    END IF;
END;
/

CREATE OR REPLACE TRIGGER trg_verifica_documente
AFTER INSERT OR UPDATE ON Document
DECLARE
    v_numar_documente INT;
    v_data_curenta DATE := SYSDATE;
BEGIN
    FOR rec IN (SELECT serie_sasiu
                FROM Document 
                WHERE ((UPPER(tip_document) IN ('ITP', 'ROVIGNIETA', 'ASIGURARE AUTO', 'CIV', 'CERTIFICAT DE INMATRICULARE'))
                      AND data_emiterii + timp_valabilitate >= v_data_curenta))
    LOOP
        SELECT COUNT(*)
        INTO v_numar_documente
        FROM Document 
        WHERE serie_sasiu = rec.serie_sasiu;
        
        IF v_numar_documente < 5 THEN
            UPDATE Masina
            SET stare_masina = 'NEAUTORIZATA'
            WHERE serie_sasiu = rec.serie_sasiu;
        END IF;
    END LOOP;
END;
/
CREATE TABLE Furnizor(
id_furnizor NUMBER(4,0) CONSTRAINT fur_pk PRIMARY KEY,
nume VARCHAR2(30) CONSTRAINT fur_nume_nn NOT NULL,
nume_strada VARCHAR2(30) CONSTRAINT fur_nume_str_nn NOT NULL,
nr_locatie NUMBER(3,0) CONSTRAINT fur_nr_loc_nn NOT NULL,
nr_telefon CHAR(10) CONSTRAINT fur_nr_tel_nn NOT NULL,
email VARCHAR2(40),
tip_produse VARCHAR2(30) CONSTRAINT fur_tip_nn NOT NULL);

ALTER TABLE Furnizor ADD(
CONSTRAINT fur_nr_loc_poz CHECK(nr_locatie>0),
CONSTRAINT fur_nr_tel_u UNIQUE(nr_telefon),
CONSTRAINT fur_nr_tel_lung CHECK(LENGTH(nr_telefon)=10),
CONSTRAINT fur_nr_tel_pref CHECK(nr_telefon like '07%'),
CONSTRAINT fur_email_fmt CHECK(email like '%@%.%'));

CREATE SEQUENCE fur_seq
START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

ALTER TABLE Furnizor 
MODIFY id_furnizor DEFAULT fur_seq.NEXTVAL;

CREATE TABLE Punct_de_ridicare(
id_punct_ridicare NUMBER(4,0) CONSTRAINT pct_pk PRIMARY KEY ,
oras VARCHAR2(30) CONSTRAINT pct_oras_nn NOT NULL,
nume VARCHAR2(30) CONSTRAINT pct_nume_nn NOT NULL,
nume_strada VARCHAR2(30) CONSTRAINT pct_nume_str_nn NOT NULL,
cod_postal CHAR(6) CONSTRAINT pct_cod_nn NOT NULL);

ALTER TABLE Punct_de_ridicare ADD(
CONSTRAINT pct_nume_u UNIQUE(nume),
CONSTRAINT pct_cod_lung CHECK(LENGTH(cod_postal)=6)
);

CREATE SEQUENCE pct_seq
START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

ALTER TABLE Punct_de_ridicare
MODIFY id_punct_ridicare DEFAULT pct_seq.NEXTVAL;


CREATE TABLE Colet(
cod_pin CHAR(6) CONSTRAINT col_pk PRIMARY KEY,
id_curier NUMBER(4,0) ,
id_furnizor NUMBER(4,0) ,
id_punct_ridicare NUMBER(4,0) ,
greutate NUMBER(5,2) CONSTRAINT col_grt_nn NOT NULL,
nume_destinatar VARCHAR2(20) CONSTRAINT col_nume_d_nn NOT NULL,
valoare_totala NUMBER(7,2) CONSTRAINT col_val_poz CHECK(valoare_totala>0),
stare_colet VARCHAR2(15) CONSTRAINT col_stare_nn NOT NULL);

ALTER TABLE Colet ADD(
CONSTRAINT col_curi_fk FOREIGN KEY(id_curier) REFERENCES Curier(id_curier) ON DELETE CASCADE,
CONSTRAINT col_fur_fk FOREIGN KEY(id_furnizor) REFERENCES Furnizor(id_furnizor) ON DELETE CASCADE,
CONSTRAINT col_pct_fk FOREIGN KEY(id_punct_ridicare) REFERENCES Punct_de_ridicare(id_punct_ridicare) ON DELETE CASCADE,
CONSTRAINT col_pk_lung CHECK(LENGTH(cod_pin)=6),
CONSTRAINT col_grt_poz CHECK(greutate>0),
CONSTRAINT col_stare CHECK(UPPER(stare_colet) in('IN PREGATIRE','IN DEPOZIT','IN LIVRARE','LIVRAT','IN RETUR','RETURNAT','RIDICAT'))
);

CREATE TABLE Client(
id_client NUMBER(4,0) CONSTRAINT cli_pk PRIMARY KEY,
nume VARCHAR2(20) CONSTRAINT cli_nume_nn NOT NULL,
prenume VARCHAR2(30) CONSTRAINT cli_prenume_nn NOT NULL,
nr_telefon CHAR(10) CONSTRAINT cli_nr_tel_nn NOT NULL,
email VARCHAR2(40) CONSTRAINT cli_email_nn NOT NULL,
tip_client VARCHAR2(15));

ALTER TABLE Client ADD(
CONSTRAINT cli_nr_tel_u UNIQUE(nr_telefon),
CONSTRAINT cli_nr_tel_lung CHECK(LENGTH(nr_telefon)=10),
CONSTRAINT cli_nr_tel_pref CHECK(nr_telefon like '07%'),
CONSTRAINT cli_email_u UNIQUE(email),
CONSTRAINT cli_email_fmt CHECK(email like '%@%.%'),
CONSTRAINT cli_tip CHECK(UPPER(tip_client) IN ('FIZIC','JURIDIC')));

CREATE SEQUENCE cli_seq
START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

ALTER TABLE Client
MODIFY id_client DEFAULT cli_seq.NEXTVAL;

CREATE TABLE Interactiune_Client_Punct(
id_interactiune NUMBER(4,0),
id_punct_ridicare NUMBER(4,0),
id_client NUMBER(4,0),
data_folosire DATE ,
tip_interactiune VARCHAR2(10));

ALTER TABLE Interactiune_Client_Punct ADD(
CONSTRAINT int_pct_fk FOREIGN KEY(id_punct_ridicare) REFERENCES Punct_de_ridicare(id_punct_ridicare) ON DELETE CASCADE,
CONSTRAINT int_cli_fk FOREIGN KEY(id_client) REFERENCES Client(id_client) ON DELETE CASCADE,
CONSTRAINT int_pk PRIMARY KEY(id_interactiune),
CONSTRAINT int_tip CHECK (UPPER(tip_interactiune) IN ('PREIA','RETURNEAZA')),
CONSTRAINT int_fk_nn CHECK(NOT (id_client IS NULL AND id_punct_ridicare IS NULL))
);
CREATE SEQUENCE int_seq
START WITH 1 INCREMENT BY 1 NOCACHE NOCYCLE;

ALTER TABLE Interactiune_Client_Punct
MODIFY id_interactiune DEFAULT int_seq.NEXTVAL;

CREATE OR REPLACE TRIGGER trg_interactiune
BEFORE INSERT OR UPDATE ON Interactiune_Client_Punct
FOR EACH ROW
BEGIN

  IF :NEW.id_punct_ridicare IS NULL OR :NEW.id_client IS NULL THEN
    :NEW.data_folosire := NULL;
    :NEW.tip_interactiune := NULL;
  END IF;
END;
/
