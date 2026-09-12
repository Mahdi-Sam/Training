# Write a program that calculates the sum of numbers entered by the user.
# The program should continue until the user enters an empty string (use the walrus operator).

# ------------------------------------------------------------------------------------------------

list = []
while True:
    if (a := input("Enter your number : ")).isalnum():
        list.append(int(a))
    else:
        break
print("sum = ", sum(list))
