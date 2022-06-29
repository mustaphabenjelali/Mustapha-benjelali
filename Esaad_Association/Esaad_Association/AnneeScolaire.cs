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
    public partial class AnneeScolaire : Form
    {
        int pos1;
        int idAnnee;
        DataTable dtAnneeScolaire = new DataTable();
        SqlDataAdapter daAnneeScolaire = new SqlDataAdapter("select * from Annee_Scolaire", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
        DataTable dt10 = new DataTable();
        public AnneeScolaire()
        {
            InitializeComponent();
        }

        public void papulaire1()
        {
            SqlDataAdapter da2 = new SqlDataAdapter("select * from Annee_Scolaire", "data source =.;initial catalog =dbScolaireTransports;integrated security=true");
            SqlCommandBuilder cv = new SqlCommandBuilder(da2);
            var ds0 = new DataSet();
            da2.Fill(ds0);
            dgvAfficherAnneeScolaire.ReadOnly = true;
            dgvAfficherAnneeScolaire.DataSource = ds0.Tables["Annee_Scolaire"];
        }

        private void AnneeScolaire_Load(object sender, EventArgs e)
        {
            SqlDataAdapter daAS = new SqlDataAdapter("select Max(idAnnee) from Annee_Scolaire", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");

            daAS.Fill(dt10);
            int id = int.Parse(dt10.Rows[0][0].ToString());
            idAnnee = id + 1;
            daAnneeScolaire.Fill(dtAnneeScolaire);
            dgvAfficherAnneeScolaire.DataSource = dtAnneeScolaire;
            DataGridViewHeaderNameChanged1();
        }

        public void DataGridViewHeaderNameChanged1()
        {
            dgvAfficherAnneeScolaire.Columns[0].HeaderText = "ترتيب السنة الدراسية";
            dgvAfficherAnneeScolaire.Columns[1].HeaderText = "السنة الدراسية";
            dgvAfficherAnneeScolaire.Columns[2].HeaderText = "معرف السنة الدراسية";
        }

        private void dgvAfficherAnneeScolaire_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtAnneeScolaire.Text = dgvAfficherAnneeScolaire.SelectedRows[0].Cells[1].Value.ToString();        }

        public void despllaying1()
        {
            if (dtAnneeScolaire.Rows[pos1].RowState != DataRowState.Deleted)
            {
                txtAnneeScolaire.Text = dtAnneeScolaire.Rows[pos1][1].ToString();
            }
        }

        public int FindingRow1()
        {
            int rowIndex0 = -1;
            for (int i = 0; i <= dtAnneeScolaire.Rows.Count - 1; i++)
            {
                if (dtAnneeScolaire.Rows[i][2].ToString() == txtIdAnneeRecherche.Text)
                {
                    rowIndex0 = i;
                }
            }
            return rowIndex0;
        }

        public bool TextBoxChecker1()
        {
            if (txtAnneeScolaire.Text == string.Empty && txtAnneeScolaire.Text == string.Empty)
            {
                MessageBox.Show("المرجوا ادخال جميع المعلومات المطلوبة");
                return false;

            }
            else
                return true;
        }

        private void btnFindAnneeScolaire_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged1();
            if (FindingRow1() != -1)
            {
                MessageBox.Show("تم المعلومات");
                pos1 = FindingRow1();
                despllaying1();
                DataTable BindingWithResults = new DataTable();
                daAnneeScolaire.Fill(BindingWithResults);
                BindingWithResults.Clear();
                BindingWithResults.ImportRow(dtAnneeScolaire.Rows[pos1]);
                dgvAfficherAnneeScolaire.DataSource = BindingWithResults;

            }
            else
                MessageBox.Show("لا توجد المعلومات");
        }

        private void btnUpdateAnnee_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged1();
            if (FindingRow1() == -1)
            {
                MessageBox.Show("لا توجد المعلومات المطلوبة");
            }
            else
            {
                dtAnneeScolaire.Rows[FindingRow1()][1] = txtAnneeScolaire.Text;
                MessageBox.Show("تم تحديث المعلومات بنجاح");
            }
        }

        private void btnDeleteAnne_Click(object sender, EventArgs e)
        {
            DataGridViewHeaderNameChanged1();
            if (FindingRow1() != -1)
            {
                idAnnee--;
                dtAnneeScolaire.Rows[FindingRow1()].Delete();
                MessageBox.Show("تم الحذف بنجاح");
            }
            else
            {
                MessageBox.Show("المعلومات غير موجودة");
            }
        }

        private void btnAddAnne_Click(object sender, EventArgs e)
        {
            if (TextBoxChecker1())
            {
                if (FindingRow1() == -1)
                {
                    DataRow row1 = dtAnneeScolaire.NewRow();
                    row1["AnneeScolaire"] = txtAnneeScolaire.Text;
                    dtAnneeScolaire.Rows.Add(row1);
                    papulaire1();
                    dgvAfficherAnneeScolaire.DataSource = dtAnneeScolaire;
                    MessageBox.Show("تم اضافة المؤسسة بنجاح");
                }
                else
                    MessageBox.Show("مؤسسة موجودة مسبقا");
            }
            else
                MessageBox.Show("لا يمكن تسجيل المؤسسة دون ملئ معلوماتها");
            DataGridViewHeaderNameChanged1();
            idAnnee++;
        }
    }
}
