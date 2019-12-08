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
    public partial class TeacherForm : Form
    {
        public TeacherForm()
        {
            InitializeComponent();
        }
        string conStr = "Data Source=DESKTOP-TIQSQIC;Initial Catalog=SchoolDb;Integrated Security=true;";
        private void btn_next_Click(object sender, EventArgs e)
        {
            FullInfoForm fullInfoForm = new FullInfoForm();
            fullInfoForm.ShowDialog();
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            using (SqlConnection sqlConnection =new SqlConnection(conStr))
            {
                sqlConnection.Open();
                using (SqlCommand command=new SqlCommand("SELECT * FROM Lessons",sqlConnection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataTable);
                    }
                }
            }
            cmbx_fenn.DataSource = dataTable;
            cmbx_fenn.DisplayMember = "Name";
            cmbx_fenn.ValueMember = "Id";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();
                using (SqlCommand command = new SqlCommand($"INSERT INTO Teacher (Name,Surname,SubjectId)" +
                    $"VALUES ('{txbx_name.Text}','{txbx_surname.Text}','{cmbx_fenn.SelectedValue}')", sqlConnection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Müəllim uğurla əlavə edildi.");
                }
            }
        }
    }
}
