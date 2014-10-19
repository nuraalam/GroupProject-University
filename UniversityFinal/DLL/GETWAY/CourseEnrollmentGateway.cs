using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityFinal.DLL.DAO;
using UniversityFinal.DLL.View;

namespace UniversityFinal.DLL.GETWAY
{
    class CourseEnrollmentGateway
    {
        private static SqlConnection connection;
        private static SqlCommand command;
        private static string query;

        private static void CallForConnection()
        {
            string conn = ConfigurationManager.ConnectionStrings["University"].ConnectionString;
            connection = new SqlConnection(conn);
            connection.ConnectionString = conn;

        }

        public string GetCourseName(string regNo)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM StudentInfo");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            string name="";
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    if (regNo == aReader[1].ToString())
                        name = aReader[2].ToString();
                }
            }
            connection.Close();
            return name;
        }

        public string GetEmailAddress(string regNo)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM StudentInfo");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            string email = "";
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    if (regNo == aReader[1].ToString())
                        email = aReader[3].ToString();
                }
            }
            connection.Close();
            return email;
        }

        public List<Course> GetCourseNameList()
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM CoursesInfo");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<Course> courseNameList=new List<Course>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    Course aCourse = new Course();
                    aCourse.CourseID = (int) aReader[0];
                    aCourse.CourseTitle = aReader[1].ToString();
                    aCourse.CourseName = aReader[2].ToString();
                    courseNameList.Add(aCourse);
                }
            }
            connection.Close();
            return courseNameList;
        }

        public int GetStudentID(string regNo)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM StudentInfo");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            int studentID =0;
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    if (regNo == aReader[1].ToString())
                        studentID = (int) aReader[0];
                }
            }
            connection.Close();
            return studentID;
        }

        public void Save(Course aCourse)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO EnrollmentCourses (StudentID,CourseID,CourseName,CourseTitle,EnrollmentDate) Values(@0,@1,@2,@3,@4)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0",aCourse.StudentID);
            command.Parameters.AddWithValue("@1",aCourse.CourseID );
            command.Parameters.AddWithValue("@2",aCourse.CourseTitle);
            command.Parameters.AddWithValue("@3",aCourse.CourseName);
            command.Parameters.AddWithValue("@4",aCourse.EnrollmentDate);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public List<ViewEnrolledCourses> GetEnrolledCourses(int studentId)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM EnrollmentCourses");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            List<ViewEnrolledCourses> allEnrolledCourses = new List<ViewEnrolledCourses>();
           
       
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    ViewEnrolledCourses aEnrolledCourses = new ViewEnrolledCourses();
                    if (studentId == (int) aReader[1])
                    {
                       // aEnrolledCourses.StudentId = (int) aReader[1];
                        aEnrolledCourses.CourseId = (int) aReader[2];
                        aEnrolledCourses.CourseName = aReader[3].ToString();
                        aEnrolledCourses.CourseTitle = aReader[4].ToString();
                        aEnrolledCourses.EnrollmentDate = aReader[5].ToString();
                        allEnrolledCourses.Add(aEnrolledCourses);
                    }
                }
            }
            connection.Close();
            return allEnrolledCourses;
        }
    }
}
