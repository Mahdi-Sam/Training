# If a list has more than 5 elements, print the sum of its first two elements (use the walrus operator).

# -----------------------------------------------------------------------------------------------------

if (len(a := list(map(int, input("Enter your numbers : ").split(","))))) > 5:
    print(a[0], "+", a[1], "=", a[0] + a[1])
else:
    print("Length is less than 5")