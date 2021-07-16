using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolLiberary;

namespace SchoolFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnPushToTest_Click(object sender, EventArgs e)
        {
            var testSchool = new School();
            testSchool.Name = txtName.Text.ToString();
            testSchool.Address = txtAddress.Text.ToString();
            testSchool.City = txtCity.Text.ToString();
            testSchool.State = txtState.Text.ToString();
            testSchool.Zip = txtZip.Text.ToString();
            testSchool.PhoneNumber = txtPhone.Text.ToString();
           
            try
            {
                testSchool.TwitterAddress = txtTwitter.Text.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show(testSchool.ToString());
        }

        private void btnTestTeacher_Click(object sender, EventArgs e)
        {
            var teacher = new Teachers();
            var gp = teacher.ComputeGradeAverage();
            MessageBox.Show("Teacher grade averga is: "+gp);
        }

        private void btnTestStudent_Click(object sender, EventArgs e)
        {
            var student = new Students();
            var gp = student.ComputeGradeAverage();
            MessageBox.Show("student grade averga is: " + gp);
        }
    }
}
