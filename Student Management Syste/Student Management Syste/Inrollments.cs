using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

/*The Enrollment class represents a student's 
enrollment in a specific course. It might have 
properties like the course the student is enrolled in,
the student's grade in the course, 
and the date the student enrolled. 
Here is an example implementation 
of the Enrollment class:
*/


namespace Student_Management_Syste
{
    class Inrollments
    {   
       public Course Course { get; set; }
        public Instructor Instructor { get; set; }
        public Student Student { get; set; }
        private DateTime enrollment_date ;
        private static Instructor instructor;

        public Inrollments(Student student, Course course, Instructor instructor)
        {
            Course = course;
            Student = student;
            Instructor = instructor;
            Enrollment_date = DateTime.Now;

        }

        public DateTime Enrollment_date
        {
            get { return enrollment_date; }
            set { enrollment_date = value; }
        }

        public static void setMarkOnEnrollment()
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
            Console.Write("Do you Want to Set Students mark 1-Yes \t\t2- No => ");
            int YesOrNo = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n\n");
            if (YesOrNo == 1)
            {


                Console.Write(" 2- Enter Course Id ");
                int Course_Id = int.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------------");
                Console.Write(" 3- Enter Score ");
                float Score = float.Parse(Console.ReadLine());
                Console.WriteLine("\n--------------------------------------");

                Marks.setMark(S_id, Course_Id, Score);



            }


        }

    }
}
