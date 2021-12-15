using Student;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentInfoApplication
{
    public partial class frmStudentInfo : Form
    {
        public frmStudentInfo()
        {
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            insertToLists(new StudentInfo(studentId.Text, lastName.Text, firstName.Text));
        }

        private void insertToLists(StudentInfo infos)
        {
            studentIds.Items.Add(infos.StudentId);
            firstNames.Items.Add(infos.FirstName);
            lastNames.Items.Add(infos.LastName);
        }
    }
}
