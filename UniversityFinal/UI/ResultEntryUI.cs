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
using UniversityFinal.DLL.View;

namespace UniversityApp
{
    public partial class ResultEntryUI : Form
    {
        private CourseEnrollmentBLL aCourseEnrollmentBll;
        private Student aStudent;
        private ViewResultSheet aViewResultSheet;
        private ResultEntryBLL aResultEntryBLL;
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

        private void saveResultEntryButton_Click(object sender, EventArgs e)
        {
            aViewResultSheet = new ViewResultSheet();
            aResultEntryBLL = new ResultEntryBLL();
            aCourse = new Course();
            aCourse  = (Course) courseResultEntryComboBox.SelectedItem; 
            aViewResultSheet.StudentID = aStudent.StudentID;
            aViewResultSheet.CourseID = aCourse .CourseID;
            aViewResultSheet.CourseTitle = aCourse .CourseTitle;
            aViewResultSheet.CourseName = aCourse .CourseName;
            aViewResultSheet.Score = Convert.ToDouble(scoreResultEntryTextBox.Text);
            aViewResultSheet.GradeLetter = aResultEntryBLL.CalculateGrade(aViewResultSheet.Score);
            aViewResultSheet.PublishingDate = resultDateTimePicker.Text;
            string msg=aResultEntryBLL.Save(aViewResultSheet);
            MessageBox.Show(msg);


        }

        private void viewResultSheetButton_Click(object sender, EventArgs e)
        {

            string msg = "Student Reg No. "+regNoResultEntryTextBox.Text + "\t" + "Student Name: "+nameResultEntryTextBox.Text + "\n";
            aCourse.StudentID = aStudent.StudentID;
            msg += aResultEntryBLL.GetResultSheet(aCourse);
            MessageBox.Show(msg);
        }

      
    }
}
