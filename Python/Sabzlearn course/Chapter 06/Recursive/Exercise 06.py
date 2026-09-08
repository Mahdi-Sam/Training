# Write a recursive function to calculate the sum of the digits of a positive integer.

# ------------------------------------------------------------------------------------

def counter(x):
    if x < 0 :
        # print()
        return f"{x} is negetive"
    if x // 10 != 0 :
        # print()
        return counter(x // 10) + (x % 10)
    else :
        # print()    
        return x % 10

a = int(input("Enter your number : "))
print(counter(a))

    