# Write a recursive function to reverse a string.

# ----------------------------------------------

def reverse(x):
    print(x[-1], end="")
    if len(x) == 1:
        return ""
    del x[-1]
    reverse(x) 

a = list(input("Enter your string :"))
reverse(a)
