# Write a function that takes the price of an item and the discount percentage, and calculates the price after the discount.

# --------------------------------------------------------------------------------------------------------------------------

def discount(x, y):
    new_price = x * (100 - y) / 100
    return new_price

a = int(input("Enter price : "))
b = int(input("Enter discount : "))
print("New price is ", discount(a, b))
