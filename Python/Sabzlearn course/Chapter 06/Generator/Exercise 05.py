# Write an infinite generator for even or odd numbers; the choice between even or odd is determined by the user.

# --------------------------------------------------------------------------------------------------------------

def infinite(x):
    i = 0
    while True:
        if x == "even":
            yield i
        elif x == "odd":
            yield i + 1
        i += 2

a = input("even or odd ? ")
i = infinite(a)
answer = "yes"
while "y" in answer :
    print(next(i))
    answer = input("Do you want to continue ? ")

