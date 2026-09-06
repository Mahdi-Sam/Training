# Write a generator that takes a string and returns its reverse (one character at a time).

# ----------------------------------------------------------------------------------------

def reversed(x):
    i = len(x) - 1
    while i >= 0 :
        yield x[i]
        i -= 1

a = input("Enter your string : ")
r = reversed(a)
for i in range(len(a)) :
    try :
        print(next(r), end = "")
    except:
        StopIteration

    
    
