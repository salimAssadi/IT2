using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Student_Management_Syste
{
    
     class Person
    {
        private int id;
        private string? name;
        private string? email;
        private string? gender;
        private  int year;
    
        public Person(int id  ,string name, string email,  string gender , int year)
        {
            Id= id;
            Name = name;
            Email = email;
            Gender = gender;
            Year = year;
        }

        public Person(int id)
        {
            this.id = id;
        }
        public int Id
        {
            get { return id; }
            set { id = value; } 
        }

        public string Name
        {
            get { return name; }
            set { name = value; }   
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
       
        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public String Gender
        {
            get { return gender;}
            set { gender = value; }
            
        }



        public   virtual bool search(int id)
        {

            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";

            sqlConnection = new SqlConnection(sqlString);

            sqlConnection.Open();

            string DisplayQuery = "SELECT * FROM  Person where Id =@id";
            SqlCommand sqlCommand = new SqlCommand(DisplayQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            if (!sqlDataReader.HasRows)
            {
                sqlDataReader.Close();
                sqlConnection.Close();
                return false;
            }
            else
            {
                Console.WriteLine("");
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }


        }


        }
    }
