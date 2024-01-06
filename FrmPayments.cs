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
    public partial class FrmPayments : Form
    {
        public FrmPayments()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int choose;
            string StudentID, StudentName, StudentSurname, StudentRemainDebt;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            StudentID = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            StudentName = dataGridView1.Rows[choose].Cells[1].Value.ToString();
            StudentSurname = dataGridView1.Rows[choose].Cells[2].Value.ToString();
            StudentRemainDebt = dataGridView1.Rows[choose].Cells[3].Value.ToString();

            TextStudentId.Text = StudentID;
            TextName.Text = StudentName;
            TextSurname.Text = StudentSurname;
            TextRemainDebt.Text = StudentRemainDebt;


        }

        private void FrmPayments_Load(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();



                adapter.SelectCommand = new SqlCommand("SELECT StudentID, StudentName,StudentSurname,StudentRemainDebt FROM Debt ORDER BY StudentId", cn.connect());
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
                dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

                // DataGridView sütunları tam genişlik
                DataGridViewColumn[] columnsArray = new DataGridViewColumn[dataGridView1.Columns.Count];
                dataGridView1.Columns.CopyTo(columnsArray, 0);
                Array.ForEach(columnsArray, column => column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells);

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

        private void ButtonPayment_Click(object sender, EventArgs e)
        {

            // deducted from the remaining amount paid
            int PaidDebt, RemainDebt, NewDebt;
            PaidDebt = Convert.ToInt32(TextPaidDebt.Text);
            RemainDebt = Convert.ToInt32(TextRemainDebt.Text);
            NewDebt = RemainDebt - PaidDebt;
            TextRemainDebt.Text = NewDebt.ToString();

            // update new amount
            SqlCommand Command = new SqlCommand("UPDATE Debt SET StudentRemainDebt = @p1 WHERE StudentID = @p2", cn.connect());

            Command.Parameters.AddWithValue("@p2", TextStudentId.Text);
            Command.Parameters.AddWithValue("@p1", TextRemainDebt.Text);
            Command.ExecuteNonQuery();
            cn.connect().Close();
            MessageBox.Show("Debt Paid");

            // Call the RefreshDataGridView method to update the DataGridView
            RefreshDataGridView();

            SqlCommand Command2 = new SqlCommand("insert into Safe (PaymentMonth,PaymentAmount) values (@k1,@k2) ", cn.connect());
            Command2.Parameters.AddWithValue("@k1", TextMonthPaid.Text);
            Command2.Parameters.AddWithValue("@k2", TextPaidDebt.Text);
            Command2.ExecuteNonQuery();
            cn.connect().Close();

        }
    


        private void RefreshDataGridView()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();



                adapter.SelectCommand = new SqlCommand("SELECT StudentID, StudentName,StudentSurname,StudentRemainDebt FROM Debt ORDER BY StudentID", cn.connect());
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed: " + ex.Message);
            }
            finally
            {
                cn.connect().Close();
            }
        }





    }
}
