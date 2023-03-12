using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;



namespace Student_Management_Syste
{
    class Student : Person
    {
        private string leval;
        private string? major;
        private string systm;
        public Course? course { get; set; }

        public Student(int id):base(id)
        {
            base.Id=id;
        }
        public Student(int id, string name, string email, string gender, int year, string major, string levl, string systm)
                        : base(id, name, email, gender, year)
        {
            Major = major;
            Leval = levl;
            Systm = systm;

        }

        public string Major
        {
            get { return major; }
            set { major = value; }
        }
        public string Systm
        {
            get { return systm; }
            set { systm = value; }
        }
        public string Leval
        {
            get { return leval; }
            set { leval = value; }
        }
        public static void Displaystudents()
        {
            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";

            sqlConnection = new SqlConnection(sqlString);
           
            sqlConnection.Open();
            string DisplayQuery = "SELECT * FROM  Person P JOIN Students S ON P.Id =S.Id ORDER BY P.Id";

            SqlCommand sqlCommand = new SqlCommand(DisplayQuery, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //Console.WriteLine("\n Id   Name   Email   Gender    Major   Level   System type\n");
            int counter = 1;
            while (sqlDataReader.Read())
            {  
                Console.Write(counter +"- | "+ sqlDataReader.GetValue(0).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(1).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(2).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(3).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(4).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(5).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(6).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(6).ToString() + "   |  ");
                Console.WriteLine("\n-----------------------------------------------------------------------\n");
                counter +=1;
            }
            Console.WriteLine("\n\n\n");
            sqlDataReader.Close();
            sqlConnection.Close();

            Console.ReadKey();
            Console.Clear();
        }

        public static void RegisterCourse()
        {
            Console.WriteLine("                     |------------------------------------------|\n");
            Console.WriteLine("                     |         Register  Students    in courses        |\n");
            Console.WriteLine("                     |------------------------------------------|\n\n");

            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            sqlConnection = new SqlConnection(sqlString);
            sqlConnection.Open();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
            try
            {


                Console.Write(" 1- Enter Student Id ");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------------");
                //create new student and add it to lsit
                int Instructor_id = 1;



                Console.Clear();
                Console.WriteLine("                  REGISTER STUDENT IN COURSE       \n\n");
                Course.dispayCourses();
                Console.WriteLine("\n               -----------------------------------------\n");
                Console.Write("                    Select  course id to Choose course  ");
                int COURSE_ID = int.Parse(Console.ReadLine());

                Console.Write("                     Enter Course Time \" In hours\"  ");
                int courseTime = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
                Student student = new Student(Id);
                Course course = new Course(COURSE_ID);
                Instructor instructor = new Instructor(Instructor_id, "", "", "", 1, "", 1, "");
                Inrollments inrollments = new Inrollments(student, course, instructor);

                string sqlEnrollments = "exec createInrollments @Course_id,@studnet_id,@Course_time";
                SqlCommand SqlEnroCommand = new SqlCommand(sqlEnrollments, sqlConnection, sqlTransaction);
                SqlEnroCommand.Parameters.AddWithValue("@Course_id", inrollments.Course.Course_id);
                SqlEnroCommand.Parameters.AddWithValue("@studnet_id", inrollments.Student.Id);
                SqlEnroCommand.Parameters.AddWithValue("@Course_time", courseTime);
                int i = SqlEnroCommand.ExecuteNonQuery();
                sqlTransaction.Commit();

                Console.WriteLine("\n\n            " + i + "- Record Added Successfully     \n");
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

        public static void RegisterNewStudent()
        {
            Console.WriteLine("                     |------------------------------------------|\n");
            Console.WriteLine("                     |         Register New Students            |\n");
            Console.WriteLine("                     |------------------------------------------|\n\n");

            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            sqlConnection = new SqlConnection(sqlString);
            sqlConnection.Open();
            SqlTransaction sqlTransaction = sqlConnection.BeginTransaction();
            try
            {


                Console.Write(" 1- Enter Student Id ");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 2- Enter Students Name ");
                string? Name = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 3- Enter Students Email ");
                string? Email = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 4- Enter Registration Year ");
                int Year = int.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 5- Enter  Major   ");
                string? Major = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 6- Enter  your Level ");
                string? Level = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 7- Enter your Gender ");
                string? Gender = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 8- Enter your System Study ");
                string? systm = Console.ReadLine();
                Console.WriteLine("\n--------------------------------------");
                //create new student and add it to lsit
                int Instructor_id = 1;



                Console.Clear();
                Console.WriteLine("                  REGISTER STUDENT IN COURSE       \n\n");
                Course.dispayCourses();
                Console.WriteLine("\n               -----------------------------------------\n");
                Console.Write("                    Select  course id to Choose course  ");
                int COURSE_ID = int.Parse(Console.ReadLine());

                Console.Write("                     Enter Course Time \" In hours\"  ");
                int courseTime = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Clear();
                string st_type = "students";
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


                string sqlStudent = "INSERT INTO Students(Id,Major,lavel,Std_type)VALUES(@Id,@Major,@Level,@systm)";
                Student student = new Student(Id, Name, Email, Gender, Year, Major, Level, systm);

                SqlCommand studentcommand = new SqlCommand(sqlStudent, sqlConnection, sqlTransaction);
                studentcommand.Parameters.AddWithValue("@Id", student.Id);
                studentcommand.Parameters.AddWithValue("@Major", student.Major);
                studentcommand.Parameters.AddWithValue("@Level", student.Leval);
                studentcommand.Parameters.AddWithValue("@systm", student.Systm);
                studentcommand.ExecuteNonQuery();


                Course course = new Course(COURSE_ID);
                Instructor instructor = new Instructor(Instructor_id, "", "", "", 1, "", 1, "");
                Inrollments inrollments = new Inrollments(student, course, instructor);

                string sqlEnrollments = "exec createInrollments @Course_id,@studnet_id,@Course_time";
                SqlCommand SqlEnroCommand = new SqlCommand(sqlEnrollments, sqlConnection, sqlTransaction);
                SqlEnroCommand.Parameters.AddWithValue("@Course_id", inrollments.Course.Course_id);
                SqlEnroCommand.Parameters.AddWithValue("@studnet_id", inrollments.Student.Id);
                SqlEnroCommand.Parameters.AddWithValue("@Course_time", courseTime);
                int i=SqlEnroCommand.ExecuteNonQuery();
                sqlTransaction.Commit();

                Console.WriteLine("\n\n            "+i+ "- Record Added Successfully     \n");
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


        public static void update()
        {
            Console.WriteLine("------------------------------------------\n");
            Console.WriteLine("        Update Students information        \n");
            Console.WriteLine("------------------------------------------\n\n");


            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            sqlConnection = new SqlConnection(sqlString);
            sqlConnection.Open();

            try
            {

                Console.WriteLine("                     Enter Student Id..");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine("                     Enter Students Name \n");
                string? Name = Console.ReadLine();
                Console.WriteLine("                     Enter Students Email \n");
                string? Email = Console.ReadLine();
                Console.WriteLine("                     Enter Registration Year \n");
                int Year = int.Parse(Console.ReadLine());
                Console.WriteLine("                     Enter  Major\n");
                string? Major = Console.ReadLine();
                Console.WriteLine("                     Enter  your Level\n");
                string? Level = Console.ReadLine();
                Console.WriteLine("                     Enter your Gender \n");
                string? Gender = Console.ReadLine();
                Console.WriteLine("                     Enter your System Study \n");
                string? systm = Console.ReadLine();


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


                Student student = new Student(Id, Name, Email, Gender, Year, Major, Level, systm);
                string sqlStudent = "UPDATE STUDENTS SET Id=@ID,Major=@Major,lavel=@Level,Std_type = @Systm where Id=@id";
                SqlCommand studentcommand = new SqlCommand(sqlStudent, sqlConnection);
                studentcommand.Parameters.AddWithValue("@Major", student.Major);
                studentcommand.Parameters.AddWithValue("@Level", student.Leval);
                studentcommand.Parameters.AddWithValue("@systm", student.Systm);
                studentcommand.Parameters.AddWithValue("@id", student.Id);
                studentcommand.ExecuteNonQuery();

            } catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);


            }
            finally
            {
                sqlConnection.Close();
            }

        }




        public static bool search(int id)
        {

            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";

            sqlConnection = new SqlConnection(sqlString);
            
            sqlConnection.Open();
            
            string DisplayQuery = "SELECT * FROM  Person P JOIN Students S ON P.Id=s.Id  where p.Id =@id";
            SqlCommand sqlCommand = new SqlCommand(DisplayQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();


            if (!sqlDataReader.HasRows)
            {
                Console.WriteLine("\n\n\n\t\tSORRY,"+ sqlDataReader + "....:~)\n\n\n");
                sqlDataReader.Close();
                sqlConnection.Close();
                return false;
            }
            else
            {

                Console.WriteLine("\n StId    Name   Email    Gender     Major    Level    System type\n");
                while (sqlDataReader.Read())
                {
                    Console.Write(sqlDataReader.GetValue(0).ToString() + "   |  ");
                    Console.Write(sqlDataReader.GetValue(1).ToString() + "   |  ");
                    Console.Write(sqlDataReader.GetValue(2).ToString() + "   |  ");
                    Console.Write(sqlDataReader.GetValue(3).ToString() + "   |  ");
                    Console.Write(sqlDataReader.GetValue(4).ToString() + "   |  ");
                    Console.Write(sqlDataReader.GetValue(5).ToString() + "   |  ");
                    Console.Write(sqlDataReader.GetValue(6).ToString() + "   |  ");
                    Console.Write(sqlDataReader.GetValue(6).ToString() + "   |  ");
                    Console.WriteLine("\n-----------------------------------------------------------------------\n");
                }
                Console.WriteLine("\n\n\n");
                sqlDataReader.Close();
                sqlConnection.Close();
                return true;
            }



        }


        public static void delete(int id)
        {

            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";

            sqlConnection = new SqlConnection(sqlString);
            
            if(search(id)==true)
            {

            sqlConnection.Open();
            string DisplayQuery = " Delete FROM  Person   where Id =@id";
            SqlCommand sqlCommand = new SqlCommand(DisplayQuery, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);
           int i= sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
                Console.WriteLine("\n\n\n\t\t" + i+" Record Deleted Successfully \n"); 
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\n\n\n\t\tSORRY,NOTHING....:~)\n\n\n");
                Console.ReadKey();
                Console.Clear();
                sqlConnection.Close();
            }
        }



        public static  void showInrollment()
        {

            Console.Write("Enter your  id ");
            int S_id = int.Parse(Console.ReadLine());

            Console.Clear();
            Console.WriteLine("             |------------------------------------------|\n");
            Console.WriteLine("             |--    Courses that Student study        --|\n");
            Console.WriteLine("             |------------------------------------------|\n");


            string regCourse = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(regCourse);
            connection.Open();


            string DisplayCours = "SELECT couse_id,Course_name,Course_price ,CourseTime,enrollment_date FROM  Enrollment E  join Course c on c.couse_id =E.course_id where E.student_id=@St_id";

            SqlCommand sqlCommand = new SqlCommand(DisplayCours, connection);
            sqlCommand.Parameters.AddWithValue("@St_id", S_id);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Console.WriteLine("\n\n  Course id     Course Name      CoursePrice     Course Time  Course Date Registeration   \n\n");
            int counter = 1;
            while (sqlDataReader.Read())
            {
                Console.Write(counter + " - |" + sqlDataReader.GetValue(0).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(1).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(2).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(3).ToString() + "   |  ");
                Console.WriteLine(sqlDataReader.GetValue(4).ToString() + "   |  ");

                Console.WriteLine("-----------------------------------------------------------------------\n");
            }
            sqlDataReader.Close();
            connection.Close();
            Console.ReadKey();
           

            }




        

       



    }
}

