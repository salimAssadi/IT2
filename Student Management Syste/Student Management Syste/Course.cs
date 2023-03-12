using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Student_Management_Syste
{

    sealed class Course
    {
        private int course_id;
        private string? course_name;
        private string? course_description;
        private decimal course_price;

        public Course(int course_id, string? course_name, decimal course_price, string course_description)
        {
            Course_id = course_id;
            Course_name = course_name;
            Course_description = course_description;
            Course_price = course_price;

        }

        public Course(int course_id)
        {
            Course_id=course_id;
        }
        public int Course_id
        {
            get { return this.course_id; }
            set { this.course_id = value; }
        }

        public string? Course_name
        {
            get { return this.course_name; }
            set { this.course_name = value; }
        }

        public string Course_description
        {
            get { return course_description; }
            set { course_description = value; }
        }

        public decimal Course_price
        {
            get { return course_price; }
            set { course_price = value; }
        }


        public static void dispayCourses()
        {
            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            sqlConnection = new SqlConnection(sqlString);
            sqlConnection.Open();
          Console.WriteLine("\n         |----------------------------------------|\n");
            Console.WriteLine("         |           Available Courses            |\n");       
            Console.WriteLine("         |----------------------------------------|\n");

            string DisplayCours = "SELECT * FROM  Course c  ORDER BY c.couse_id";

            SqlCommand sqlCommand = new SqlCommand(DisplayCours, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            //Console.WriteLine("\n\n  Course id          Course Name          CoursePrice        Course Description \n\n");
            int counter = 1;
            while (sqlDataReader.Read())
            {
                Console.Write(counter+ " - |"+ sqlDataReader.GetValue(0).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(1).ToString() + "   |  ");
                Console.Write(sqlDataReader.GetValue(2).ToString() + "   |  ");
                Console.WriteLine(sqlDataReader.GetValue(3).ToString() + "   |  ");

                Console.WriteLine("-----------------------------------------------------------------------\n");
            }
            Console.WriteLine("\n\n");
            sqlDataReader.Close();
            sqlConnection.Close();

            Console.ReadKey();

        }


        public static void Add_course()
        {
            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            sqlConnection = new SqlConnection(sqlString);

            try
            {
               
                Console.WriteLine("         |------------------------------------------|\n");
                Console.WriteLine("         |                Add Course                |\n");
                Console.WriteLine("         |------------------------------------------|\n\n");

                sqlConnection.Open();
                Console.Write("Enter Course Id  ");
                int CourseId = int.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                Console.Write("Enter Course Name  ");
                string? CourseName = Console.ReadLine();
                Console.WriteLine("------------------------------------------");
                Console.Write("Enter Course Price  ");
                decimal Courseprice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("------------------------------------------");
                Console.Write("Enter  Courser Description  ");
                string? CourserDescription = Console.ReadLine();
                Console.WriteLine("------------------------------------------");


                string Sqladdcourse = "INSERT INTO Course(couse_id,Course_name,course_price,Course_desc) VALUES(@COURSE_ID,@COURSE_NAME,@COURSE_PRICE,@COURSE_DESC)";
                Course course = new Course(CourseId, CourseName, Courseprice, CourserDescription);
                SqlCommand coursecommand = new SqlCommand(Sqladdcourse, sqlConnection);
                coursecommand.Parameters.AddWithValue("@COURSE_ID", course.Course_id);
                coursecommand.Parameters.AddWithValue("@COURSE_NAME", course.Course_name);
                coursecommand.Parameters.AddWithValue("COURSE_PRICE", course.Course_price);
                coursecommand.Parameters.AddWithValue("COURSE_DESC", course.Course_description);
                coursecommand.ExecuteNonQuery();
                
                Console.WriteLine("\n\n\n\t One course added successfully");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            sqlConnection.Close();

            }

        }


    }
    
}
