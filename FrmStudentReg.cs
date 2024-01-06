using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DormitorySystem1
{

    public partial class FrmStudentReg : Form
    {

        public FrmStudentReg()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();


        private void label9_Click(object sender, EventArgs e)
        {

        }


        private void FrmStudentReg_Load(object sender, EventArgs e)
        {
            //department listing 
            
            SqlCommand command = new SqlCommand("Select DepartmentName From Departments", cn.connect());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                ComboDepartment.Items.Add(read[0].ToString());
            }

            cn.connect().Close();

            //list vacant rooms

            SqlCommand command2 = new SqlCommand("Select RoomNo From Rooms Where RoomCapacity != RoomActive", cn.connect());
            SqlDataReader read2 = command2.ExecuteReader();
            while (read2.Read())
            {
                ComboRoomNum.Items.Add(read2[0].ToString());
            }

            cn.connect().Close();

            
        }

       

        private void ButtonSave_Click_1(object sender, EventArgs e)
        {
            try
            {
               
                SqlCommand CommandSave = new SqlCommand("insert into Student(StudentName,StudentSurname,StudentTC,StudentPhone,StudentBirth,StudentDepartment,StudentMail,StudentRoomNum,ParentNameSurname,ParentPhone,ParentAddress)values(@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10,@p11)", cn.connect());
                CommandSave.Parameters.AddWithValue("@p1", TextStudentName.Text);
                CommandSave.Parameters.AddWithValue("@p2", TextStudentSurname.Text);
                CommandSave.Parameters.AddWithValue("@p3", MaskedTC.Text);
                CommandSave.Parameters.AddWithValue("@p4", MaskedStudentPhone.Text);
                CommandSave.Parameters.AddWithValue("@p5", MaskedBirth.Text);
                CommandSave.Parameters.AddWithValue("@p6", ComboDepartment.Text);
                CommandSave.Parameters.AddWithValue("@p7", TextMail.Text);
                CommandSave.Parameters.AddWithValue("@p8", ComboRoomNum.Text);
                CommandSave.Parameters.AddWithValue("@p9", TextParentNameSurname.Text);
                CommandSave.Parameters.AddWithValue("@p10", MaskedParentPhone.Text);
                CommandSave.Parameters.AddWithValue("@p11", RichAddress.Text);
                CommandSave.ExecuteNonQuery();
                MessageBox.Show("Registration successful");


                SqlCommand Command = new SqlCommand("Select StudentId from Student", cn.connect());
                SqlDataReader read3 = Command.ExecuteReader();
                while (read3.Read())
                {
                    label12.Text = read3[0].ToString();
                }
                cn.connect().Close();


                SqlCommand CommandSave2 = new SqlCommand("insert into Debt (StudentId,StudentName,StudentSurname)values (@b1,@b2,@b3)", cn.connect());
                CommandSave2.Parameters.AddWithValue("@b1", label12.Text);
                CommandSave2.Parameters.AddWithValue("@b2", TextStudentName.Text);
                CommandSave2.Parameters.AddWithValue("@b3", TextStudentSurname.Text);
             
                CommandSave2.ExecuteNonQuery();
                cn.connect().Close();


            }

            catch (Exception)
            {
                MessageBox.Show("Registration failed! Please try again.");
           
            }

            // oda kontenjan arttırma

            SqlCommand CommandRoom = new SqlCommand("update Rooms set RoomActive=RoomActive+1 Where RoomNo=@Room1", cn.connect());
            CommandRoom.Parameters.AddWithValue("@Room1", ComboRoomNum.Text);
            CommandRoom.ExecuteNonQuery();
            cn.connect().Close();
         

        }

        private void label12_Click(object sender, EventArgs e)
        {
            


        }
    }
}