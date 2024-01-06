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
    public partial class FrmAdminEdit : Form
    {
       
        public FrmAdminEdit()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();



                adapter.SelectCommand = new SqlCommand("SELECT AdminId, AdminName,AdminPassword FROM Admin ORDER BY AdminId", cn.connect());
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Admin(AdminName,AdminPassword) values (@p1,@p2) ", cn.connect());
            command.Parameters.AddWithValue("@p1", TextUserName.Text);
            command.Parameters.AddWithValue("@p2",Textpassword.Text);
            command.ExecuteNonQuery();
            cn.connect().Close();
            MessageBox.Show("Add Admin");
            RefreshDataGridView(); 
        }



       private void RefreshDataGridView()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();



                adapter.SelectCommand = new SqlCommand("SELECT AdminName,AdminPassword FROM Admin ORDER BY AdminId", cn.connect());
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

        


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int Choose;
            Choose = dataGridView1.SelectedCells[0].RowIndex;
            string  id,name, password;
            id = dataGridView1.Rows[Choose].Cells[0].Value.ToString();
            name = dataGridView1.Rows[Choose].Cells[1].Value.ToString();
            password = dataGridView1.Rows[Choose].Cells[2].Value.ToString();

            TextAdminID.Text = id;
            TextUserName.Text = name;
            Textpassword.Text = password;
          
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM Admin WHERE AdminId=@p0", cn.connect());
                command.Parameters.AddWithValue("@p0", TextAdminID.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Deletion Successful");

                // Remove the deleted row from the DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["AdminId"].Value != null && row.Cells["AdminId"].Value.ToString() == TextAdminID.Text)
                    {
                        dataGridView1.Rows.Remove(row);
                        dataGridView1.Invalidate(); // Update the display
                        break; // Exit the loop once the row is removed
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.connect().Close();
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE Admin SET AdminName=@p1,AdminPassword=@p2 WHERE AdminId=@p0", cn.connect());
                command.Parameters.AddWithValue("@p0", TextAdminID.Text);
                command.Parameters.AddWithValue("@p1", TextUserName.Text);
                command.Parameters.AddWithValue("@p2", Textpassword.Text);
               
                command.ExecuteNonQuery();
                MessageBox.Show("Update Successful");

                // Update the DataGridView row with the new values
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["AdminId"].Value != null && row.Cells["AdminId"].Value.ToString() == TextAdminID.Text)
                    {
                        row.Cells["AdminName"].Value = TextUserName.Text;
                        row.Cells["AdminPassword"].Value = Textpassword.Text;
                        break; // Exit the loop once the row is updated
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                cn.connect().Close();
            }
        }

    }
}
