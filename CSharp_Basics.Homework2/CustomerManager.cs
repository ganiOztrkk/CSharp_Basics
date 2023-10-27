namespace CSharp_Basics.Homework2;

public class CustomerManager
{
    public void Add(ICustomerDal customerDal)
    {
        customerDal.Add();
    }
}