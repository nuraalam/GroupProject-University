using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using UniversityFinal.DLL.DAO;
using UniversityFinal.DLL.View;

namespace UniversityApp
{
    class ResultEntryGateway
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

        public void Save(ViewResultSheet aViewResultSheet)
        {
            CallForConnection();
            connection.Open();
            query = "INSERT INTO ResultSheet (StudentID,CourseID,CourseTitle,CourseName,Score,GradeLetter,PublishingDate) Values(@0,@1,@2,@3,@4,@5,@6)";
            command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@0", aViewResultSheet.StudentID);
            command.Parameters.AddWithValue("@1", aViewResultSheet.CourseID);
            command.Parameters.AddWithValue("@2", aViewResultSheet.CourseTitle);
            command.Parameters.AddWithValue("@3", aViewResultSheet.CourseName);
            command.Parameters.AddWithValue("@4", aViewResultSheet.Score);
            command.Parameters.AddWithValue("@5", aViewResultSheet.GradeLetter);
            command.Parameters.AddWithValue("@6", aViewResultSheet.PublishingDate);
            command.ExecuteNonQuery();
            connection.Close();
        }

        public bool ResultIsPublist(Course aCourse)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM ResultSheet");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();

            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    if (aCourse.StudentID == (int) aReader[1] && aCourse.CourseID == (int) aReader[2])
                        return true;
                }
            }
            connection.Close();
            return false;
        }

        public List<ViewResultSheet> GetResultSheet(Course aCourse)
        {
            CallForConnection();
            connection.Open();
            query = String.Format("SELECT* FROM ResultSheet");
            command = new SqlCommand(query, connection);
            SqlDataReader aReader = command.ExecuteReader();
            
            List<ViewResultSheet> viewResultSheetList=new List<ViewResultSheet>();
            if (aReader.HasRows)
            {
                while (aReader.Read())
                {
                    ViewResultSheet aViewResultSheet=new ViewResultSheet();
                    if (aCourse.StudentID == (int) aReader[1])
                    {
                        aViewResultSheet.CourseTitle = aReader[3].ToString();
                        aViewResultSheet.CourseName = aReader[4].ToString();
                        aViewResultSheet.Score = (double) aReader[5];
                        aViewResultSheet.GradeLetter = aReader[6].ToString();
                        aViewResultSheet.PublishingDate = aReader[7].ToString();
                        viewResultSheetList.Add(aViewResultSheet);
                    }
                        
                }
            }
            connection.Close();
            return viewResultSheetList;
        }
    }
}