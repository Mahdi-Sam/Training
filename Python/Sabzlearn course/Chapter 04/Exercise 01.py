# Get a number from the user and check whether it is divisible by both 2 and 5.

# --------------------------------------------------------------------------------

x = int(input("Enter your number : "))
if (x % 2 == 0) & (x % 5 == 0):
    print(x, "is divisible by 2 & 5")
else:
    print(x, "is not divisible by 2 & 5")
