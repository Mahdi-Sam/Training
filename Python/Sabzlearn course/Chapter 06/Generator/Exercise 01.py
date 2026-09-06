# Implement the behavior of `enumerate` using a generator.

# -------------------------------------------------------

def gen_enum(x : list):
    for i in range(len(x)) :
        yield i ,  x[i]

a = list(input("Enter your list :").split(","))
g = gen_enum(a)
while True :
    print(next(g))
    y = input("Do you want to continue ? ")
    if "y" not in y :
        break 

