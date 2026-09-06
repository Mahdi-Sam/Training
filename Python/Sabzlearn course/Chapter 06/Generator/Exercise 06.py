# Create a generator that produces the following outputs at each step:
# First time:  1
# Second time: 2 2
# Third time:  3 3 3
# And so on...

# --------------------------------------------------------------------

def operator():
    i = 1
    while True:
        yield (str(i) + " ") * i
        i += 1


op = operator()
answer = "yes"
while "y" in answer:
    print(next(op))
    answer = input("Do you want to continue ? ")
