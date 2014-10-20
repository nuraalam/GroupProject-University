using System;
using System.Collections.Generic;
using System.Windows.Forms;
using UniversityApp;
using UniversityFinal.DLL.DAO;
using UniversityFinal.DLL.View;

namespace UniversittyApp
{
    class ShowResultSheetBLL
    {
        private ResultEntryGateway aResultEntryGateway;
        private double averageScore;
        private int countNumberOfCourse;

        public ShowResultSheetBLL()
        {
            aResultEntryGateway = new ResultEntryGateway();
        }

        public List<ViewResultSheet> GetResultSheet(Course aCourse)
        {

            return aResultEntryGateway.GetResultSheet(aCourse);
        }

        public string GetAvgScore(Course aCourse)
        {
            averageScore = 0;
            countNumberOfCourse = 0;
            List<ViewResultSheet> resultList = aResultEntryGateway.GetResultSheet(aCourse);
            foreach (ViewResultSheet aResultSheet in resultList)
            {
                averageScore += aResultSheet.Score;
                countNumberOfCourse++;

            }
            if (countNumberOfCourse>0)
            {
                averageScore = averageScore /countNumberOfCourse;
                return averageScore.ToString();
            }

            return "Not Applicable";
        }

        public string GetGradeLetter(Course aCourse)
        {
            if (countNumberOfCourse == 0)
                return "Not Applicable";
            if (averageScore >= 90)
            {
                return "A";
            }
            if (averageScore >= 70 && averageScore < 90)
            {
                return "B";
            }
            if (averageScore >= 50 && averageScore < 70)
            {
                return "C";
            }
            return "F";
        }
    }
}