using System.Threading.Channels;

namespace AssignmentC_02
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Q1
            //static void PrintNum()
            //{
            //    Console.WriteLine("Please enter a number");
            //    int x = int.Parse(Console.ReadLine());
            //    Console.WriteLine(x);
            //}
            //PrintNum();

            #endregion

            #region Q2
            //static void converting()
            //{
            //    Console.WriteLine("enter a string to convert it");
            //    int x=int.Parse(Console.ReadLine()); 
            //}
            //converting();  //if user enter non-numeric characters error warning will appear that input wasn't in correct format
            #endregion

            #region Q3
            //static void FloatingPoint()
            //{
            //    Console.WriteLine("enter a floating num 1");
            //    float num1=float.Parse(Console.ReadLine());
            //    Console.WriteLine("enter a floating num 2");
            //    float num2=float.Parse(Console.ReadLine());
            //    float res =num1+num2;
            //    Console.WriteLine(res);
            //}
            //FloatingPoint();
            #endregion

            #region Q4
            //static void GivenString()
            //{
            //    Console.WriteLine("enter a sting");
            //    string s= Console.ReadLine();
            //    Console.WriteLine("enter starting index");
            //    int i =int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter the needing length");
            //    int l =int.Parse(Console.ReadLine());
            //    string res=s.Substring(i,l);
            //    Console.WriteLine(res);
            //    }

            //GivenString();
            #endregion

            #region Q5
            //int x = 5;
            //int y=8;
            //y = x;
            //Console.WriteLine(y);       // y value is 5
            //x = 6;
            //Console.WriteLine(y);        // y still equal 5
            #endregion

            #region Q6
            //Class1 c1 = new Class1();
            //c1.x = 2;
            //c1.y = 3;
            //Class1 c2 = new Class1();
            //c2.x = 4;
            //c2.y = 5;
            //Console.WriteLine(c2.y);          //5
            //c2 = c1;                          //assigning c1 values to c2 
            //Console.WriteLine(c2.y);          //3 
            //c1.y = 6;                             
            //Console.WriteLine(c2.y);          //6
            #endregion

            #region Q7
            //static void concat()
            //{
            //    Console.WriteLine("enter the frist string");
            //    string s1=Console.ReadLine();
            //    Console.WriteLine("enter the second string");
            //    string s2=Console.ReadLine();
            //    string res=s1+s2;
            //    Console.WriteLine(res);
            //}
            //concat();
            #endregion

            #region Q8
            //int d;
            //d = Convert.ToInt32(!(30 < 20));
            ///*
            // condition is false ..not(false)=true ..converting true boolean value into integer 
            // so 1 is assigned to d
            // */

            #endregion

            #region Q9
            //Console.WriteLine(13 / 2 + " " + 13 % 2);

            //// 13/2 = 6 ... 13%2=1  so the result is 6 1
            #endregion

            #region Q10
            //int num = 1, z = 5;

            //if (!(num <= 0)) // not(false)...condition is true
            //    Console.WriteLine(++num + z++ + " " + ++z);
            ////++num is 2 + z(5) =7  then increase z to 6 then space then increase z to 7

            //else // not be excuted
            //    Console.WriteLine(--num + z-- + " " + --z);

            ////so the result is 7 7

            #endregion
        }
    }
}
