namespace Esaad_Association
{
    partial class Bus
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMatriculeFind = new Guna.UI2.WinForms.Guna2TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbCarburant = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMatriculeTransports = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbMarque = new System.Windows.Forms.ComboBox();
            this.txtModele = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCapacite = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdateBus = new Guna.UI2.WinForms.Guna2Button();
            this.btnDeleteBus = new Guna.UI2.WinForms.Guna2Button();
            this.btnAddBus = new Guna.UI2.WinForms.Guna2Button();
            this.dgvAfficherBus = new Guna.UI2.WinForms.Guna2DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherBus)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtMatriculeFind);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(992, 88);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بحث برقم التسجيل السيارة";
            // 
            // btnFind
            // 
            this.btnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFind.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnFind.ForeColor = System.Drawing.Color.White;
            this.btnFind.Location = new System.Drawing.Point(359, 29);
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
            this.label9.Location = new System.Drawing.Point(673, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(171, 20);
            this.label9.TabIndex = 10;
            this.label9.Text = "رقم التسجيل (Matricule)";
            // 
            // txtMatriculeFind
            // 
            this.txtMatriculeFind.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatriculeFind.DefaultText = "";
            this.txtMatriculeFind.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatriculeFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatriculeFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatriculeFind.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatriculeFind.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatriculeFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMatriculeFind.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatriculeFind.Location = new System.Drawing.Point(482, 29);
            this.txtMatriculeFind.Name = "txtMatriculeFind";
            this.txtMatriculeFind.PasswordChar = '\0';
            this.txtMatriculeFind.PlaceholderText = "";
            this.txtMatriculeFind.SelectedText = "";
            this.txtMatriculeFind.Size = new System.Drawing.Size(174, 34);
            this.txtMatriculeFind.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbCarburant);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtMatriculeTransports);
            this.groupBox2.Controls.Add(this.cmbMarque);
            this.groupBox2.Controls.Add(this.txtModele);
            this.groupBox2.Controls.Add(this.txtCapacite);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnUpdateBus);
            this.groupBox2.Controls.Add(this.btnDeleteBus);
            this.groupBox2.Controls.Add(this.btnAddBus);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(200)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(47, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(883, 264);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "معلومات العربة";
            // 
            // cmbCarburant
            // 
            this.cmbCarburant.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbCarburant.FormattingEnabled = true;
            this.cmbCarburant.ItemHeight = 25;
            this.cmbCarburant.Items.AddRange(new object[] {
            "essence - ايسونس",
            "diesel - الديزل"});
            this.cmbCarburant.Location = new System.Drawing.Point(434, 206);
            this.cmbCarburant.Name = "cmbCarburant";
            this.cmbCarburant.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbCarburant.Size = new System.Drawing.Size(183, 33);
            this.cmbCarburant.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(699, 208);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 22);
            this.label5.TabIndex = 37;
            this.label5.Text = "نوع الوقود";
            // 
            // txtMatriculeTransports
            // 
            this.txtMatriculeTransports.BorderColor = System.Drawing.Color.Black;
            this.txtMatriculeTransports.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMatriculeTransports.DefaultText = "";
            this.txtMatriculeTransports.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMatriculeTransports.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMatriculeTransports.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatriculeTransports.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMatriculeTransports.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatriculeTransports.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtMatriculeTransports.ForeColor = System.Drawing.Color.Black;
            this.txtMatriculeTransports.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMatriculeTransports.Location = new System.Drawing.Point(433, 32);
            this.txtMatriculeTransports.Name = "txtMatriculeTransports";
            this.txtMatriculeTransports.PasswordChar = '\0';
            this.txtMatriculeTransports.PlaceholderText = "";
            this.txtMatriculeTransports.SelectedText = "";
            this.txtMatriculeTransports.Size = new System.Drawing.Size(184, 35);
            this.txtMatriculeTransports.TabIndex = 36;
            // 
            // cmbMarque
            // 
            this.cmbMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbMarque.FormattingEnabled = true;
            this.cmbMarque.ItemHeight = 25;
            this.cmbMarque.Items.AddRange(new object[] {
            "Citroen",
            "Renault",
            "Fiat",
            "Mercedes",
            "Hyundai",
            "Peugeot",
            "Ford"});
            this.cmbMarque.Location = new System.Drawing.Point(433, 160);
            this.cmbMarque.Name = "cmbMarque";
            this.cmbMarque.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbMarque.Size = new System.Drawing.Size(183, 33);
            this.cmbMarque.TabIndex = 35;
            // 
            // txtModele
            // 
            this.txtModele.BorderColor = System.Drawing.Color.Black;
            this.txtModele.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModele.DefaultText = "";
            this.txtModele.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModele.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModele.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModele.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModele.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModele.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtModele.ForeColor = System.Drawing.Color.Black;
            this.txtModele.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModele.Location = new System.Drawing.Point(433, 117);
            this.txtModele.Name = "txtModele";
            this.txtModele.PasswordChar = '\0';
            this.txtModele.PlaceholderText = "";
            this.txtModele.SelectedText = "";
            this.txtModele.Size = new System.Drawing.Size(184, 35);
            this.txtModele.TabIndex = 34;
            // 
            // txtCapacite
            // 
            this.txtCapacite.BorderColor = System.Drawing.Color.Black;
            this.txtCapacite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacite.DefaultText = "";
            this.txtCapacite.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCapacite.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCapacite.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacite.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacite.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacite.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.txtCapacite.ForeColor = System.Drawing.Color.Black;
            this.txtCapacite.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacite.Location = new System.Drawing.Point(433, 74);
            this.txtCapacite.Name = "txtCapacite";
            this.txtCapacite.PasswordChar = '\0';
            this.txtCapacite.PlaceholderText = "";
            this.txtCapacite.SelectedText = "";
            this.txtCapacite.Size = new System.Drawing.Size(184, 35);
            this.txtCapacite.TabIndex = 32;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(681, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 31;
            this.label4.Text = "طراز السيارة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(674, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 30;
            this.label3.Text = "العلامة التجارية";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(693, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 29;
            this.label2.Text = "عدد المقاعد";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(640, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "رقم التسجيل (Matricule)\r\n";
            // 
            // btnUpdateBus
            // 
            this.btnUpdateBus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateBus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateBus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateBus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateBus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnUpdateBus.ForeColor = System.Drawing.Color.White;
            this.btnUpdateBus.Location = new System.Drawing.Point(215, 116);
            this.btnUpdateBus.Name = "btnUpdateBus";
            this.btnUpdateBus.Size = new System.Drawing.Size(89, 32);
            this.btnUpdateBus.TabIndex = 27;
            this.btnUpdateBus.Text = "تعديل";
            this.btnUpdateBus.Click += new System.EventHandler(this.btnUpdateBus_Click);
            // 
            // btnDeleteBus
            // 
            this.btnDeleteBus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDeleteBus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDeleteBus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDeleteBus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnDeleteBus.ForeColor = System.Drawing.Color.White;
            this.btnDeleteBus.Location = new System.Drawing.Point(215, 78);
            this.btnDeleteBus.Name = "btnDeleteBus";
            this.btnDeleteBus.Size = new System.Drawing.Size(89, 32);
            this.btnDeleteBus.TabIndex = 26;
            this.btnDeleteBus.Text = "مسح";
            this.btnDeleteBus.Click += new System.EventHandler(this.btnDeleteBus_Click);
            // 
            // btnAddBus
            // 
            this.btnAddBus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddBus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddBus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddBus.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnAddBus.ForeColor = System.Drawing.Color.White;
            this.btnAddBus.Location = new System.Drawing.Point(215, 40);
            this.btnAddBus.Name = "btnAddBus";
            this.btnAddBus.Size = new System.Drawing.Size(89, 32);
            this.btnAddBus.TabIndex = 24;
            this.btnAddBus.Text = "اضافة";
            this.btnAddBus.Click += new System.EventHandler(this.btnAddBus_Click);
            // 
            // dgvAfficherBus
            // 
            dataGridViewCellStyle25.BackColor = System.Drawing.Color.White;
            this.dgvAfficherBus.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle25;
            this.dgvAfficherBus.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAfficherBus.BackgroundColor = System.Drawing.Color.White;
            this.dgvAfficherBus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAfficherBus.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAfficherBus.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle26.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAfficherBus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle26;
            this.dgvAfficherBus.ColumnHeadersHeight = 35;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle27.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAfficherBus.DefaultCellStyle = dataGridViewCellStyle27;
            this.dgvAfficherBus.EnableHeadersVisualStyles = false;
            this.dgvAfficherBus.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherBus.Location = new System.Drawing.Point(46, 385);
            this.dgvAfficherBus.Name = "dgvAfficherBus";
            this.dgvAfficherBus.RowHeadersVisible = false;
            this.dgvAfficherBus.RowTemplate.Height = 28;
            this.dgvAfficherBus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAfficherBus.Size = new System.Drawing.Size(883, 229);
            this.dgvAfficherBus.TabIndex = 23;
            this.dgvAfficherBus.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherBus.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvAfficherBus.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvAfficherBus.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvAfficherBus.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvAfficherBus.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherBus.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherBus.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvAfficherBus.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAfficherBus.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAfficherBus.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvAfficherBus.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvAfficherBus.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvAfficherBus.ThemeStyle.ReadOnly = false;
            this.dgvAfficherBus.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvAfficherBus.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvAfficherBus.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvAfficherBus.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAfficherBus.ThemeStyle.RowsStyle.Height = 28;
            this.dgvAfficherBus.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvAfficherBus.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvAfficherBus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAfficherBus_CellContentClick);
            // 
            // Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(25)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(992, 663);
            this.Controls.Add(this.dgvAfficherBus);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Bus";
            this.Text = "حافلة";
            this.Load += new System.EventHandler(this.Bus_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfficherBus)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button btnFind;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtMatriculeFind;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2TextBox txtMatriculeTransports;
        private System.Windows.Forms.ComboBox cmbMarque;
        private Guna.UI2.WinForms.Guna2TextBox txtModele;
        private Guna.UI2.WinForms.Guna2TextBox txtCapacite;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnUpdateBus;
        private Guna.UI2.WinForms.Guna2Button btnDeleteBus;
        private Guna.UI2.WinForms.Guna2Button btnAddBus;
        private System.Windows.Forms.ComboBox cmbCarburant;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView dgvAfficherBus;
    }
}