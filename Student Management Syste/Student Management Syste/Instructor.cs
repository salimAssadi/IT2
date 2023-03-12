using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_Management_Syste
{
    class Instructor : Person, Ipayment
    {
        private string ?specialist;
        private decimal salary;
        private string ?officeLocation;
       public readonly static long passw=1234;

        public Instructor(int id, string name, string email, string gender,int year,string? specialist, decimal salary, string? officeLocation) :base(id,name, email,gender,year)
        {
            
            Specialist = specialist;
            Salary = salary;
            OfficeLocation = officeLocation;
              
        }
        
         public  Instructor (int id):base(id)
        {

        }


        public string Specialist
        {
            get { return specialist; }
            set { specialist = value; } 
        }

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string OfficeLocation
        {
            get { return officeLocation; }
            set { officeLocation = value; }
        }

        public static void ImployNewInstructor()
        {
            Console.WriteLine("                     |------------------------------------------|\n");
            Console.WriteLine("                     |         Imploy New Instructor            |\n");
            Console.WriteLine("                     |------------------------------------------|\n\n");

            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            sqlConnection = new SqlConnection(sqlString);
            sqlConnection.Open();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
            try
            {


                Console.Write(" 1- Enter Instructor Id ");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 2- Enter Instructor Name ");
                string? Name = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 3- Enter Instructor Email ");
                string? Email = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 4- Enter HireDate Year ");
                int Year = int.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 5- Enter   Instructor Specialist ");
                string? Specialist = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 6- Enter  Instructor Office Location ");
                string? Office = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 7- Enter your Gender ");
                string? Gender = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 8- Enter  Instructor salary \n");
               
                //create new student and add it to lsit
                //int Instructor_id = 1;


                Console.Clear();
                Console.WriteLine("                  Choose Course For Instructor       \n\n");
                Course.dispayCourses();
                Console.WriteLine("\n               -----------------------------------------\n");
                Console.Write("                    Select  course id to Choose course  for Instructor ");
                int COURSE_ID = int.Parse(Console.ReadLine());

                Console.Write("                     Enter  Instructor salary  ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("\n               --------------------------------------\n");
                Console.WriteLine();
                Console.Clear();
                string st_type = "instructor";
                string sqlperson = "INSERT INTO Person(Id,Name,Email,Gender,Re_Year,per_type)VALUES(@Id,@Name,@Email,@Gender,@year,@type_stu)";
                Person person = new Person(Id, Name, Email, Gender, Year);
                SqlCommand personcommand = new SqlCommand(sqlperson, sqlConnection, sqlTransaction); ;
                personcommand.Parameters.AddWithValue("@Id", person.Id);
                personcommand.Parameters.AddWithValue("@Name", person.Name);
                personcommand.Parameters.AddWithValue("@Email", person.Email);
                personcommand.Parameters.AddWithValue("@Gender", person.Gender);
                personcommand.Parameters.AddWithValue("@year", person.Year);
                personcommand.Parameters.AddWithValue("@type_stu",st_type);
                personcommand.ExecuteNonQuery();


                string sqlStudent = "INSERT INTO instructor(instructor_id,Specialist,Salary,officeLocation,cou_id)VALUES(@Id,@Specialist,@Salary,@office,@course_id)";
                Instructor instructor1 = new Instructor(Id, Name, Email, Gender, Year,Specialist,salary,Office);

                SqlCommand studentcommand = new SqlCommand(sqlStudent, sqlConnection, sqlTransaction);
                studentcommand.Parameters.AddWithValue("@Id", instructor1.Id);
                studentcommand.Parameters.AddWithValue("@Specialist", instructor1.Specialist);
                studentcommand.Parameters.AddWithValue("@Salary", instructor1.Salary);
                studentcommand.Parameters.AddWithValue("@office", instructor1.OfficeLocation);
                studentcommand.Parameters.AddWithValue("@course_id",COURSE_ID);
                studentcommand.ExecuteNonQuery();
                sqlTransaction.Commit();

                Console.WriteLine("\n\n             1- Record Added Successfully     \n");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                sqlTransaction.Rollback();

            }

            finally
            {

                sqlConnection.Close();
            }





        }

        public static void DisplayInstructor()
        {
            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";

            sqlConnection = new SqlConnection(sqlString);

            sqlConnection.Open();
            string DisplayQuery = "select Id,Name,Email,Re_Year,Specialist,officeLocation,Course_name,Salary from Person join Instructor on Id=instructor_id join Course on cou_id=couse_id ORDER BY person.Id";

            SqlCommand sqlCommand = new SqlCommand(DisplayQuery, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //Console.WriteLine("\n Id   Name   Email   Gender    Major   Level   System type\n");
            int counter = 1;
            while (sqlDataReader.Read())
            {
                Console.Write(counter + "- | " + sqlDataReader.GetValue(0).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(1).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(2).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(3).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(4).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(5).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(6).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(7).ToString() + "   |  ");
                
                Console.WriteLine("\n-----------------------------------------------------------------------\n");
                counter += 1;
            }
            Console.WriteLine("\n\n\n");
            sqlDataReader.Close();
            sqlConnection.Close();

            Console.ReadKey();
            Console.Clear();
        }

        public static void update()
        {
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("        Update Instructors Information        \n");
            Console.WriteLine("------------------------------------------\n\n");


            // sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
                SqlConnection sqlConnection = new SqlConnection(sqlString);
            sqlConnection.Open();

            try
            {

                Console.WriteLine("Enter Instructor Id..");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Instructor Name \n");
                string? Name = Console.ReadLine();
                Console.WriteLine(" Enter Instructor Email \n");
                string? Email = Console.ReadLine();
                Console.WriteLine("Enter your Gender \n");
                string? Gender = Console.ReadLine();
                Console.WriteLine("Enter Hire date Year \n");
                int Year = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter   Instructor Specialist\n");
                string? Specialist = Console.ReadLine();
                Console.WriteLine("Enter  Instructor Office Location \n");
                string? Office = Console.ReadLine();
                Console.WriteLine("Enter  Instructor salary \n"); 
                decimal salary = decimal.Parse(Console.ReadLine());


                // string updateQuery = "Exec updateStudent @id,@name,@email,@gender,@Year,@Major,@level,@systm_type";
                Person person = new Person(Id, Name, Email, Gender, Year);
                string updateQuery = "update  person set name=@name,Email=@Email,Gender=@Gender,Re_Year=@year where Id=@id";
                SqlCommand personcommand = new SqlCommand(updateQuery, sqlConnection);
                personcommand.Parameters.AddWithValue("@Name", person.Name);
                personcommand.Parameters.AddWithValue("@Email", person.Email);
                personcommand.Parameters.AddWithValue("@Gender", person.Gender);
                personcommand.Parameters.AddWithValue("@year", person.Year);
                personcommand.Parameters.AddWithValue("@Id", person.Id);
                personcommand.ExecuteNonQuery();


                Instructor instructor = new Instructor(Id, Name, Email, Gender, Year,Specialist,salary,Office);
                string sqlStudent = "UPDATE instructor SET Specialist=@Specialist,Salary=@Salary,officeLocation = @office where Id=@id";
                SqlCommand studentcommand = new SqlCommand(sqlStudent, sqlConnection);
                studentcommand.Parameters.AddWithValue("@Specialist",instructor.Specialist);
                studentcommand.Parameters.AddWithValue("@Salary", instructor.Salary);
                studentcommand.Parameters.AddWithValue("@office", instructor.OfficeLocation);
                studentcommand.Parameters.AddWithValue("@id", instructor.Id);
                studentcommand.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);


            }
            finally
            {
                sqlConnection.Close();
            }

        }


        public void payment(int id)
        {   
                SqlConnection sqlConnection;
                string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
                sqlConnection = new SqlConnection(sqlString);
            try
            {
                sqlConnection.Open();


                if (base.search(id) == true)
                {
                    Console.Write("Enter Instructor salary");
                    decimal sal = decimal.Parse(Console.ReadLine());
                    
                    string paysal = "update instructor set Salary = salary + @sal where Instructor_id=@id";

                    SqlCommand sqlCommand = new SqlCommand(paysal, sqlConnection);
                    sqlCommand.Parameters.AddWithValue("@sal",sal);
                    sqlCommand.Parameters.AddWithValue("@id", id);
                    sqlCommand.ExecuteNonQuery();
                    Console.WriteLine("\n\n\n\t\t One Record Updated");
                }
                else
                {
                    Console.WriteLine("\n\n\n\t\tNot Fonund");
                }
                sqlConnection.Close();
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                Console.WriteLine(ex.Message);
            }
        }




    }

}
