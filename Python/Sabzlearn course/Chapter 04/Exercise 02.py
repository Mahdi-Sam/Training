# Get the lengths of a triangle's sides from the user and determine whether they form a triangle. If they do, what type of triangle is it?

# ----------------------------------------------------------------------------------------------------------------------------------------

x, y, z = map(int, input("Enter your size of sides: ").split(","))
if x <= 0 or y <= 0 or z <= 0:
    print("Side lengths must be positive.")
elif (x + y <= z) or (x + z <= y) or (y + z <= x):
    print("These sizes could not be sides of a triangle.")
elif x == y == z:
    print("This is an equilateral triangle.")

elif (
    (x**2 + y**2 == z**2) or
    (x**2 + z**2 == y**2) or
    (y**2 + z**2 == x**2)
):
    if (x == y) or (x == z) or (y == z):
        print("This is an right-angled-isosceles triangle.")
    else :
        print("This is a right-angled triangle.")

elif (x == y) or (x == z) or (y == z):
    print("This is an isosceles triangle.")

else:
    print("This is a scalene triangle.")
