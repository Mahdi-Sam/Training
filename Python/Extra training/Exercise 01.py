from functools import wraps

def dec(func):
    @wraps(func)
    def wrapper (*args, **kwargs):
        print("*" * 10)
        value = func(*args, **kwargs)
        print("*" * 10)
        return value
    return wrapper

@dec 
def hello(x, y, z):
    print(f"hi, my name is {x} {y} and i am {z} years old")

hello(input("Enter your name : "), input("Enter your lastname : "), input("Enter your age : "))

