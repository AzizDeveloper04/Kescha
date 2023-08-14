System.Console.WriteLine("Enter you name: ");
string name=Console.ReadLine();
string greeting=$"hello {name}";
System.Console.WriteLine(greeting);
System.Console.WriteLine("Enter you age: ");
int age=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the age of the kescha");
int keschaage=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"The difference in your ages is {Math.Abs(age-keschaage)}");
