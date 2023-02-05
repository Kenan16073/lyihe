using System;
using System.Linq.Expressions;

namespace TASK
{
    internal class Program
    {
        static void Main(string[] args )
        {
            string[] students = {"Xeyyam Eliyev","Cavad Hesenov","Ehmed Veliyev"};

            string option;
            bool check = true;

            do
            {
                Console.WriteLine("/n1.Butun telebelere bax.");
                Console.WriteLine("2.Yeni telebe elave et.");
                Console.WriteLine("3.Telebeler uzre axtaris et.");
                Console.WriteLine("4.Telebelerin adlarina bax.");
                Console.WriteLine("5.Siyahida adin olub olmadigina bax.");
                Console.WriteLine("0.Cix.");

                Console.WriteLine("n/Secim edin:");
                option= Console.ReadLine();

                switch (option)
                {
                    case "1":           
                        for(int i = 0; i < students.Length;i++)
                        Console.WriteLine(students[i]);
                        break;
                    case "2":
                        Console.WriteLine("Elave edeceyiniz telebeni daxil edin.");
                        string newstudent=Console.ReadLine();
                        Array.Resize(ref students,students.Length+1);
                        students[students.Length-1]=newstudent;
                        break; 
                    case "3":
                        Console.WriteLine("Axtardiqiniz telebeni daxil edin.");
                        string Searchstudent = Console.ReadLine();
                        

                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].ToLower().ToUpper().Contains(Searchstudent.ToLower().ToUpper()))
                            {
                                Console.WriteLine(students[i]);
                                
                                
                            }
                            else
                            {
                               Console.WriteLine("Bele bir telebe yoxdur.");

                            }
                             break;
                        }
                        
                        break;
                    case "4":

                        for (int i = 0; i < students.Length; i++)
                        {
                            string student = students[i];
                            Console.WriteLine(student.Split(' ')[0]);
                        }
                        break;
                    case "5":
                        Console.WriteLine("FullName daxil edin.Siyahida adin olub olmadiqina baxilacaq");
                        string Sstudent = Console.ReadLine();
                        


                        for (int i = 0; i < students.Length; i++)
                        {
                            if (students[i].ToLower().ToUpper().Contains(Sstudent.ToLower().ToUpper()))
                            {
                                Console.WriteLine("Var");
                                
                                
                            }
                            else
                            {
                              Console.WriteLine("Yoxdur");

                            }
                               break;

                        }
                        break;
                    case "0":
                        
                        check = false;
                        
                        break;
                        default:
                        Console.WriteLine("Dogru secim edin!!!");
                        break;
                }
                

            }
            while (check);
        
            
        }
    }
}
