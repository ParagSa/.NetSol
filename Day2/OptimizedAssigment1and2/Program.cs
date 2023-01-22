namespace OptimizedAssigment1and2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1("parag");
            Class1 o1 = new Class1("parag", 10000, 11);
            Class1 o2 = new Class1("parag", 10000, 11);
            Console.WriteLine(o.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);


            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o.EmpNo);
            Console.WriteLine(o.GetNetSalary());

        }
    }
    public class Class1
    {
        private string Name { set; get; }
        public static int empno = 1;

        private decimal Basic { set; get; }
       private short DeptNo { set; get; }
        public int EmpNo { get; set; }
        
        public static int NextEmpNo
        {

            get { return empno++; }
        }
        

        public decimal GetNetSalary()
        {
            decimal sum = Basic + 1000;
            return sum;


        }
        public Class1(string name ="", decimal basic=0, short deptno=0)
        {
            if (name == "")
            {
                Console.WriteLine("Invalid Input");

            }
            if (basic<=0) {
                Console.WriteLine("Invalid Input");
            }
            if (deptno <= 0)
            {
                Console.WriteLine("Invalid Input");
            }



            Name = name;
            DeptNo = deptno;
            Basic = basic;
            EmpNo = NextEmpNo;

        }
      
       

        

    }

}