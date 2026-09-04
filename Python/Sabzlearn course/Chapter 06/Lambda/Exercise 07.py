# Write a program using a lambda function to check whether a given string is numeric (note that we want decimal strings, such as "4.5", to be recognized as well).

# ----------------------------------------------------------------------------------------------------------------------------------------------------------------

a = input("Enter your string :")
b = lambda x : True if x.isdigit() or x.replace(".","").isdigit() else False
print(b(a))
