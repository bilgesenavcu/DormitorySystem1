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
    public partial class FrmStudentEdit : Form
    {
        public FrmStudentEdit()
        {
            InitializeComponent();
        }

        SqlCon cn = new SqlCon();


        public string ID,name,surname,TC,phone ,birth,department;

        private void ButtonDelete_Click(object sender, EventArgs e)
        { //öğrenci silme
            SqlCommand CommandDelete = new SqlCommand("delete from Student where StudentId=@k1",cn.connect());
            CommandDelete.Parameters.AddWithValue("@k1", TextStudentıd.Text);
            CommandDelete.ExecuteNonQuery();
            cn.connect().Close();
            MessageBox.Show("Delete Student");
            //oda kontenjan azaltma
            SqlCommand CommandRoom = new SqlCommand("Update Rooms set RoomActive=RoomActive-1 where RoomNo=@Room", cn.connect());
            CommandRoom.Parameters.AddWithValue("@Room", ComboRoomNum.Text);
            CommandRoom.ExecuteNonQuery();
            cn.connect().Close();

        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {

            try
            {
                SqlCommand Command = new SqlCommand("update Student set StudentName=@p2,StudentSurname=@p3,StudentTC=@p4,StudentPhone=@p5,StudentBirth=@p6,StudentDepartment=@p7,StudentMail=@p8,StudentRoomNum=@p9,ParentNameSurname=@p10,ParentPhone=@p11,ParentAddress=@p12 where StudentId=@p1", cn.connect());
                Command.Parameters.AddWithValue("@p1", TextStudentıd.Text);
                Command.Parameters.AddWithValue("@p2", TextStudentName.Text);
                Command.Parameters.AddWithValue("@p3", TextStudentSurname.Text);
                Command.Parameters.AddWithValue("@p4", MaskedTC.Text);
                Command.Parameters.AddWithValue("@p5", MaskedStudentPhone.Text);
                Command.Parameters.AddWithValue("@p6", MaskedBirth.Text);
                Command.Parameters.AddWithValue("@p7", ComboDepartment.Text);
                Command.Parameters.AddWithValue("@p8", TextMail.Text);
                Command.Parameters.AddWithValue("@p9", ComboRoomNum.Text);
                Command.Parameters.AddWithValue("@p10", TextParentNameSurname.Text);
                Command.Parameters.AddWithValue("@p11", MaskedParentPhone.Text);
                Command.Parameters.AddWithValue("@p12", RichAddress.Text);
                Command.ExecuteNonQuery();
                cn.connect().Close();
                MessageBox.Show("Record Updated");
            }
            catch
            {
                MessageBox.Show("Failed! Try Again.");

            }
          

        }

        public string mail, RoomNum, ParentNameSurname, ParentPhone, address;

        private void FrmStudentEdit_Load(object sender, EventArgs e)
        {
            TextStudentıd.Text = ID;
            TextStudentName.Text = name;
            TextStudentSurname.Text = surname;
            MaskedTC.Text = TC;
            MaskedStudentPhone.Text = phone;
            MaskedBirth.Text = birth;
            ComboDepartment.Text = department;
            TextMail.Text = mail;
            ComboRoomNum.Text = RoomNum;
            TextParentNameSurname.Text = ParentNameSurname;
            MaskedParentPhone.Text = ParentPhone;
            RichAddress.Text = address;

        }
    }
}
