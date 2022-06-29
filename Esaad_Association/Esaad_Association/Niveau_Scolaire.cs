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
    public partial class Niveau_Scolaire : Form
    {
        int pos;
        int idNiveau;
        DataTable dtNiveau = new DataTable();
        SqlDataAdapter daNiveau = new SqlDataAdapter("select * from Niveau_Scolaire", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
        DataTable dt = new DataTable();
        public Niveau_Scolaire()
        {
            InitializeComponent();
        }

        public void papulaire()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from Niveau_Scolaire", "data source =.;initial catalog =dbScolaireTransports;integrated security=true");
            SqlCommandBuilder cv = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            dgvAfficherNiveau.ReadOnly = true;
            dgvAfficherNiveau.DataSource = ds.Tables["Niveau_Scolaire"];
        }

        private void Niveau_Scolaire_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daN = new SqlDataAdapter("select Max(idNiveau) from Niveau_Scolaire" , "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
            daN.Fill(dt);
            int id = int.Parse(dt.Rows[0][0].ToString());
            idNiveau = id + 1;
            daNiveau.Fill(dtNiveau);
            dgvAfficherNiveau.DataSource = dtNiveau;
            DataGridViewHeaderNameChanged();
        }

        public void DataGridViewHeaderNameChanged()
        {
            dgvAfficherNiveau.Columns[0].HeaderText = "ترتيب المستوى";
            dgvAfficherNiveau.Columns[1].HeaderText = "المستوى التعليمي";
            dgvAfficherNiveau.Columns[2].HeaderText = "معرف المستوى";
        }

        private void dgvAfficherNiveau_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtLibelleNiveau.Text = dgvAfficherNiveau.SelectedRows[0].Cells[1].Value.ToString();
            txtIdNiveauScolaire.Text = dgvAfficherNiveau.SelectedRows[0].Cells[2].Value.ToString();
        }

        private void btnUpdateNiveau_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged();
            if (FindingRow() == -1)
            {
                MessageBox.Show("لا توجد المعلومات المطلوبة");
            }
            else
            {
                dtNiveau.Rows[FindingRow()][1] = txtLibelleNiveau.Text;
                dtNiveau.Rows[FindingRow()][2] = txtIdNiveauScolaire.Text;
                MessageBox.Show("تم تحديث المعلومات بنجاح");
            }
        }


        private void btnAddNiveau_Click(object sender, EventArgs e)
        {

            if (TextBoxChecker())
            {
                if (FindingRow() == -1)
                {
                    DataRow row1 = dtNiveau.NewRow();
                    row1["LibelleNiveau"] = txtLibelleNiveau.Text;
                    row1["CodeNiveau"] = txtIdNiveauScolaire.Text;
                    dtNiveau.Rows.Add(row1);
                    papulaire();
                    dgvAfficherNiveau.DataSource = dtNiveau;
                    MessageBox.Show("تم اضافة المستوى التعليمي بنجاح");
                }
                else
                    MessageBox.Show("المستوى التعليمي موجودة مسبقا");
            }
            else
                MessageBox.Show("لا يمكن تسجيل المستوى التعليمي دون ملئ معلوماتها");
            DataGridViewHeaderNameChanged();
            idNiveau++;
        }

        private void btnDeleteNiveau_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged();
            if (FindingRow() != -1)
            {
                idNiveau--;
                dtNiveau.Rows[FindingRow()].Delete();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("المعلومات غير موجودة");
            }
        }

        public void despllaying()
        {
            if (dtNiveau.Rows[pos].RowState != DataRowState.Deleted)
            {
                txtLibelleNiveau.Text = dtNiveau.Rows[pos][1].ToString();
                txtIdNiveauScolaire.Text = dtNiveau.Rows[pos][2].ToString();
            }
        }

        public int FindingRow()
        {
            int rowIndex = -1;
            for (int i = 0; i <= dtNiveau.Rows.Count - 1; i++)
            {
                if (dtNiveau.Rows[i][2].ToString() == txtIdNiveauFind.Text)
                {
                    rowIndex = i;
                }
            }
            return rowIndex;
        }

        public bool TextBoxChecker()
        {
            if (txtLibelleNiveau.Text == string.Empty && txtIdNiveauScolaire.Text == string.Empty)
            {
                MessageBox.Show("المرجوا ادخال جميع المعلومات المطلوبة");
                return false;
            }
            else
                return true;
        }

        private void btnFindNiveau_Click(object sender, EventArgs e)
        {
            if (FindingRow() != -1)
            {
                DataGridViewHeaderNameChanged();
                MessageBox.Show("تم المعلومات");
                pos = FindingRow();
                despllaying();
                DataTable BindingWithResults = new DataTable();
                daNiveau.Fill(BindingWithResults);
                BindingWithResults.Clear();
                BindingWithResults.ImportRow(dtNiveau.Rows[pos]);
                dgvAfficherNiveau.DataSource = BindingWithResults;
            }
            else
                MessageBox.Show("لا توجد المعلومات");
        }


        
    }
}
