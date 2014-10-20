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

            return aCourseEnrollmentGateway.GetCourseName(regNo);
        }

        public string GetStudentEmail(string regNo)
        {
          
            return aCourseEnrollmentGateway.GetEmailAddress(regNo);
        }

        public List<Course> GetCourseNameList()
        {
         
            return aCourseEnrollmentGateway.GetCourseNameList();
        }

        public int GetStudentID(string regNo)
        {
          
            return aCourseEnrollmentGateway.GetStudentID(regNo);
        }

        public string Save(Course aCourse)
        {
            if (CourseHasBeenTaken(aCourse))
                return "Course has already been Taken";

            aCourseEnrollmentGateway.Save(aCourse);
            return "Course Enrollment Completed";
        }

        public bool CourseHasBeenTaken(Course aCourse)
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
          
            return aCourseEnrollmentGateway.GetEnrolledCourses(studentId);
        }
    }
}
