# Write a program that filters a list of integers into even and odd numbers using lambda functions.

# ------------------------------------------------------------------------------------------------

a = list(map(int, input("Enter your numbers : ").split(",")))
print("even list :", list(filter(lambda x : x % 2 == 0 , a)))
print("odd list :", list(filter(lambda x : x % 2 == 1 , a)))