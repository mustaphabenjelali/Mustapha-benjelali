using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Esaad_Association
{
    public partial class Bus : Form
    {

        int pos;
        DataTable dtBus = new DataTable();
        SqlDataAdapter daBus = new SqlDataAdapter("select * from Bus_Scolaire", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
        DataTable dt = new DataTable();
        public Bus()
        {
            InitializeComponent();
        }

        public void papulaire()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Bus_Scolaire", "data source =.;initial catalog =dbScolaireTransports;integrated security=true");
            SqlCommandBuilder cv = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvAfficherBus.ReadOnly = true;
            dgvAfficherBus.DataSource = ds.Tables["Bus_Scolaire"];
        }


        private void Bus_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daEcole = new SqlDataAdapter("select * from Bus_Scolaire", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
            daEcole.Fill(dt);
            daBus.Fill(dtBus);
            dgvAfficherBus.DataSource = dtBus;
            DataGridViewHeaderNameChanged();
        }

        public void DataGridViewHeaderNameChanged()
        {
            dgvAfficherBus.Columns[0].HeaderText = "رقم التسجيل";
            dgvAfficherBus.Columns[1].HeaderText = "عدد المقاعد ";
            dgvAfficherBus.Columns[2].HeaderText = "طراز السيارة";
            dgvAfficherBus.Columns[3].HeaderText = "العلامة التجارية";
            dgvAfficherBus.Columns[4].HeaderText = "نوع الوقود";
        }

        private void dgvAfficherBus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMatriculeTransports.Text = dgvAfficherBus.SelectedRows[0].Cells[0].Value.ToString();
            txtCapacite.Text = dgvAfficherBus.SelectedRows[0].Cells[1].Value.ToString();
            txtModele.Text = dgvAfficherBus.SelectedRows[0].Cells[2].Value.ToString();
            cmbMarque.Text = dgvAfficherBus.SelectedRows[0].Cells[3].Value.ToString();
            cmbCarburant.Text = dgvAfficherBus.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (FindingRow(txtMatriculeFind.Text) != -1)
            {
                DataGridViewHeaderNameChanged();
                MessageBox.Show("تم المعلومات");
                pos = FindingRow(txtMatriculeFind.Text);
                despllaying();
                DataTable BindingWithResults = new DataTable();
                daBus.Fill(BindingWithResults);
                BindingWithResults.Clear();
                BindingWithResults.ImportRow(dtBus.Rows[pos]);
                dgvAfficherBus.DataSource = BindingWithResults;

            }
            else
                MessageBox.Show("لا توجد المعلومات");
        }

        public void despllaying()
        {
            if (dtBus.Rows[pos].RowState != DataRowState.Deleted)
            {
                txtCapacite.Text = dtBus.Rows[pos][1].ToString();
                txtModele.Text = dtBus.Rows[pos][2].ToString();
                cmbMarque.Text = dtBus.Rows[pos][3].ToString();
                txtMatriculeTransports.Text = dtBus.Rows[pos][0].ToString();
                cmbCarburant.Text = dtBus.Rows[pos][4].ToString();
            }
        }

        public int FindingRow(string Matricule)
        {
            int rowIndex = -1;
            for (int i = 0; i <= dtBus.Rows.Count - 1; i++)
            {
                if (dtBus.Rows[i][0].ToString() == Matricule)
                {
                    rowIndex = i;
                }
            }
            return rowIndex;
        }

        private void btnDeleteBus_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged();
            if (FindingRow(txtMatriculeFind.Text) != -1)
            {
                dtBus.Rows[FindingRow(txtMatriculeFind.Text)].Delete();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("المعلومات غير موجودة");
            }
        }

        private void btnUpdateBus_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged();
            if (FindingRow(txtMatriculeFind.Text) == -1)
            {
                MessageBox.Show("لا توجد المعلومات المطلوبة");
            }
            else
            {
                dtBus.Rows[FindingRow(txtMatriculeFind.Text)][0] = txtMatriculeTransports.Text;
                dtBus.Rows[FindingRow(txtMatriculeFind.Text)][1] = int.Parse(txtCapacite.Text);
                dtBus.Rows[FindingRow(txtMatriculeFind.Text)][2] = txtModele.Text;
                dtBus.Rows[FindingRow(txtMatriculeFind.Text)][3] = cmbMarque.Text;
                dtBus.Rows[FindingRow(txtMatriculeFind.Text)][4] = cmbCarburant.Text;
                MessageBox.Show("تم تحديث المعلومات بنجاح");
            }
        }

        private void btnAddBus_Click(object sender, EventArgs e)
        {
            if (TextBoxChecker())
            {
                if (FindingRow(txtMatriculeTransports.Text) == -1)
                {
                    DataRow row1 = dtBus.NewRow();
                    row1["MatriculeTransport"] = txtMatriculeTransports.Text;
                    row1["Capacite"] =int.Parse(txtCapacite.Text);
                    row1["Modele"] = txtModele.Text;
                    row1["Marque"] = cmbMarque.Text;
                    row1["Carburant"] = cmbCarburant.Text;
                    dtBus.Rows.Add(row1);
                    papulaire();
                    dgvAfficherBus.DataSource = dtBus;
                    MessageBox.Show("تم اضافة المؤسسة بنجاح");
                }
                else
                    MessageBox.Show("مؤسسة موجودة مسبقا");
            }
            else
                MessageBox.Show("لا يمكن تسجيل المؤسسة دون ملئ معلوماتها");
            DataGridViewHeaderNameChanged();
        }

        public bool TextBoxChecker()
        {
            if (txtMatriculeTransports.Text == string.Empty && txtCapacite.Text == string.Empty && txtModele.Text == string.Empty && cmbMarque.Text == string.Empty && cmbCarburant.Text == string.Empty)
            {
                MessageBox.Show("المرجوا ادخال جميع المعلومات المطلوبة");
                return false;
            }
            else
                return true;
        }
    }
}
