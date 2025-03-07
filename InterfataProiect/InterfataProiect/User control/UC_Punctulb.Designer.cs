namespace InterfataProiect.User_control
{
    partial class UC_Punctulb
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Punctulb));
            this.lbl_intrebare = new System.Windows.Forms.Label();
            this.btn_stergere = new System.Windows.Forms.Button();
            this.btn_editare = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_stergere_selectare = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb_stergere_criteriu = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pan_stergere = new System.Windows.Forms.Panel();
            this.btn_stergere_conf = new System.Windows.Forms.Button();
            this.tb_valoare = new System.Windows.Forms.TextBox();
            this.pan_editare = new System.Windows.Forms.Panel();
            this.btn_editare_conf = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_editare_val_cautare = new System.Windows.Forms.TextBox();
            this.cmb_editare_filtru = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_editare_col = new System.Windows.Forms.ComboBox();
            this.tb_editare_val_noua = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmb_editare_selectare = new System.Windows.Forms.ComboBox();
            this.pan_stergere.SuspendLayout();
            this.pan_editare.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_intrebare
            // 
            this.lbl_intrebare.AutoSize = true;
            this.lbl_intrebare.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrebare.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_intrebare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_intrebare.Location = new System.Drawing.Point(286, 55);
            this.lbl_intrebare.Name = "lbl_intrebare";
            this.lbl_intrebare.Size = new System.Drawing.Size(606, 47);
            this.lbl_intrebare.TabIndex = 0;
            this.lbl_intrebare.Text = "Ce modificare dorești să faci?";
            // 
            // btn_stergere
            // 
            this.btn_stergere.BackColor = System.Drawing.Color.Thistle;
            this.btn_stergere.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stergere.Location = new System.Drawing.Point(24, 150);
            this.btn_stergere.Name = "btn_stergere";
            this.btn_stergere.Size = new System.Drawing.Size(131, 64);
            this.btn_stergere.TabIndex = 1;
            this.btn_stergere.Text = "Ștergere";
            this.btn_stergere.UseVisualStyleBackColor = false;
            this.btn_stergere.Click += new System.EventHandler(this.btn_stergere_Click);
            // 
            // btn_editare
            // 
            this.btn_editare.BackColor = System.Drawing.Color.Thistle;
            this.btn_editare.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editare.Location = new System.Drawing.Point(1039, 150);
            this.btn_editare.Name = "btn_editare";
            this.btn_editare.Size = new System.Drawing.Size(131, 64);
            this.btn_editare.TabIndex = 3;
            this.btn_editare.Text = "Editare";
            this.btn_editare.UseVisualStyleBackColor = false;
            this.btn_editare.Click += new System.EventHandler(this.btn_editare_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(28, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Selectează tabelul :";
            // 
            // cmb_stergere_selectare
            // 
            this.cmb_stergere_selectare.FormattingEnabled = true;
            this.cmb_stergere_selectare.Items.AddRange(new object[] {
            "Sucursala",
            "Curier",
            "Masina",
            "Document",
            "Furnizor",
            "Punct_de_ridicare",
            "Client",
            "Colet",
            "Interactiune_Client_Punct"});
            this.cmb_stergere_selectare.Location = new System.Drawing.Point(29, 58);
            this.cmb_stergere_selectare.Name = "cmb_stergere_selectare";
            this.cmb_stergere_selectare.Size = new System.Drawing.Size(202, 28);
            this.cmb_stergere_selectare.TabIndex = 6;
            this.cmb_stergere_selectare.SelectedIndexChanged += new System.EventHandler(this.cmb_stergere_selectare_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(25, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Criteriu de ștergere :";
            // 
            // cmb_stergere_criteriu
            // 
            this.cmb_stergere_criteriu.FormattingEnabled = true;
            this.cmb_stergere_criteriu.Location = new System.Drawing.Point(29, 136);
            this.cmb_stergere_criteriu.Name = "cmb_stergere_criteriu";
            this.cmb_stergere_criteriu.Size = new System.Drawing.Size(203, 28);
            this.cmb_stergere_criteriu.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(60, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "Valoare criteriu :";
            // 
            // pan_stergere
            // 
            this.pan_stergere.BackColor = System.Drawing.Color.Thistle;
            this.pan_stergere.Controls.Add(this.label3);
            this.pan_stergere.Controls.Add(this.btn_stergere_conf);
            this.pan_stergere.Controls.Add(this.cmb_stergere_criteriu);
            this.pan_stergere.Controls.Add(this.tb_valoare);
            this.pan_stergere.Controls.Add(this.label2);
            this.pan_stergere.Controls.Add(this.label1);
            this.pan_stergere.Controls.Add(this.cmb_stergere_selectare);
            this.pan_stergere.Location = new System.Drawing.Point(404, 220);
            this.pan_stergere.Name = "pan_stergere";
            this.pan_stergere.Size = new System.Drawing.Size(388, 370);
            this.pan_stergere.TabIndex = 11;
            // 
            // btn_stergere_conf
            // 
            this.btn_stergere_conf.BackColor = System.Drawing.Color.Thistle;
            this.btn_stergere_conf.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_stergere_conf.Location = new System.Drawing.Point(239, 303);
            this.btn_stergere_conf.Name = "btn_stergere_conf";
            this.btn_stergere_conf.Size = new System.Drawing.Size(131, 64);
            this.btn_stergere_conf.TabIndex = 12;
            this.btn_stergere_conf.Text = "Confirmă ștergerea";
            this.btn_stergere_conf.UseVisualStyleBackColor = false;
            this.btn_stergere_conf.Click += new System.EventHandler(this.btn_stergere_conf_Click);
            // 
            // tb_valoare
            // 
            this.tb_valoare.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_valoare.Location = new System.Drawing.Point(64, 218);
            this.tb_valoare.Name = "tb_valoare";
            this.tb_valoare.Size = new System.Drawing.Size(169, 27);
            this.tb_valoare.TabIndex = 0;
            // 
            // pan_editare
            // 
            this.pan_editare.BackColor = System.Drawing.Color.Thistle;
            this.pan_editare.Controls.Add(this.btn_editare_conf);
            this.pan_editare.Controls.Add(this.label8);
            this.pan_editare.Controls.Add(this.tb_editare_val_cautare);
            this.pan_editare.Controls.Add(this.cmb_editare_filtru);
            this.pan_editare.Controls.Add(this.label7);
            this.pan_editare.Controls.Add(this.label4);
            this.pan_editare.Controls.Add(this.cmb_editare_col);
            this.pan_editare.Controls.Add(this.tb_editare_val_noua);
            this.pan_editare.Controls.Add(this.label5);
            this.pan_editare.Controls.Add(this.label6);
            this.pan_editare.Controls.Add(this.cmb_editare_selectare);
            this.pan_editare.Location = new System.Drawing.Point(404, 220);
            this.pan_editare.Name = "pan_editare";
            this.pan_editare.Size = new System.Drawing.Size(388, 370);
            this.pan_editare.TabIndex = 13;
            this.pan_editare.Paint += new System.Windows.Forms.PaintEventHandler(this.pan_editare_Paint);
            // 
            // btn_editare_conf
            // 
            this.btn_editare_conf.BackColor = System.Drawing.Color.Thistle;
            this.btn_editare_conf.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_editare_conf.Location = new System.Drawing.Point(237, 303);
            this.btn_editare_conf.Name = "btn_editare_conf";
            this.btn_editare_conf.Size = new System.Drawing.Size(131, 64);
            this.btn_editare_conf.TabIndex = 17;
            this.btn_editare_conf.Text = "Confirmă editarea";
            this.btn_editare_conf.UseVisualStyleBackColor = false;
            this.btn_editare_conf.Click += new System.EventHandler(this.btn_editare_conf_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Thistle;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(58, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(181, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Valoare căutare :";
            // 
            // tb_editare_val_cautare
            // 
            this.tb_editare_val_cautare.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_editare_val_cautare.Location = new System.Drawing.Point(62, 311);
            this.tb_editare_val_cautare.Name = "tb_editare_val_cautare";
            this.tb_editare_val_cautare.Size = new System.Drawing.Size(169, 27);
            this.tb_editare_val_cautare.TabIndex = 15;
            // 
            // cmb_editare_filtru
            // 
            this.cmb_editare_filtru.FormattingEnabled = true;
            this.cmb_editare_filtru.Items.AddRange(new object[] {
            ""});
            this.cmb_editare_filtru.Location = new System.Drawing.Point(32, 244);
            this.cmb_editare_filtru.Name = "cmb_editare_filtru";
            this.cmb_editare_filtru.Size = new System.Drawing.Size(203, 28);
            this.cmb_editare_filtru.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Thistle;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(33, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Filtru de căutare :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(58, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Valoare nouă :";
            // 
            // cmb_editare_col
            // 
            this.cmb_editare_col.FormattingEnabled = true;
            this.cmb_editare_col.Location = new System.Drawing.Point(32, 105);
            this.cmb_editare_col.Name = "cmb_editare_col";
            this.cmb_editare_col.Size = new System.Drawing.Size(203, 28);
            this.cmb_editare_col.TabIndex = 8;
            // 
            // tb_editare_val_noua
            // 
            this.tb_editare_val_noua.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_editare_val_noua.Location = new System.Drawing.Point(62, 181);
            this.tb_editare_val_noua.Name = "tb_editare_val_noua";
            this.tb_editare_val_noua.Size = new System.Drawing.Size(169, 27);
            this.tb_editare_val_noua.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Thistle;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(33, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(201, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Coloană de editat :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Thistle;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(28, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(203, 23);
            this.label6.TabIndex = 4;
            this.label6.Text = "Selectează tabelul :";
            // 
            // cmb_editare_selectare
            // 
            this.cmb_editare_selectare.FormattingEnabled = true;
            this.cmb_editare_selectare.Items.AddRange(new object[] {
            "Sucursala",
            "Curier",
            "Masina",
            "Document",
            "Furnizor",
            "Punct_de_ridicare",
            "Client",
            "Colet",
            "Interactiune_Client_Punct"});
            this.cmb_editare_selectare.Location = new System.Drawing.Point(29, 37);
            this.cmb_editare_selectare.Name = "cmb_editare_selectare";
            this.cmb_editare_selectare.Size = new System.Drawing.Size(202, 28);
            this.cmb_editare_selectare.TabIndex = 6;
            this.cmb_editare_selectare.SelectedIndexChanged += new System.EventHandler(this.cmb_editare_selectare_SelectedIndexChanged);
            // 
            // UC_Punctulb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.pan_editare);
            this.Controls.Add(this.btn_editare);
            this.Controls.Add(this.btn_stergere);
            this.Controls.Add(this.lbl_intrebare);
            this.Controls.Add(this.pan_stergere);
            this.Name = "UC_Punctulb";
            this.Size = new System.Drawing.Size(1197, 608);
            this.Load += new System.EventHandler(this.UC_Punctulb_Load);
            this.pan_stergere.ResumeLayout(false);
            this.pan_stergere.PerformLayout();
            this.pan_editare.ResumeLayout(false);
            this.pan_editare.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_intrebare;
        private System.Windows.Forms.Button btn_stergere;
        private System.Windows.Forms.Button btn_editare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_stergere_selectare;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmb_stergere_criteriu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pan_stergere;
        private System.Windows.Forms.TextBox tb_valoare;
        private System.Windows.Forms.Button btn_stergere_conf;
        private System.Windows.Forms.Panel pan_editare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_editare_col;
        private System.Windows.Forms.TextBox tb_editare_val_noua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmb_editare_selectare;
        private System.Windows.Forms.ComboBox cmb_editare_filtru;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_editare_val_cautare;
        private System.Windows.Forms.Button btn_editare_conf;
    }
}
