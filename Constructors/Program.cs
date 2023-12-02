using Constructors;

Customer customer1 = new Customer { Id=1, FirstName="engin", LastName="demiroğ", City="ankara"};
Customer customer2 = new Customer ( 2, "derin", "demiroğ", "ankara" );

Console.WriteLine(customer2.FirstName);