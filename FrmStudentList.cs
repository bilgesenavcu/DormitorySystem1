using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DormitorySystem1
{
    public partial class FrmStudentList : Form
    {
        public FrmStudentList()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();

       
        private void FrmStudentList_Load(object sender, EventArgs e)
        {

            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();



                adapter.SelectCommand = new SqlCommand("SELECT StudentId, StudentName,StudentSurname,StudentTC,StudentPhone,StudentBirth,StudentDepartment,StudentMail,StudentRoomNum,ParentNameSurname,ParentPhone,ParentAddress FROM Student ORDER BY StudentId", cn.connect());
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Fail: " + ex.Message);
            }
            finally
            {
                cn.connect().Close();
            }
        }

        int choose;
     

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            choose = dataGridView1.SelectedCells[0].RowIndex;
            FrmStudentEdit frm = new FrmStudentEdit();
            frm.ID = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            frm.name = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            frm.surname = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            frm.TC = dataGridView1.Rows[choose].Cells[3].Value.ToString();
            frm.phone = dataGridView1.Rows[choose].Cells[4].Value.ToString();
            frm.birth = dataGridView1.Rows[choose].Cells[5].Value.ToString();
            frm.department = dataGridView1.Rows[choose].Cells[6].Value.ToString();
            frm.mail = dataGridView1.Rows[choose].Cells[7].Value.ToString();
            frm.RoomNum= dataGridView1.Rows[choose].Cells[8].Value.ToString();
            frm.ParentNameSurname = dataGridView1.Rows[choose].Cells[9].Value.ToString();
            frm.ParentPhone = dataGridView1.Rows[choose].Cells[10].Value.ToString();
            frm.address = dataGridView1.Rows[choose].Cells[11].Value.ToString();
            frm.Show();
        }
    }
}
