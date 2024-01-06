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
    public partial class FrmMainForm : Form
    {
        public FrmMainForm()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();
       
        private void FrmMainForm_Load(object sender, EventArgs e)
        {
            

            label1.Text = DateTime.Now.ToLongDateString();
           
            
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();



                adapter.SelectCommand = new SqlCommand("SELECT StudentId, StudentName,StudentSurname,StudentRoomNum FROM Student ORDER BY StudentId", cn.connect());
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

        private void staffEditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStaff1 Fr = new FrmStaff1();
            Fr.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void passwordTransactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdminEdit Fr = new FrmAdminEdit();
            Fr.Show();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Calc.exe");

        }

        private void paintToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("MsPaint.Exe");
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentReg Fr = new FrmStudentReg();
            Fr.Show();
        }

        private void studentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentList Fr = new FrmStudentList();
            Fr.Show();
        }

        private void editStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentList Fr = new FrmStudentList();
            Fr.Show();
        }

        private void addDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment Fr = new FrmDepartment();
            Fr.Show();
        }

        private void editDepartmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDepartment Fr = new FrmDepartment();
            Fr.Show();
        }

        private void getPaidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPayments Fr = new FrmPayments();
            Fr.Show();
        }

        private void addExpenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpense Fr = new FrmExpense();
            Fr.Show();
        }

        private void expenseListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmExpenseList Fr = new FrmExpenseList();
            Fr.Show();
        }

        private void incomeStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmIncomeStatistics Fr = new FrmIncomeStatistics();
            Fr.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program was made by Bilge Şenavcu.", "Student Dormitory Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void managerToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
