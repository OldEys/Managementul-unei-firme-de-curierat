namespace InterfataProiect.User_control
{
    partial class UC_Punctula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Punctula));
            this.lbl_Selecteaza = new System.Windows.Forms.Label();
            this.cmb_selecteaza = new System.Windows.Forms.ComboBox();
            this.Afiseaza = new System.Windows.Forms.Button();
            this.grid = new System.Windows.Forms.DataGridView();
            this.lbl_sorteaza = new System.Windows.Forms.Label();
            this.cb_sortare = new System.Windows.Forms.CheckBox();
            this.cmb_sortare = new System.Windows.Forms.ComboBox();
            this.cmb_cautare = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_valoare = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Selecteaza
            // 
            this.lbl_Selecteaza.AutoSize = true;
            this.lbl_Selecteaza.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Selecteaza.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_Selecteaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Selecteaza.Location = new System.Drawing.Point(385, 15);
            this.lbl_Selecteaza.Name = "lbl_Selecteaza";
            this.lbl_Selecteaza.Size = new System.Drawing.Size(445, 51);
            this.lbl_Selecteaza.TabIndex = 0;
            this.lbl_Selecteaza.Text = "Selectează un tabel";
            // 
            // cmb_selecteaza
            // 
            this.cmb_selecteaza.FormattingEnabled = true;
            this.cmb_selecteaza.Items.AddRange(new object[] {
            "Sucursala",
            "Curier",
            "Masina",
            "Document",
            "Furnizor",
            "Punct_de_ridicare",
            "Client",
            "Colet",
            "Interactiune_Client_Punct"});
            this.cmb_selecteaza.Location = new System.Drawing.Point(414, 79);
            this.cmb_selecteaza.Name = "cmb_selecteaza";
            this.cmb_selecteaza.Size = new System.Drawing.Size(388, 28);
            this.cmb_selecteaza.TabIndex = 1;
            this.cmb_selecteaza.SelectedIndexChanged += new System.EventHandler(this.cmb_selecteaza_SelectedIndexChanged);
            // 
            // Afiseaza
            // 
            this.Afiseaza.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.Afiseaza.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afiseaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Afiseaza.Location = new System.Drawing.Point(44, 147);
            this.Afiseaza.Name = "Afiseaza";
            this.Afiseaza.Size = new System.Drawing.Size(160, 81);
            this.Afiseaza.TabIndex = 4;
            this.Afiseaza.Text = "Afișează";
            this.Afiseaza.UseVisualStyleBackColor = false;
            this.Afiseaza.Click += new System.EventHandler(this.Afiseaza_Click);
            // 
            // grid
            // 
            this.grid.BackgroundColor = System.Drawing.Color.White;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(297, 124);
            this.grid.Name = "grid";
            this.grid.RowHeadersWidth = 62;
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(731, 446);
            this.grid.TabIndex = 5;
            // 
            // lbl_sorteaza
            // 
            this.lbl_sorteaza.AutoSize = true;
            this.lbl_sorteaza.BackColor = System.Drawing.Color.Transparent;
            this.lbl_sorteaza.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_sorteaza.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_sorteaza.Location = new System.Drawing.Point(12, 260);
            this.lbl_sorteaza.Name = "lbl_sorteaza";
            this.lbl_sorteaza.Size = new System.Drawing.Size(218, 22);
            this.lbl_sorteaza.TabIndex = 7;
            this.lbl_sorteaza.Text = "Sortează după coloană";
            this.lbl_sorteaza.Click += new System.EventHandler(this.lbl_sorteaza_Click);
            // 
            // cb_sortare
            // 
            this.cb_sortare.AutoSize = true;
            this.cb_sortare.BackColor = System.Drawing.Color.Transparent;
            this.cb_sortare.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.cb_sortare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_sortare.Location = new System.Drawing.Point(14, 316);
            this.cb_sortare.Name = "cb_sortare";
            this.cb_sortare.Size = new System.Drawing.Size(222, 26);
            this.cb_sortare.TabIndex = 11;
            this.cb_sortare.Text = "Sortare descendentă";
            this.cb_sortare.UseVisualStyleBackColor = false;
            // 
            // cmb_sortare
            // 
            this.cmb_sortare.FormattingEnabled = true;
            this.cmb_sortare.Location = new System.Drawing.Point(14, 282);
            this.cmb_sortare.Name = "cmb_sortare";
            this.cmb_sortare.Size = new System.Drawing.Size(222, 28);
            this.cmb_sortare.TabIndex = 13;
            this.cmb_sortare.SelectedIndexChanged += new System.EventHandler(this.cmb_sortare_SelectedIndexChanged);
            // 
            // cmb_cautare
            // 
            this.cmb_cautare.FormattingEnabled = true;
            this.cmb_cautare.Location = new System.Drawing.Point(14, 395);
            this.cmb_cautare.Name = "cmb_cautare";
            this.cmb_cautare.Size = new System.Drawing.Size(222, 28);
            this.cmb_cautare.TabIndex = 14;
            this.cmb_cautare.SelectedIndexChanged += new System.EventHandler(this.cmb_cautare_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(10, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 22);
            this.label1.TabIndex = 15;
            this.label1.Text = "Filtrare după coloană";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // tb_valoare
            // 
            this.tb_valoare.Location = new System.Drawing.Point(44, 458);
            this.tb_valoare.Name = "tb_valoare";
            this.tb_valoare.Size = new System.Drawing.Size(192, 26);
            this.tb_valoare.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(40, 433);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(202, 22);
            this.label2.TabIndex = 17;
            this.label2.Text = "Valoare de comparat";
            // 
            // UC_Punctula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_valoare);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_cautare);
            this.Controls.Add(this.cmb_sortare);
            this.Controls.Add(this.cb_sortare);
            this.Controls.Add(this.lbl_sorteaza);
            this.Controls.Add(this.grid);
            this.Controls.Add(this.Afiseaza);
            this.Controls.Add(this.cmb_selecteaza);
            this.Controls.Add(this.lbl_Selecteaza);
            this.Name = "UC_Punctula";
            this.Size = new System.Drawing.Size(1237, 820);
            this.Load += new System.EventHandler(this.UC_Punctula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Selecteaza;
        private System.Windows.Forms.ComboBox cmb_selecteaza;
        private System.Windows.Forms.Button Afiseaza;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label lbl_sorteaza;
        private System.Windows.Forms.CheckBox cb_sortare;
        private System.Windows.Forms.ComboBox cmb_sortare;
        private System.Windows.Forms.ComboBox cmb_cautare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_valoare;
        private System.Windows.Forms.Label label2;
    }
}
