# take a string from the user and then print the number of sentences, the number of words, the total number of characters (such as letters, spaces, periods, commas, etc.), and the number of English letters (such as a, b, c, etc.).

# ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

string = input("Enter your string : ")

sentenceCount = 0
wordCount = len(string.split())
charCount = len(string)
engletCount = 0

for i in string:
    if i in ".?!":
        sentenceCount += 1

    if "a" <= i.lower() <= "z":
        engletCount += 1

print(
    f"number of sentences : {sentenceCount}\n"
    f"number of words : {wordCount}\n"
    f"number of all characters : {charCount}\n"
    f"number of English letters : {engletCount}"
)
