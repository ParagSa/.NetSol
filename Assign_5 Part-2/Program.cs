using System.ComponentModel.DataAnnotations;

namespace Assign_5_Part_2
{
    internal class Program
    {

        static void Main(string[] args)
        {
            
            //Dictionary<int, Employee> empList = new Dictionary<int, Employee>();
            Console.Write("Enter number of Employees: ");
            int n = int.Parse(Console.ReadLine());
            Employee[] empArray = new Employee[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter employee number: ");
                int empNo = int.Parse(Console.ReadLine());

                Console.Write("Enter employee name: ");
                string empName = Console.ReadLine();

                Console.Write("Enter employee salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());

                Employee emp = new Employee() { Id = empNo, Name = empName, Salary = salary };
                empArray[i] = emp;
            }



            List<Employee> empList = new List<Employee>(empArray);
            foreach (var emp in empList)
            {
                Console.WriteLine("EmpNo: " + emp.Id);
                Console.WriteLine("EmpName: " + emp.Name);
                Console.WriteLine("EmpSalary: " + emp.Salary);
                Console.WriteLine("-----------------------------------------");
            }






        }
    }
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }


    }
}