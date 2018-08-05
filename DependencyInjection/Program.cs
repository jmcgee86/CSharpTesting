using System;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjection
{
    //USER INTERFACE
    class Program
    {
        static void Main(string[] args)
        {
            Customer obj = new Customer(new SQLServerDAL());
            obj.CustomerName = "test1";
            obj.Add();
        }
    }

    //MIDDLE LAYER
    public class Customer
    {
        //REMOVE: when changing to Interface
            // private OracleDAL OdalOra = new OracleDAL();
            // private SQLServerDAL Odal = new SQLServerDAL();
        private IDal _odal;
        public string CustomerName { get; set; }
        public Customer(IDal iobj)
        {
            _odal = iobj;
        }
        public void Add()
        {
            //DAL
                    // if(true) //config file, parameter table, etc..
                    // {
                    //     //Odal.Add(); //SQL Server
                    //     //Odal = new SQLServerDAL();
                    // }
                    // else
                    // {
                    //     Odal = new OracleDAL();
                    //     //OdalOra.Add(); //Oracle 
                    // }
            _odal.Add();
        }
    }
    //DATA ACCESS LAYER
    public interface IDal
    {
        void Add();
    }
        
    
    public class SQLServerDAL : IDal
    {
        public void Add()
        {
            Console.WriteLine("SQL Server Inserted");
        }
    }
      public class OracleDAL : IDal
    {
        public void Add()
        {
            Console.WriteLine("Added by oracle");
        }
    }
}
