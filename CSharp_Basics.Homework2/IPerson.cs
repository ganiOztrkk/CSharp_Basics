using System;
namespace CSharp_Basics.Homework2
{
    public interface IPerson
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
    }

    class Client : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
    }

    class Student : IPerson
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }
    }

    class PersonManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.FirstName);
        }
    }
}

