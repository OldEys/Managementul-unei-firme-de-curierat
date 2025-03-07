namespace InterfataProiect.User_control
{
    partial class UC_Punctulf
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Punctulf));
            this.lbl_intrebare = new System.Windows.Forms.Label();
            this.pan_compusa = new System.Windows.Forms.Panel();
            this.btn_afisare = new System.Windows.Forms.Button();
            this.pan_complexa = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_compusa = new System.Windows.Forms.Button();
            this.grid_compusa = new System.Windows.Forms.DataGridView();
            this.grid_complexa = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_afisare_complexa = new System.Windows.Forms.Button();
            this.btn_complexa = new System.Windows.Forms.Button();
            this.btn_salvare = new System.Windows.Forms.Button();
            this.pan_compusa.SuspendLayout();
            this.pan_complexa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grid_compusa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_complexa)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_intrebare
            // 
            this.lbl_intrebare.BackColor = System.Drawing.Color.Transparent;
            this.lbl_intrebare.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lbl_intrebare.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_intrebare.Location = new System.Drawing.Point(415, 22);
            this.lbl_intrebare.Name = "lbl_intrebare";
            this.lbl_intrebare.Size = new System.Drawing.Size(389, 52);
            this.lbl_intrebare.TabIndex = 2;
            this.lbl_intrebare.Text = "Utilizarea vizualizărilor ";
            // 
            // pan_compusa
            // 
            this.pan_compusa.BackColor = System.Drawing.Color.DarkMagenta;
            this.pan_compusa.Controls.Add(this.btn_salvare);
            this.pan_compusa.Controls.Add(this.btn_afisare);
            this.pan_compusa.Controls.Add(this.label1);
            this.pan_compusa.Location = new System.Drawing.Point(38, 210);
            this.pan_compusa.Name = "pan_compusa";
            this.pan_compusa.Size = new System.Drawing.Size(473, 355);
            this.pan_compusa.TabIndex = 3;
            // 
            // btn_afisare
            // 
            this.btn_afisare.BackColor = System.Drawing.Color.Purple;
            this.btn_afisare.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_afisare.Location = new System.Drawing.Point(10, 252);
            this.btn_afisare.Name = "btn_afisare";
            this.btn_afisare.Size = new System.Drawing.Size(160, 63);
            this.btn_afisare.TabIndex = 7;
            this.btn_afisare.Text = "Afișare";
            this.btn_afisare.UseVisualStyleBackColor = false;
            this.btn_afisare.Click += new System.EventHandler(this.btn_afisare_Click);
            // 
            // pan_complexa
            // 
            this.pan_complexa.BackColor = System.Drawing.Color.DarkMagenta;
            this.pan_complexa.Controls.Add(this.btn_afisare_complexa);
            this.pan_complexa.Controls.Add(this.label2);
            this.pan_complexa.Location = new System.Drawing.Point(38, 210);
            this.pan_complexa.Name = "pan_complexa";
            this.pan_complexa.Size = new System.Drawing.Size(473, 355);
            this.pan_complexa.TabIndex = 4;
            this.pan_complexa.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(467, 111);
            this.label1.TabIndex = 7;
            this.label1.Text = "Afișarea tuturor mașinilor și a documentelor acestora și posibilitatea de modific" +
    "are a datelor\r\n";
            // 
            // btn_compusa
            // 
            this.btn_compusa.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_compusa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_compusa.Location = new System.Drawing.Point(38, 125);
            this.btn_compusa.Name = "btn_compusa";
            this.btn_compusa.Size = new System.Drawing.Size(153, 79);
            this.btn_compusa.TabIndex = 5;
            this.btn_compusa.Text = "Vizualizare compusă";
            this.btn_compusa.UseVisualStyleBackColor = false;
            this.btn_compusa.Click += new System.EventHandler(this.btn_compusa_Click);
            // 
            // grid_compusa
            // 
            this.grid_compusa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_compusa.Location = new System.Drawing.Point(632, 210);
            this.grid_compusa.Name = "grid_compusa";
            this.grid_compusa.RowHeadersWidth = 62;
            this.grid_compusa.RowTemplate.Height = 28;
            this.grid_compusa.Size = new System.Drawing.Size(515, 355);
            this.grid_compusa.TabIndex = 7;
            // 
            // grid_complexa
            // 
            this.grid_complexa.AllowUserToAddRows = false;
            this.grid_complexa.AllowUserToDeleteRows = false;
            this.grid_complexa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_complexa.Location = new System.Drawing.Point(632, 210);
            this.grid_complexa.Name = "grid_complexa";
            this.grid_complexa.ReadOnly = true;
            this.grid_complexa.RowHeadersWidth = 62;
            this.grid_complexa.RowTemplate.Height = 28;
            this.grid_complexa.Size = new System.Drawing.Size(515, 355);
            this.grid_complexa.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(470, 106);
            this.label2.TabIndex = 8;
            this.label2.Text = "Afișarea sucursalei , a mașinilor disponibile din fiecare sucursală și a capacită" +
    "ții totale a mașinilor din sucursală .\r\n";
            // 
            // btn_afisare_complexa
            // 
            this.btn_afisare_complexa.BackColor = System.Drawing.Color.Purple;
            this.btn_afisare_complexa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_afisare_complexa.Location = new System.Drawing.Point(143, 249);
            this.btn_afisare_complexa.Name = "btn_afisare_complexa";
            this.btn_afisare_complexa.Size = new System.Drawing.Size(150, 63);
            this.btn_afisare_complexa.TabIndex = 8;
            this.btn_afisare_complexa.Text = "Afișare";
            this.btn_afisare_complexa.UseVisualStyleBackColor = false;
            this.btn_afisare_complexa.Click += new System.EventHandler(this.btn_afisare_complexa_Click);
            // 
            // btn_complexa
            // 
            this.btn_complexa.BackColor = System.Drawing.Color.DarkMagenta;
            this.btn_complexa.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_complexa.Location = new System.Drawing.Point(358, 125);
            this.btn_complexa.Name = "btn_complexa";
            this.btn_complexa.Size = new System.Drawing.Size(150, 79);
            this.btn_complexa.TabIndex = 9;
            this.btn_complexa.Text = "Vizualizare complexă";
            this.btn_complexa.UseVisualStyleBackColor = false;
            this.btn_complexa.Click += new System.EventHandler(this.btn_complexa_Click);
            // 
            // btn_salvare
            // 
            this.btn_salvare.BackColor = System.Drawing.Color.Purple;
            this.btn_salvare.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salvare.Location = new System.Drawing.Point(291, 252);
            this.btn_salvare.Name = "btn_salvare";
            this.btn_salvare.Size = new System.Drawing.Size(160, 63);
            this.btn_salvare.TabIndex = 8;
            this.btn_salvare.Text = "Salvare date";
            this.btn_salvare.UseVisualStyleBackColor = false;
            this.btn_salvare.Click += new System.EventHandler(this.btn_salvare_Click);
            // 
            // UC_Punctulf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btn_complexa);
            this.Controls.Add(this.grid_complexa);
            this.Controls.Add(this.pan_complexa);
            this.Controls.Add(this.grid_compusa);
            this.Controls.Add(this.btn_compusa);
            this.Controls.Add(this.pan_compusa);
            this.Controls.Add(this.lbl_intrebare);
            this.Name = "UC_Punctulf";
            this.Size = new System.Drawing.Size(1197, 608);
            this.Load += new System.EventHandler(this.UC_Punctulf_Load);
            this.pan_compusa.ResumeLayout(false);
            this.pan_complexa.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grid_compusa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_complexa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_intrebare;
        private System.Windows.Forms.Panel pan_compusa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan_complexa;
        private System.Windows.Forms.Button btn_compusa;
        private System.Windows.Forms.Button btn_afisare;
        private System.Windows.Forms.DataGridView grid_compusa;
        private System.Windows.Forms.DataGridView grid_complexa;
        private System.Windows.Forms.Button btn_afisare_complexa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_complexa;
        private System.Windows.Forms.Button btn_salvare;
    }
}
