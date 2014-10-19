using System.Collections.Generic;
using UniversityFinal.BLL;
using UniversityFinal.DLL.DAO;
using UniversityFinal.DLL.View;

namespace UniversityApp
{
    class ResultEntryBLL
    {
        private ResultEntryGateway aResultEntryGateway;

        public  string CalculateGrade(double score)
        {
            if (score>=90)
            {
                return "A";
            }
            if (score>=70 && score<90)
            {
                return "B";
            }
            if (score>=50 && score<70)
            {
                return "C";
            }
            return "F";
        }

        public string Save(ViewResultSheet aViewResultSheet)
        {
            aResultEntryGateway = new ResultEntryGateway();
            CourseEnrollmentBLL aCourseEnrollmentBLL=new CourseEnrollmentBLL();
            Course aCourse=new Course();
            aCourse.StudentID = aViewResultSheet.StudentID;
            aCourse.CourseID = aViewResultSheet.CourseID;
            if (aCourseEnrollmentBLL.CourseHasBeenTaken(aCourse))
            {
                if (CourseResultHasBeenUpdated(aCourse))
                    return "Result is already updated for this course";
                aResultEntryGateway.Save(aViewResultSheet);
                return "Score is Saved";
            }
            
            return "Student has not been enrolled in this course";
        }

        private bool CourseResultHasBeenUpdated(Course aCourse)
        {
            if (aResultEntryGateway.ResultIsPublist(aCourse))
            {
                return true;
            }
            return false;
        }


        public string GetResultSheet(Course aCourse)
        {
            string msg ="Title\tScore\tGrade\tPublishingDate\n";
            List<ViewResultSheet> aViewResultSheets = aResultEntryGateway.GetResultSheet(aCourse);
            foreach (ViewResultSheet resultSheet in aViewResultSheets)
            {
                msg += resultSheet.CourseTitle + "\t" + resultSheet.Score + "\t" +
                      resultSheet.GradeLetter + "\t" + resultSheet.PublishingDate + "\n";
            }
            return msg;
        }
    }
}