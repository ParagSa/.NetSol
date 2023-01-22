namespace ConstructorsAndObjectInitializers
{
    internal class Program
    {
        static void Main(string[] args)
        {
          // Class1 o = new Class1();
            Class1 o = new Class1(1,2,3);
            Console.WriteLine(o.P1);
            Console.WriteLine(o.P2);
            Console.WriteLine(o.P3);
        }
    }
    public class Class1
    {
        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }
        public Class1() 
        { 
            P1 = 10;
            P2 = 20;
            P3 = 30;

        
        }
       // public Class1(int P1, int P2, int P3)
       // {
           // this.P1 = P1;
            //this.P2 = P2;
            //this.P3 = P3;


        //}
        public Class1(int P1 = 10, int P2=20, int P3=30)
        {
            this.P1 = P1;
            this.P3 = P3;
            this.P2 = P2;


        }
    }


}