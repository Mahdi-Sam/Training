# Write a program that generates random numbers between 1 and 100. If the generated number is greater than 80, the program stops. 
# The number of generated numbers must be printed. (Use the walrus operator in the loop.)

# --------------------------------------------------------------------------------------------------------------------------

from random import randint

list = []
while (a := randint(1, 100)) <= 80 :
    list.append(a)
print(list)
print("length : ", len(list))