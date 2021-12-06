// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

namespace Clinic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Doctor> listOfDoctors = new List<Doctor>();
            Console.WriteLine("choose number");
            Console.WriteLine("1.Add Doctor  2.Show Doctor  3.Add Patients  4.Show All Doctors");
            int counter = 0;
           
             switch (int.Parse(Console.ReadLine()))
            {
                case 1:
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
                  
                    break;

                case 2:
                    Console.WriteLine("enter the name of the doctor");
                    string firstname2 = Console.ReadLine();

                    FileStream doctor2 = new FileStream($@"C:\Clinic\{firstname2}.txt", FileMode.Open);
                    using (StreamReader reader = new StreamReader(doctor2))
                    {
                      Console.WriteLine(reader.ReadLine());
                    }
                    break;

                    
                case 4:
                    
    
                    FileStream doctor3 = new FileStream($@"C:\Clinic\allDoctors.txt", FileMode.Open);
                    using (StreamReader reader = new StreamReader(doctor3))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                    }

                    break;

               
            }
           


        }
     
    }
}

