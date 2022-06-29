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
    public partial class frmStudent : Form
    {
        SqlDataAdapter student_adapter = new SqlDataAdapter(@"select * from Eleve" , "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
        DataTable student_table = new DataTable();
        DataTable anne_tble = new DataTable();
        DataTable level_table = new DataTable();
        DataTable ecole_table = new DataTable();
        DataTable apprendre_table = new DataTable();
        DataTable etudier_table = new DataTable();


        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            student_adapter.Fill(student_table);
            SqlDataAdapter daAnneeScolaire = new SqlDataAdapter("select * from Annee_Scolaire", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
            SqlDataAdapter daEcole = new SqlDataAdapter("select * from Ecole", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
            SqlDataAdapter daNiveau = new SqlDataAdapter("select * from Niveau_Scolaire", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
            SqlDataAdapter apprendre_adapter = new SqlDataAdapter("select * from Apprendre", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
            SqlDataAdapter etudier_adapter = new SqlDataAdapter("select * from Etudier", "data source = .;initial catalog =dbScolaireTransports;integrated security = true");
            daAnneeScolaire.Fill(anne_tble);
            daEcole.Fill(ecole_table);
            daNiveau.Fill(level_table);
            apprendre_adapter.Fill(apprendre_table);
            etudier_adapter.Fill(etudier_table);
            ///////////////anne shcol//////////////
            //cmbAnneeScolaire.DataSource = anne_tble;
            //cmbAnneeScolaire.DisplayMember = "AnneeScolaire";
            //cmbAnneeScolaire.ValueMember = "idAnnee";
            ///////////////////ecole////////////////////
            //cmbEcole.DataSource = ecole_table;
            //cmbEcole.ValueMember = "idEcole";
            //cmbEcole.DisplayMember = "NomEcole";
            //////////////////////////////////////////
            ////cmbNiveau.DataSource = level_table;
            ////cmbNiveau.DisplayMember = "LibelleNiveau";
            ////cmbNiveau.ValueMember = "CodeNiveau";
            ///////////////////////////////////////////
           

        }
        public DataRow FindingRow(string codeStudent)
        {
            DataRow row = null;
            for(int i = 0; i<=student_table.Rows.Count-1;i++)
            {
                if (student_table.Rows[i][0].ToString() == codeStudent)
                    row = student_table.Rows[i];
            }
            return row;
        }

        private void btnFindStudent_Click(object sender, EventArgs e)
        {
            if(FindingRow(txtMassarFind.Text)==null)
            {
                
                MessageBox.Show("doesn't exists !");
            }
            else
            {
                MessageBox.Show("Found it !");
                txtMassar.Text = FindingRow(txtMassarFind.Text)[0].ToString();
                txtNomStudent.Text = FindingRow(txtMassarFind.Text)[1].ToString();
                txtPrenomStudent.Text = FindingRow(txtMassarFind.Text)[2].ToString();
                dtpDateNaissance.Value = (DateTime)FindingRow(txtMassarFind.Text)[3];
                cmbSexe.Text = FindingRow(txtMassarFind.Text)[4].ToString();
                txtTelephone.Text = FindingRow(txtMassarFind.Text)[5].ToString();
                txtEmail.Text = FindingRow(txtMassarFind.Text)[6].ToString();
                txtAdresse.Text = FindingRow(txtMassarFind.Text)[7].ToString();
                dtpDataInscre.Value = (DateTime)FindingRow(txtMassarFind.Text)[8];
          
               
            }
        }

        private void cmbAnneeScolaire_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                    


        }

        private void cmbEcole_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void cmbNiveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }




        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (FindingRow(txtMassar.Text)==null)
            {
                DataRow row = student_table.NewRow();
                row[0] = txtMassar.Text;
                row[1] = txtNomStudent.Text;
                row[2] = txtPrenomStudent.Text;
                row[3] = dtpDateNaissance.Value;
                row[4] = cmbSexe.Text;
                row[5] = txtTelephone.Text;
                row[6] = txtEmail.Text;
                row[7] = txtAdresse.Text;
                row[8] = dtpDataInscre.Value;
                student_table.Rows.Add(row);
                MessageBox.Show("added sucessfully");
            }
        }

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            var row = FindingRow(txtMassar.Text);
            if (row != null)
            {
                row[0] = txtMassar.Text;
                row[1] = txtNomStudent.Text;
                row[2] = txtPrenomStudent.Text;
                row[3] = dtpDateNaissance.Value;
                row[4] = cmbSexe.Text;
                row[5] = txtTelephone.Text;
                row[6] = txtEmail.Text;
                row[7] = txtAdresse.Text;
                row[8] = dtpDataInscre.Value;
                MessageBox.Show("modified sucessfully");
            }
        }
    }
}
