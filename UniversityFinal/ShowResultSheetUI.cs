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

namespace UniversittyApp
{

    public partial class ShowResultSheetUI : Form
    {
        private CourseEnrollmentBLL aCourseEnrollmentBll;
        private Student aStudent;
        private Course aCourse;
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
        }


    }
}
