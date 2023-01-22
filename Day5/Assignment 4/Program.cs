using System.Runtime.Intrinsics.X86;

namespace Assignment_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a jagged array to store the marks for each student in each batch.
            int numOfBatches;
            Console.WriteLine("enter the number of batches:");
            numOfBatches = int.Parse(Console.ReadLine());
            int[][] marks = new int[numOfBatches][];

            //Use a for loop to accept the number of students in each batch and initialize
            //the inner arrays of the jagged array.
            for (int i =0; i<numOfBatches;i++) 
            {
                Console.WriteLine("Enter the number of students in each batch {0}:",i+1);
                int numStudents = int.Parse(Console.ReadLine());
                marks[i] = new int[numStudents];
            
            }

            //Accepts the marks of the student
            for (int i = 0; i < numOfBatches; i++)
            {
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.WriteLine("Enter mark for student {0} in batch {1}:", j + 1, i + 1);
                    marks[i][j] = int.Parse(Console.ReadLine());
                }
            }

            // display the marks of the students

            for (int i = 0; i < numOfBatches; i++)
            {
                for (int j = 0; j < marks[i].Length; j++)
                {
                    Console.WriteLine("Mark for student {0} in batch {1} : {2}", j + 1, i + 1, marks[i][j]);
                }
            }







        }
    }
}