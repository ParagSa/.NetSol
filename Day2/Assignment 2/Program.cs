namespace Assignment_2
{
    
    internal class Program
    {
      
        static void Main(string[] args)
        {
            Class1 o = new Class1("parag", 10000, 11);
            Class1 o1 = new Class1("parag", 10000, 11);
            Class1 o2 = new Class1("parag", 10000, 11);
            Console.WriteLine(o.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o2.EmpNo);


            Console.WriteLine(o2.EmpNo);
            Console.WriteLine(o1.EmpNo);
            Console.WriteLine(o.EmpNo);




        }
       
    }
    public class Class1
    {
        private string name;
        public static int empno = 1;

        private decimal basic;
        private short deptno;
        public int EmpNo { get; set; }
        public string Name
        {
            set
            {
                if (value != "")
                {
                    name = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
            }
            get { return name; }
        }
        public static int NextEmpNo
        {

            get { return empno++; }
        }
        private decimal Basic
        {
            set
            {
                if (value > 1000)
                {
                    basic = value;
                }
                else
                {
                    Console.WriteLine("Invalid Input");

                }


            }
            get { return basic; }
        }
        private short DeptNo
        {
            set
            {
                if (value > 0)
                {
                    deptno = value;


                }
                else
                {
                    Console.WriteLine("Invalid Input");


                }


            }
            get { return deptno; }
        }

        public decimal GetNetSalary()
        {
            decimal sum = basic + 1000;
            return sum;


        }
        public Class1(string name, decimal basic, short deptno)
        {
            Name = name;
            DeptNo = deptno;
            Basic = basic;
            EmpNo = NextEmpNo;

        }
        public Class1(string name, decimal basic)
        {
            Name = name;

            Basic = basic;
            EmpNo = NextEmpNo;


        }
        public Class1(string name)
        {
            Name = name;
            EmpNo = NextEmpNo;

        }


        public Class1()
        {
            EmpNo = NextEmpNo;


        }




    }


}