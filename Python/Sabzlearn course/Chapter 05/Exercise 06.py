# Write a program that takes the number of rows from the user and draws the following shape:
#     *
#     **
#     ***
#     ****
#     *****

# ----------------------------------------------------------------------------------------------

x = int(input("Enter your number : "))
for i in range(x + 1):
    for i in range(i):
        print("*", end="")
    print("\n")
