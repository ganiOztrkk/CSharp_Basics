using System;
namespace CSharp_Basics.Homework2
{
	public class Customer
	{
		public int Id { get; set; }

		public string _firstName;
		public string? FirstName
        {
            get => "MR" + _firstName;
            set => _firstName = value!;
        }


        public string? LastName { get; set; }
		public string? City { get; set; }
	}
}

