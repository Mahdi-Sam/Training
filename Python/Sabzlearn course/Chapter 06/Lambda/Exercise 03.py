# We have a list of dictionaries in the format [{"name": "apple", "weight": 50, "color": "red"}, ...]. Write a program using a lambda function to sort this list based on the color specified in the dictionaries.

# ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

list = [{"name": "apple", "weight": 60, "color": "red"},
        {"name": "banana", "weight": 90, "color": "yellow"},
        {"name": "coconut", "weight": 50, "color": "brown"},
        {"name": "grape", "weight": 30, "color": "purple"},
        ]
list.sort(key = lambda x : x["color"] )
print(list)