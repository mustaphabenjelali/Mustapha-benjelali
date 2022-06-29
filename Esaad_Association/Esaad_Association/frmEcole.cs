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
    public partial class frmEcole : Form
    {
        int pos;
        int idEcole;
        DataTable dtEcole = new DataTable();
        SqlDataAdapter daEcole1n = new SqlDataAdapter("select * from Ecole", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
        DataTable dt = new DataTable();

        public frmEcole()
        {
            InitializeComponent();
        }

        public void papulaire()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Ecole", "data source =.;initial catalog =dbScolaireTransports;integrated security=true");
            SqlCommandBuilder cv = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvAfficherEcole.ReadOnly = true;
            dgvAfficherEcole.DataSource = ds.Tables["Ecole"];
        }

        private void frmEcole_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daEcole = new SqlDataAdapter("select Max(idEcole) from Ecole", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");

            daEcole.Fill(dt);
            int id = int.Parse(dt.Rows[0][0].ToString());
            idEcole = id + 1;
            daEcole1n.Fill(dtEcole);
            dgvAfficherEcole.DataSource = dtEcole;
            DataGridViewHeaderNameChanged();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (TextBoxChecker())
            {
                if (FindingRow(txtEcoleId.Text) == -1)
                {
                    DataRow row1 = dtEcole.NewRow();
                    row1["NomEcole"] = txtNomEcole.Text;
                    row1["AdresseEcole"] = txtAdresseEcole.Text;
                    row1["Degre"] = cmbDegreEcole.Text;
                    row1["EcoleCode"] = txtEcoleId.Text;
                    dtEcole.Rows.Add(row1);
                    papulaire();
                    dgvAfficherEcole.DataSource = dtEcole;
                    MessageBox.Show("تم اضافة المؤسسة بنجاح");
                    idEcole++;
                }
                else
                    MessageBox.Show("مؤسسة موجودة مسبقا");
            }
            else
                MessageBox.Show("لا يمكن تسجيل المؤسسة دون ملئ معلوماتها");
            DataGridViewHeaderNameChanged();
           
        }

        private void dgvAfficherEcole_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            txtNomEcole.Text = dgvAfficherEcole.SelectedRows[0].Cells[1].Value.ToString();
            txtAdresseEcole.Text = dgvAfficherEcole.SelectedRows[0].Cells[2].Value.ToString();
            cmbDegreEcole.Text = dgvAfficherEcole.SelectedRows[0].Cells[3].Value.ToString();
            txtEcoleId.Text = dgvAfficherEcole.SelectedRows[0].Cells[4].Value.ToString();
        }
        public void DataGridViewHeaderNameChanged()
        {
            dgvAfficherEcole.Columns[0].HeaderText = "ترتيب المؤسسة";
            dgvAfficherEcole.Columns[1].HeaderText = "اسم المؤسسة ";
            dgvAfficherEcole.Columns[2].HeaderText = "عنوان المؤسسة";
            dgvAfficherEcole.Columns[3].HeaderText = "المستوى التعليمي";
            dgvAfficherEcole.Columns[4].HeaderText = "معرف المؤسسة";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged();
            if (FindingRow(txtIdEcoleFind.Text) != -1)
            {
                idEcole--;
                dtEcole.Rows[FindingRow(txtIdEcoleFind.Text)].Delete();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("المعلومات غير موجودة");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged();
            if (FindingRow(txtIdEcoleFind.Text) == -1)
            {
                MessageBox.Show("لا توجد المعلومات المطلوبة");
            }
            else
            {
                dtEcole.Rows[FindingRow(txtIdEcoleFind.Text)][1] = txtNomEcole.Text;
                dtEcole.Rows[FindingRow(txtIdEcoleFind.Text)][2] = txtAdresseEcole.Text;
                dtEcole.Rows[FindingRow(txtIdEcoleFind.Text)][3] = cmbDegreEcole.Text;
                dtEcole.Rows[FindingRow(txtIdEcoleFind.Text)][4] = txtEcoleId.Text;
                MessageBox.Show("تم تحديث المعلومات بنجاح");
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {

            if (FindingRow(txtIdEcoleFind.Text) != -1)
            {
                DataGridViewHeaderNameChanged();
                MessageBox.Show("تم المعلومات");
                pos = FindingRow(txtIdEcoleFind.Text);
                despllaying();
                DataTable BindingWithResults = new DataTable();
                daEcole1n.Fill(BindingWithResults);
                BindingWithResults.Clear();
                BindingWithResults.ImportRow(dtEcole.Rows[pos]);
                dgvAfficherEcole.DataSource = BindingWithResults;

            }
            else
                MessageBox.Show("لا توجد المعلومات");
        }
        public void despllaying()
        {
            if (dtEcole.Rows[pos].RowState != DataRowState.Deleted)
            {
                txtNomEcole.Text = dtEcole.Rows[pos][1].ToString();
                txtAdresseEcole.Text = dtEcole.Rows[pos][2].ToString();
                cmbDegreEcole.Text = dtEcole.Rows[pos][3].ToString();
                txtEcoleId.Text = dtEcole.Rows[pos][4].ToString();
            }
        }
        public int FindingRow(string ecolecode)
        {
            int rowIndex = -1;
            for (int i = 0; i <= dtEcole.Rows.Count - 1; i++)
            {
                if (dtEcole.Rows[i][4].ToString() == ecolecode)
                {
                    rowIndex = i;
                }
            }
            return rowIndex;
        }

        public bool TextBoxChecker()
        {
            if (txtNomEcole.Text == string.Empty && txtAdresseEcole.Text == string.Empty && txtEcoleId.Text == string.Empty && cmbDegreEcole.Text == string.Empty)
            {
                MessageBox.Show("المرجوا ادخال جميع المعلومات المطلوبة");
                return false;
            }
            else
                return true;
        }
       
    }
}
