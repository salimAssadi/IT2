
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace Student_Management_Syste
{
  class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection;
            string sqlString = @"Data Source=.;Initial Catalog =SMS;Integrated Security=True";
            try
            { g:
                sqlConnection = new SqlConnection(sqlString);
                Console.WriteLine("             |------------------------------------------|\n");
                Console.WriteLine("             |-- 1-Instructors           2- Students  --|\n");
                Console.WriteLine("             |------------------------------------------|\n");
               string r;
                Console.Write("Please Enter Choise:  ");
                r = Console.ReadLine();
                Console.WriteLine();
                if (r == "1")
                {   p:
                    Console.Clear();
                    Console.Write("        Enter  PIN  ");
                    long password = long.Parse(Console.ReadLine());
                    if (password == Instructor.passw)
                    {
                        Console.WriteLine("         password is correct\n");
                        Console.Clear();
                    }
                    else
                    { 
                        goto p;  
                    }
                    bool exit = false;



                    while (!exit)
                    {
                  Console.WriteLine("\n\n\n             |------------------------------------------|\n");
                        Console.WriteLine("             |   Welcome to stdunets Mangements system  |\n");
                        Console.WriteLine("             |------------------------------------------|\n\n");
                        Console.WriteLine("             |                 Main Menu                |\n");
                        Console.WriteLine("             |------------------------------------------|\n");
                        Console.WriteLine("             | 1-  Dispaly student's schedule           |\n");
                        Console.WriteLine("             | 2-  Register new Students                |\n");
                        Console.WriteLine("             | 3-  Update student Profile               |\n");
                        Console.WriteLine("             | 4-  Add Course                           |\n");
                        Console.WriteLine("             | 5-  Delete  Student                      |\n");
                        Console.WriteLine("             | 6-  Dispaly Courses                      |\n");
                        Console.WriteLine("             | 7-  Pay Instructor Salay                 |\n");
                        Console.WriteLine("             | 8-  Register Students with another Course|\n");
                        Console.WriteLine("             | 9-  Search  about studnet                |\n");
                        Console.WriteLine("             | 10- Display Instructors                  |\n");
                        Console.WriteLine("             | 11- Imploy Instructor                    |\n");
                        Console.WriteLine("             | 12- Show students courses and set Marks  |\n");
                        Console.WriteLine("             | 13- Exit                                 |\n");
                        Console.WriteLine("             |------------------------------------------|\n\n\n");

                        Console.Write("Please enter your Option(1 - 10)..");
                        int chiose = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n\n\n");
                        switch (chiose)
                        {
                            case 1:
                                Console.Clear();
                                Console.WriteLine("                     |------------------------------------------|\n");
                                Console.WriteLine("                     |         Students in formation            |\n");
                                Console.WriteLine("                     |------------------------------------------|\n\n");
                                Student.Displaystudents();
          
                                break;
                            case 2:
                                Console.Clear();
                                Student.RegisterNewStudent();

                    
                                break;

                            case 3:
                                Console.Clear();
                                Student.update();
                

                                break;

                            case 4:
                                Console.Clear();
                                Course.Add_course();
                                break;
                                
                            case 5:
                                Console.Clear();
                                
                                Console.WriteLine("             |------------------------------------------|\n");
                                Console.WriteLine("             |--            Delete Students           --|\n");
                                Console.WriteLine("             |------------------------------------------|\n");
                                Console.Write("                     Enter  Your ID  ");
                                int id = int.Parse(Console.ReadLine());
                               Console.WriteLine("             |------------------------------------------|\n");

                                Student.delete(id);
                                break;

                            case 6:
                                Console.Clear();
                                Course.dispayCourses();
                                break;
                            case 7:
                                Console.Clear();
                                Console.WriteLine("\n         |----------------------------------------|\n");
                                Console.WriteLine("           |         Payment Instructor salaries    |\n");
                                Console.WriteLine("           |----------------------------------------|\n");
                                
                                Console.Write("                *| Enter Instructor id ..");
                                int Inid = int.Parse(Console.ReadLine());
                                Instructor instructor = new Instructor(Inid);
                                instructor.payment(Inid);

                                break;
                            case 8:
                                Student.RegisterCourse();
                                break;

                            case 9:
                                Console.WriteLine("------------------------------------------\n");
                                Console.WriteLine("        Search about Students             \n");
                                Console.WriteLine("------------------------------------------\n\n");
                                Console.Write("Enter  Your ID ..");
                                int delid = int.Parse(Console.ReadLine());
                                Student.search(delid);
                                break;

                            case 10:
                                Console.Clear();
                                Console.WriteLine("                     |------------------------------------------|\n");
                                Console.WriteLine("                     |        Instructors in formation          |\n");
                                Console.WriteLine("                     |------------------------------------------|\n\n");
                                Instructor.DisplayInstructor();
                                break;

                            case 11:
                                Console.Clear();
                                Console.WriteLine("                     |------------------------------------------|\n");
                                Console.WriteLine("                     |           Imploy New Instructor          |\n");
                                Console.WriteLine("                     |------------------------------------------|\n\n");
                                Instructor.ImployNewInstructor();
                                break;


                            case 12:
                                Console.Clear();
                                Inrollments.setMarkOnEnrollment();
                                break;

                            default:
                                Console.Clear();
                                goto g;
                                break;


                                
                        }


                    } 
                    
                }if( r == "2")
                {   o:
                    Console.Clear();
                    Console.WriteLine("             |------------------------------------------|\n");
                    Console.WriteLine("             |--   1-show Course       2- show Marks  --|\n");
                    Console.WriteLine("             |--              3-Exist                 --|\n");
                    Console.WriteLine("             |------------------------------------------|\n");

                    Console.Write("Enter your Choice");
                    string ch=Console.ReadLine();

                    switch(ch)
                    {
                        case "1":
                           
                            Student.showInrollment();
                            
                            Console.ReadKey();
                            Console.ReadKey();
                            goto o;
                            break;

                        case "2": 
                            Console.Clear();
                            Console.WriteLine("Enter you Id");
                            int M_id = int.Parse(Console.ReadLine());
                            Marks.getmark(M_id);
                            Console.ReadKey();
                            goto o;
                            break;


                        default:
                            Console.Clear();
                            goto g;
                            break;




                    }




                }
                else
                {
                    
                    Console.Clear();
                    goto g;
                   
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}

