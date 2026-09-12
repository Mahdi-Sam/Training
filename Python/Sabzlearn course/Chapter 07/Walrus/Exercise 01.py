# Take a string and print its length if it is greater than 10 (use the walrus operator).

# --------------------------------------------------------------------------------------

if len(a := input("Enter your string : ")) > 10:
    print("it is more than 10")
else:
    print("it is less than 10")
