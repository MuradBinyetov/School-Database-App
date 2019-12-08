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
    public partial class DataGridForm : Form
    {
        public DataGridForm()
        {
            InitializeComponent();
        }
        string conStr = "Data Source=DESKTOP-TIQSQIC;Initial Catalog=SchoolDb; Integrated Security=true;";
        private void DataGridForm_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            
            using (SqlConnection sqlConnection=new SqlConnection(conStr))
            {
                sqlConnection.Open();
                using (SqlCommand command=new SqlCommand("SELECT c.Id,C.Name FROM FullInfo AS Fi" +
                    $" INNER JOIN Class AS C ON C.Id=Fi.ClassId", sqlConnection))
                {
                    using(SqlDataAdapter sqlData=new SqlDataAdapter(command))
                    {
                        sqlData.Fill(dataTable);
                    }
                }
            }
            cmbx_sinif.DataSource = dataTable;
            cmbx_sinif.DisplayMember = "Name";
            cmbx_sinif.ValueMember = "Id";
        }

      

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            DataTable data = new DataTable();
            string num = ((ComboBox)cmbx_sinif).SelectedValue.ToString();
            using (SqlConnection sql = new SqlConnection(conStr))
            {
                sql.Open();
                using (SqlCommand sqlCommand = new SqlCommand($"select DISTINCT L.Name AS 'Fənnin adı',T.Name+' '+T.Surname as 'Müəllimin adı və soyadı',C.Name AS 'Sinifin adı' from FullInfo FI" +
                    $" join Lessons L on l.Id =FI.LessonId" +
                    $" join Teacher T on T.Id=Fi.TeacherId" +
                    $" join Class C on {num}=Fi.ClassId", sql))

                {
                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                        sqlDataAdapter.Fill(data);
                        dtgrd_info.DataSource = data;
                    }
                }
            }
        }
    }
}
