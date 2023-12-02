using AsenkronCSharpIntro;

//int sayi1 = 10;
//int sayi2 = 20;

//sayi1 = sayi2;
//sayi2 = 100;

//Console.WriteLine("sayi 1: "+sayi1);

//int[] sayilar1 = new int[] {1,2,3};
//int[] sayilar2 = new int[] { 10, 20, 30 };

//sayilar1 = sayilar2;
//sayilar2[0] = 1000;

//Console.WriteLine("Sayılar[0]= " + sayilar1[0]);

Person person1 = new Person();
Person person2 = new Person();
person1.FirstName = "Engin";

person2 = person1;
person1.FirstName = "Derin";
//Console.WriteLine(person2.FirstName);

Customer customer = new Customer();
customer.FirstName = "Salih";
customer.CreditCardNumber = "123456789";

Employee employee = new Employee();

Person person3 = customer;
customer.FirstName = "Ahmet";

//Console.WriteLine(((Customer)person3).CreditCardNumber);

PersonManager personManager = new PersonManager();
personManager.Add(customer);

