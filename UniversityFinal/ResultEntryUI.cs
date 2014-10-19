using System;
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

namespace UniversityApp
{
    public partial class ResultEntryUI : Form
    {
        private CourseEnrollmentBLL aCourseEnrollmentBll;
        private Student aStudent;
        private Course aCourse;
        public ResultEntryUI()
        {
            InitializeComponent();
            ShowCourseNameComboBox();
        }
        private void ShowCourseNameComboBox()
        {
            aCourseEnrollmentBll = new CourseEnrollmentBLL();
            List<Course> courseNameList = aCourseEnrollmentBll.GetCourseNameList();
            foreach (Course courseName in courseNameList)
            {
                courseResultEntryComboBox.Items.Add(courseName);
            }
            courseResultEntryComboBox.DisplayMember = "CourseName";


        }
        private void findResultEntryButton_Click(object sender, EventArgs e)
        {
            aCourseEnrollmentBll = new CourseEnrollmentBLL();
            aStudent = new Student();
            aStudent.RegNo = regNoResultEntryTextBox.Text;
            nameResultEntryTextBox.Text = aCourseEnrollmentBll.GetStudentName(aStudent.RegNo);
            emailResultEntryTextBox.Text = aCourseEnrollmentBll.GetStudentEmail(aStudent.RegNo);
            aStudent.StudentID = aCourseEnrollmentBll.GetStudentID(aStudent.RegNo);
        }

      
    }
}
