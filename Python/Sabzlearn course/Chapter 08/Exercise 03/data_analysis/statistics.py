from math import sqrt
from decimal import Decimal
def ave(list):
    return round(sum(list) / len(list), 2)

def median(list):
    list = sorted(list)
    if len(list) % 2 == 1:
        print("Median of entered numbers is ", list[len(list) // 2])
    else: 
        print("Median of entered numbers is ", (list[len(list) // 2] + list[(len(list) // 2) - 1]) / 2)

def standard_deviation(list):
    y = 0
    for i in list:
        y += (i - ave(list)) ** 2
    print("Standard deviation of entered numbers is ", round(Decimal(sqrt(y / len(list))), 2))
        