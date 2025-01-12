System.Console.Write("Enter your name:  ");
string name = Console.ReadLine();
string greeting = $"Hello, {name}";
System.Console.WriteLine(greeting);
System.Console.Write("Enter you age: ");
string ageAsString = Console.ReadLine();
System.Console.WriteLine("Converting...");
int age = Convert.ToInt32(ageAsString);
System.Console.WriteLine($"Successfuly converted!  {age}");
int keschasAge = 3;
int ageDifference = age - keschasAge;
System.Console.WriteLine($"The difference betwen your and Kescha's age is {ageDifference}");

System.Console.WriteLine($"Siz Keschadan kattasiz {age > keschasAge}");
System.Console.WriteLine($"Siz Keschadan yoshroqsiz {age < keschasAge}");
System.Console.WriteLine($"Siz Keschadan katta yoki tengsiz {age >= keschasAge}");
System.Console.WriteLine($"Siz Keschadan yosh yoki tengsiz {age <= keschasAge}");
System.Console.WriteLine($"Siz Kescha bilan yoshingiz teng {age == keschasAge}");
System.Console.WriteLine($"Sizning yoshingiz Keschani yoshi bilan teng emasmi? {age != keschasAge}");