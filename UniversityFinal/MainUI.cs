using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversittyApp;
using UniversityApp;

namespace UniversityFinal
{
    public partial class MainUI : Form
    {
        public MainUI()
        {
            InitializeComponent();
        }

        private void enrollButton_Click(object sender, EventArgs e)
        {
            CourseEnrollmentUI aCourseEnrollmentUi=new CourseEnrollmentUI();
            aCourseEnrollmentUi.ShowDialog();
        }

        private void enterResultButton_Click(object sender, EventArgs e)
        {
            ResultEntryUI resultEntryUi=new ResultEntryUI();
            resultEntryUi.ShowDialog();
        }
        private void ShowResultButton_Click(object sender, EventArgs e)
        {
            ShowResultSheetUI  shwShowResultSheetUi=new ShowResultSheetUI();
            shwShowResultSheetUi.ShowDialog();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      

     

      



        
    }
}
