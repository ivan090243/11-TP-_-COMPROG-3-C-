using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;
using System.Drawing.Text;
using System.Collections;
using Microsoft.SqlServer.Server;

namespace TASKPERFORMANCE_COMPROG3
{
    internal class ClubRegistrationQuery
    {
        private SqlConnection sqlConnect;
        private SqlCommand sqlCommand;
        private SqlDataAdapter sqlAdapter;
        private SqlDataReader sqlReader;

        public DataTable dataTable;
        public BindingSource bindingSource;

        private string connectionString;

        public string FirstName, MiddleName, LastName, Gender, Program;
        public int Age;


        public ClubRegistrationQuery()
        {
            connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ivan_\source\repos\TASKPERFORMANCE_COMPROG3\TASKPERFORMANCE_COMPROG3\ClubDB.mdf;Integrated Security=True;";

            sqlConnect = new SqlConnection(connectionString);

            dataTable = new DataTable();
            bindingSource = new BindingSource();

        }
        public bool DisplayList()
        {
            string ViewClubMembers = "select StudentId , FirstName , MiddleName , LastName , Age, Gender , Program from ClubMembers";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            sqlConnect.Open();
            sqlCommand = new SqlCommand(ViewClubMembers, sqlConnect);
            sqlReader = sqlCommand.ExecuteReader();
            sqlReader.Read();



            sqlConnect.Close();

            return true;

        }

        public string sId;
        public bool DisplayText()
        {
            string ViewClubMembers = "select StudentId , FirstName , MiddleName , LastName , Age, Gender , Program from ClubMembers where Student_Id = '" + sId + "' ";
            sqlAdapter = new SqlDataAdapter(ViewClubMembers, sqlConnect);

            dataTable.Clear();
            sqlAdapter.Fill(dataTable);
            bindingSource.DataSource = dataTable;

            sqlConnect.Open();


            sqlCommand = new SqlCommand(ViewClubMembers, sqlConnect);
            sqlReader = sqlCommand.ExecuteReader();
            sqlReader.Read();

           FirstName = sqlReader[1].ToString();
           MiddleName = sqlReader[2].ToString();
           LastName = sqlReader[3].ToString();
           Age = int.Parse(sqlReader[4].ToString());
           Gender = sqlReader[5].ToString();
           Program = sqlReader[6].ToString();

            sqlConnect.Close();

            return true;

        }
        public int Count;
        public int c()
        {

            sqlConnect.Open();
            SqlCommand comm = new SqlCommand("SELECT COUNT(*) FROM ClubMembers", sqlConnect);
            sqlReader = comm.ExecuteReader();
            sqlReader.Read();
            Count = int.Parse(sqlReader[0].ToString());
            sqlConnect.Close();

            return Count;
        }


        public bool RegisterStudent(int ID, long StudentID, string FirstName, string
                                    MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("INSERT INTO ClubMembers (ID, StudentID, FirstName, MiddleName, LastName, Age, Gender, Program)  VALUES(@ID, @StudentID, @FirstName, @MiddleName, @LastName, @Age, @Gender, @Program)", sqlConnect);
            sqlCommand.Parameters.Add("@ID", SqlDbType.Int).Value = ID;
            sqlCommand.Parameters.Add("@RegistrationID", SqlDbType.BigInt).Value = StudentID;
            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
            return true;
        }

        public void UpdateStudent(long StudentID, string FirstName, string
                                MiddleName, string LastName, int Age, string Gender, string Program)
        {
            sqlCommand = new SqlCommand("UPDATE ClubMembers SET FirstName = @FirstName,MiddleName = @MiddleName,LastName= @LastName,Age= @Age,Gender= @Gender,Program= @Program WHERE StudentId = @StudentID", sqlConnect);

            sqlCommand.Parameters.Add("@StudentID", SqlDbType.VarChar).Value = StudentID;
            sqlCommand.Parameters.Add("@FirstName", SqlDbType.VarChar).Value = FirstName;
            sqlCommand.Parameters.Add("@MiddleName", SqlDbType.VarChar).Value = MiddleName;
            sqlCommand.Parameters.Add("@LastName", SqlDbType.VarChar).Value = LastName;
            sqlCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Age;
            sqlCommand.Parameters.Add("@Gender", SqlDbType.VarChar).Value = Gender;
            sqlCommand.Parameters.Add("@Program", SqlDbType.VarChar).Value = Program;
            sqlConnect.Open();
            sqlCommand.ExecuteNonQuery();
            sqlConnect.Close();
        }
    }
}
   