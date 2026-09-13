# Get a sentence from the user and print its word count using the walrus operator.

# -------------------------------------------------------------------------------

print("The sentence has",(a := input("Enter your sentence : ")).count(" ") + 1 , "words")