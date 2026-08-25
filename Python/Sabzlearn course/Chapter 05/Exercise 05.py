# Write a program that takes an integer and displays the number of its digits.

# ---------------------------------------------------------------------------

x = int(input("Enter your number : "))
i = 0
while x > 0:
    x //= 10
    i += 1 
print("number of digits is", i)