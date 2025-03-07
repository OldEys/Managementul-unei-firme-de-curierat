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
    public partial class UC_Punctuld : UserControl
    {
        public OracleConnection Con { get; set; }

        public UC_Punctuld()
        {
            InitializeComponent();
        }

        private void UC_Punctuld_Load(object sender, EventArgs e)
        {

        }

        private void btn_afiseaza_Click(object sender, EventArgs e)
        {

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = Con;
            DataTable dt = new DataTable();
            OracleDataAdapter adapter;
            //string query = "SELECT c.id_curier, c.nume, c.prenume,c.salariu, " +
            //    "COUNT(co.cod_pin) AS nr_col_livrate , " +
            //    "COUNT(DISTINCT p.id_punct_ridicare) AS nr_puncte_ridicare " +
            //    "FROM Curier c JOIN Colet co ON c.id_curier = co.id_curier " +
            //    "JOIN Punct_de_ridicare p ON co.id_punct_ridicare = p.id_punct_ridicare" +
            //    " WHERE  co.stare_colet IN ('livrat','returnat') " +
            //    "GROUP BY  c.id_curier, c.nume, c.prenume,c.salariu HAVING COUNT(co.cod_pin) >= 4 " +
            //    "ORDER BY nr_col_livrate DESC";
            string query = "WITH ColeteLivrate AS (" +
                    "SELECT c.id_curier,c.id_sucursala, COUNT(co.cod_pin) AS nr_col_livrate " +
                    "FROM Curier c JOIN Colet co ON c.id_curier=co.id_curier " +
                    "WHERE co.stare_colet in ('livrat','returnat','ridicat') " +
                    "GROUP BY c.id_curier,c.id_sucursala " +
                    "HAVING COUNT (co.cod_pin)>= 4) " +
                "SELECT s.id_sucursala,s.nume AS nume_sucursala,COUNT(cl.id_curier) AS nr_curieri " +
                "FROM ColeteLivrate cl " +
                "JOIN Sucursala s ON cl.id_sucursala=s.id_sucursala " +
                "GROUP BY s.id_sucursala,s.nume " +
                "HAVING COUNT(cl.id_curier)>=3 " +
                "ORDER BY nr_curieri DESC";
            try
            {
                cmd.CommandText = query;
                adapter = new OracleDataAdapter(cmd);
                OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
                adapter.Fill(dt);
                grid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eroare la afisarea mesajului " + ex.Message);
            }
        }
    }
}
