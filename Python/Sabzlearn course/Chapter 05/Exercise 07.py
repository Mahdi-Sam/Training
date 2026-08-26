# We have a list of ten different names. Write a program that asks the user to think of one of the names, 
# and then tries to guess which name it is. The program should then ask the user whether its guess was correct.
# If the guess is wrong, it should guess another name.
# The program must not guess a name that the user has already said was incorrect.
# For example, suppose our list contains **A, B, and C**. The user chooses **A** in their mind.
# The program guesses **B** and asks, “Did I guess correctly?” The user says, “No.”
# The program then guesses **A** and asks, “Did I guess correctly?”
# The user says, “Yes,” and the program ends.

# ----------------------------------------------------------------------------------------------------------------

from random import choice
list = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J"]
print("Choose a letter from this list", list)
answer = "no"
while answer == "no" :
    print("is that letter", letter := choice(list), "?" , end=" ")
    answer = input()
    if answer == "yes":
        print("hooooooraaaaa")
    else :
        list.remove(letter)




