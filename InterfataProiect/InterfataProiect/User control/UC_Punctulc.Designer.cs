namespace InterfataProiect.User_control
{
    partial class UC_Punctulc
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Punctulc));
            this.lbl_intrebare = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmb_tab2 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_tab3 = new System.Windows.Forms.ComboBox();
            this.cmb_cond1 = new System.Windows.Forms.ComboBox();
            this.cmb_cond2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmb_tab1 = new System.Windows.Forms.ComboBox();
            this.tb_cond1 = new System.Windows.Forms.TextBox();
            this.tb_cond2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.pan_tabele = new System.Windows.Forms.Panel();
            this.btn_selectare = new System.Windows.Forms.Button();
            this.pan_conditii = new System.Windows.Forms.Panel();
            this.cbl_3 = new System.Windows.Forms.CheckedListBox();
            this.btn_afisare = new System.Windows.Forms.Button();
            this.cbl_2 = new System.Windows.Forms.CheckedListBox();
            this.cbl_1 = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.pan_rezultat = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.pan_tabele.SuspendLayout();
            this.pan_conditii.SuspendLayout();
            this.pan_rezultat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_intrebare
            // 
            this.lbl_intrebare.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrebare.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            this.lbl_intrebare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_intrebare.Location = new System.Drawing.Point(310, 17);
            this.lbl_intrebare.Name = "lbl_intrebare";
            this.lbl_intrebare.Size = new System.Drawing.Size(579, 94);
            this.lbl_intrebare.TabIndex = 1;
            this.lbl_intrebare.Text = "Extragerea informațiilor din 3 tabele                      filtrate prin 2 condiț" +
    "ii";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectați tabelele din care doriți să extrageți informații";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.MediumPurple;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 32);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tabelul 1";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumPurple;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Tabelul 2";
            // 
            // cmb_tab2
            // 
            this.cmb_tab2.FormattingEnabled = true;
            this.cmb_tab2.Items.AddRange(new object[] {
            "Sucursala",
            "Curier",
            "Masina",
            "Document",
            "Furnizor",
            "Punct_de_ridicare",
            "Client",
            "Colet",
            "Interactiune_Client_Punct"});
            this.cmb_tab2.Location = new System.Drawing.Point(8, 215);
            this.cmb_tab2.Name = "cmb_tab2";
            this.cmb_tab2.Size = new System.Drawing.Size(203, 28);
            this.cmb_tab2.TabIndex = 7;
            this.cmb_tab2.SelectedIndexChanged += new System.EventHandler(this.cmb_tab2_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 32);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tabelul 3";
            // 
            // cmb_tab3
            // 
            this.cmb_tab3.FormattingEnabled = true;
            this.cmb_tab3.Items.AddRange(new object[] {
            "Sucursala",
            "Curier",
            "Masina",
            "Document",
            "Furnizor",
            "Punct_de_ridicare",
            "Client",
            "Colet",
            "Interactiune_Client_Punct"});
            this.cmb_tab3.Location = new System.Drawing.Point(8, 299);
            this.cmb_tab3.Name = "cmb_tab3";
            this.cmb_tab3.Size = new System.Drawing.Size(203, 28);
            this.cmb_tab3.TabIndex = 9;
            this.cmb_tab3.SelectedIndexChanged += new System.EventHandler(this.cmb_tab3_SelectedIndexChanged);
            // 
            // cmb_cond1
            // 
            this.cmb_cond1.FormattingEnabled = true;
            this.cmb_cond1.Location = new System.Drawing.Point(107, 41);
            this.cmb_cond1.Name = "cmb_cond1";
            this.cmb_cond1.Size = new System.Drawing.Size(203, 28);
            this.cmb_cond1.TabIndex = 11;
            // 
            // cmb_cond2
            // 
            this.cmb_cond2.FormattingEnabled = true;
            this.cmb_cond2.Location = new System.Drawing.Point(107, 106);
            this.cmb_cond2.Name = "cmb_cond2";
            this.cmb_cond2.Size = new System.Drawing.Size(203, 28);
            this.cmb_cond2.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(4, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(381, 43);
            this.label5.TabIndex = 13;
            this.label5.Text = "Selectați condițiile de filtrare";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.MediumPurple;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(4, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 32);
            this.label6.TabIndex = 14;
            this.label6.Text = "Condiția 1";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.MediumPurple;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(5, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Condiția 2";
            // 
            // cmb_tab1
            // 
            this.cmb_tab1.FormattingEnabled = true;
            this.cmb_tab1.Items.AddRange(new object[] {
            "Sucursala",
            "Curier",
            "Masina",
            "Document",
            "Furnizor",
            "Punct_de_ridicare",
            "Client",
            "Colet",
            "Interactiune_Client_Punct"});
            this.cmb_tab1.Location = new System.Drawing.Point(8, 130);
            this.cmb_tab1.Name = "cmb_tab1";
            this.cmb_tab1.Size = new System.Drawing.Size(203, 28);
            this.cmb_tab1.TabIndex = 16;
            this.cmb_tab1.SelectedIndexChanged += new System.EventHandler(this.cmb_tab1_SelectedIndexChanged);
            // 
            // tb_cond1
            // 
            this.tb_cond1.Location = new System.Drawing.Point(179, 75);
            this.tb_cond1.Name = "tb_cond1";
            this.tb_cond1.Size = new System.Drawing.Size(131, 26);
            this.tb_cond1.TabIndex = 17;
            // 
            // tb_cond2
            // 
            this.tb_cond2.Location = new System.Drawing.Point(179, 140);
            this.tb_cond2.Name = "tb_cond2";
            this.tb_cond2.Size = new System.Drawing.Size(131, 26);
            this.tb_cond2.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(5, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(183, 32);
            this.label8.TabIndex = 19;
            this.label8.Text = "Valoare condiție 2";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(4, 75);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(179, 32);
            this.label9.TabIndex = 20;
            this.label9.Text = "Valoare condiție 1";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(3, 41);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 62;
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(422, 406);
            this.grid.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(141, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(123, 31);
            this.label10.TabIndex = 22;
            this.label10.Text = "Rezultat";
            // 
            // pan_tabele
            // 
            this.pan_tabele.BackColor = System.Drawing.Color.MediumPurple;
            this.pan_tabele.Controls.Add(this.btn_selectare);
            this.pan_tabele.Controls.Add(this.cmb_tab2);
            this.pan_tabele.Controls.Add(this.label3);
            this.pan_tabele.Controls.Add(this.cmb_tab1);
            this.pan_tabele.Controls.Add(this.label4);
            this.pan_tabele.Controls.Add(this.cmb_tab3);
            this.pan_tabele.Controls.Add(this.label2);
            this.pan_tabele.Controls.Add(this.label1);
            this.pan_tabele.Location = new System.Drawing.Point(3, 128);
            this.pan_tabele.Name = "pan_tabele";
            this.pan_tabele.Size = new System.Drawing.Size(299, 450);
            this.pan_tabele.TabIndex = 23;
            // 
            // btn_selectare
            // 
            this.btn_selectare.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_selectare.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_selectare.Location = new System.Drawing.Point(3, 365);
            this.btn_selectare.Name = "btn_selectare";
            this.btn_selectare.Size = new System.Drawing.Size(131, 70);
            this.btn_selectare.TabIndex = 17;
            this.btn_selectare.Text = "Selectează";
            this.btn_selectare.UseVisualStyleBackColor = false;
            this.btn_selectare.Click += new System.EventHandler(this.btn_selectare_Click);
            // 
            // pan_conditii
            // 
            this.pan_conditii.BackColor = System.Drawing.Color.MediumPurple;
            this.pan_conditii.Controls.Add(this.tb_cond2);
            this.pan_conditii.Controls.Add(this.cbl_3);
            this.pan_conditii.Controls.Add(this.btn_afisare);
            this.pan_conditii.Controls.Add(this.cbl_2);
            this.pan_conditii.Controls.Add(this.cbl_1);
            this.pan_conditii.Controls.Add(this.cmb_cond2);
            this.pan_conditii.Controls.Add(this.label7);
            this.pan_conditii.Controls.Add(this.label5);
            this.pan_conditii.Controls.Add(this.label6);
            this.pan_conditii.Controls.Add(this.label8);
            this.pan_conditii.Controls.Add(this.cmb_cond1);
            this.pan_conditii.Controls.Add(this.tb_cond1);
            this.pan_conditii.Controls.Add(this.label9);
            this.pan_conditii.Controls.Add(this.label11);
            this.pan_conditii.Location = new System.Drawing.Point(308, 128);
            this.pan_conditii.Name = "pan_conditii";
            this.pan_conditii.Size = new System.Drawing.Size(432, 450);
            this.pan_conditii.TabIndex = 24;
            // 
            // cbl_3
            // 
            this.cbl_3.FormattingEnabled = true;
            this.cbl_3.Location = new System.Drawing.Point(255, 210);
            this.cbl_3.Name = "cbl_3";
            this.cbl_3.Size = new System.Drawing.Size(120, 165);
            this.cbl_3.TabIndex = 26;
            // 
            // btn_afisare
            // 
            this.btn_afisare.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_afisare.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_afisare.Location = new System.Drawing.Point(255, 377);
            this.btn_afisare.Name = "btn_afisare";
            this.btn_afisare.Size = new System.Drawing.Size(122, 70);
            this.btn_afisare.TabIndex = 21;
            this.btn_afisare.Text = "Afișează";
            this.btn_afisare.UseVisualStyleBackColor = false;
            this.btn_afisare.Click += new System.EventHandler(this.btn_afisare_Click);
            // 
            // cbl_2
            // 
            this.cbl_2.FormattingEnabled = true;
            this.cbl_2.Location = new System.Drawing.Point(129, 210);
            this.cbl_2.Name = "cbl_2";
            this.cbl_2.Size = new System.Drawing.Size(120, 165);
            this.cbl_2.TabIndex = 28;
            // 
            // cbl_1
            // 
            this.cbl_1.FormattingEnabled = true;
            this.cbl_1.Location = new System.Drawing.Point(3, 210);
            this.cbl_1.Name = "cbl_1";
            this.cbl_1.Size = new System.Drawing.Size(120, 165);
            this.cbl_1.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Century Gothic", 11F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(4, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(414, 74);
            this.label11.TabIndex = 29;
            this.label11.Text = "Selectați ce atribute doriți să afișați";
            // 
            // pan_rezultat
            // 
            this.pan_rezultat.BackColor = System.Drawing.Color.MediumPurple;
            this.pan_rezultat.Controls.Add(this.label10);
            this.pan_rezultat.Controls.Add(this.grid);
            this.pan_rezultat.Location = new System.Drawing.Point(746, 128);
            this.pan_rezultat.Name = "pan_rezultat";
            this.pan_rezultat.Size = new System.Drawing.Size(428, 450);
            this.pan_rezultat.TabIndex = 25;
            // 
            // UC_Punctulc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbl_intrebare);
            this.Controls.Add(this.pan_conditii);
            this.Controls.Add(this.pan_tabele);
            this.Controls.Add(this.pan_rezultat);
            this.Name = "UC_Punctulc";
            this.Size = new System.Drawing.Size(1197, 608);
            this.Load += new System.EventHandler(this.UC_Punctulc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.pan_tabele.ResumeLayout(false);
            this.pan_conditii.ResumeLayout(false);
            this.pan_conditii.PerformLayout();
            this.pan_rezultat.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_intrebare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmb_tab2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_tab3;
        private System.Windows.Forms.ComboBox cmb_cond1;
        private System.Windows.Forms.ComboBox cmb_cond2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmb_tab1;
        private System.Windows.Forms.TextBox tb_cond1;
        private System.Windows.Forms.TextBox tb_cond2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pan_tabele;
        private System.Windows.Forms.Panel pan_conditii;
        private System.Windows.Forms.Panel pan_rezultat;
        private System.Windows.Forms.Button btn_afisare;
        private System.Windows.Forms.Button btn_selectare;
        private System.Windows.Forms.CheckedListBox cbl_3;
        private System.Windows.Forms.CheckedListBox cbl_1;
        private System.Windows.Forms.CheckedListBox cbl_2;
        private System.Windows.Forms.Label label11;
    }
}
