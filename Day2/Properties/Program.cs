namespace Properties
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i; // local variable
            i = 0;
            // Class1 o = new Class1();
            // o.Seti (10);
            //  Console.WriteLine(o.Geti());
            Class2 o = new Class2();
               o.P1 = 20;
             Console.WriteLine(o.P1);    
        }

    }
        public class Class1 {
            private int i;
        public void Seti(int Value) {
            if (Value < 100)
                i = Value;
            else
                Console.WriteLine("Invalid input");

        }
        public int Geti() { 
            return i;
        }
        }
    public class Class2{
        private int p1;
        public int P1 /// property
        { 
            get { return p1; }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                    Console.WriteLine("Invalid input");
            }
        }
        

    }
}