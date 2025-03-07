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
using TheArtOfDevHtmlRenderer.Adapters;

namespace InterfataProiect.User_control
{
    public partial class UC_Punctulf : UserControl
    {

        DataTable dt_compusa = new DataTable();
        DataTable dt_complexa = new DataTable();
        OracleDataAdapter adapter_compusa;
        OracleDataAdapter adapter_complexa;
        private OracleConnection con;
        public OracleConnection Con { get; set; }

        public UC_Punctulf()
        {
            InitializeComponent();
            pan_compusa.Hide();
            grid_compusa.Hide();
            pan_complexa.Hide();
            grid_complexa.Hide();
        }

        private void UC_Punctulf_Load(object sender, EventArgs e)
        {

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_afisare_Click(object sender, EventArgs e)
        {
            //cream un trigger de instead of pentru a putea insera in document
            //atunci cand dorim sa inseram in view
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Con;
            string trg = "CREATE OR REPLACE TRIGGER trg_insert_document " +
                "INSTEAD OF INSERT ON masini_documente FOR EACH ROW BEGIN " +
                "INSERT INTO Document (id_document, serie_sasiu, tip_document, data_emiterii, timp_valabilitate) " +
                "VALUES (:NEW.id_document, :NEW.doc_serie_sasiu, " +
                ":NEW.tip_document, :NEW.data_emiterii, :NEW.timp_valabilitate); END;";
            string viewCreate = "CREATE OR REPLACE VIEW masini_documente AS(" +
                "SELECT m.serie_sasiu AS masina_serie_sasiu, " +
            "m.nr_inmatriculare," +
            "m.id_sucursala, " +
            "m.capacitate, " +
            "m.marca," +
            "m.model, " +
            "m.km_parcursi," +
            "d.id_document," +
            "d.serie_sasiu AS doc_serie_sasiu," +
            "d.tip_document," +
            "d.data_emiterii," +
            "d.timp_valabilitate FROM Masina " +
                "m JOIN Document d on m.serie_sasiu=d.serie_sasiu)";
            //cream viewul si selectam tot din el 
            string query = "SELECT * FROM masini_documente";
            try
            {
                cmd.CommandText = trg;
                cmd.ExecuteNonQuery();
                cmd.CommandText = viewCreate;
                cmd.ExecuteNonQuery();
                cmd.CommandText = query;
                adapter_compusa = new OracleDataAdapter(cmd);
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter_compusa);
                adapter_compusa.Fill(dt_compusa);
                grid_compusa.DataSource = dt_compusa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afisarea mesajului " + ex.Message);
            }
        }
        private void ConfigureUpdateCommands()
        {
            //update ul implicit nu functioneaza cand dam join la tabele asadar
            //il suprascriem manual
            if (Con == null)
            {
                MessageBox.Show("Conexiunea nu este inițializată!");
                return;
            }

            //comanda de update
            adapter_compusa.UpdateCommand = new OracleCommand(
                "UPDATE Masina SET nr_inmatriculare = :nr_inmatriculare," +
                "id_sucursala=:id_sucursala, capacitate=:capacitate," +
                "marca=:marca, model=:model, km_parcursi=:km_parcursi " +
                "WHERE serie_sasiu = :serie_sasiu", Con);
            //adaugam parametrii din comanda de sus cu valorile scoase din introducerea datelor in grid
            //adapter cunoaste coloana deoarece i am dat fill in button press
            adapter_compusa.UpdateCommand.Parameters.Add(":nr_inmatriculare", OracleDbType.Char, 50).SourceColumn = "nr_inmatriculare";
            adapter_compusa.UpdateCommand.Parameters.Add(":id_sucursala", OracleDbType.Int64).SourceColumn = "id_sucursala";
            adapter_compusa.UpdateCommand.Parameters.Add(":capacitate", OracleDbType.Int64).SourceColumn = "capacitate";
            adapter_compusa.UpdateCommand.Parameters.Add(":marca", OracleDbType.Varchar2, 50).SourceColumn = "marca";
            adapter_compusa.UpdateCommand.Parameters.Add(":model", OracleDbType.Varchar2, 50).SourceColumn = "model";
            adapter_compusa.UpdateCommand.Parameters.Add(":km_parcursi", OracleDbType.Int64).SourceColumn = "km_parcursi";
            adapter_compusa.UpdateCommand.Parameters.Add(":serie_sasiu", OracleDbType.Varchar2, 50).SourceColumn = "serie_sasiu";
            
            OracleCommand updateDocumentCommand = new OracleCommand(
                "UPDATE Document SET tip_document = :tip_document, data_emiterii = :data_emiterii, " +
                "timp_valabilitate=:timp_valabilitate WHERE id_document = :id_document", Con);

            updateDocumentCommand.Parameters.Add(":tip_document", OracleDbType.Varchar2, 50).SourceColumn = "tip_document";
            updateDocumentCommand.Parameters.Add(":data_emiterii", OracleDbType.Date).SourceColumn = "data_emiterii";
            updateDocumentCommand.Parameters.Add(":timp_valabilitate", OracleDbType.Int64).SourceColumn = "timp_valabilitate";
            updateDocumentCommand.Parameters.Add(":id_document", OracleDbType.Int64, 50).SourceColumn = "id_document";

            adapter_compusa.UpdateCommand = updateDocumentCommand;
        }

