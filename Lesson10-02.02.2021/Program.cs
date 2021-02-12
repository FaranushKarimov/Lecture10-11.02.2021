using System;

namespace Lesson10_02._02._2021
{
    class Program
    {
        delegate T Operations<T, U, Y>(U val1, Y val2);
        static void Main(string[] args)
        {
            bool working = true;
            string choices = "12345";

            while (working)
            {
                System.Console.Write(@"
                1. Minus
                2. Sum
                3. Multiply
                4. Division
                5. Exit
                Type reference number: ");

                int choice = int.Parse(Console.ReadLine());
                if (choice == 5)
                {
                    break;
                }
                if (choices.Contains(choice.ToString()))
                {


                    System.Console.Write("First number:");
                    string op1 = Console.ReadLine();
                    System.Console.Write("Second number:");
                    string op2 = Console.ReadLine();

                    op1 = op1.Replace('.', ',');
                    op2 = op2.Replace('.', ',');

                    double v1 = 0.0, v2 = 0.0;
                    int f1 = 0, f2 = 0;
                    if (double.TryParse(op1, out v1))
                    {
                        if (double.TryParse(op2, out v2))
                        {
                            Operations<double, double, double> del;
                            switch (choice)
                            {
                                case 1:
                                    {
                                        del = new Operations<double, double, double>(Calculator.minus);
                                        System.Console.WriteLine(del.Invoke(v1, v2));
                                    }
                                    break;
                                case 2:
                                    {
                                        del = new Operations<double, double, double>(Calculator.sum);
                                        System.Console.WriteLine(del.Invoke(v1, v2));
                                    }
                                    break;
                                case 3:
                                    {
                                        del = new Operations<double, double, double>(Calculator.mult);
                                        System.Console.WriteLine(del.Invoke(v1, v2));
                                    }
                                    break;
                                case 4:
                                    {
                                        del = new Operations<double, double, double>(Calculator.div);
                                        System.Console.WriteLine(del.Invoke(v1, v2));
                                    }
                                    break;
                            }
                        }
                    }
                    else if (int.TryParse(op1, out f1))
                    {
                        if (int.TryParse(op2, out f2))
                        {
                            Operations<int, int, int> del;
                            switch (choice)
                            {
                                case 1:
                                    {
                                        del = new Operations<int, int, int>(Calculator.minus);
                                        System.Console.WriteLine(del.Invoke(f1, f2));
                                    }
                                    break;
                                case 2:
                                    {
                                        del = new Operations<int, int, int>(Calculator.sum);
                                        System.Console.WriteLine(del.Invoke(f1, f2));
                                    }
                                    break;
                                case 3:
                                    {
                                        del = new Operations<int, int, int>(Calculator.mult);
                                        System.Console.WriteLine(del.Invoke(f1, f2));
                                    }
                                    break;
                                case 4:
                                    {
                                        del = new Operations<int, int, int>(Calculator.div);
                                        System.Console.WriteLine(del.Invoke(f1, f2));
                                    }
                                    break;
                            }
                        }
                    }
                }

            }

        }

    }
}
