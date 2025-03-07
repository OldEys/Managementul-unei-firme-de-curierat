using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web.Configuration;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace InterfataProiect.User_control
{

    public partial class UC_Punctula : UserControl
    {
        private string[] tabele = {"sucursala","curier","masina","document","furnizor","punct_de_ridicare",
        "client","colet","interactiune_client_punct"};
        public OracleConnection Con { get; set; }  
        private DataTable dt = new DataTable();
        private OracleDataAdapter adapter;
        private string sortare="ASC";
        public UC_Punctula()
        {
            InitializeComponent();
        }
        
        private void Afiseaza_Click(object sender, EventArgs e)
        {
            try
            {
                if (cb_sortare.Checked)
                {
                    sortare = "DESC";
                }
                else
                {
                    sortare = "ASC";
                }
                string valoareSelectata = cmb_selecteaza.Text;
                string conditieSortare = cmb_sortare.Text;
                string conditieCautare = cmb_cautare.Text;
                string condValoare = tb_valoare.Text;

                if (!tabele.Any(t => t.Equals(valoareSelectata, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("Elementul nu există în lista tabelelor permise.");
                    return;
                }

                grid.DataSource = null;
                grid.Columns.Clear();

                dt.Clear();
                dt.Columns.Clear();

                string query = $"SELECT * FROM {valoareSelectata} ";

                OracleCommand command = new OracleCommand();
                command.Connection = Con;

                if (!string.IsNullOrEmpty(conditieCautare) && !string.IsNullOrEmpty(condValoare))
                {
                    query += $"WHERE {conditieCautare} = :condValoare ";

                    OracleParameter param = new OracleParameter("condValoare", OracleDbType.Varchar2);
                    if (long.TryParse(condValoare, out long numericValue))
                    {
                        param.OracleDbType = OracleDbType.Int64;
                        param.Value = numericValue;
                    }
                    else if (DateTime.TryParse(condValoare, out DateTime dateValue))
                    {
                        param.OracleDbType = OracleDbType.Date;
                        param.Value = dateValue;
                    }
                    else
                    {
                        param.Value = condValoare;
                    }
                    command.Parameters.Add(param);
                }

                if (!string.IsNullOrEmpty(conditieSortare))
                {
                    query += $"ORDER BY {conditieSortare} {sortare}";
                }

                command.CommandText = query;

                adapter = new OracleDataAdapter(command);
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);

                adapter.Fill(dt);
                grid.DataSource = dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la încărcarea datelor: " + ex.Message);
            }

        }
        public void SaveData()
        {
            try
            {
                if (dt.GetChanges() != null)
                {
                    adapter.Update(dt);
                    MessageBox.Show("Modificările au fost salvate cu succes!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la salvarea datelor: " + ex.Message);
            }
        }
            
        private void UC_Punctula_Load(object sender, EventArgs e)
        {

        }

        private void cmb_sortare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb_selecteaza_SelectedIndexChanged(object sender, EventArgs e)
        {

            cmb_sortare.Items.Clear();
            cmb_cautare.Items.Clear();
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

            if (atributeTabele.ContainsKey(cmb_selecteaza.SelectedItem.ToString().ToLower()))
            {
                cmb_sortare.Items.AddRange(atributeTabele[cmb_selecteaza.SelectedItem.ToString().ToLower()].ToArray());
                cmb_cautare.Items.AddRange(atributeTabele[cmb_selecteaza.SelectedItem.ToString().ToLower()].ToArray());
            }
            else
            {
                MessageBox.Show("Tabelul selectat nu există!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmb_cautare_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_sorteaza_Click(object sender, EventArgs e)
        {

        }
    }
}
