# Write a function that performs the same task as the built-in `len` function.

# -----------------------------------------------------------------------------

def len_(x):
    i = 0
    while id(x[-(i+1)]) != id(x[0]):
        i += 1
    print("The length is", i+1)

a = input("Enter your input : ")
len_(a)
