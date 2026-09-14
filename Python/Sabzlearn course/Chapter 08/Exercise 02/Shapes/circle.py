from decimal import Decimal
def area(r):
    print("circle area : ", round(2 * 3.14 * r, 2))

def perimeter(r):
    print("circle perimeter : ", round(Decimal(3.14 * (r ** 2)), 2))