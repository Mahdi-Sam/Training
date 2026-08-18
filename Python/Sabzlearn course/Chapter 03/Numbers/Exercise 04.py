# Write a program that takes three numbers and prints their average.

# ------------------------------------------------------------------

x, y, z = map(int, input("Enter 3 numbers : ").split(" "))
print(f"The average of {x} , {y} , {z} is {round((x + y + z) / 3, 2)}")
