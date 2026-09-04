# Write a program using a lambda to determine whether a given string starts with a specific character.

# -----------------------------------------------------------------------------------------------------

a = input("Enter your word :")
b = input("Enter your character :")
f = lambda x : x[0] == b
print(f(a))

