using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityFinal.BLL;
using UniversityFinal.DLL.DAO;
using UniversityFinal.DLL.View;

namespace UniversityApp
{
    public partial class CourseEnrollmentUI : Form
    {
        private CourseEnrollmentBLL aCourseEnrollmentBll;
        private Student aStudent;
        private Course aCourse;

        public CourseEnrollmentUI()
        {
            InitializeComponent();
            ShowCourseNameComboBox();
        }

        private void ShowCourseNameComboBox()
        {
            aCourseEnrollmentBll=new CourseEnrollmentBLL();
            List<Course> courseNameList=aCourseEnrollmentBll.GetCourseNameList();
            foreach (Course courseName in courseNameList)
            {
                courseCourseComboBox.Items.Add(courseName);
            }
            courseCourseComboBox.DisplayMember = "CourseName";


        }

        private void findCourseButton_Click(object sender, System.EventArgs e)
        {
            aCourseEnrollmentBll = new CourseEnrollmentBLL();
            aStudent = new Student();
            aStudent.RegNo = regNoCourseTextBox.Text;
            nameCourseTextBox.Text = aCourseEnrollmentBll.GetStudentName(aStudent.RegNo);
            emailCourseTextBox.Text = aCourseEnrollmentBll.GetStudentEmail(aStudent.RegNo);
            aStudent.StudentID = aCourseEnrollmentBll.GetStudentID(aStudent.RegNo);
            ShowEnrolledCourses();
        }

        private void enrollButton_Click(object sender, System.EventArgs e)
        {
            aCourse = new Course();
            aCourse = (Course) courseCourseComboBox.SelectedItem;
            aCourse.StudentID = aStudent.StudentID;      
            aCourse.EnrollmentDate = courseDateTimePicker.Text;
            string msg=aCourseEnrollmentBll.Save(aCourse);
            ShowEnrolledCourses();
            MessageBox.Show(msg);
        }

        private void ShowEnrolledCourses()
        {
            enrolledCoursesListView.Items.Clear();
            
            List<ViewEnrolledCourses> allEnrolledCourseses = aCourseEnrollmentBll.GetEnrolledCourses(aStudent.StudentID);
            foreach (var anEnrolledCourse in allEnrolledCourseses)
            {
                ListViewItem item=new ListViewItem(anEnrolledCourse.CourseTitle);
                item.SubItems.Add(anEnrolledCourse.CourseName);
                item.SubItems.Add(anEnrolledCourse.EnrollmentDate);
                enrolledCoursesListView.Items.Add(item);
            }
            
        }
    }
}