        private void InsertDocument(DataRow row)
        {
            try
            {
             
                //cream o comanda noua de inserare in masini_documente
                //iar aceasta comanda va fi detectata de trigger si va insera in document
                OracleCommand insertDocumentCommand = new OracleCommand(
                    "INSERT INTO masini_documente (id_document, doc_serie_sasiu, tip_document, data_emiterii, timp_valabilitate) " +
                    "VALUES (:id_document, :doc_serie_sasiu, :tip_document, :data_emiterii, :timp_valabilitate)", Con);

                insertDocumentCommand.Parameters.Add(":id_document", OracleDbType.Int64).Value = row["id_document"];
                insertDocumentCommand.Parameters.Add(":doc_serie_sasiu", OracleDbType.Varchar2).Value = row["doc_serie_sasiu"];
                insertDocumentCommand.Parameters.Add(":tip_document", OracleDbType.Varchar2).Value = row["tip_document"];
                insertDocumentCommand.Parameters.Add(":data_emiterii", OracleDbType.Date).Value = row["data_emiterii"];
                insertDocumentCommand.Parameters.Add(":timp_valabilitate", OracleDbType.Int64).Value = row["timp_valabilitate"];

                insertDocumentCommand.ExecuteNonQuery();
                MessageBox.Show("Document inserat cu succes prin view!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la inserare: " + ex.Message);
            }
        }

        private void ConfigureDeleteCommands()
        {
            //configuram comanda de delete
            if (Con == null)
            {
                MessageBox.Show("Conexiunea nu este inițializată!");
                return;
            }

            //practic vom suprascrie toate comenzile de LMD ale adapterului
            OracleCommand deleteMasinaCommand = new OracleCommand(
                "DELETE FROM Masina WHERE serie_sasiu = :serie_sasiu", Con);

            deleteMasinaCommand.Parameters.Add(":serie_sasiu", OracleDbType.Varchar2, 50, "serie_sasiu");

            adapter_compusa.DeleteCommand = deleteMasinaCommand;

            OracleCommand deleteDocumentCommand = new OracleCommand(
                "DELETE FROM Document WHERE id_document = :id_document", Con);

            deleteDocumentCommand.Parameters.Add(":id_document", OracleDbType.Int64, 50, "id_document");

            adapter_compusa.DeleteCommand = deleteDocumentCommand;
        }
        public void SaveData()
        {
            //functie de salvare a datelor
            try
            {
                DataTable changes = dt_compusa.GetChanges();
                if (changes != null)
                {
                    //daca s au facut modificari atunci vedem ce fel de modificare avem
                    
                    foreach (DataRow row in changes.Rows)
                    {

                        if (row.RowState == DataRowState.Added)
                        {
                            //daca avem insert apelam functia de insert
                            InsertDocument(row);
                        }

                    }
                    //daca nu e insert atunci suprascriem comenzile de delete si update
                    //iar adapterul o foloseste pe cea care are nevoie
                    changes=dt_compusa.GetChanges(DataRowState.Modified|DataRowState.Deleted);
                    if(changes != null)
                    {
                        ConfigureDeleteCommands();
                        ConfigureUpdateCommands();
                        adapter_compusa.Update(dt_compusa);
                    }
                    MessageBox.Show("Modificările au fost salvate cu succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la modificarea datelor: " + ex.Message);
            }
        }

        private void btn_compusa_Click(object sender, EventArgs e)
        {
            pan_compusa.Show();
            grid_compusa.Show();

            pan_complexa.Hide();
            grid_complexa.Hide();
        }

        private void btn_complexa_Click(object sender, EventArgs e)
        {
            pan_complexa.Show();
            grid_complexa.Show();

            pan_compusa.Hide();
            grid_compusa.Hide();
        }

        private void btn_afisare_complexa_Click(object sender, EventArgs e)
        {
            OracleCommand cmd= new OracleCommand();
            cmd.Connection = Con;
            string viewCreate = "CREATE OR REPLACE VIEW masini_disponibile AS " +
                "SELECT s.id_sucursala, s.nume, " +
                "COUNT(m.serie_sasiu) masini_disp, SUM(m.capacitate) capacitate_tot " +
                "FROM sucursala s JOIN masina m on m.id_sucursala=s.id_sucursala " +
                "WHERE UPPER(stare_masina)='DISPONIBILA' " +
                "GROUP BY s.id_sucursala, s.nume " +
                "ORDER BY COUNT(m.serie_sasiu) DESC, SUM(m.capacitate) DESC";
            //cream viewul si selectam tot din el 
            string query = "SELECT * FROM masini_disponibile";
            try
            {
                cmd.CommandText = viewCreate;
                cmd.ExecuteNonQuery();
                cmd.CommandText = query;
                adapter_complexa = new OracleDataAdapter(cmd);
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter_complexa);
                adapter_complexa.Fill(dt_complexa);
                grid_complexa.DataSource = dt_complexa;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afisarea mesajului " + ex.Message);
            }
        }

        private void btn_salvare_Click(object sender, EventArgs e)
        {
            SaveData();
        }
    }
}

