# We have two different lists of phone numbers belonging to various individuals. Some numbers may appear in both lists.
# Create a new list that combines the two previous ones but excludes any duplicates.

# ----------------------------------------------------------------------------------------------------------------

list1 = ["0939", "0912", "0910"]
list2 = ["0936", "0912", "0903"]
s = set(list1 + list2)
print(s)
