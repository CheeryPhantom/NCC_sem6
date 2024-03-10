using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class question1 {
        private int a, b, sum1;
        public void sum()
        {
            Console.WriteLine("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number: ");
            b = Convert.ToInt32(Console.ReadLine());
            sum1 = a + b;
            sum1.ToString();
            Console.WriteLine("The sum of " + a + " and " + b + " is: " + sum1);
        }
    }

    internal class question2
    {
        private double P, rate,interest1;
        private int time;
        public void interest()
        {
            Console.WriteLine("Enter Principle and Rate in decimals! ");
            Console.WriteLine("Enter the Principle amount: ");
            P= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the Time in years: ");
            time = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Rate: ");
            rate = Convert.ToDouble(Console.ReadLine());
            interest1 = P * time * rate / 100;
            Console.WriteLine("The interest is: " + interest1);
        }
    }

    internal class question3
    {
        private double a, b, c, x,y;

        public void roots() {
            Console.WriteLine("Program to find roots of a Quadratic Equation");
            Console.WriteLine("Enter values for a,b & c respectively: ");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            x = (-b + Math.Sqrt(Math.Pow(b, 2.0) - 4 * a * c)) / 2 * a;
            y = (-b - Math.Sqrt(Math.Pow(b, 2.0) - 4 * a * c)) / 2 * a;
            Console.WriteLine("The roots of the given quadratic equation are: " + x + " and " + y);
        }
    }

    internal class question4 {
        private float[] marks = new float[5];
        private float sum,percent;
        private bool fail;
        public void result()
        {
            Console.WriteLine("Enter marks for 5 subjects: ");
            for (int i = 0;i< marks.Length; i++)
            {
                marks[i]= float.Parse(Console.ReadLine());

                if (marks[i] < 35){
                    fail = true;
                }
                sum += marks[i];
            }
            if (fail)
            {
                Console.WriteLine("You have failed!");
            }else { Console.WriteLine("You have passed! "); }
            percent = sum / 5;
            Console.WriteLine("You have got " + percent + "%");
            if (!fail)
            {
                if (percent < 65)
                {
                    Console.WriteLine("You have gotten 2nd Division! ");
                }
                else if (percent < 80)
                {
                    Console.WriteLine("You have gotten 1st Division! ");
                }
                else
                {
                    Console.WriteLine("You have gotten Distinction! ");

                }
            }
        }
    }

    internal class question5
    {
        private double a, b;
        private char op;
        public void calculator()
        {
            Console.WriteLine("Enter first operand: ");a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter operator: ");op = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter second operand: "); b = double.Parse(Console.ReadLine());
            switch(op)
            {
                case '+':
                    Console.Write("The sum is: "+(a+b));
                    break;

                case '-':
                    Console.Write("The difference is: " + (a - b));
                    break;

                case '*':
                    Console.Write("The product is: " + (a * b));
                    break;

                case '/':
                    Console.Write("The quotient is: " + (a / b));
                    break;

                default: 
                    Console.WriteLine("Error! operand not allowed!");
                    break;
            }
        }
    }

    internal class question6 {
        private string[] names = new string[4];

        private bool[] include = new bool[4];
        public void printIfT() {
            Console.WriteLine("Enter 4 names ");
            for (int i = 0; i < names.Length; i++)
            {
                include[i] = false;
                names[i] = Console.ReadLine().ToLower();
                for (int j = 0; j < names[i].Length; j++)
                {
                    if (names[i][j] == 't')
                    {
                        include[i] = true;
                        break;
                    }
                }
            }
            Console.WriteLine("\nThe names with 't' are: \n");
            for (int i = 0;i < include.Length; i++)
            {
                if (include[i])
                {
                    Console.WriteLine(names[i]);
                }
            }
        }
    }

    internal class question7
    {
        private string[] names;
        public question7()
        {
            Console.WriteLine("Enter number of names you want to sort: ");
            int n = int.Parse(Console.ReadLine());
            names = new string[n];
        }
        public void sortNames() {
            for (int i = 0;i<names.Length;i++)
            {
                Console.Write("Enter name"+(i+1)+": ");
                names[i] = Console.ReadLine();
            }
            Array.Sort(names);
            Console.WriteLine("\nAfter sorting: \n");
            for (int i = 0;i< names.Length;i++)
            {
                Console.WriteLine(names[i]);
            }
        }
    }

    internal class question8
    {
        private int[] numbers;

        public question8()
        {
            Console.WriteLine("Enter the size of array");
            int n = int.Parse(Console.ReadLine());
            numbers = new int[n];
        }

        public void getMinMax() {
            int min = int.MaxValue;
            int max = 0;
            Console.WriteLine("Enter numbers:\n ");
            for (int i = 0;i<numbers.Length;i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a<min) min = a;
                if (a>max) max = a;
            }
            Console.WriteLine("Min: " + min + " Max: " + max);
        }
    }

    internal class question9
    {
        private int[ , ] numbers = new int[3,3];

        public void displayUpper()
        {
            Console.WriteLine("Enter a 3 x 3 matrix of numbers: ");
          /*  Console.WriteLine(numbers.GetLength(0));
            Console.WriteLine(numbers.GetLength(1));*/
            for (int i = 0; i < numbers.GetLength(0);i++) {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    //Console.WriteLine(i+" "+j);
                    numbers[i,j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0;i< numbers.Length;i++)
            {
                Console.Write(new string(' ', i*2));
                for (int j = 0;j< numbers.GetLength(0) - i; j++)
                {
                    Console.Write(numbers[i, j]+" ");
                }
                Console.WriteLine();
            }
        }
    }

    internal class rectangle
    {
        private int length, breadth, area;
        public rectangle()
        {
            Console.WriteLine("Enter length of rectangle: ");length = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter breadth of rectangle: "); breadth = int.Parse(Console.ReadLine());
        }

        public void ComputeArea()
        {
            area = length * breadth;
        }

        public void DisplayArea()
        {
            Console.WriteLine("The area of the rectangle is: " + area);
        }
        public int GetArea()
        {
            return area;
        }
    }
}
