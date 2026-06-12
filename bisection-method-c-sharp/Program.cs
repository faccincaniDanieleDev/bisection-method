namespace bisection_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double temp = 0;

            //user input
            Console.WriteLine("Enter the value of a: ");
            while(!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input. Enter a valid number: ");
            }

            Console.WriteLine("Enter the value of b: ");
            while(!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Enter a valid number: ");
            }

            //swap b < a
            if(b < a)
            {
                temp = a;
                a = b;
                b = temp;
            }

            double Fa = f(a);
            double Fb = f(b);

            //check hypothesis before calculating
            if(checkHypothesis(Fa,Fb))
            {
                double result = bisectionMethod(a,b);
                Console.WriteLine("The approximate solution is: " + result.ToString("F5"));
            }

            else
            {
                Console.WriteLine("a and b do not satisfy the hypotesis of zero theorem");
            }

        }

        // Function to evaluate f(x) = x^3 - x + 1
        public static double f(double x)
        {
            return Math.Pow(x,3) - x + 1;
        }

        // Check if f(a) and f(b) have opposite signs (Bolzano's theorem)
        public static bool checkHypothesis(double Fa, double Fb)
        {
            return (Fa * Fb) < 0 ? true : false;
        }

        // Bisection method - finds the root of f(x) in [a, b] with tolerance 0.01
        public static double bisectionMethod(double a, double b)
        {
            double Fa = f(a);
            double Fb = f(b);
            double c = double.NaN;

            do
            {
                //calculate midpoint
                c = (a + b) / 2;
                double Fc = f(c);

                //extract root found
                if(Fc == 0)
                {
                    break;
                }

                else
                {
                    //narrow the interval
                    if(checkHypothesis(Fa,Fc))
                    {
                        b = c;
                        Fb = f(b);
                    }

                    else
                    {
                        a = c;
                        Fa = f(a);
                    }
                }
            }while((b - a) / 2 >= 0.01);

            return c;
        }
    }
}
