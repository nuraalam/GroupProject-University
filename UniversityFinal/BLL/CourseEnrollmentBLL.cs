using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFinal.DLL.DAO;
using UniversityFinal.DLL.GETWAY;
using UniversityFinal.DLL.View;

namespace UniversityFinal.BLL
{
    class CourseEnrollmentBLL
    {
        CourseEnrollmentGateway aCourseEnrollmentGateway=new CourseEnrollmentGateway();
        public string GetStudentName(string regNo)
        {
            string name = aCourseEnrollmentGateway.GetCourseName(regNo);
            return name;
        }

        public string GetStudentEmail(string regNo)
        {
            string email = aCourseEnrollmentGateway.GetEmailAddress(regNo);
            return email;
        }

        public List<Course> GetCourseNameList()
        {
            List<Course> aCourseNameList = aCourseEnrollmentGateway.GetCourseNameList();
            return aCourseNameList;
        }

        public int GetStudentID(string regNo)
        {
            int studentID = aCourseEnrollmentGateway.GetStudentID(regNo);
            return studentID;
        }

        public string Save(Course aCourse)
        {
            if (CourseHasBeenTaken(aCourse))
                return "Course has already been Taken";

            aCourseEnrollmentGateway.Save(aCourse);
            return "Course Enrollment Completed";
        }

        private bool CourseHasBeenTaken(Course aCourse)
        {
            List<ViewEnrolledCourses> allEnrolledCourseses = GetEnrolledCourses(aCourse.StudentID);
            foreach (var anEnrolledCourse in allEnrolledCourseses)
            {
                if (anEnrolledCourse.CourseId==aCourse.CourseID)
                {
                    return true;
                }
            }
            return false;
        }

        public List<ViewEnrolledCourses> GetEnrolledCourses(int studentId)
        {
            List<ViewEnrolledCourses> allEnrolledCourseses = aCourseEnrollmentGateway.GetEnrolledCourses(studentId);
            return allEnrolledCourseses;
        }
    }
}
