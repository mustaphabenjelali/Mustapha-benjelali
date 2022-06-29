namespace Esaad_Association
{
    partial class Niveau_Scolaire
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
            this.txtIdNiveauFind = new System.Windows.Forms.TextBox();
            this.btnFindNiveau = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvAfficherNiveau = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLibelleNiveau = new System.Windows.Forms.TextBox();
            this.txtIdNiveauScolaire = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateNiveau = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddNiveau = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherNiveau)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdNiveauFind);
            this.groupBox1.Controls.Add(this.btnFindNiveau);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1005, 88);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث بمعرف المستوى التعليمي";
            // 
            // txtIdNiveauFind
            // 
            this.txtIdNiveauFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIdNiveauFind.Location = new System.Drawing.Point(405, 28);
            this.txtIdNiveauFind.Name = "txtIdNiveauFind";
            this.txtIdNiveauFind.Size = new System.Drawing.Size(171, 35);
            this.txtIdNiveauFind.TabIndex = 36;
            // 
            // btnFindNiveau
            // 
            this.btnFindNiveau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindNiveau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindNiveau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindNiveau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindNiveau.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFindNiveau.ForeColor = System.Drawing.Color.White;
            this.btnFindNiveau.Location = new System.Drawing.Point(280, 29);
            this.btnFindNiveau.Name = "btnFindNiveau";
            this.btnFindNiveau.Size = new System.Drawing.Size(99, 34);
            this.btnFindNiveau.TabIndex = 11;
            this.btnFindNiveau.Text = "بحث";
            this.btnFindNiveau.Click += new System.EventHandler(this.btnFindNiveau_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(594, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "معرف المستوى التعليمي";
            // 
            // dgvAfficherNiveau
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAfficherNiveau.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAfficherNiveau.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAfficherNiveau.BackgroundColor = System.Drawing.Color.White;
            this.dgvAfficherNiveau.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAfficherNiveau.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAfficherNiveau.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfficherNiveau.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAfficherNiveau.ColumnHeadersHeight = 35;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAfficherNiveau.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAfficherNiveau.EnableHeadersVisualStyles = false;
            this.dgvAfficherNiveau.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherNiveau.Location = new System.Drawing.Point(146, 356);
            this.dgvAfficherNiveau.Name = "dgvAfficherNiveau";
            this.dgvAfficherNiveau.RowHeadersVisible = false;
            this.dgvAfficherNiveau.RowTemplate.Height = 28;
            this.dgvAfficherNiveau.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAfficherNiveau.Size = new System.Drawing.Size(725, 229);
            this.dgvAfficherNiveau.TabIndex = 25;
            this.dgvAfficherNiveau.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherNiveau.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAfficherNiveau.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAfficherNiveau.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAfficherNiveau.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAfficherNiveau.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherNiveau.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherNiveau.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAfficherNiveau.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAfficherNiveau.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAfficherNiveau.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAfficherNiveau.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAfficherNiveau.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAfficherNiveau.ThemeStyle.ReadOnly = false;
            this.dgvAfficherNiveau.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherNiveau.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAfficherNiveau.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAfficherNiveau.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAfficherNiveau.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAfficherNiveau.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherNiveau.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAfficherNiveau.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAfficherNiveau_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txtLibelleNiveau);
            this.groupBox2.Controls.Add(this.txtIdNiveauScolaire);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUpdateNiveau);
            this.groupBox2.Controls.Add(this.btnAddNiveau);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(93, 104);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(829, 221);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات  المستوى التعليمي";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(507, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "معرف المستوى التعليمي :\r\n";
            // 
            // txtLibelleNiveau
            // 
            this.txtLibelleNiveau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtLibelleNiveau.Location = new System.Drawing.Point(311, 91);
            this.txtLibelleNiveau.Name = "txtLibelleNiveau";
            this.txtLibelleNiveau.Size = new System.Drawing.Size(171, 35);
            this.txtLibelleNiveau.TabIndex = 36;
            // 
            // txtIdNiveauScolaire
            // 
            this.txtIdNiveauScolaire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtIdNiveauScolaire.Location = new System.Drawing.Point(311, 40);
            this.txtIdNiveauScolaire.Name = "txtIdNiveauScolaire";
            this.txtIdNiveauScolaire.Size = new System.Drawing.Size(171, 35);
            this.txtIdNiveauScolaire.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(514, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "المستوى التعليمي :\r\n";
            // 
            // btnUpdateNiveau
            // 
            this.btnUpdateNiveau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateNiveau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateNiveau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateNiveau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateNiveau.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdateNiveau.ForeColor = System.Drawing.Color.White;
            this.btnUpdateNiveau.Location = new System.Drawing.Point(312, 155);
            this.btnUpdateNiveau.Name = "btnUpdateNiveau";
            this.btnUpdateNiveau.Size = new System.Drawing.Size(89, 32);
            this.btnUpdateNiveau.TabIndex = 27;
            this.btnUpdateNiveau.Text = "تعديل";
            this.btnUpdateNiveau.Click += new System.EventHandler(this.btnUpdateNiveau_Click);
            // 
            // btnAddNiveau
            // 
            this.btnAddNiveau.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNiveau.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNiveau.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNiveau.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNiveau.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddNiveau.ForeColor = System.Drawing.Color.White;
            this.btnAddNiveau.Location = new System.Drawing.Point(413, 155);
            this.btnAddNiveau.Name = "btnAddNiveau";
            this.btnAddNiveau.Size = new System.Drawing.Size(89, 32);
            this.btnAddNiveau.TabIndex = 24;
            this.btnAddNiveau.Text = "اضافة";
            this.btnAddNiveau.Click += new System.EventHandler(this.btnAddNiveau_Click);
            // 
            // Niveau_Scolaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1005, 672);
            this.Controls.Add(this.dgvAfficherNiveau);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Niveau_Scolaire";
            this.Text = "Niveau_Scolaire";
            this.Load += new System.EventHandler(this.Niveau_Scolaire_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherNiveau)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnFindNiveau;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAfficherNiveau;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpdateNiveau;
        private Guna.UI2.WinForms.Guna2Button btnAddNiveau;
        private System.Windows.Forms.TextBox txtLibelleNiveau;
        private System.Windows.Forms.TextBox txtIdNiveauScolaire;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIdNiveauFind;
    }
}