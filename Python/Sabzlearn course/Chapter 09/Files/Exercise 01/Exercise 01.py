# Write a program that takes input from the user and saves it to a file named `output.txt`. 
# The program should continue accepting input until the user enters the word "exit".

# -----------------------------------------------:-------------------------------------------
from pathlib import Path

file_path = Path(__file__).parent / "output.txt"

while (x := input("Enter something: ")) != "exit":
    with open(file_path, "a") as f:
        f.write(x + "\n")

with open(file_path, "r") as f:
    print(f.read())

    