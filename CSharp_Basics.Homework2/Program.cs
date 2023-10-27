namespace CSharp_Basics.Homework2;

class Program
{
    static void Main(string[] args)
    {
        #region Classes 37-40
        //var customerManager = new CustomerManager();
        //customerManager.Add();
        //customerManager.Update();

        //var productManager = new ProdutManager();
        //productManager.Add();
        //productManager.Update();

        //var customer = new Customer();
        //customer.City = "Tekirdağ";
        //customer.Id = 1;
        //customer.FirstName = "Gani";
        //customer.LastName = "Öztürk";

        //var customer2 = new Customer()
        //{
        //    Id=2,
        //    FirstName = "Ayten",
        //    LastName = "Akbaş",
        //    City = "Adana"
        //};

        //var customer3 = new Customer
        //{
        //    Id = 3,
        //    FirstName = "Hamza",
        //    LastName = "Gültaşlı",
        //    City = "Mardin"
        //};

        #endregion

        #region WinForm 41
        //ios cihaz ile winform oluşturamadığım için sadece izledim.
        #endregion

        #region Interfaces 42-46

        //PersonManager personManeger = new PersonManager();

        //personManeger.Add(new Customer() { FirstName = "Engin", LastName = "Demiroğ", City = "İstanbul", Id = 5 });

        //CustomerManager customerManager = new CustomerManager();

        //customerManager.Add(new OracleServerCustomerDal());
        //customerManager.Add(new SqlServerCustomerDal());
        //customerManager.Add(new PostgreServerCustomerDal());


        //ICustomerDal[] customerDals = new ICustomerDal[2]
        //{
        //    new SqlServerCustomerDal(),
        //    new OracleServerCustomerDal()
        //};

        //foreach (var item in customerDals)
        //{
        //    item.Add();
        //}
        //IWorker[] workers = new IWorker[3]
        //    {
        //        new Manager(),
        //        new Worker (),
        //        new Robots(),
        //    };
        //foreach (var worker in workers)
        //{
        //    worker.Work();
        //}
        //IEat[] eats = new IEat[2]
        //{
        //        new Worker(),
        //        new Manager(),

        //};


        #endregion

        #region Inheritance 47
        //Person[] persons = new Person[3]
        //    {
        //        new Customer
        //        {
        //            FirstName = "Engin"
        //        },
        //        new Student
        //        {
        //            FirstName = "Derin"
        //        },
        //        new Person
        //        {
        //            FirstName = "Salih"
        //        }
        //    };

        //foreach (Person person in persons)
        //{
        //    Console.WriteLine(person.FirstName);
        //}

        #endregion

    }


    #region 45-Multiple Implementation
    //interface IWorker
    //{
    //    void Work();

    //}
    //interface IEat
    //{
    //    void Eat();
    //}
    //interface ISalary
    //{
    //    void GetSalary();
    //}
    //class Manager : IWorker, IEat, ISalary
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
    //class Worker : IWorker, IEat, ISalary
    //{
    //    public void Eat()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void GetSalary()
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    //class Robots : IWorker
    //{
    //    public void Work()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}

    #endregion

    #region Inheritance 47
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }

    class Student : Person
    {
        public string Department { get; set; }
    }

    #endregion
}