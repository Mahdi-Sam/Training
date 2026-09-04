# Write a program using lambda to square and cube each number in a list of integers.

# ---------------------------------------------------------------------------------

a = list(map(int, input("Enter your numbers : ").split(",")))
square = list(map(lambda x : x ** 2, a))
cube = list(map(lambda x : x ** 3, a))
print("square list :", square)
print("cube list :", cube)
