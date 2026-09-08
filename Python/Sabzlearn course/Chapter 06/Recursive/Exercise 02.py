# Write a recursive function to calculate the power of a number.

# --------------------------------------------------------------

def pow(x, n):
    if n == 0 :
        return 1
    return pow(x, n -1) * x

a = int(input("Enter your number : "))
b = int(input("Enter your power : "))
print("Result : ", pow(a, b))