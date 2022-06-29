namespace Esaad_Association
{
    partial class frmEcole
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
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtIdEcoleFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAdresseEcole = new System.Windows.Forms.TextBox();
            this.txtNomEcole = new System.Windows.Forms.TextBox();
            this.txtEcoleId = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbDegreEcole = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUpdateEcole = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddEcole = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAfficherEcole = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherEcole)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtIdEcoleFind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(1002, 88);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث بمعرف المؤسسة";
            // 
            // btnFind
            // 
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(391, 29);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(99, 34);
            this.btnFind.TabIndex = 11;
            this.btnFind.Text = "بحث";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(712, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "معرف المؤسسة";
            // 
            // txtIdEcoleFind
            // 
            this.txtIdEcoleFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIdEcoleFind.DefaultText = "";
            this.txtIdEcoleFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtIdEcoleFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtIdEcoleFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdEcoleFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtIdEcoleFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdEcoleFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtIdEcoleFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtIdEcoleFind.Location = new System.Drawing.Point(513, 29);
            this.txtIdEcoleFind.Name = "txtIdEcoleFind";
            this.txtIdEcoleFind.PasswordChar = '\0';
            this.txtIdEcoleFind.PlaceholderText = "";
            this.txtIdEcoleFind.SelectedText = "";
            this.txtIdEcoleFind.Size = new System.Drawing.Size(174, 34);
            this.txtIdEcoleFind.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdresseEcole);
            this.groupBox2.Controls.Add(this.txtNomEcole);
            this.groupBox2.Controls.Add(this.txtEcoleId);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.cmbDegreEcole);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUpdateEcole);
            this.groupBox2.Controls.Add(this.btnAddEcole);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(72, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(883, 252);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "المعلومات المؤسسة التعليمية";
            // 
            // txtAdresseEcole
            // 
            this.txtAdresseEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtAdresseEcole.Location = new System.Drawing.Point(432, 136);
            this.txtAdresseEcole.Name = "txtAdresseEcole";
            this.txtAdresseEcole.Size = new System.Drawing.Size(183, 35);
            this.txtAdresseEcole.TabIndex = 40;
            // 
            // txtNomEcole
            // 
            this.txtNomEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtNomEcole.Location = new System.Drawing.Point(432, 89);
            this.txtNomEcole.Name = "txtNomEcole";
            this.txtNomEcole.Size = new System.Drawing.Size(183, 35);
            this.txtNomEcole.TabIndex = 39;
            // 
            // txtEcoleId
            // 
            this.txtEcoleId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtEcoleId.Location = new System.Drawing.Point(432, 44);
            this.txtEcoleId.Name = "txtEcoleId";
            this.txtEcoleId.Size = new System.Drawing.Size(183, 35);
            this.txtEcoleId.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(635, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(194, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = " معرف المؤسسة التعليمية :";
            // 
            // cmbDegreEcole
            // 
            this.cmbDegreEcole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbDegreEcole.FormattingEnabled = true;
            this.cmbDegreEcole.ItemHeight = 29;
            this.cmbDegreEcole.Items.AddRange(new object[] {
            "الابتدائي",
            "الاعدادي",
            "الثانوي"});
            this.cmbDegreEcole.Location = new System.Drawing.Point(432, 181);
            this.cmbDegreEcole.Name = "cmbDegreEcole";
            this.cmbDegreEcole.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbDegreEcole.Size = new System.Drawing.Size(183, 37);
            this.cmbDegreEcole.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(631, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "عنوان المؤسسة التعليمية :\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(678, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = " المستوى";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(643, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "اسم المؤسسة التعليمية :";
            // 
            // btnUpdateEcole
            // 
            this.btnUpdateEcole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateEcole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateEcole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateEcole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateEcole.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdateEcole.ForeColor = System.Drawing.Color.White;
            this.btnUpdateEcole.Location = new System.Drawing.Point(190, 73);
            this.btnUpdateEcole.Name = "btnUpdateEcole";
            this.btnUpdateEcole.Size = new System.Drawing.Size(89, 32);
            this.btnUpdateEcole.TabIndex = 27;
            this.btnUpdateEcole.Text = "تعديل";
            this.btnUpdateEcole.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAddEcole
            // 
            this.btnAddEcole.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEcole.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddEcole.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddEcole.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddEcole.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddEcole.ForeColor = System.Drawing.Color.White;
            this.btnAddEcole.Location = new System.Drawing.Point(190, 32);
            this.btnAddEcole.Name = "btnAddEcole";
            this.btnAddEcole.Size = new System.Drawing.Size(89, 32);
            this.btnAddEcole.TabIndex = 24;
            this.btnAddEcole.Text = "اضافة";
            this.btnAddEcole.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvAfficherEcole
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvAfficherEcole.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAfficherEcole.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAfficherEcole.BackgroundColor = System.Drawing.Color.White;
            this.dgvAfficherEcole.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAfficherEcole.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAfficherEcole.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfficherEcole.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAfficherEcole.ColumnHeadersHeight = 32;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAfficherEcole.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvAfficherEcole.EnableHeadersVisualStyles = false;
            this.dgvAfficherEcole.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherEcole.Location = new System.Drawing.Point(29, 370);
            this.dgvAfficherEcole.Name = "dgvAfficherEcole";
            this.dgvAfficherEcole.RowHeadersVisible = false;
            this.dgvAfficherEcole.RowTemplate.Height = 28;
            this.dgvAfficherEcole.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAfficherEcole.Size = new System.Drawing.Size(949, 202);
            this.dgvAfficherEcole.TabIndex = 22;
            this.dgvAfficherEcole.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherEcole.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAfficherEcole.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAfficherEcole.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAfficherEcole.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAfficherEcole.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherEcole.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherEcole.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAfficherEcole.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAfficherEcole.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAfficherEcole.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAfficherEcole.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAfficherEcole.ThemeStyle.HeaderStyle.Height = 32;
            this.dgvAfficherEcole.ThemeStyle.ReadOnly = false;
            this.dgvAfficherEcole.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherEcole.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAfficherEcole.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAfficherEcole.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAfficherEcole.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAfficherEcole.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherEcole.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAfficherEcole.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAfficherEcole_CellContentClick_2);
            // 
            // frmEcole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(1002, 616);
            this.Controls.Add(this.dgvAfficherEcole);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmEcole";
            this.Text = "ادارة مؤسسة تعليمية جديدة";
            this.Load += new System.EventHandler(this.frmEcole_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherEcole)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtIdEcoleFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnUpdateEcole;
        private Guna.UI2.WinForms.Guna2Button btnAddEcole;
        private System.Windows.Forms.ComboBox cmbDegreEcole;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAfficherEcole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNomEcole;
        private System.Windows.Forms.TextBox txtEcoleId;
        private System.Windows.Forms.TextBox txtAdresseEcole;
    }
}