# Write a recursive function to calculate the sum of the elements in a list.

# -------------------------------------------------------------------------
def rev_len(x):
    if x == [] :
        return 0
    del x[0]
    return rev_len(x) + 1
  

a = list(input("Enter your list : ").split(","))
print(rev_len(a))

