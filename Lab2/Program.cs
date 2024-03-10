using lab2;
using System.IO;

// question1.Fact();

// public class Imain
// {
//     public static void Main(string[] args)
//     {
//         //question1.Fact();
//         Quadratic quad = new Quadratic();
//         quad.input();
//         double[] roots = quad.Calculate();
//         Console.WriteLine("The roots are: " + roots[0] + " and " + roots[1]);

//     }
// }

// public class Imain
// {

//     public static void Main(string[] args)
//     {
//         question3.Student[] students = new question3.Student[5];
//         for (int i = 0; i < 5; i++)
//         {
//             question3.Student student = new question3.Student();
//             student.Input();
//             students[i] = student;
//         }

//         Console.WriteLine("\nStudents older than 24: ");
//         foreach (var student in students)
//         {
//             if (student.age > 24)
//             {
//                 Console.WriteLine($"Name: {student.name}, age: {student.age}");
//             }
//         }
//     }
// }

// class TimeDemo
// {
//     public static void Main(string[] args)
//     {
//         Time t1 = new Time { hr = 5, min = 40, sec = 40 };
//         Time t2 = new Time { hr = 4, min = 40, sec = 50 };
//         Time t = new Time();

//         t = t.Sum(t1, t2);

//         Console.WriteLine("Sum of time:");
//         Console.WriteLine("Hours: {0}, Minutes: {1}, Seconds: {2}", t.hr, t.min, t.sec);

//         Console.ReadLine();
//     }
// }

// class Text
// {
//     static void Main(string[] args)
//     {
//         string inputFileName = "input.txt";
//         string outputFileName = "output.txt";

//         try
//         {
//             string content = File.ReadAllText(inputFileName);

//             File.WriteAllText(outputFileName, content);

//             Console.WriteLine("File copied successfully.");
//         }
//         catch (Exception ex)
//         {
//             Console.WriteLine($"An error occurred: {ex.Message}");
//         }
//     }
// }

// class question6
// {
//     static void Main(string[] args)
//     {
//         string inputFileName = "input.txt";

//         string content = File.ReadAllText(inputFileName);

//         string[] words = content.Split(new char[] { ' ', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

//         foreach (string word in words)
//         {
//             if (word.EndsWith("g"))
//             {
//                 Console.WriteLine(word);
//             }
//         }
//     }
// }

// class Program
// {
//     static void Main(string[] args)
//     {
//         Airplane ap = new Airplane("767-300ERF", "Airbus", 550);
//         ap.DisplayDetails();
//         ap.startEngine();
//         ap.takeOff();
//         ap.land();
//         ap.stopEngine();
//     }
// }

