
#region Order Task

//using _19._12._2022_homeWork.Models;
//using System.Runtime.InteropServices;

//static Order[] Orders()
//{
//    Order order1 = new Order(new DateTime(2022, 12, 19), 25, "Ready");
//    Order order2 = new Order(new DateTime(2022, 12, 18), 55, "Ready");
//    Order order3 = new Order(new DateTime(2022, 12, 20), 35, "Comfirm");
//    Order order4 = new Order(new DateTime(2022, 12, 21), 35, "Pending");
//    Order order5 = new Order(new DateTime(2022, 12, 19), 38, "Pending");
//    Order order6 = new Order(new DateTime(2022, 12, 19), 42, "Comfirm");
//    Order order7 = new Order(new DateTime(2022, 12, 18), 45, "Ready");

//    return new Order[] { order1, order2, order3, order4, order5,order6, order7 };
//}


//double filteredPrice = 30;
//DateTime filteredDate =  DateTime.Now.AddDays(1);
//string status = "Ready";


//GetFilteredOrders(filteredDate, filteredPrice, status);

//static void GetFilteredOrders( DateTime date, double price, string status)
//{
//    var orders = Orders();
//    int count = 0;

//    foreach (var order in orders)
//    {
//        if (order.Date <=  date && order.Price > price  && order.Status == status)
//        {
//            count++;
//            Console.ForegroundColor = ConsoleColor.Cyan;
//            Console.WriteLine($"Order date: {order.Date.ToString("yyyy-MMM-dd")} , Order price: {order.Price} , Order status: {order.Status} ");
//        }
//    }
//    Console.ForegroundColor = ConsoleColor.Red;



//    Console.WriteLine($"Count: {count}");
//    Console.ResetColor();


//}



#endregion

#region Person Task

//using _19._12._2022_homeWork.Models;



//static Person[] Persons()
//{
//    Person person1 = new Person("Konul", "Ibrahimova", 26 ,true);
//    Person person2 = new Person("Arzu", "Memmedova", 21 ,true);
//    Person person3 = new Person("Tural", "Huseynov", 16 ,false);
//    Person person4 = new Person("Vuqar", "Abbasov", 22 ,true);
//    Person person5 = new Person("Lale", "Selimova", 21 ,true);
//    Person person6 = new Person("Sara", "Ibrahimova", 15 ,false);

//    return new Person[] { person1, person2, person3, person4, person5, person6 };

//}


//int age = 20;

//GetPersonsData(age);

//static void GetPersonsData(int age)
//{
//    var persons = Persons();

//    foreach (var person in Persons())
//    {
//        if (person.Age > age && person.IsStudent )
//        {
//            Console.ResetColor();
//            Console.ForegroundColor= ConsoleColor.Cyan;
//            Console.WriteLine($" Name: {person.Name} Surname: {person.Surname} Age: {person.Age} ");

//        }
//    }
//}
#endregion

#region Calculate_Task
using _19._12._2022_homeWork.Models;


Calculate();

static void Calculate()
{
    Calculator calculator = new Calculator();


    Console.WriteLine("Birinci reqemi daxil edin");

Number1: string strNum1 = Console.ReadLine();
    double checkedNum1;
    bool isParseNum1 = double.TryParse(strNum1, out checkedNum1);

    if (!isParseNum1)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Duzgun reqem daxil edin");
        goto Number1;
    }


    Console.WriteLine("Operator daxil edin");
    string operation = Console.ReadLine();


    Console.WriteLine("ikinci reqemi daxil edin");
Number2: string strNum2 = Console.ReadLine();
    double checkedNum2;
    bool isParseNum2 = double.TryParse(strNum2, out checkedNum2);

    if (!isParseNum2)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Duzgun reqem daxil edin");
        goto Number2;
    }

    if (checkedNum2 == 0 && operation == "/")
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Sifira bolmek olmur");
        Console.ResetColor();
        goto Number2;

    }

    var result = calculator.Calculation(checkedNum1, checkedNum2, operation);
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("Result =" + result);
    Console.WriteLine();

}

#endregion

#region ELave task

//Console.WriteLine("Soz daxil edin");

//string word= Console.ReadLine();

//Console.WriteLine("Axtardiginiz simvolu daxil edin");

//char symbol= char.Parse(Console.ReadLine());




//int [] arr= GetSymbol(word, symbol);

//foreach (var item in arr)
//{
//	Console.WriteLine(item);
//}




//static int[] GetSymbol( string word , char symbol)
//{

//	int[] arr = { };
//	bool chek = false;

//	for (int i = 0; i < word.Length; i++)
//	{
//		if (word[i]== symbol)
//		{
//			Array.Resize(ref arr, arr.Length + 1);
//			arr[arr.Length - 1]=i;
//			chek= true;	
//		}


//	}
//	if (!chek)
//	{
//		Console.WriteLine("bu simvol textde yoxdur");
//	}
//	return arr;	

//}





#endregion
