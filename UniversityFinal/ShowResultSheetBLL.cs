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

        public List<ViewResultSheet> GetResultSheet(Course aCourse)
        {
            aResultEntryGateway = new ResultEntryGateway();
            List<ViewResultSheet> resultList=aResultEntryGateway.GetResultSheet(aCourse);
           
            return resultList;
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

            return "N/A";
        }

        public string GetGradeLetter(Course aCourse)
        {
            if (countNumberOfCourse == 0)
                return "N/A";
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