namespace Assigment_4_part_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare a jagged array to store the Employee objects.

            int numEmployees;
            Console.WriteLine("Enter number of employees:");
            numEmployees = int.Parse(Console.ReadLine());
            Employee[] employees = new Employee[numEmployees];

            //Use a for loop to accept the details for all employees and
            //create Employee objects to store in the jagged array.


            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine("Enter details for employee {0}:", i + 1);
                Console.WriteLine("EmpNo:");
                int empNo = int.Parse(Console.ReadLine());
                Console.WriteLine("Name:");
                string name = Console.ReadLine();
                Console.WriteLine("Salary:");
                double salary = double.Parse(Console.ReadLine());
                // other properties
                employees[i] = new Employee { EmpNo = empNo, Name = name, Salary = salary };
            }
            // find max salary of employee

            double maxSalary = double.MinValue;
            Employee maxSalaryEmployee = null;
            for (int i = 0; i < numEmployees; i++)
            {
                if (employees[i].Salary > maxSalary)
                {
                    maxSalary = employees[i].Salary;
                    maxSalaryEmployee = employees[i];
                }
            }
            Console.WriteLine("Employee with highest salary:");
            Console.WriteLine("EmpNo: {0}", maxSalaryEmployee.EmpNo);
            Console.WriteLine("Name: {0}", maxSalaryEmployee.Name);
            Console.WriteLine("Salary: {0}", maxSalaryEmployee.Salary);






        }
    }
    //Create an Employee class with properties such as EmpNo, Name, Salary, etc.
    public class Employee 
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }

    }
}