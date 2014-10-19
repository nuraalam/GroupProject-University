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

namespace UniversittyApp
{

    public partial class ShowResultSheetUI : Form
    {
        private CourseEnrollmentBLL aCourseEnrollmentBll;
        private Student aStudent;
        private Course aCourse;
        private ShowResultSheetBLL aShowResultSheetBLL;

        public ShowResultSheetUI()
        {
            InitializeComponent();
           
        }

        private void findResultSheetButton_Click(object sender, EventArgs e)
        {
            
            aCourseEnrollmentBll = new CourseEnrollmentBLL();
            aStudent = new Student();
            aStudent.RegNo = regNoResultSheetTextBox.Text;
            NameResultSheetTextBox.Text = aCourseEnrollmentBll.GetStudentName(aStudent.RegNo);
            emailResultSheetTextBox.Text = aCourseEnrollmentBll.GetStudentEmail(aStudent.RegNo);
            aStudent.StudentID = aCourseEnrollmentBll.GetStudentID(aStudent.RegNo);
            aCourse=new Course();
            aCourse.StudentID = aCourseEnrollmentBll.GetStudentID(aStudent.RegNo);
           
            aShowResultSheetBLL = new ShowResultSheetBLL();
            ShowResultInListView();
            averageResultSheetTextBox.Text = aShowResultSheetBLL.GetAvgScore(aCourse);
            gradeResultSheetTextBox.Text = aShowResultSheetBLL.GetGradeLetter(aCourse);
        }

        private void ShowResultInListView()
        {
            resultSheeListView.Items.Clear();
            List<ViewResultSheet> resultList = aShowResultSheetBLL.GetResultSheet(aCourse);
            foreach (ViewResultSheet aResultSheet in resultList)
            {
                ListViewItem item = new ListViewItem(aResultSheet.CourseTitle);
                item.SubItems.Add(aResultSheet.CourseName);
                item.SubItems.Add(aResultSheet.Score.ToString());
                item.SubItems.Add(aResultSheet.GradeLetter);
                resultSheeListView.Items.Add(item);
            }
        }
    }
}
