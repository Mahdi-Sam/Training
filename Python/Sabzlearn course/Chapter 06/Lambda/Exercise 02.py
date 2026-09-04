# We have a list of tuples in the format [("Ali", 93), ("Reza", 65), ...]. Write a program using a lambda function to sort this list based on the numbers contained in the tuples.

# ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

list = [("Ali", 93), ("Reza", 65), ("Mahdi", 27), ("Shahin", 42), ("Maryam", 19)]
a = sorted(list, key = lambda x : x[1])
print(a)