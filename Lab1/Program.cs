using Lab1;
using System;
/*question1 q1 = new question1();
q1.sum();

question2 q2 = new question2();
q2.interest();*/

/*question3 question3 = new question3();
question3.roots();
*/

/*question4 q4 = new question4();
q4.result();*/


/*question5 q5 = new question5();
q5.calculator();*/

/*question6 q6 = new question6();
q6.printIfT();*/

/*question7 q7 = new question7();
q7.sortNames();*/

/*question8 q8 = new question8();
q8.getMinMax();*/

/*question9 q9 = new question9();
q9.displayUpper();*/

rectangle r1 = new rectangle();
rectangle r2 = new rectangle();
r1.ComputeArea();
r2.ComputeArea();
r1.DisplayArea();
r2.DisplayArea();
int area1 = r1.GetArea();
int area2 = r2.GetArea();
Console.Write("\nThe greater area is: ");
if(area1 < area2)
{
    Console.Write(area2);
}
else
{
    Console.Write(area1);
}
Console.WriteLine();

