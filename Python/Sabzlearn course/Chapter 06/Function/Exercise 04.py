# Write a function that takes a number as input and determines whether it is a perfect square or not.

# ---------------------------------------------------------------------------------------------------

import math
def sqrt_(x): 
    if math.sqrt(x) * math.sqrt(x) == x :
        print(x, "is perfect square.")
    else:
        print(x, "is not perfect square.")

a = float(input("Enter your number :"))
sqrt_(a)