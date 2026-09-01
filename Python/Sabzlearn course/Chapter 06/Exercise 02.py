# Write a function that performs the same task as the built-in `max` and `min` functions.

# ----------------------------------------------------------------------------------------

def maxnum(x:list):
    for i in range(len(x) - 1) : 
        if x[i] > x[i + 1] :
            x[i], x[i + 1] = x[i + 1], x[i]
    print(x[len(x)-1])

def minnum(x:list):
    for i in range(len(x) - 1, 0, -1):
        if x[i] < x[i - 1]:
            x[i], x[i - 1] = x[i - 1], x[i]
    print(x[0])

a = list(map(int, input("Enter your numbers :"). split(",")))
maxnum(a)
minnum(a)