# Write a program that takes two numbers from the user and displays the numbers between them.

# -------------------------------------------------------------------------------------------

x, y = map(int, input("Enter two numbers : ").split(","))
if x == y:
    print("They are equal")
elif x < y:
    for i in range(x + 1, y):
        print(i, end=" ")
elif y < x:
    for i in range(y + 1, x):
        print(i, end=" ")
