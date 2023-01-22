namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o = new Class1("parag",1,10000, 11 );
            
            Console.WriteLine(o.GetNetSalary());
        
        }
    }
    public class Class1
    {
        private string name;
        private int empno;
        private decimal basic;
        private short deptno;
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
        private int EmpNo
        {
            set
            {
                if (value > 0)
                {
                    empno = value;

                }
                else
                {
                    Console.WriteLine("Invalid Input");

                }


            }
            get { return empno; }
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
        public Class1(string name, int empno, decimal basic, short deptno) 
        {
            Name = name;
            DeptNo = deptno;
            Basic = basic;
            EmpNo = empno;
        
        
        }
        public Class1(string name, int empno, decimal basic) {
            Name = name;
          EmpNo = empno;
            Basic = basic;



        }
        public Class1(string name, int empno)
        {
            Name = name;
            EmpNo = empno;
        }

        public Class1( int empno)
        {
     
            EmpNo = empno;
        }
        public Class1()
        {

           
        }




    }

}