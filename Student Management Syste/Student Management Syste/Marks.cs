using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Student_Management_Syste
{


    sealed class Marks
    {
        public Course Course;
        public Student Student;

        private float score;

        public Marks(Course course, Student student, float score)
        {
            Course = course;
            Student = student;
            Mark = score;
        }


        public float Mark
        {

            get { return score; }
            set { score = value; }
        }


        public static void setMark(int student_ID, int course_Id, float score)
        {
            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            sqlConnection = new SqlConnection(sqlString);
            sqlConnection.Open();

            try
            {

                string? setmarK = "insert into Mark (person_id,course_id,score)values(@p_id,@c_id,@score)";
                Course course = new Course(course_Id);
                Student student = new Student(student_ID);

                Marks marks = new Marks(course, student, score);
                SqlCommand cmd = new SqlCommand(setmarK, sqlConnection);
                cmd.Parameters.AddWithValue("@p_id", student.Id);
                cmd.Parameters.AddWithValue("@c_id", course.Course_id);
                cmd.Parameters.AddWithValue("@score", score);
                cmd.ExecuteNonQuery();
                Console.WriteLine("\n\n\n\t ONE Mark Add successfully");
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


        public static void getmark(int ID)
        {
            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            sqlConnection = new SqlConnection(sqlString);
            sqlConnection.Open();

            try
            {

                string? getmarK = "select Course_name,SCORE from Mark M JOIN COURSE C ON C.couse_id=M.course_id WHERE M.person_id=@STU_ID";
                SqlCommand GETM = new SqlCommand(getmarK, sqlConnection);
                GETM.Parameters.AddWithValue("@STU_ID", ID);
                SqlDataReader sqlDataReader = GETM.ExecuteReader();
                Console.WriteLine("\n\n  Course   |   Score \n\n");
                int counter = 1;
                while (sqlDataReader.Read())
                {
                    Console.Write("  "+sqlDataReader.GetValue(0).ToString() + "  |  ");
                    Console.WriteLine(sqlDataReader.GetValue(1).ToString() + "  |  ");
                    Console.WriteLine("-------------------\n");
                }
                sqlDataReader.Close();

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