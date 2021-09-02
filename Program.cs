using System;


namespace Calculator2
{
    public class CalculatorOperations
    {
        public double Add(double num1, double num2)
        {
            double res = num1 + num2;
            Console.WriteLine("Addition is = " + res);
            return res;
        }
    
    
        public double subs(double num1, double num2)
        {
            double res = num1 - num2;
            Console.WriteLine("Substraction is = " + res);
            return res;
        }
    
        public double mult(double num1, double num2)
        {
            double res = num1 * num2;
            Console.WriteLine("Multiplication is = " + res);
            return res;
        }
    
        public double Divi(double num1, double num2)
        {
            double res = num1 / num2;
            double mod = num1 % num2;
            Console.WriteLine("Quotiont is = " + res);
            Console.WriteLine("Reminder is = " + mod);
            return res;
        }
    
        public void eqa(double num1, double num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine(num1 + " is equal to " + num2);
            }
            else
            {
                Console.WriteLine(num1 + " is not eqaul to " + num2);
            }
        }
    
        public void great(double num1, double num2)
        {
            if (num1 > num2)
            {
                Console.WriteLine(num1 + " is gerater than " + num2);
            }
            else
            {
                Console.WriteLine(num2 + " is greater than " + num1);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;

            CalculatorOperations CO = new CalculatorOperations();



            char conf;

            do
            {
                Console.WriteLine("Press specific key to perform opertion from following operations");
                Console.WriteLine("Addition = 1");
                Console.WriteLine("Substraction = 2");
                Console.WriteLine("Multiplication = 3");
                Console.WriteLine("Devision = 4");
                Console.WriteLine("Equal = 5");
                Console.WriteLine("Greater = 6");

                int Var = Convert.ToInt32(Console.ReadLine());
                
                switch (Var)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter numbers1  :");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter numbers2  :");
                            b = Convert.ToDouble(Console.ReadLine());
                            CO.Add(a, b);
                            Console.WriteLine("For continue press Y for cancle press N");
                            conf = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Enter numbers1  :");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter numbers2  :");
                            b = Convert.ToDouble(Console.ReadLine());
                            CO.subs(a, b);
                            Console.WriteLine("For continue press Y for cancle press N");
                            conf = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Enter numbers1  :");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter numbers2  :");
                            b = Convert.ToDouble(Console.ReadLine());
                            CO.mult(a, b);
                            Console.WriteLine("For continue press Y for cancle press N");
                            conf = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Enter numbers1  :");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter numbers2  :");
                            b = Convert.ToDouble(Console.ReadLine());
                            CO.Divi(a, b);
                            Console.WriteLine("For continue press Y for cancle press N");
                            conf = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Enter numbers1  :");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter numbers2  :");
                            b = Convert.ToDouble(Console.ReadLine());
                            CO.eqa(a, b);
                            Console.WriteLine("For continue press Y for cancle press N");
                            conf = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Enter numbers1  :");
                            a = Convert.ToDouble(Console.ReadLine());
                            Console.WriteLine("Enter numbers2  :");
                            b = Convert.ToDouble(Console.ReadLine());
                            CO.great(a, b);
                            Console.WriteLine("For continue press Y for cancle press N");
                            conf = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Select correct option, Thank you!!"); 
                            Console.WriteLine("For continue press Y for cancle press N");
                            conf = Convert.ToChar(Console.ReadLine());
                            break;
                        }
                }
            } while(conf == 'Y');
            {
                Console.WriteLine("Thank You!!!!");
            }
           }
    }
}
