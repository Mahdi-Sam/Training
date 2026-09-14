from data_analysis.statistics import *

a = list(map(int, input("Enter your numbers : ").split(",")))
print("The average of entered numbers is ", ave(a))
median(a)
standard_deviation(a)