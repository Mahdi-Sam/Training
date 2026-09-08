# Write a recursive function to count the number of occurrences of an element in a list.

# -------------------------------------------------------------------------------------

def counter(lst, x):
    if lst == []:
        return 0
    if lst[0] != x:
        del lst[0]
        return counter(lst, x)
    del lst[0]
    return counter(lst, x) + 1

a = list(input("Enter your list : ").split(","))
b = input("Enter your element : ")
print(counter(a, b))