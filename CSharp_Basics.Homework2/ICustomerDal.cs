using System;
namespace CSharp_Basics.Homework2
{
	public interface ICustomerDal
	{
		void Add();
		void Update();
		void Delete();
	}

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql Added");
        }

        public void Delete()
        {
            Console.WriteLine("Sql Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Sql Updated");
        }
    }

    class OracleServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle Added");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Oracle Updated");
        }
    }

    class PostgreServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Postgre Added");
        }

        public void Delete()
        {
            Console.WriteLine("Postgre Deleted");
        }

        public void Update()
        {
            Console.WriteLine("Postgre Updated");
        }
    }
}

