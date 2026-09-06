# Write a generator that takes a list and returns the sum of its elements (adding one new element at a time).

# -----------------------------------------------------------------------------------------------------------

def add(x):
    sum = 0
    for i in x:
        i = int(i)
        sum += i 
        yield sum 

a = list(input("Enter your numbers : ").split(","))
for i in add(a):
    print(i)

