using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Paala, James P.          BSIT - 501

namespace FrmReadingFiles
{
    public partial class frmRegistration : Form
    {
        public frmRegistration()
        {
            InitializeComponent();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            string getLastName = txtLastName.Text;
            string getFirstName = txtFirstName.Text;
            string getMiddleName = txtMiddleInitial.Text;
            string getStudentNo = txtStudentNo.Text;
            string getProgram = cbPrograms.Text;
            string getGender = cbGender.Text;
            string getContactNo = txtContactNo.Text;
            string getAge = txtAge.Text;
            string getBirthDay = datePickerBirtday.Value.ToString("yyyyMM-dd");
            string SetFileName = String.Concat(getStudentNo, ".txt");

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, SetFileName));

            string[] info = { "StudentNo: "+ getStudentNo, "Full Name: "+ getFirstName+" "+getMiddleName+". "+getLastName,
                "Programs: "+ getProgram, "Age : "+ getAge, "Birthday: "+getBirthDay, "Gender: "+getGender, "Contact No: "+getContactNo
            };

            foreach (string line in info)
            {
                outputFile.WriteLine(line);

            }
            outputFile.Close();
            Close();
        }
    }
}
