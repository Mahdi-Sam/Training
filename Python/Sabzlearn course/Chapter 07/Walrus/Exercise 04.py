# Check whether a specific number—for example, 5—exists in a list. If it does, print its index (using the walrus operator).

# ------------------------------------------------------------------------------------------------------------------------

if (b := input("Enter your number : ")) in (a := input("Enter your list : ").split(",")):
    print("yes")
else:    
    print("no")


