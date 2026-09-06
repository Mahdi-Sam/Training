# Write a generator to produce the Fibonacci sequence.

# ---------------------------------------------------

def fib():
    list = []
    list.append(1)
    yield list[0]
    list.append(1)
    yield list[1]
    i = 2
    while True :
        list.append(list[i -1] + list[i - 2])
        yield list[i]
        i +=1 

# a = int(input("Enter your number : "))
f = fib()
while True :
    print(next(f))
    y = input("Do you want to continue ?")
    if "y" not in y :
        break 

        

