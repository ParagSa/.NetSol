using Microsoft.Data.SqlClient;
namespace Databases
{
    internal class Program
    {
        static void Main()
        {
            //connect();
            // Insert();
            //Employee obj= new Employee {EmpNo=7,Name="rajesh D'Silva",Basic=4545,DeptNo=30};
            //InsertWithParameters(obj);
            //InsertWithStoredProcedures(obj);
            //UpdateWithParameters(obj);
            //UpdateWithStoredProcedures(obj);
            // DeleteWithParameters(1);
            DeleteWithStoredProcedures(2);
        }
        static void connect() 
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString= @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try {
                cn.Open();

                Console.WriteLine("hello");


            }
            catch(Exception ex)
            {
               Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }
            
        
            
        }

        static void Insert()
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = "insert into Employees values(4,'ritesh', 121212,10 )";

                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("hello");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }



        }
        static void InsertEmployee(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = $"insert into Employees values({obj.EmpNo},{obj.Name}, {obj.Basic},{obj.DeptNo} )";
                // Never Write code in this pattern.
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("hello");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }



        }

        static void InsertWithParameters(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = $"insert into Employees values( @EmpNo, @Name,@Basic, @DeptNo)";
                cmdInsert.Parameters.AddWithValue("@EmpNo",obj.EmpNo);
                cmdInsert.Parameters.AddWithValue("@Name", obj.Name);
                cmdInsert.Parameters.AddWithValue("@Basic", obj.Basic);
                cmdInsert.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                // Never Write code in this pattern.
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("hello");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }



        }

        static void InsertWithStoredProcedures(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInsert.CommandText = "InsertEmployee";
                cmdInsert.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmdInsert.Parameters.AddWithValue("@Name", obj.Name);
                cmdInsert.Parameters.AddWithValue("@Basic", obj.Basic);
                cmdInsert.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                // Never Write code in this pattern.
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("hello");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }



        }

        static void UpdateWithParameters(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = $"update Employees set Name= @Name, Basic = @Basic, DeptNo =  @DeptNo where EmpNo = @EmpNo";
                cmdInsert.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmdInsert.Parameters.AddWithValue("@Name", obj.Name);
                cmdInsert.Parameters.AddWithValue("@Basic", obj.Basic);
                cmdInsert.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                // Never Write code in this pattern.
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("hello");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }



        }
        static void UpdateWithStoredProcedures(Employee obj)
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;
                 
                cmdInsert.CommandText = "UpdateEmployee";
                cmdInsert.Parameters.AddWithValue("@EmpNo", obj.EmpNo);
                cmdInsert.Parameters.AddWithValue("@Name", obj.Name);
                cmdInsert.Parameters.AddWithValue("@Basic", obj.Basic);
                cmdInsert.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                // Never Write code in this pattern.
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("hello");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }



        }
        static void DeleteWithParameters(int i)
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.Text;
                cmdInsert.CommandText = $"delete from Employees where EmpNo = @EmpNo";
                cmdInsert.Parameters.AddWithValue("@EmpNo", i);
                //cmdInsert.Parameters.AddWithValue("@Name", obj.Name);
                //cmdInsert.Parameters.AddWithValue("@Basic", obj.Basic);
                //cmdInsert.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                // Never Write code in this pattern.
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("hello");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }



        }

        static void DeleteWithStoredProcedures(int i)
        {
            SqlConnection cn = new SqlConnection();
            //Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
            cn.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=thane;Integrated Security=True;";
            try
            {
                cn.Open();
                SqlCommand cmdInsert = new SqlCommand();
                cmdInsert.Connection = cn;
                cmdInsert.CommandType = System.Data.CommandType.StoredProcedure;
                cmdInsert.CommandText = "DeleteEmployee";
                cmdInsert.Parameters.AddWithValue("@EmpNo", i);
                //cmdInsert.Parameters.AddWithValue("@Name", obj.Name);
                //cmdInsert.Parameters.AddWithValue("@Basic", obj.Basic);
                //cmdInsert.Parameters.AddWithValue("@DeptNo", obj.DeptNo);

                // Never Write code in this pattern.
                cmdInsert.ExecuteNonQuery();
                Console.WriteLine("hello");


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally { cn.Close(); }



        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

        public decimal Basic { get; set; }
        
        public int DeptNo { get; set; }
    
    }

}