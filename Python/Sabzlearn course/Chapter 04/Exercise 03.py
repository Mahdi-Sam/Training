# Get a character from the user and determine whether the entered character is a digit, an English letter, or another symbol.

# ---------------------------------------------------------------------------------------------------------------------------

x = input("Enter your character : ")
if 48 <= ord(x) < 58 :
    print(x ,"is a number ")
elif 65 <= ord(x) < 91 or 97 <= ord(x) < 123 :
    print(x , "is a letter ")
else :
    print(x ,"is a symbol")