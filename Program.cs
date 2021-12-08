// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Clinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] daybook = new int[4, 7];


            List<Doctor> listOfDoctors = new List<Doctor>();
            Console.WriteLine("choose number");
            Console.WriteLine("1.Add Doctor  2.Show Doctor  3.Add Patients  4.Show All Doctors  5.print daybook  6.show days with less then 5 Patients");
            int counter = 0;

            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Enter first name Of the doctor");
                        string firstname = Console.ReadLine();
                        Console.WriteLine("Enter last name");
                        string lastname = Console.ReadLine();
                        Console.WriteLine("Enter job");
                        string job = Console.ReadLine();
                        Console.WriteLine("Enter number Of Patients");
                        int numOfPatients = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter year Of Birth");
                        int yearOfBirth = int.Parse(Console.ReadLine());
                        Doctor doctor1 = new Doctor(numOfPatients, yearOfBirth, firstname, lastname, job);
                        listOfDoctors.Add(doctor1);

                        FileStream alldoctor = new FileStream($@"C:\Clinic\allDoctors.txt", FileMode.Append);
                        using (StreamWriter writer = new StreamWriter(alldoctor))
                        {
                            for (int i = 0; i < listOfDoctors.Count; i++)
                            {
                                writer.WriteLine($"id:{counter++}  first name: {listOfDoctors[i].firstName}  last name: {listOfDoctors[i].lastName}  job: {listOfDoctors[i].job}  number of patients: {listOfDoctors[i].numOfPatients}  year of birth: {listOfDoctors[i].yearOfBirth},");
                            }
                        }

                        FileStream doctor = new FileStream($@"C:\Clinic\{firstname}.txt", FileMode.Append);
                        using (StreamWriter writer = new StreamWriter(doctor))
                        {
                            for (int i = 0; i < listOfDoctors.Count; i++)
                            {
                                writer.WriteLine($"id:{counter++}  first name: {listOfDoctors[i].firstName}  last name: {listOfDoctors[i].lastName}  job: {listOfDoctors[i].job}  number of patients: {listOfDoctors[i].numOfPatients}  year of birth: {listOfDoctors[i].yearOfBirth},");
                            }
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("value must be number");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;



                case 2:
                    try
                    {
                        Console.WriteLine("enter the name of the doctor");
                        string firstname2 = Console.ReadLine();

                        FileStream doctor2 = new FileStream($@"C:\Clinic\{firstname2}.txt", FileMode.Open);
                        using (StreamReader reader = new StreamReader(doctor2))
                        {
                            Console.WriteLine(reader.ReadLine());
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("value must be text");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;



                case 3:

                    try
                    {
                        Console.WriteLine("enter the name of the doctor");
                        string firstname3 = Console.ReadLine();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("value must be text");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                    break;


                case 4:
                    try
                    {

                        FileStream doctor3 = new FileStream($@"C:\Clinic\allDoctors.txt", FileMode.Open);
                        using (StreamReader reader = new StreamReader(doctor3))
                        {
                            Console.WriteLine(reader.ReadToEnd());
                        }
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("value must be text");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                    break;



                case 5:

                    Daybook(daybook);
                    break;

                case 6:
                    try
                    {
                        Console.WriteLine("enter number of weeks");
                        int numOfWeeks = int.Parse(Console.ReadLine());
                        Console.WriteLine("enter number of Days");
                        int numOfDays = int.Parse(Console.ReadLine());

                        int[,] daybook2 = new int[numOfWeeks, numOfDays];
                        //DaysWith5P(daybook);
                        Schedule schedule1 = new Schedule(daybook);
                        schedule1.DaysWith5P(daybook);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("value must be text");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }

                    break;
            }


            
          
        }

        static void Daybook(int[,] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    
                   array[i,j]  = random.Next(1 , 10);
                    array[i, 6] = 0;
                    Console.Write(array[i, j]);
                    
                }
            }
        }

       

                  
                    
                   







    }
}

