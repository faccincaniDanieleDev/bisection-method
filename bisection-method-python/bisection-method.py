import math

#function to evaluate f(x) = x^3 - x + 1
def f(x: float) -> float:
    return math.pow(x,3) - x + 1

#Check if f(a) and f(b) have opposite signs (Bolzano's theorem)
def checkHypothesis(Fa: float, Fb: float) -> bool:
    return (Fa * Fb) < 0

#Bisection method - finds the root of f(x) in [a, b] with tolerance 0.01
def bisection_method(a: float, b: float) -> float:
    
    Fa = f(a)
    Fb = f(b)
    c = 0
     
    while True:
        
        #Calculate midpoint
        c = (a + b) / 2
        Fc = f(c)
        
        #Extract root found
        if Fc == 0:
            break
        
        else:
            #Narrow the interval
            if checkHypothesis(Fa,Fc):
                b = c
                Fb = f(b)
                
            else:
                a = c
                Fa = f(a)
                
            
        
        if (b - a) / 2 <= 0.01:
            break
        
    return c



def main() -> None:
    
    a = 0
    b = 0
    temp = 0
    
    while True:
        try:
            a = float(input("Enter a value of a: "))
            break
        
        except ValueError:
            print("Invalid input. Enter a valid number: ")
            
            
    while True:
        try:
            b = float(input("Enter a value of b: "))
            break
        
        except ValueError:
            print("Invalid input. Enter a valid number: ")
            
            
    #Swap if b < a
    if b < a:
        temp = a
        a = b
        b = temp
        
    Fa = f(a)
    Fb = f(b)
    
    #Check hypothesis before calculating
    if checkHypothesis(Fa,Fb):
        result = bisection_method(a,b)
        print(f"The approximate solution is: {result:.5f}")
        
    else:
        print("a and b do not satisfy the hypothesis of the zero theorem")
        
        
        
if __name__ == "__main__":
    main()
            
    

