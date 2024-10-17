#region Section 1 C# Primitive Types


//sbyte,byte,short,ushort,int,uint,long,ulong,float,decimal,char,bool

//Primitive types store a single value.



//int intValue = 42;
//long longValue = 123456789L;
//float floatValue = 3.14F;
//double doubleValue = 3.14159;
//decimal decimalValue = 10000.1234M;
//bool boolValue = true;
//char charValue = 'A';

//Console.WriteLine("int value: " + intValue);
//Console.WriteLine("long value: " + longValue);
//Console.WriteLine("float value: " + floatValue);
//Console.WriteLine("double value: " + doubleValue);
//Console.WriteLine("decimal value: " + decimalValue);
//Console.WriteLine("bool value: " + boolValue);
//Console.WriteLine("char value: " + charValue);






#endregion


#region Section 2 C# Non Primitive Types

//string,class,interface,structures,enumerations




//using CSharpBasics.MyExampleNamespace;


//Console.Write("Enter a message: ");

//// Read the message from the console
//string message = Console.ReadLine();

//// Display the message
//Console.WriteLine("You entered: " + message);


//Person person = new Person
//{
//    Name = "Luffy",
//    Age = 21
//};

//Person p2 = new Person();
//p2.Name = "nithin";


//Console.WriteLine("Person Name: " + person.Name);
//Console.WriteLine("Person Age: " + person.Age);





#endregion


#region Section 2 - More about Get and Set Accessors (Encapsulation)



//using CSharpBasics.MyExampleNamespace;

//PersonClass person = new PersonClass();
//person.Name = "Luffy";

//person.Age = -1;
// Output: Age cannot be negative.


//person.Age = 150;
// Output: Age cannot be greater than 120.


//person.Age = 21;
//Console.WriteLine("Luffy's Age: " + person.Age);





#endregion


#region Section 3 - If,Else

/*
string weather = "sunny"; 

if (weather == "sunny")
{
    Console.WriteLine("It's a beautiful day! Wear sunglasses.");
}
else if (weather == "rainy")
{
    Console.WriteLine("Don't forget your umbrella.");
}
else if (weather == "snowy")
{
    Console.WriteLine("Wear a warm coat and boots.");
}
else
{
    Console.WriteLine("Go for a vacation !!!");
}

*/

#endregion


#region Section 4 - Switch case 



//int dayNumber = 3;

//switch (dayNumber)
//{
//    case 1:
//        Console.WriteLine("Monday");
//        break;
//    case 2:
//        Console.WriteLine("Tuesday");
//        break;
//    case 3:
//        Console.WriteLine("Wednesday");
//        break;
//    case 4:
//        Console.WriteLine("Thursday");
//        break;
//    case 5:
//        Console.WriteLine("Friday");
//        break;
//    case 6:
//        Console.WriteLine("Saturday");
//        break;
//    case 7:
//        Console.WriteLine("Sunday");
//        break;
//    default:
//        Console.WriteLine("Invalid day number");
//        break;
//}



#endregion


#region Section 5 - Loops (While Loop)



//int number = 1;

//while (number <= 10)
//{
//    if (number == 5)
//    {
//        number++;
//        continue;
//    }

//    if (number == 8)
//    {
//        break;
//    }

//    Console.WriteLine(number);
//    number++;
//}

//Console.WriteLine("Loop has ended.");




#endregion


#region Section 5 Loops - (For Loop with Arrays)




//int[] numbers = { 1, 2, 3, 4, 5 };


//Console.WriteLine("Numbers:");
//for (int i = 0; i < numbers.Length; i++)
//{
//    Console.WriteLine(numbers[i]);
//}





#endregion


#region Section 5 Loops - (For Loop with Arrays but need to add a new value)




//int[] numbers = { 1, 2, 3, 4, 5 };


////Ooops, I need to add one more value to this array before printing

////REMEMBER :- arrays have a fixed size, meaning you cannot directly add or remove elements from them after they've been created.
////But we can create a new array with the desired size, copy the existing elements, and then add the new value.

//int newValue = 6;

//int[] newNumbers = new int[numbers.Length + 1];


//// Copy existing elements to the new array
//for (int i = 0; i < numbers.Length; i++)
//{
//    newNumbers[i] = numbers[i];
//}

//// Add the new value to the last position
//newNumbers[newNumbers.Length - 1] = newValue;


//Console.WriteLine("Numbers:");
//for (int i = 0; i < newNumbers.Length; i++)
//{
//    Console.WriteLine(newNumbers[i]);
//}





#endregion



#region Section 5 Loops - For Loop with List



//List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Mango" };


//Console.WriteLine("Fruits:");
//for (int i = 0; i < fruits.Count; i++)
//{
//    Console.WriteLine(fruits[i]);
//}



#endregion

#region Section 5 Loops - For Loop with List , adding a new value



//List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Mango" };

//fruits.Add("Watermelon");

//fruits.Remove("Banana");

