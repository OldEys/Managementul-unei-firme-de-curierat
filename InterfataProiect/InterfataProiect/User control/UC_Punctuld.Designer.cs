namespace InterfataProiect.User_control
{
    partial class UC_Punctuld
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Punctuld));
            this.lbl_intrebare = new System.Windows.Forms.Label();
            this.grid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_afiseaza = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_intrebare
            // 
            this.lbl_intrebare.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrebare.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_intrebare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_intrebare.Location = new System.Drawing.Point(330, 35);
            this.lbl_intrebare.Name = "lbl_intrebare";
            this.lbl_intrebare.Size = new System.Drawing.Size(532, 143);
            this.lbl_intrebare.TabIndex = 1;
            this.lbl_intrebare.Text = "Determinarea celor mai active sucursale";
            this.lbl_intrebare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Location = new System.Drawing.Point(35, 59);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersWidth = 62;
            this.grid.RowTemplate.Height = 28;
            this.grid.Size = new System.Drawing.Size(490, 302);
            this.grid.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(205, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 40);
            this.label2.TabIndex = 4;
            this.label2.Text = "Rezultat";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SlateBlue;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.grid);
            this.panel2.Location = new System.Drawing.Point(620, 208);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(561, 372);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(546, 132);
            this.label1.TabIndex = 2;
            this.label1.Text = "Determinarea sucursalelor care au cel puțin 3 curieri care au gestionat cel puțin" +
    " 4 colete (stare_colet este \'livrat\',\'returnat\',\'ridicat\'),ordonate descrescător" +
    " după numărul de curieri";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_afiseaza
            // 
            this.btn_afiseaza.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_afiseaza.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_afiseaza.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_afiseaza.Location = new System.Drawing.Point(200, 177);
            this.btn_afiseaza.Name = "btn_afiseaza";
            this.btn_afiseaza.Size = new System.Drawing.Size(167, 84);
            this.btn_afiseaza.TabIndex = 5;
            this.btn_afiseaza.Text = "Afișează";
            this.btn_afiseaza.UseVisualStyleBackColor = false;
            this.btn_afiseaza.Click += new System.EventHandler(this.btn_afiseaza_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.btn_afiseaza);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(15, 208);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 372);
            this.panel1.TabIndex = 8;
            // 
            // UC_Punctuld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_intrebare);
            this.Controls.Add(this.panel2);
            this.Name = "UC_Punctuld";
            this.Size = new System.Drawing.Size(1197, 608);
            this.Load += new System.EventHandler(this.UC_Punctuld_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_intrebare;
        private System.Windows.Forms.DataGridView grid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_afiseaza;
        private System.Windows.Forms.Panel panel1;
    }
}
