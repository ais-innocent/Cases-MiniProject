import re

def lower_first(word):
    return word[0].lower() + word[1:]

def upper_first(word):
    return word[0].upper() + word[1:]

def is_snake_case(name):
    return name.find('_') != -1

def to_snake_case(name):
    return re.sub("([A-Z])", "_\\1", name).lower()

def to_camel_case(name):
    return lower_first("".join(upper_first(part) for part in name.split('_')))

while (True):
    name = input()
    if(is_snake_case(name)):
        print(to_camel_case(name))
    else:
        print(to_snake_case(name))