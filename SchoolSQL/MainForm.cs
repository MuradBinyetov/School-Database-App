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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        string conStr = "Data Source=DESKTOP-TIQSQIC;Initial Catalog=SchoolDb;Integrated Security=true;";
        private void MainForm_Load(object sender, EventArgs e)
        {

            DataTable dataClass = new DataTable();
            using (SqlConnection sqlConnection =new SqlConnection(conStr))
            {
                sqlConnection.Open();

                using (SqlCommand command=new SqlCommand("SELECT * FROM Class",sqlConnection))
                {
                    using (SqlDataAdapter dataAdapter =new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataClass);
                    }
                }
            }
            cmbx_sinif.DataSource = dataClass;
            cmbx_sinif.DisplayMember = "Name";
            cmbx_sinif.ValueMember = "Id";



            DataTable dataLesson = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand("SELECT * FROM Lessons", sqlConnection))
                {
                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataLesson);
                    }
                }
            }
            cmbx_fenn.DataSource = dataLesson;
            cmbx_fenn.DisplayMember = "Name";
            cmbx_fenn.ValueMember = "Id";
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            TeacherForm teacherForm = new TeacherForm();
            teacherForm.ShowDialog();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlConnection = new SqlConnection(conStr))
            {
                sqlConnection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO ClassLesson (ClassId,LessonId)" +
                    $"VALUES('{cmbx_sinif.SelectedValue}','{cmbx_fenn.SelectedValue}')", sqlConnection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Siniflərə uyğun fənnlər uğurla əlavə edildi.");
                }
            }
        }
    }
}
