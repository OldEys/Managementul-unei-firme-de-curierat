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

namespace InterfataProiect.User_control
{
    public partial class UC_Punctulb : UserControl
    {
        private string[] tabele = {"sucursala","curier","masina","document","furnizor","punct_de_ridicare",
        "client","colet","interactiune_client_punct"};
        public OracleConnection Con {  get; set; }
            public UC_Punctulb()
            {
                InitializeComponent();
                pan_stergere.Hide();
                pan_editare.Hide();
            }

        private void UC_Punctulb_Load(object sender, EventArgs e)
        {

        }
        private void cmb_stergere_selectare_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_stergere_criteriu.Items.Clear();
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

            if (atributeTabele.ContainsKey(cmb_stergere_selectare.SelectedItem.ToString().ToLower()))
            {
                cmb_stergere_criteriu.Items.AddRange(atributeTabele[cmb_stergere_selectare.SelectedItem.ToString().ToLower()].ToArray());
            }
            else
            {
                MessageBox.Show("Tabelul selectat nu există!");
            }
        }

        private void btn_stergere_conf_Click(object sender, EventArgs e)
        {

            string tabelStergere = cmb_stergere_selectare.Text;
            string criteriuStergere = cmb_stergere_criteriu.Text;
            string valoareStergere = tb_valoare.Text;
            if (!tabele.Any(t => t.Equals(tabelStergere, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Elementul nu există în lista tabelelor permise.");
                return;
            }
  
            string query = $"DELETE FROM {tabelStergere} ";
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Con;
            try
            {


                if (!string.IsNullOrEmpty(criteriuStergere) && !string.IsNullOrEmpty(valoareStergere))
                {
                    query += $"WHERE {criteriuStergere} = :valoareStergere";
                    OracleParameter param = new OracleParameter("valoareStergere", OracleDbType.Varchar2);
                    if (long.TryParse(valoareStergere, out long numericValue))
                    {
                        param.OracleDbType = OracleDbType.Int64;
                        param.Value = numericValue;
                    }
                    else if (DateTime.TryParse(valoareStergere, out DateTime dateValue))
                    {
                        param.OracleDbType = OracleDbType.Date;
                        param.Value = dateValue;
                    }
                    else
                    {
                        param.Value = valoareStergere;
                    }
                    cmd.Parameters.Add(param);
                }
                cmd.CommandText = query;
                int rowsAffected = cmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Datele au fost șterse cu succes.");
                }
                else
                {
                    MessageBox.Show("Nu s-au găsit date care să corespundă criteriului de ștergere.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la ștergerea datelor: " + ex.Message);

            }
        }

        private void btn_editare_Click(object sender, EventArgs e)
        {
            pan_editare.Show();
            pan_stergere.Hide();
        }

        private void btn_stergere_Click(object sender, EventArgs e)
        {
            pan_stergere.Show();
            pan_editare.Hide();
        }

        private void cmb_editare_selectare_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmb_editare_col.Items.Clear();
            cmb_editare_filtru.Items.Clear();
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

            if (atributeTabele.ContainsKey(cmb_editare_selectare.SelectedItem.ToString().ToLower()))
            {
                cmb_editare_col.Items.AddRange(atributeTabele[cmb_editare_selectare.SelectedItem.ToString().ToLower()].ToArray());
                cmb_editare_filtru.Items.AddRange(atributeTabele[cmb_editare_selectare.SelectedItem.ToString().ToLower()].ToArray());
            }
            else
            {
                MessageBox.Show("Tabelul selectat nu există!");
            }
        }
        private void btn_editare_conf_Click(object sender, EventArgs e)
        {
            string tabelEditare = cmb_editare_selectare.Text;
            string colEditare = cmb_editare_col.Text;
            string valNouaEditare = tb_editare_val_noua.Text;
            string filtruEditare = cmb_editare_filtru.Text;
            string valFiltruEditare = tb_editare_val_cautare.Text;
            string query = $"UPDATE {tabelEditare} ";
            if (!tabele.Any(t => t.Equals(tabelEditare, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Elementul nu există în lista tabelelor permise.");
                return;
            }
            if (valNouaEditare==valFiltruEditare && colEditare==filtruEditare)
            {
                MessageBox.Show("Nu puteți modifica cu aceeași valoare");
                return;
            }
            
            if (string.IsNullOrEmpty(tabelEditare) || string.IsNullOrEmpty(colEditare))
            {
                MessageBox.Show("Selectează tabelul și coloana de editat!");
                return;
            }
            try
            {
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = Con;
                if (!string.IsNullOrEmpty(colEditare) && !string.IsNullOrEmpty(valNouaEditare))
                {
                    query += $"SET {colEditare} = :valNouaEditare ";
                    OracleParameter param = new OracleParameter("valNouaEditare", OracleDbType.Varchar2);
                    if (long.TryParse(valNouaEditare, out long numericValue))
                    {
                        param.OracleDbType = OracleDbType.Int64;
                        param.Value = numericValue;
                    }
                    else if (DateTime.TryParse(valNouaEditare, out DateTime dateValue))
                    {
                        param.OracleDbType = OracleDbType.Date;
                        param.Value = dateValue;
                    }
                    else
                    {
                        param.Value = valNouaEditare;
                    }
                    cmd.Parameters.Add(param);
                }
                if (!string.IsNullOrEmpty(filtruEditare) && !string.IsNullOrEmpty(valFiltruEditare))
                {
                    query += $"WHERE {filtruEditare} = :valFiltruEditare ";
                    OracleParameter paramFiltru = new OracleParameter("valFiltruEditare", OracleDbType.Varchar2);
                    if (long.TryParse(valFiltruEditare, out long numericValue))
                    {
                        paramFiltru.OracleDbType = OracleDbType.Int64;
                        paramFiltru.Value = numericValue;
                    }
                    else if (DateTime.TryParse(valFiltruEditare, out DateTime dateValue))
                    {
                        paramFiltru.OracleDbType = OracleDbType.Date;
                        paramFiltru.Value = dateValue;
                    }
                    else
                    {
                        paramFiltru.Value = valFiltruEditare;
                    }
                    cmd.Parameters.Add(paramFiltru);
                }
                cmd.CommandText = query;
                int rowsAffected = cmd.ExecuteNonQuery(); 

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Actualizare realizată cu succes!");
                }
                else
                {
                    MessageBox.Show("Nicio înregistrare actualizată. Verifică datele introduse.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la actualizare: " + ex.Message);
            }
        }
        private void pan_editare_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
