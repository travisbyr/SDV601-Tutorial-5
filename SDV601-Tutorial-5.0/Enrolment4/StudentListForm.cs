using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enrolment4
{
    public partial class StudentListForm : Form
    {
        public StudentListForm()
        {
            InitializeComponent();
            studentType.DataSource = Student.StudentType;
            studentType.SelectedIndex = 0;
        }

        private void UpdateDisplay()
        {
            studentList.DataSource = null;
            studentList.DataSource = Institute.StudentList;
        }

        private void createStudentButton_Click(object sender, EventArgs e)
        {
            Student student = Student.NewStudent(studentType.SelectedIndex);
            if (student != null && student.ViewEdit())
            {
                Institute.StudentList.Add(student);
                UpdateDisplay();
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void modifyStudentButton_Click(object sender, EventArgs e)
        {
            Student student = (Student)studentList.SelectedItem;
            if (student != null && student.ViewEdit())
            {
                UpdateDisplay();
            }
            UpdateDisplay();
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
