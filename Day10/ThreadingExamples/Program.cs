//namespace ThreadingExamples1
//{
//    internal class Program
//    {
//        static void Main1()
//        {
//            Thread t1 = new Thread(new ThreadStart(Func1));
//            Thread t2 = new Thread(Func2);

//            t1.Start();
//            t2.Start();

//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Main : " + i);

//            }

//            Console.ReadLine();
//        }

//        static void Main2()
//        {
//            Thread t1 = new Thread(new ThreadStart(Func1));
//            Thread t2 = new Thread(Func2);

//            t1.IsBackground = true; //does not wait for this thread to complete
//            t2.IsBackground = true;

//            t1.Start();
//            t2.Start();

//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Main : " + i);
//            }

//        }
//        static void Main3()
//        {
//            Thread t1 = new Thread(new ThreadStart(Func1));
//            Thread t2 = new Thread(Func2);

//            t1.Priority = ThreadPriority.Highest;
//            t2.Priority = ThreadPriority.Lowest;

//            t1.Start();
//            t2.Start();

//            for (int i = 0; i < 1000; i++)
//            {
//                Console.WriteLine("Main : " + i);
//            }

//        }
//        static void Main4()
//        {
//            Thread t1 = new Thread(new ThreadStart(Func1));
//            Thread t2 = new Thread(Func2);

//            t1.Start();
//            t2.Start();

//            for (int i = 0; i < 10; i++)
//            {
//                Console.WriteLine("Main : " + i);
//            }
//            t1.Join();   //waiting call
//            //below code should run only after t1 thread finishes
//            Console.WriteLine("After t1");
//        }
//        static void Main5()
//        {
//            Thread t1 = new Thread(new ThreadStart(Func1));
//            Thread t2 = new Thread(Func2);

//            //if(t1.ThreadState == ThreadState.)


//            t1.Start();
//            t2.Start();
//            //t1.Suspend();
//            //t1.Resume();
//            Console.ReadLine();
//            Console.WriteLine("t1" + t1.ManagedThreadId);
//            Console.WriteLine("t2" + t2.ManagedThreadId);
//            for (int i = 0; i < 1000; i++)
//            {
//                Console.WriteLine("Main : " + i);
//                if (i == 50)
//                {
//                    //t1.Abort();  //only with framework, not supported on core
//                }

//            }
//            t1.Join();
//            Console.WriteLine("t1 ended");
//            Console.ReadLine();
//            t1.Start(); //error. check for threadstate before doing this


//        }

//        static void Main6()
//        {
//            AutoResetEvent wh = new AutoResetEvent(false);
//            Thread t1 = new Thread(delegate ()
//            {
//                for (int i = 0; i < 1000; i++)
//                {
//                    Console.WriteLine("f1:" + i);
//                    if (i == 100)
//                    {
//                        //instead of Suspend, use this
//                        Console.WriteLine("waiting");
//                        wh.WaitOne();
//                    }
//                }
//            });
//            t1.Start();


//            Thread.Sleep(10000);
//            //resume
//            Console.WriteLine("resuming....");
//            wh.Set();
//        }
//        static void Func1()
//        {
//            for (int i = 0; i < 1000; i++)
//            {
//                Console.WriteLine("First : " + i);
//                //Thread.Sleep(5000);

//            }

//        }
//        static void Func2()
//        {
//            for (int i = 0; i < 1000; i++)
//            {
//                Console.WriteLine("Second : " + i);
//                //Thread.Sleep(5000);

//            }

//        }
//    }
//}

namespace ThreadingExamples2
{
    internal class Program
    {
        static void Main()
        {
            List<object> myList = new List<object>() { "item1", 2, 3.14 };
            Thread t1 = new Thread(new ParameterizedThreadStart(Func1));
            Thread t2 = new Thread(Func2);
            int a = 100;
            int b = 200;
           


            t1.Start(myList);
            t2.Start("bbb");
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Main : " + i);
            }
        }
        static void Func1(object obj)
        {
           List<object> myList = (List<object>)obj;
    for (int i = 0; i < myList.Count; i++)
    {
        if(myList[i] is string)
            Console.WriteLine(myList[i] as string);
        else if(myList[i] is int)
            Console.WriteLine(myList[i].ToString());
        else if(myList[i] is double)
            Console.WriteLine(myList[i].ToString());
    }

        }
        static void Func2(object obj)
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Second : " + i + obj.ToString());
            }

        }

    }
}