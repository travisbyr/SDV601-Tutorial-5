using System;
using System.Windows.Forms;

namespace Enrolment4
{
    public partial class MainForm : Form
    {
        //private Student _student;
        private StudentListForm _studentListForm = new StudentListForm();
        //private Student _studentCopy;
        //private StudentForm _studentForm;
        //private DomesticStudentForm _domesticStudentForm = new DomesticStudentForm();
        //private InternationalStudentForm _internationalStudentForm = new InternationalStudentForm();
        //private string[] _studentType = { "Domestic", "International" };
        //public Student Student { get => _student; set => _student = value; }

        public MainForm()
        {
            InitializeComponent();

            //studentType.DataSource = Student.StudentType;
            //studentType.SelectedIndex = 0;
        }

        
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void manageStudentButton_Click(object sender, EventArgs e)
        {
            studentDetails.Text = string.Format("{0} Student(s)\nTotal Balance: {1:C}", Institute.StudentList.Count, Institute.TotalBalance());
            _studentListForm.ShowDialog();
        }
        /*
private void createStudentButton_Click(object sender, EventArgs e)
{
   Student student = Student.NewStudent(studentType.SelectedIndex);
   EditStudent(student);
}

private void modifyStudentButton_Click(object sender, EventArgs e)
{
   EditStudent(_student);
}

private void EditStudent(Student student)
{
   if (student != null && student.ViewEdit())
   {
       _student = student;
       studentDetails.Text = "Student:\n" + _student.ToString();
   }
}
*/
    }
}
