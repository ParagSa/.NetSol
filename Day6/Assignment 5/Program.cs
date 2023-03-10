using System.Runtime.Intrinsics.X86;

namespace Assignment_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Employee> empList = new Dictionary<int, Employee>();
           

            while (true)
            {
                Console.WriteLine("Enter the Employee Number:");
                int empNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Employee Name:");
                string empName = Console.ReadLine();


                Console.WriteLine("Enter the Employee salary:");
                decimal empSal = decimal.Parse(Console.ReadLine());

                Employee emp = new Employee() { Id = empNo, Name = empName, Salary = empSal};
                empList.Add(empNo, emp);

                Console.Write("Do you want to enter more employees (yes/no)? ");
                if (Console.ReadLine().ToLower() == "no")
                    break;
                
            }

            var highestSalaryEmp = empList.Values.OrderByDescending(e => e.Salary).First();
            Console.WriteLine("Employee with highest salary: " + highestSalaryEmp.Name);
        }
 
    }
}
class Employee
{
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Salary { get; set; }
    
    
}