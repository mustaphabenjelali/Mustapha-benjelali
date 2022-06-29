namespace Esaad_Association
{
    partial class AnneeScolaire
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFindAnneeScolaire = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdAnneeRecherche = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAnneeScolaire = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateAnnee = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddAnne = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAfficherAnneeScolaire = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherAnneeScolaire)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFindAnneeScolaire);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIdAnneeRecherche);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(968, 88);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث بمعرف السنة الدراسية";
            // 
            // btnFindAnneeScolaire
            // 
            this.btnFindAnneeScolaire.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindAnneeScolaire.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindAnneeScolaire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindAnneeScolaire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindAnneeScolaire.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindAnneeScolaire.ForeColor = System.Drawing.Color.White;
            this.btnFindAnneeScolaire.Location = new System.Drawing.Point(280, 29);
            this.btnFindAnneeScolaire.Name = "btnFindAnneeScolaire";
            this.btnFindAnneeScolaire.Size = new System.Drawing.Size(99, 34);
            this.btnFindAnneeScolaire.TabIndex = 11;
            this.btnFindAnneeScolaire.Text = "بحث";
            this.btnFindAnneeScolaire.Click += new System.EventHandler(this.btnFindAnneeScolaire_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(594, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "معرف السنة الدراسية";
            // 
            // txtIdAnneeRecherche
            // 
            this.txtIdAnneeRecherche.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdAnneeRecherche.DefaultText = "";
            this.txtIdAnneeRecherche.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdAnneeRecherche.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdAnneeRecherche.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdAnneeRecherche.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdAnneeRecherche.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdAnneeRecherche.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdAnneeRecherche.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdAnneeRecherche.Location = new System.Drawing.Point(403, 29);
            this.txtIdAnneeRecherche.Name = "txtIdAnneeRecherche";
            this.txtIdAnneeRecherche.PasswordChar = '\0';
            this.txtIdAnneeRecherche.PlaceholderText = "";
            this.txtIdAnneeRecherche.SelectedText = "";
            this.txtIdAnneeRecherche.Size = new System.Drawing.Size(174, 34);
            this.txtIdAnneeRecherche.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAnneeScolaire);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUpdateAnnee);
            this.groupBox2.Controls.Add(this.btnAddAnne);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(176, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(701, 236);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات السنة الدراسية";
            // 
            // txtAnneeScolaire
            // 
            this.txtAnneeScolaire.BorderColor = System.Drawing.Color.Black;
            this.txtAnneeScolaire.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAnneeScolaire.DefaultText = "";
            this.txtAnneeScolaire.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAnneeScolaire.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAnneeScolaire.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnneeScolaire.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAnneeScolaire.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnneeScolaire.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAnneeScolaire.ForeColor = System.Drawing.Color.Black;
            this.txtAnneeScolaire.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAnneeScolaire.Location = new System.Drawing.Point(213, 67);
            this.txtAnneeScolaire.Name = "txtAnneeScolaire";
            this.txtAnneeScolaire.PasswordChar = '\0';
            this.txtAnneeScolaire.PlaceholderText = "";
            this.txtAnneeScolaire.SelectedText = "";
            this.txtAnneeScolaire.Size = new System.Drawing.Size(184, 35);
            this.txtAnneeScolaire.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(430, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "السنة الدراسية :";
            // 
            // btnUpdateAnnee
            // 
            this.btnUpdateAnnee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAnnee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateAnnee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateAnnee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateAnnee.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdateAnnee.ForeColor = System.Drawing.Color.White;
            this.btnUpdateAnnee.Location = new System.Drawing.Point(204, 150);
            this.btnUpdateAnnee.Name = "btnUpdateAnnee";
            this.btnUpdateAnnee.Size = new System.Drawing.Size(89, 32);
            this.btnUpdateAnnee.TabIndex = 27;
            this.btnUpdateAnnee.Text = "تعديل";
            this.btnUpdateAnnee.Click += new System.EventHandler(this.btnUpdateAnnee_Click);
            // 
            // btnAddAnne
            // 
            this.btnAddAnne.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAnne.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddAnne.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddAnne.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddAnne.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddAnne.ForeColor = System.Drawing.Color.White;
            this.btnAddAnne.Location = new System.Drawing.Point(310, 150);
            this.btnAddAnne.Name = "btnAddAnne";
            this.btnAddAnne.Size = new System.Drawing.Size(89, 32);
            this.btnAddAnne.TabIndex = 24;
            this.btnAddAnne.Text = "اضافة";
            this.btnAddAnne.Click += new System.EventHandler(this.btnAddAnne_Click);
            // 
            // dgvAfficherAnneeScolaire
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAfficherAnneeScolaire.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAfficherAnneeScolaire.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAfficherAnneeScolaire.BackgroundColor = System.Drawing.Color.White;
            this.dgvAfficherAnneeScolaire.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAfficherAnneeScolaire.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAfficherAnneeScolaire.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfficherAnneeScolaire.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAfficherAnneeScolaire.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAfficherAnneeScolaire.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAfficherAnneeScolaire.EnableHeadersVisualStyles = false;
            this.dgvAfficherAnneeScolaire.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherAnneeScolaire.Location = new System.Drawing.Point(244, 353);
            this.dgvAfficherAnneeScolaire.Name = "dgvAfficherAnneeScolaire";
            this.dgvAfficherAnneeScolaire.RowHeadersVisible = false;
            this.dgvAfficherAnneeScolaire.RowTemplate.Height = 28;
            this.dgvAfficherAnneeScolaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAfficherAnneeScolaire.Size = new System.Drawing.Size(570, 150);
            this.dgvAfficherAnneeScolaire.TabIndex = 24;
            this.dgvAfficherAnneeScolaire.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherAnneeScolaire.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAfficherAnneeScolaire.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAfficherAnneeScolaire.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAfficherAnneeScolaire.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAfficherAnneeScolaire.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherAnneeScolaire.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherAnneeScolaire.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAfficherAnneeScolaire.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAfficherAnneeScolaire.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAfficherAnneeScolaire.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAfficherAnneeScolaire.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAfficherAnneeScolaire.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAfficherAnneeScolaire.ThemeStyle.ReadOnly = false;
            this.dgvAfficherAnneeScolaire.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherAnneeScolaire.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAfficherAnneeScolaire.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAfficherAnneeScolaire.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAfficherAnneeScolaire.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAfficherAnneeScolaire.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherAnneeScolaire.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAfficherAnneeScolaire.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAfficherAnneeScolaire_CellContentClick);
            // 
            // AnneeScolaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(968, 538);
            this.Controls.Add(this.dgvAfficherAnneeScolaire);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AnneeScolaire";
            this.Text = " سنة دراسية";
            this.Load += new System.EventHandler(this.AnneeScolaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherAnneeScolaire)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnFindAnneeScolaire;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtIdAnneeRecherche;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtAnneeScolaire;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpdateAnnee;
        private Guna.UI2.WinForms.Guna2Button btnAddAnne;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAfficherAnneeScolaire;
    }
}