//Console.WriteLine("Fruits:");
//for (int i = 0; i < fruits.Count; i++)
//{
//    Console.WriteLine(fruits[i]);
//}



#endregion


#region Section 5 Loops - ForEach Loop



//List<string> fruits = new List<string> { "Apple", "Banana", "Cherry", "Date", "Mango" };


//Console.WriteLine("Fruits:");

//foreach (string fruit in fruits)
//{
//    Console.WriteLine(fruit);
//}



#endregion




#region Section 6 - Using List with Class




//using CSharpBasics.StudentNamespace;

//List<Student> students = new List<Student>();

//Student luffy = new Student("Luffy", 21);

//students.Add(luffy);

//students.Add(new Student("Zoro", 24));


//foreach (Student student in students)
//{
//    student.DisplayInfo();
//}



#endregion

#region Section 6 - LINQ Query



//List<string> fruits = new List<string> { "Apple",  "Cherry", "Date", "Mango", "Banana","Cucumber" };

//Find all fruits that start with the letter 'A'.

//var result = fruits.Where(fruit => fruit.StartsWith("A"));

//foreach (var fruit in result)
//{
//    Console.WriteLine(fruit);
//}

//Sort the fruits alphabetically.

//var result = fruits.OrderBy(fruit => fruit);

//foreach (var fruit in result)
//{
//    Console.WriteLine(fruit);
//}

//Get the length of each fruit name.

//var result = fruits.Select(fruit => fruit.Length);

//foreach (var length in result)
//{
//    Console.WriteLine(length);
//}

//Find the first fruit that starts with 'C'.

//var result = fruits.FirstOrDefault(fruit => fruit.StartsWith("C"));
//Console.WriteLine(result);


//Count how many fruits have more than 5 characters.


//var result = fruits.Count(fruit => fruit.Length > 5);
//Console.WriteLine(result);





#endregion


#region Section 7 - Classes and Interfaces (Class Library)


//using VehicleProject.Classes;
//using VehicleProject.Interface;


//IVehicle myBike = new Bike();
//myBike.Start();




#endregion


#region Section 7 - Access Modifiers



//using CSharpBasics.Section_8;
//using VehicleProject.Classes;
//using VehicleProject.Interface;

//Car myCar = new Car();

////myCar.SetSpeed(); 
//// inaccesible due to the protection level

////myCar.PerformMaintenance();

//myCar.Start();






#endregion


#region Section 8 - Abstraction (OOPS concept)

/* 

DIFFERENCE BETWEEN ABSTRACT CLASS AND INTERFACE

Abstract Class:
Purpose: To provide a common base class that can contain shared code and definitions for other classes to inherit from.
Implementation: Can contain both complete (implemented) methods and abstract (incomplete) methods that derived classes must override.
Usage: Used when you want to share code among related classes but still enforce some methods to be implemented by derived classes.


Interface:
Purpose: To define a contract or set of methods that a class must implement, without providing any method implementations.
Implementation: Cannot contain any method implementations—only method signatures. Classes that implement the interface must provide the method implementations.
Usage: Used to define a contract that multiple, possibly unrelated, classes can adhere to, ensuring they implement specific methods.

*/



// Create instances of WashingMachine and Refrigerator
//using CSharpBasics.Section_8;

//WashingMachine myWashingMachine = new WashingMachine();

//Appliance myRefrigerator = new Refrigerator();


//// Call methods on WashingMachine
//myWashingMachine.DisplayInfo();
//myWashingMachine.Operate();

//myWashingMachine?.StartSpinCycle();

//// Call methods on Refrigerator
//myRefrigerator.DisplayInfo();
//myRefrigerator.Operate();
//// Cast to Refrigerator to access specific methods
//(myRefrigerator as Refrigerator)?.SetTemperature(4);




#endregion


#region Section 9 - Polymorphism



using CSharpBasics.Section_9;
using CSharpBasics.Section_Async_Await;


/*Method Overloading: The Add method is defined multiple times in the Calculator class, each with a different parameter list. This is method overloading.
Compile-Time Polymorphism: The method to be called is determined at compile time based on the number and type of arguments passed to the method.
Different Parameters: The Add method can handle different types and numbers of parameters, demonstrating how method overloading allows the same method name to be used for different purposes.*/

//Calculator calculator = new Calculator();

//Call the overloaded Add methods
/*Console.WriteLine("Add two integers: " + calculator.Add(5, 10));*/          // Outputs: 15
/*Console.WriteLine("Add three integers: " + calculator.Add(5, 10, 15)); */   // Outputs: 30
/*Console.WriteLine("Add two doubles: " + calculator.Add(5.5, 10.5));   */    // Outputs: 16.0


#endregion



#region Async Await Concepts

//Basic Synchronous Code

//SynchronousExample synchronousExample = new SynchronousExample();
//synchronousExample.MakeTea();

//Asynchronous Code Example
AsynchronousExample asynchronousExample = new AsynchronousExample();
await asynchronousExample.MakeTeaAsync();



#endregion