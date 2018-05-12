using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class MainClass
{
    public static void Main()
    {
        car car1 = new car();
        car car2 = new car();
        car car3 = new car();
        // Test code
        Console.WriteLine(car1.numTires);
        Console.WriteLine(car2.year);
        Console.WriteLine(car3.runs);
    }
}
public class car
{
    public int numTires = 4;
    public int year = 2000;
    public bool runs = true;
}

//public class Tutorial
//{
//    public static void Main()
//    {
//        string fullString = "fullxx xstxring";
//        string partOfString = fullString.Substring(5);
//        string shorterPart = fullString.Substring(5, 3);
//        Console.WriteLine(partOfString);
//        Console.WriteLine(shorterPart);

//        //Dictionary<string, long> phonebook = new Dictionary<string, long>();
//        //phonebook.Add("Alex", 415434543);
//        //phonebook["Jessica"] = 415984588;

//        //phonebook.Remove("Jessica");
//        //Console.WriteLine(phonebook.Count);
//        //Console.WriteLine(phonebook["Alex"]);
//        //Console.WriteLine(phonebook.Count);

//    }
//}

//public enum CarType
//{
//    Toyota,
//    Honda,
//    Ford,
//    Fords,
//}

//public class Tutorial
//{
//    public static void Main()
//    {
//        // TODO: add your code here
//        List<int> primeNumbers = new List<int>();
//        int[] arr = new int[] { 2, 3, 5, 7, 11 };
//        primeNumbers.AddRange(arr);
//        // test code
//        Console.WriteLine(primeNumbers.Count);
//        Console.WriteLine(primeNumbers[0]);
//        Console.WriteLine(primeNumbers[1]);
//        Console.WriteLine(primeNumbers[2]);
//        Console.WriteLine(primeNumbers[3]);
//        Console.WriteLine(primeNumbers[4]);
//        Console.WriteLine(primeNumbers);
//    }
//}

//namespace RectangleApplication
//{
//    class Rectangle
//    {

//        // member variables
//        double length;
//        double width;

//        public void Acceptdetails()
//        {
//            length = 4.5;
//            width = 3.5;
//        }
//        public double GetArea()
//        {
//            return length * width;
//        }
//        public void Display()
//        {
//            Console.WriteLine("Length: {0}", length);
//            Console.WriteLine("Width: {0}", width);
//            Console.WriteLine("Area: {0}", GetArea());
//        }
//    }
//    class ExecuteRectangle
//    {
//        static void Main(string[] args)
//        {
//            Rectangle r = new Rectangle();
//            r.Acceptdetails();
//            r.Display();
//            Console.ReadLine();
//        }
//    }
//}

//namespace CsharpTutorial
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            /* my first program in C# */
//            Console.WriteLine("Hello World");
//            Console.ReadKey();
//        }

//    }
//}
