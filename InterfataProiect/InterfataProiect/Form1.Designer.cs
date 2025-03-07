using System.Windows.Forms;

namespace InterfataProiect
{
    partial class Meniu
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Meniu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_ProiectBD = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MeniuPanel = new System.Windows.Forms.Panel();
            this.punctulf = new System.Windows.Forms.Button();
            this.punctulc = new System.Windows.Forms.Button();
            this.MeniuPrincipal = new System.Windows.Forms.Button();
            this.punctuld = new System.Windows.Forms.Button();
            this.punctula = new System.Windows.Forms.Button();
            this.punctulb = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.MeniuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel1.Controls.Add(this.lbl_ProiectBD);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 71);
            this.panel1.TabIndex = 0;
            // 
            // lbl_ProiectBD
            // 
            this.lbl_ProiectBD.AutoSize = true;
            this.lbl_ProiectBD.Font = new System.Drawing.Font("Century Gothic", 13F, System.Drawing.FontStyle.Bold);
            this.lbl_ProiectBD.Location = new System.Drawing.Point(809, 19);
            this.lbl_ProiectBD.Name = "lbl_ProiectBD";
            this.lbl_ProiectBD.Size = new System.Drawing.Size(358, 30);
            this.lbl_ProiectBD.TabIndex = 2;
            this.lbl_ProiectBD.Text = "ProiectBD-Babii Victor Ionuț";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // MeniuPanel
            // 
            this.MeniuPanel.BackColor = System.Drawing.Color.White;
            this.MeniuPanel.Controls.Add(this.punctulf);
            this.MeniuPanel.Controls.Add(this.punctulc);
            this.MeniuPanel.Controls.Add(this.MeniuPrincipal);
            this.MeniuPanel.Controls.Add(this.punctuld);
            this.MeniuPanel.Controls.Add(this.punctula);
            this.MeniuPanel.Controls.Add(this.punctulb);
            this.MeniuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MeniuPanel.Location = new System.Drawing.Point(0, 71);
            this.MeniuPanel.Name = "MeniuPanel";
            this.MeniuPanel.Size = new System.Drawing.Size(1197, 77);
            this.MeniuPanel.TabIndex = 1;
            // 
            // punctulf
            // 
            this.punctulf.BackColor = System.Drawing.Color.White;
            this.punctulf.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.punctulf.FlatAppearance.BorderSize = 0;
            this.punctulf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punctulf.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctulf.Location = new System.Drawing.Point(1071, 6);
            this.punctulf.Name = "punctulf";
            this.punctulf.Size = new System.Drawing.Size(122, 65);
            this.punctulf.TabIndex = 8;
            this.punctulf.Text = "Punctul f)";
            this.punctulf.UseVisualStyleBackColor = false;
            this.punctulf.Click += new System.EventHandler(this.punctulf_Click);
            // 
            // punctulc
            // 
            this.punctulc.BackColor = System.Drawing.Color.White;
            this.punctulc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.punctulc.FlatAppearance.BorderSize = 0;
            this.punctulc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punctulc.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctulc.Location = new System.Drawing.Point(668, 6);
            this.punctulc.Name = "punctulc";
            this.punctulc.Size = new System.Drawing.Size(122, 65);
            this.punctulc.TabIndex = 6;
            this.punctulc.Text = "Punctul c)";
            this.punctulc.UseVisualStyleBackColor = false;
            this.punctulc.Click += new System.EventHandler(this.punctulc_Click);
            // 
            // MeniuPrincipal
            // 
            this.MeniuPrincipal.BackColor = System.Drawing.Color.White;
            this.MeniuPrincipal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.MeniuPrincipal.FlatAppearance.BorderSize = 0;
            this.MeniuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MeniuPrincipal.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MeniuPrincipal.Location = new System.Drawing.Point(12, 6);
            this.MeniuPrincipal.Name = "MeniuPrincipal";
            this.MeniuPrincipal.Size = new System.Drawing.Size(153, 68);
            this.MeniuPrincipal.TabIndex = 2;
            this.MeniuPrincipal.Text = "Pagina de pornire";
            this.MeniuPrincipal.UseVisualStyleBackColor = false;
            this.MeniuPrincipal.Click += new System.EventHandler(this.MeniuPrincipal_Click);
            // 
            // punctuld
            // 
            this.punctuld.BackColor = System.Drawing.Color.White;
            this.punctuld.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.punctuld.FlatAppearance.BorderSize = 0;
            this.punctuld.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punctuld.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctuld.Location = new System.Drawing.Point(871, 6);
            this.punctuld.Name = "punctuld";
            this.punctuld.Size = new System.Drawing.Size(122, 65);
            this.punctuld.TabIndex = 3;
            this.punctuld.Text = "Punctul d)";
            this.punctuld.UseVisualStyleBackColor = false;
            this.punctuld.Click += new System.EventHandler(this.punctuld_Click);
            // 
            // punctula
            // 
            this.punctula.BackColor = System.Drawing.Color.White;
            this.punctula.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.punctula.FlatAppearance.BorderSize = 0;
            this.punctula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punctula.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctula.Location = new System.Drawing.Point(243, 6);
            this.punctula.Name = "punctula";
            this.punctula.Size = new System.Drawing.Size(122, 65);
            this.punctula.TabIndex = 5;
            this.punctula.Text = "Punctul a)";
            this.punctula.UseVisualStyleBackColor = false;
            this.punctula.Click += new System.EventHandler(this.punctula_Click_1);
            // 
            // punctulb
            // 
            this.punctulb.BackColor = System.Drawing.Color.White;
            this.punctulb.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.punctulb.FlatAppearance.BorderSize = 0;
            this.punctulb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.punctulb.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punctulb.Location = new System.Drawing.Point(449, 6);
            this.punctulb.Name = "punctulb";
            this.punctulb.Size = new System.Drawing.Size(122, 65);
            this.punctulb.TabIndex = 4;
            this.punctulb.Text = "Punctul b)";
            this.punctulb.UseVisualStyleBackColor = false;
            this.punctulb.Click += new System.EventHandler(this.punctulb_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(0, 148);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1197, 608);
            this.panelContainer.TabIndex = 2;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 756);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.MeniuPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InterfataProiect";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.MeniuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel MeniuPanel;
        private PictureBox pictureBox1;
        private Button MeniuPrincipal;
        private Button punctulf;
        private Button punctulc;
        private Button punctuld;
        private Button punctula;
        private Button punctulb;
        private Label lbl_ProiectBD;
        private Panel panelContainer;
    }
    
}

