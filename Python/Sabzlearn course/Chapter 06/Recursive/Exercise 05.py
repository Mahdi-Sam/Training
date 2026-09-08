# Write a recursive function to check whether a string is a palindrome (reads the same from both directions).

# ----------------------------------------------------------------------------------------------------------

def ispal(x):
    if len(x) == 0 or len(x) == 1:
            print("It is palindrome")
            return
    if x[0] == x[len(x) - 1]:
        del x[0]
        del x[len(x) - 1]
        ispal(x)
    else :
        print("It is not palindrome")
        return  

a = list(input("Enter your string :"))
ispal(a)