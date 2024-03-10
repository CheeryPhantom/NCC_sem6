using System;
using System.Dynamic;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography.X509Certificates;

namespace lab2
{
    internal class question1
    {
        public delegate int FactDelegate(int n);

        public static void Fact()
        {
            FactDelegate factDelegate = Factorial;
            Console.WriteLine("Enter a number to find its factorial: ");
            int n = int.Parse(Console.ReadLine());

            int fact = factDelegate(n);
            Console.WriteLine($"Factorial of {n} is: {fact}");
        }

        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
    }

    internal class Quadratic
    {
        private int a, b, c;
        public double x1, x2;

        public void input()
        {
            Console.WriteLine("Enter values for a,b & c respectively: ");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
        }
        public double[] Calculate()
        {
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2.0) - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2.0) - 4 * a * c)) / (2 * a);
            return new double[] { x1, x2 };
        }
    }

    internal class question3
    {
        public class Student
        {
            public int age;
            public string name;
            public void Input()
            {
                Console.WriteLine("Enter age of student: ");
                age = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name of student: ");
                name = Console.ReadLine();
            }
        }
    }

    class Time
    {
        public int hr, min, sec;

        public Time Sum(Time t1, Time t2)
        {
            Time t = new Time();

            t.hr = t1.hr + t2.hr;
            t.min = t1.min + t2.min;
            t.sec = t1.sec + t2.sec;

            if (t.sec >= 60)
            {
                t.min += t.sec / 60;
                t.sec %= 60;
            }
            if (t.min >= 60)
            {
                t.hr += t.min / 60;
                t.min %= 60;
            }

            return t;
        }
    }

    abstract class Vehicle
    {
        public abstract void startEngine();
        public void stopEngine()
        {
            Console.WriteLine("The Engine has stopped.");
        }
    }

    class Airplane : Vehicle
    {
        public string Model;
        public string Manufacturer;
        public int maxCapacity;

        public Airplane(string model, string manufacturer, int maxcapacity)
        {
            Model = model;
            Manufacturer = manufacturer;
            maxCapacity = maxcapacity;
        }
        public override void startEngine()
        {
            Console.WriteLine("The engine has started");
        }

        public void takeOff()
        {
            Console.WriteLine("The Airplane has taken off successfully");
        }

        public void land()
        {
            Console.WriteLine("The Airplane has landed successfully");
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"The Airline model: {Model}, Manufacturer: {Manufacturer}, Max Capacity:{maxCapacity}");
        }
    }

}