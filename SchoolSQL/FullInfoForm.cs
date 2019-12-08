using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolSQL
{
    public partial class FullInfoForm : Form
    {
        public FullInfoForm()
        {
            InitializeComponent();
        }
        string conStr = "Data Source=DESKTOP-TIQSQIC;Initial Catalog=SchoolDb;Integrated Security=true;";
        private void FullInfoForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();
                using (SqlCommand command=new SqlCommand("SELECT * FROM Class",sqlConnection))
                {
                    using (SqlDataAdapter dataAdapter=new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            cmbx_sinif.DataSource = dataTable;
            cmbx_sinif.DisplayMember = "Name";
            cmbx_sinif.ValueMember = "Id";
        }

        private void cmbx_sinif_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            string num= ((ComboBox)sender).SelectedValue.ToString();
            using (SqlConnection sql = new SqlConnection(conStr))
            {
                sql.Open();
                using (SqlCommand sqlCommand=new SqlCommand("SELECT DISTINCT L.Name,L.Id FROM Class AS C" +
                    $" Inner Join ClassLesson AS CL ON Cl.ClassId={num}" +
                    " Inner Join Lessons AS L ON L.Id=Cl.LessonId",sql))
                {
                    using(SqlDataAdapter sqlDataAdapter=new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(dataTable);
                    }
                }
            }
            cmbx_fenn.DataSource = dataTable;
            cmbx_fenn.DisplayMember = "Name";
            cmbx_fenn.ValueMember = "Id";
            cmbx_teacher.DataSource = null;
        }

        private void cmbx_fenn_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string num = ((ComboBox)sender).SelectedValue.ToString();
            using (SqlConnection sql = new SqlConnection(conStr))
            {
                sql.Open();
                using (SqlCommand sqlCommand = new SqlCommand($"SELECT  DISTINCT T.Name+' '+T.Surname AS 'Name_Surname',T.Id  FROM Lessons AS L " +
                    $"INNER JOIN Teacher T" +
                    $" ON T.SubjectId={num}", sql))
                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(data);
                        
                    }
                }
            }
            cmbx_teacher.DataSource = data;
            cmbx_teacher.DisplayMember = "Name_Surname";
            cmbx_teacher.ValueMember = "Id";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            DataGridForm gridForm = new DataGridForm();
            gridForm.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            
            using (SqlConnection sql = new SqlConnection(conStr))
            {
                sql.Open();
                using (SqlCommand sqlCommand = new SqlCommand("INSERT INTO FullInfo (LessonId,ClassId,TeacherId)" +
                    $"VALUES('{cmbx_sinif.SelectedValue}','{cmbx_fenn.SelectedValue}','{cmbx_teacher.SelectedValue}')", sql))
                {
                    sqlCommand.ExecuteNonQuery();
                }
            }

        }
    }
}
