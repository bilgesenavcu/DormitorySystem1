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
    public partial class FrmStaff1 : Form
    {
        public FrmStaff1()
        {
            InitializeComponent();
        }
        SqlCon cn = new SqlCon();
        private void FrmStaff1_Load(object sender, EventArgs e)
        {
            try
            {

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();



                adapter.SelectCommand = new SqlCommand("SELECT StaffId, StaffNameSurname,StaffDepartment FROM Staff ORDER BY StaffId", cn.connect());
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


        private void RefreshDataGridView()
        {
            try
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataSet dataset = new DataSet();

                adapter.SelectCommand = new SqlCommand("SELECT StaffId, StaffNameSurname, StaffDepartment FROM Staff ORDER BY StaffId", cn.connect());
                adapter.Fill(dataset);
                dataGridView1.DataSource = dataset.Tables[0];

                // Yeni eklenen kişiyi seçili hale getir
                if (dataGridView1.Rows.Count > 0)
                {
                    int lastRowIndex = dataGridView1.Rows.Count - 1;
                    dataGridView1.CurrentCell = dataGridView1.Rows[lastRowIndex].Cells[0];
                    dataGridView1.Rows[lastRowIndex].Selected = true;
                }
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





        private void BtnStaffDelete_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("DELETE FROM Staff WHERE StaffId=@p1", cn.connect());
                command.Parameters.AddWithValue("@p1", TextStaffId.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Deletion Successful");

                // Remove the deleted row from the DataGridView
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["StaffId"].Value != null && row.Cells["StaffId"].Value.ToString() == TextStaffId.Text)
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

        private void BtnStaffSave_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("insert into Staff (StaffNameSurname,StaffDepartment) values (@p1,@p2) ", cn.connect());
            command.Parameters.AddWithValue("@p1", TextStaffName.Text);
            command.Parameters.AddWithValue("@p2", TextStaffDepartment.Text);
            command.ExecuteNonQuery();
            cn.connect().Close();
            MessageBox.Show("Add Staff");
            RefreshDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Choose;
            Choose = dataGridView1.SelectedCells[0].RowIndex;
            string id, name, department;
            id = dataGridView1.Rows[Choose].Cells[0].Value.ToString();
            name = dataGridView1.Rows[Choose].Cells[1].Value.ToString();
            department = dataGridView1.Rows[Choose].Cells[2].Value.ToString();

            TextStaffId.Text = id;
            TextStaffName.Text = name;
            TextStaffDepartment.Text = department;
        }

        private void BtnStaffUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand command = new SqlCommand("UPDATE Staff SET StaffNameSurname=@p1,StaffDepartment=@p2 WHERE StaffId=@p3", cn.connect());
                command.Parameters.AddWithValue("@p1", TextStaffName.Text);
                command.Parameters.AddWithValue("@p2",TextStaffDepartment.Text);
                command.Parameters.AddWithValue("@p3", TextStaffId.Text);
                command.ExecuteNonQuery();
                MessageBox.Show("Update Successful");

                // Update the DataGridView row with the new values
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if (row.Cells["StaffId"].Value != null && row.Cells["StaffId"].Value.ToString() == TextStaffId.Text)
                    {
                        row.Cells["StaffNameSurname"].Value = TextStaffName.Text;
                        row.Cells["StaffDepartment"].Value = TextStaffDepartment.Text;
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
