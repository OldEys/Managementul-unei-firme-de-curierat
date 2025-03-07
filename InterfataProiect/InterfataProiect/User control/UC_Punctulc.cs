using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace InterfataProiect.User_control
{
    public partial class UC_Punctulc : UserControl
    {
        public OracleConnection Con { get; set; }
        private DataTable dt=new DataTable();

        private string[] tabele = { "sucursala", "curier", "masina", "document", "furnizor", "punct_de_ridicare", "client", "colet", "interactiune_client_punct" };
        private string[] pk = { "id_sucursala", "id_curier", "serie_sasiu", "id_document", "id_furnizor", "id_punct_ridicare", "id_client", "cod_pin", "id_interactiune" };
        public UC_Punctulc()
        {
            InitializeComponent();
            pan_conditii.Hide();
            pan_rezultat.Hide();
        }

        private void UC_Punctulc_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void cmb_tab1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_tab2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cmb_tab3_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void PopuleazaAtribute(string tabelSelectat)
        {
            //dictionary cu toate schemele relationale 
            Dictionary<string, List<string>> atributeTabele = new Dictionary<string, List<string>>()
            {
                { "sucursala", new List<string> { "id_sucursala", "nume", "oras", "nume_strada", "nr_locatie", "nr_telefon", "email" } },
                { "curier", new List<string> { "id_curier", "id_sucursala", "nume", "prenume", "nr_telefon", "cnp", "salariu", "data_angajare" } },
                { "client", new List<string> { "id_client", "nume", "prenume", "nr_telefon", "email","tip_client" } },
                { "masina" ,new List<string> { "serie_sasiu","nr_inmatriculare","capacitate","stare_masina","marca","model","km_parcursi" } },
                { "document" ,new List<string> { "id_document","serie_sasiu","tip_document","data_emiterii","timp_valabilitate"} },
                { "furnizor" ,new List<string> { "id_furnizor","nume","nume_strada","nr_locatie","nr_telefon","email","tip_produse" } },
                { "punct_de_ridicare" ,new List<string> { "id_punct_ridicare","oras","nume","nume_strada","cod_postal" } },
                { "colet" ,new List<string> { "cod_pin","id_curier","capacitate","id_furnizor","id_punct_ridicare","greutate","nume_destinatar","valoare_totala","stare_colet" } },
                { "interactiune_client_punct" ,new List<string> { "id_interactiune","id_punct_ridicare","id_client","data_folosire","tip_interactiune" } }
            };
            //daca dictionarul contine tabelSelectat ca nume de tabel ,adauga in combobox toate atributele
            //din dict care au ca key numele tabelului selectat
            if (atributeTabele.ContainsKey(tabelSelectat.ToLower()))
            {
                //cmb_cond1.Items.AddRange(atributeTabele[tabelSelectat.ToLower()].ToArray());
                cmb_cond1.Items.AddRange(atributeTabele[tabelSelectat.ToLower()]
                    .Select(atribut => $"{tabelSelectat}.{atribut}").ToArray());
                //adauga ca range lista cu atribute corespunzatoare numelui tabelului ,iar la final
                //face conversia din list in array 
                cmb_cond2.Items.AddRange(atributeTabele[tabelSelectat.ToLower()]
                    .Select(atribut => $"{tabelSelectat}.{atribut}").ToArray());
            }
            else
            {
                MessageBox.Show("Tabelul selectat nu există!");
            }
        }

        private void PopuleazaCheckBoxList(CheckedListBox cbl,ComboBox cb)
        {
            cbl.Items.Clear();
            Dictionary<string, List<string>> atributeTabele = new Dictionary<string, List<string>>()
            {
                { "sucursala", new List<string> { "id_sucursala", "nume", "oras", "nume_strada", "nr_locatie", "nr_telefon", "email" } },
                { "curier", new List<string> { "id_curier", "id_sucursala", "nume", "prenume", "nr_telefon", "cnp", "salariu", "data_angajare" } },
                { "client", new List<string> { "id_client", "nume", "prenume", "nr_telefon", "email","tip_client" } },
                { "masina" ,new List<string> { "serie_sasiu","nr_inmatriculare","capacitate","stare_masina","marca","model","km_parcursi" } },
                { "document" ,new List<string> { "id_document","serie_sasiu","tip_document","data_emiterii","timp_valabilitate"} },
                { "furnizor" ,new List<string> { "id_furnizor","nume","nume_strada","nr_locatie","nr_telefon","email","tip_produse" } },
                { "punct_de_ridicare" ,new List<string> { "id_punct_ridicare","oras","nume","nume_strada","cod_postal" } },
                { "colet" ,new List<string> { "cod_pin","id_curier","capacitate","id_furnizor","id_punct_ridicare","greutate","nume_destinatar","valoare_totala","stare_colet" } },
                { "interactiune_client_punct" ,new List<string> { "id_interactiune","id_punct_ridicare","id_client","data_folosire","tip_interactiune" } }
            };
            if (atributeTabele.ContainsKey(cb.SelectedItem.ToString().ToLower()))
            {
                cbl.Items.AddRange(atributeTabele[cb.SelectedItem.ToString().ToLower()].ToArray());
            }
            else
            {
                MessageBox.Show("Tabelul selectat nu există!");
            }

        }
        private void btn_selectare_Click(object sender, EventArgs e)
        {
            //cand apasam selecteaza sterge tot din comboboxuri
            cmb_cond1.Items.Clear();
            cmb_cond2.Items.Clear();
            string tabel1 = cmb_tab1.Text;
            string tabel2 = cmb_tab2.Text;
            string tabel3 = cmb_tab3.Text;
            //verifica daca tabelele sunt goale sau identice,daca nu ,populam
            //comboboxurile si checkboxlisturile cu atribute
            if (tabel1 == "" || tabel2 == "" || tabel3 == "")
            {
                MessageBox.Show("Tabele neselectate ! Selectați 3 tabele valide !");
                return;
            }
            if (tabel1 == tabel2 || tabel2 == tabel3 || tabel1 == tabel3)
            {
                MessageBox.Show("Tabele echivalente , reîncearcă cu tabele distincte");
                return;
            }
            PopuleazaAtribute(tabel1);
            PopuleazaAtribute(tabel2);
            PopuleazaAtribute(tabel3);
            PopuleazaCheckBoxList(cbl_1, cmb_tab1);
            PopuleazaCheckBoxList(cbl_2, cmb_tab2);
            PopuleazaCheckBoxList(cbl_3, cmb_tab3);
            pan_conditii.Show();
            //afisam urm panel ( cel cu conditiile de filtrare)
        }
        string FindForeignKey(string tabelSource, string tabelDest)
        {
            //verifica daca tabelDest are ca foreign key , primary keyul lui tabelSource
            //practic verifica daca dest e fiul lui source
            Dictionary<string, List<string>> foreignKeys = new Dictionary<string, List<string>>
            {
                { "curier", new List<string> { "id_sucursala" } },
                { "masina", new List<string> { "id_sucursala" } },
                { "document", new List<string> { "serie_sasiu" } },
                { "colet", new List<string> { "id_curier", "id_punt_ridicare,id_furnizor" } },
                { "interactiune_client_punct", new List<string> { "id_client", "id_punct_ridicare" } }
            };
            if (foreignKeys.ContainsKey(tabelDest.ToLower()))
            {
                //daca dest se afla in dictionarul cu tabele care au fk uri
                var fkList = foreignKeys[tabelDest.ToLower()];
                foreach (var fk in fkList)
                {
                    //daca se regaseste pk ul lui source in unul din fk urile lui dest returneaza stringul
                    if (fk.Contains(pk[Array.IndexOf(tabele, tabelSource.ToLower())]))
                    {
                        return fk;
                    }
                }
                return null;
            }
            return null;
        }

        private void btn_afisare_Click(object sender, EventArgs e)
        {
            
            string tabel1 = cmb_tab1.Text;
            string tabel2 = cmb_tab2.Text;
            string tabel3 = cmb_tab3.Text;
            string cond1 = cmb_cond1.Text;
            string cond2 = cmb_cond2.Text;
            string valCond1 = tb_cond1.Text;
            string valCond2 = tb_cond2.Text;

            //curata grid  si datatable , pentru a putea afisa de mai multe ori fara sa inchidem
            grid.DataSource = null;
            grid.Columns.Clear();

            dt.Clear();
            dt.Columns.Clear();


            int indexTabel1 = Array.IndexOf(tabele, tabel1.ToLower());
            int indexTabel2 = Array.IndexOf(tabele, tabel2.ToLower());
            int indexTabel3 = Array.IndexOf(tabele, tabel3.ToLower());

            //indexTabel este indexul din arrayul de stringuri a tabelului
            //acel index este folosit pentru corespondenta cu pk urile tabelelor 
            string pkTabel1 = pk[indexTabel1];
            string pkTabel2 = pk[indexTabel2];
            string pkTabel3 = pk[indexTabel3];
            string fkTabel2 = FindForeignKey(tabel1, tabel2);
            string fkTabel3 = FindForeignKey(tabel2, tabel3);

            string query = $"SELECT ";
            //pentru fiecare casuta in checkboxlist bifata va afisa acel atribut
            //folosit pentru a nu avea ambiguitati si pentru flexibilitate
            foreach(var item in cbl_1.CheckedItems)
            {
                query += $"{tabel1}.{item.ToString()},";
            }
            foreach (var item in cbl_2.CheckedItems)
            {
                query += $"{tabel2}.{item.ToString()},";
            }
            foreach (var item in cbl_3.CheckedItems)
            {
                query += $"{tabel3}.{item.ToString()},";
            }
            string joinCondition1;
            string joinCondition2;
            //verificam care dintre tabel1 si 2 e parintele,copilul sau daca exista o relatie intre ele
            if(FindForeignKey(tabel1,tabel2) != null)
            {
                //1 e parinte,2 copil
                joinCondition1 = $"{tabel1}.{pkTabel1} = {tabel2}.{fkTabel2}";
            }
            else
            {
                fkTabel2 = FindForeignKey(tabel2,tabel1);
                if (fkTabel2 == null){
                    //nu exista relatie
                    MessageBox.Show("tabelele 1 si 2 nu sunt legate");
                    return;
                }
                //2 e parinte ,1 copil
                joinCondition1 = $"{tabel1}.{fkTabel2} = {tabel2}.{pkTabel2}";
            }
            if (FindForeignKey(tabel2, tabel3) != null)
            {
                joinCondition2 = $"{tabel2}.{pkTabel2} = {tabel3}.{fkTabel3}";
            }
            else
            {
                fkTabel3 = FindForeignKey(tabel3, tabel2);
                if (fkTabel3 == null)
                {
                    MessageBox.Show("tabelele 2 si 3 nu sunt legate");
                    return;
                }
                joinCondition2 = $"{tabel2}.{fkTabel2} = {tabel3}.{pkTabel3}";
            }
            query = query.TrimEnd(',');
            query += $" FROM {tabel1} JOIN {tabel2} ON {joinCondition1} JOIN {tabel3} ON {joinCondition2} ";
            try
            {
                //cream o noua comanda si un adapter 
                OracleCommand cmd = new OracleCommand();
                OracleDataAdapter adapter;
                cmd.Connection = Con;
                
                //facem conversia valorii cu care se verifica in clauza where
                if (!string.IsNullOrEmpty(cond1) && !string.IsNullOrEmpty(valCond1)
                    && !string.IsNullOrEmpty(cond2) && !string.IsNullOrEmpty(valCond2))
                {
                    query += $"WHERE {cond1} = :valCond1 AND {cond2} = :valCond2";
                    //cream un nou parametru care va fi in locul textului "valCond1/2"
                    OracleParameter joinParam1 = new OracleParameter("valCond1", OracleDbType.Varchar2);
                    OracleParameter joinParam2 = new OracleParameter("valCond2", OracleDbType.Varchar2);

                    if (long.TryParse(valCond1, out long numericValue1))
                    {
                        //daca reuseste conversia specificam tipul de date al parametrului
                        //si valoarea sa
                        joinParam1.OracleDbType = OracleDbType.Int64;
                        joinParam1.Value = numericValue1;
                    }
                    else if (DateTime.TryParse(valCond1, out DateTime dateValue1))
                    {
                        joinParam1.OracleDbType = OracleDbType.Date;
                        joinParam1.Value = dateValue1;
                    }
                    else
                    {
                        joinParam1.Value = valCond1;
                    }

                    if (long.TryParse(valCond2, out long numericValue2))
                    {
                        joinParam2.OracleDbType = OracleDbType.Int64;
                        joinParam2.Value = numericValue2;
                    }
                    else if (DateTime.TryParse(valCond2, out DateTime dateValue2))
                    {
                        joinParam2.OracleDbType = OracleDbType.Date;
                        joinParam2.Value = dateValue2;
                    }
                    else
                    {
                        joinParam2.Value = valCond2;
                    }
                    //adaugam parametrii la cmd pentru a lua locul textului provizoriu ":valCond1/2"
                    cmd.Parameters.Add(joinParam1);
                    cmd.Parameters.Add(joinParam2);


                }

                cmd.CommandText = query;
                adapter = new OracleDataAdapter(cmd);//asignam adapterul cu comanda noastra
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);//facem un builer
                //pe baza adapterului

                //rezultatul din adapter umple dataTabel ul
                adapter.Fill(dt);
                //gridul va afisa tabelul din dt
                grid.DataSource = dt;

                pan_rezultat.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la incarcarea datelor: " + ex.Message);
            }
        }

    }
}
