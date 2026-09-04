# Write a program that counts the even and odd numbers in a list of integers using lambda functions.

# --------------------------------------------------------------------------------------------------

a = list(map(int, input("Enter your numbers : ").split(",")))
even_count = len(list(filter(lambda x : x % 2 == 0 , a)))
odd_count = len(list(filter(lambda x : x % 2 == 1 , a)))
print(f"You entered {even_count} even numbers and {odd_count} odd numbers")