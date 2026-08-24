# Now, based on the previous exercise , add a feature to the program that accepts a word from the user, retrieves its meanings from the dictionary, and displays them.

#----------------------------------------------------------------------------------------------------------------------------------------------------

d = {}
k = input("Enter your word : ")

d[k]= input("meanings : ").split(",")

k = input("Enter your word : ")
d[k] = meaning = input("meanings : ").split(",")

print(d)

word = input("choose your word in dictionary : ")
print("meanings : " , d[k])