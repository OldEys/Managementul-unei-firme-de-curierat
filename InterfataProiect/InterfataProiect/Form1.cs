using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.Design.WebControls;
using System.Windows.Forms;
using InterfataProiect.User_control;
using Oracle.ManagedDataAccess.Client;
namespace InterfataProiect
{
    public partial class Meniu : Form
    {

        private OracleConnection con;
        private UC_Punctula pa;
        private UC_Punctulf pf;
        private UserControl currentUserControl=null;
        private Button lastClickedButton = null;
        public Meniu()
        { 
            InitializeComponent();


            string connectionString = "Data Source=(DESCRIPTION=" +
                                      "(ADDRESS =(PROTOCOL=TCP)(HOST=LOCALHOST)(PORT=1521))" +
                                      "(CONNECT DATA = " +
                                      "(SERVER=DEDICATED)" +
                                      "(SID=XE)));User Id=project_root;password=rootpa55";

            con = new OracleConnection(connectionString);
            con.Open();  

            UC_MeniuPrincipal uc = new UC_MeniuPrincipal();  
            addUserControl(uc);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            if (currentUserControl != null)
            {
                if(currentUserControl is UC_Punctula pa)
                {
                    pa.SaveData();
                }
                if (currentUserControl is UC_Punctulf pf)
                {
                    pf.SaveData();
                }
            }
            userControl.Dock= DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
            userControl.BringToFront();
            currentUserControl = userControl;
        }


        private void MeniuPrincipal_Click(object sender, EventArgs e)
        {
            UC_MeniuPrincipal uc = new UC_MeniuPrincipal();
            addUserControl(uc);
            highlightButton(sender as Button);
        }

        private void punctula_Click_1(object sender, EventArgs e)
        {
            UC_Punctula uc = new UC_Punctula();
            uc.Con = con;
            addUserControl(uc);
            highlightButton(sender as Button);
        }

        private void punctulb_Click(object sender, EventArgs e)
        {
            UC_Punctulb uc = new UC_Punctulb();
            uc.Con = con;
            addUserControl(uc);
            highlightButton(sender as Button);
        }

        private void punctulc_Click(object sender, EventArgs e)
        {
            UC_Punctulc uc = new UC_Punctulc();
            uc.Con = con;
            addUserControl(uc);
            highlightButton(sender as Button);
        }

        private void punctuld_Click(object sender, EventArgs e)
        {
            UC_Punctuld uc = new UC_Punctuld();
            uc.Con = con;
            addUserControl(uc);
            highlightButton(sender as Button);
        }

        private void punctulf_Click(object sender, EventArgs e)
        {
            UC_Punctulf uc = new UC_Punctulf();
            uc.Con = con;
            addUserControl(uc);
            highlightButton(sender as Button);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
        private void highlightButton(Button clickedButton)
        {
            if(lastClickedButton!=null)
            {
                lastClickedButton.BackColor= Color.White;
            }
            clickedButton.BackColor = Color.LightGray;
            lastClickedButton = clickedButton;
        }

    }

}
