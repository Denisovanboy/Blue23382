// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel.Design;

public class Blutech
{
    

    public static void Main()
    {
        string p = "";
        string j = Appinfo.AppName(p);
        Console.WriteLine(j);
        
        Thread menuthread = new Thread(Menu);
        menuthread.Start();
    }

    public static void Menu()
    {
        string input;
        string secondnum = null;
        string firstnum = null;

        int length;
        int positionofoperator;
        int first1;
        int second1;
        int truesum;
        int count;

        while (true)
        {
            Console.WriteLine(" Calculator function");
             input = Console.ReadLine();
            first1 = 0; second1 = 0;
            firstnum = null;
            secondnum = null;

            //Addition 
            if (input.Contains("+"))
            {

                Console.WriteLine("Addition");


                positionofoperator = input.IndexOf("+");
                length = input.Length;

                count = 0;
                while (positionofoperator > count)
                {

                    firstnum = firstnum + input.ElementAt(count);
                    count++;


                }

                first1 = Convert.ToInt32(firstnum);
                count = 0;
                while (length > count)
                {
                    if (count > positionofoperator)
                    {
                        secondnum = secondnum + input.ElementAt(count);
                    }
                    count++;

                }

                second1 = Convert.ToInt32(secondnum);

                truesum = first1 + second1;

                Console.WriteLine(input + " = " + truesum);
            }


            else if (input.Contains("-"))
            {

                
                Console.WriteLine("Subtraction");

                positionofoperator = input.IndexOf("-");
                length = input.Length;

                count = 0;
                while (positionofoperator > count)
                {

                    firstnum = firstnum + input.ElementAt(count);
                    count++;


                }

                first1 = Convert.ToInt32(firstnum);
                count = 0;
                while (length > count)
                {
                    if (count > positionofoperator)
                    {
                        secondnum = secondnum + input.ElementAt(count);
                    }
                    count++;

                }

                second1 = Convert.ToInt32(secondnum);

                truesum = first1 - second1;

                Console.WriteLine(input + " = " + truesum);
               
            }
            else if (input.Contains("*"))
            {

                 Console.WriteLine("Multiplication");


                positionofoperator = input.IndexOf("*");
                length = input.Length;

                count = 0;
                while (positionofoperator > count)
                {

                    firstnum = firstnum + input.ElementAt(count);
                    count++;


                }

                first1 = Convert.ToInt32(firstnum);
                count = 0;
                while (length > count)
                {
                    if (count > positionofoperator)
                    {
                        secondnum = secondnum + input.ElementAt(count);
                    }
                    count++;

                }

                second1 = Convert.ToInt32(secondnum);

                truesum = first1 * second1;

                Console.WriteLine(input + " = " + truesum);
            }

            else if (input.Contains("/"))
            {

                Console.WriteLine("Division");
                


                positionofoperator = input.IndexOf("/");
                length = input.Length;

                count = 0;
                while (positionofoperator > count)
                {

                    firstnum = firstnum + input.ElementAt(count);
                    count++;


                }

                first1 = Convert.ToInt32(firstnum);
                count = 0;
                while (length > count)
                {
                    if (count > positionofoperator)
                    {
                        secondnum = secondnum + input.ElementAt(count);
                    }
                    count++;

                }

                second1 = Convert.ToInt32(secondnum);

                truesum = first1 / second1;

                Console.WriteLine(input + " = " + truesum);

            }


            else
            {
                Console.WriteLine("Failure");
            }
        }

    }

    
}
public class Appinfo
{
    public static string AppName(string j)
    {
        string name = "Calcjet";
        string version = "1.0";
        string sum = name + " " + version;
        j = sum;
        return j;

        


    }
}
