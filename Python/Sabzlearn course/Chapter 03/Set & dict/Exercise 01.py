# Suppose you are to create a real dictionary. Implement it using the dictionary data type.
# Ensure that the main word serves as the dictionary key, while the definitions—which may consist of more than one word—are obtained from the user.

#----------------------------------------------------------------------------------------------------------------------------------------------------

d = {}
k = input("Enter your word : ")
d[k]=[]
c = "yes"
while c == "yes" :
    meaning = input("meaning : ")
    d[k].append(meaning)
    c = input("Do you want to add more meaning ? ") 

print(d)