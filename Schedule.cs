using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
    internal class Schedule
    {
        public int[,] array;

        public Schedule(int[,] array)
        {
            this.array = array;
        }



        public void DaysWith5P(int[,] array)
        {
            Random random = new Random();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                Console.WriteLine();
                for (int j = 0; j < array.GetLength(1); j++)
                {

                    array[i, j] = random.Next(1, 10);
                    if (array[i, j] < 5)
                    {
                        Console.Write($"|Patients: {array[i, j]}|");

                    }
                    else
                    {
                        Console.Write("  |Busy|");
                    }





                }
            }
        }


    }
}
