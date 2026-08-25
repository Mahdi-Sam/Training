# Write a program that takes two integers as input and displays their least common multiple.

# --------------------------------------------------------------------------------------------

x, y = map(int, input("Enter two numbers : ").split(","))
lx, ly = set(), set()

for i in range(1, x + 1):
    if x % i == 0:
        lx.add(i)
for i in range(1, y + 1):
    if y % i == 0:
        ly.add(i)

print(x * y / max(lx & ly))
