# Write a function that performs the same task as the built-in `sum` function.

# ----------------------------------------------------------------------------

def sum_(x : list):
    sum = 0 
    for i in range(0, len(x)):
        sum += x[i]
    return sum

a = list(map(int, input("Enter your numbers :").split(","))) 
print("sum =", sum_(a))

