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
    public partial class FrmDepartment : Form
    {
        public FrmDepartment()
        {
            InitializeComponent();
        }


        SqlCon cn = new SqlCon();

       

        private void FrmDepartment_Load(object sender, EventArgs e)
        {
            try
            {
              
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();

                

                adapter.SelectCommand = new SqlCommand("SELECT DepartmentId, DepartmentName FROM Departments ORDER BY DepartmentId", cn.connect());
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        int choose;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn && e.RowIndex != -1)
            {
                string columnName = dataGridView1.Columns[e.ColumnIndex].Name;


                if (columnName == "DepartmentId" || columnName == "DepartmentName")
                {
                   
                    if (dataGridView1.SortOrder == System.Windows.Forms.SortOrder.Descending)
                    {
                        dataGridView1.Sort(dataGridView1.Columns["DepartmentId"], ListSortDirection.Ascending);
                    }
                   
                }
            }
            string Id, DepartmentName;
            choose = dataGridView1.SelectedCells[0].RowIndex;
            Id = dataGridView1.Rows[choose].Cells[0].Value.ToString();
            DepartmentName = dataGridView1.Rows[choose].Cells[1].Value.ToString();

            TextDepartmentId.Text = Id;
            TextDepartmentName.Text = DepartmentName;

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                
                SqlCommand Command1 = new SqlCommand("Insert into Departments (DepartmentName) values (@p1)", cn.connect());
                Command1.Parameters.AddWithValue("@p1", TextDepartmentName.Text);

                Command1.ExecuteNonQuery();
                cn.connect().Close();
                MessageBox.Show("Department added.");
                RefreshDataGridView();

            }
            catch
            {
                MessageBox.Show("Failed!Try again.");
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand Command2 = new SqlCommand("delete from Departments where DepartmentId=@p1", cn.connect());
                Command2.Parameters.AddWithValue("@p1", TextDepartmentId.Text);
                Command2.ExecuteNonQuery();
                cn.connect().Close();
                MessageBox.Show("deletion successful");
                RefreshDataGridView();
            }
            catch
            {
                MessageBox.Show("Failed,transaction did not occur");
            }
           

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand Command2 = new SqlCommand("update Departments set DepartmentName=@p1 where DepartmentId=@p2", cn.connect());
                Command2.Parameters.AddWithValue("@p2", TextDepartmentId.Text);
                Command2.Parameters.AddWithValue("@p1", TextDepartmentName.Text);
                Command2.ExecuteNonQuery();
                cn.connect().Close();
                MessageBox.Show("update has occurred");
                RefreshDataGridView();


            }
            catch
            {
                MessageBox.Show("Failed");
            }

        }



        private void RefreshDataGridView()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();

                

                adapter.SelectCommand = new SqlCommand("SELECT DepartmentId, DepartmentName FROM Departments ORDER BY DepartmentId", cn.connect());
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
