#include <iostream>
#include <cmath>
#include <iomanip>
using namespace std;


//function to evaluate f(x) = x^3 - x + 1
double f(double x)
{
    return pow(x,3) - x + 1;
}

//Check if f(a) and f(b) have opposits signs (Bolzano's theorem)
bool checkHypothesis(double Fa, double Fb)
{
    return (Fa * Fb) < 0 ? true : false;
}

//Bisection method - finds the root of f(x) in [a,b] with tollerance 0.01
double bisection_method(double a, double b)
{
    double Fa = f(a);
    double Fb = f(b);
    double c = 0;

    do
    {
        //calculate midpoint
        c = (a + b)/2;
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
    } while ((b - a) / 2 >= 0.01);

    return c;
}


int main()
{
    double a = 0;
    double b = 0;
    double temp = 0;

    //User input
    cout << "Enter the value of a: ";
    cin >> a;

    cout << "Enter the value of b: ";
    cin >> b;

    //Swap if b < a
    if(b < a)
    {
        temp = a;
        a = b;
        b = temp;
    }

    double Fa = f(a);
    double Fb = f(b);

    //Check hypothesis before calculating
    if(checkHypothesis(Fa,Fb))
    {
        double result = bisection_method(a,b);
        cout << "The approximate solution is: " << fixed << setprecision(5) << result << endl;
    }

    else
    {
        cout << "a and b do not satisfy the hypothesis of zero theorem" << endl;
    }
    return 0;
}