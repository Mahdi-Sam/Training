# Write a function that reads a character and determines whether it is a digit, an uppercase letter, lowercase letter, or another symbol.

# ---------------------------------------------------------------------------------------------------------------------

def type(x):
    if 48 < ord(x) < 58:
        print(x, "is a number")
    elif 65 < ord(x) < 91:
        print(x, "is an upprcase letter")
    elif 97 < ord(x) < 123:
        print(x, "is a lowercase letter")
    else :
        print(x, "is a symbol")

a = input("Enter your character :")
type(a)