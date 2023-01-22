namespace Assign_5_Part_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> empList = new List<Employee>();

            while (true)
            {
                Console.WriteLine("Enter the Employee Number:");
                int empNo = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the Employee Name:");
                string empName = Console.ReadLine();


                Console.WriteLine("Enter the Employee salary:");
                decimal empSal = decimal.Parse(Console.ReadLine());

                Employee emp = new Employee() { Id = empNo, Name = empName, Salary = empSal };
                empList.Add(emp);

                Console.Write("Do you want to enter more employees (yes/no)? ");
                if (Console.ReadLine().ToLower() == "no")
                    break;

            }

            Employee[] empArray = empList.ToArray();

            foreach (var emp in empArray)
            {
                Console.WriteLine("EmpNo: " + emp.Id);
                Console.WriteLine("EmpName: " + emp.Name);
                Console.WriteLine("Salary: " + emp.Salary);
                Console.WriteLine("-----------------");
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