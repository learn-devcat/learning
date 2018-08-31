import os
import random
import string
import json

chars = string.ascii_letters + string.digits + '!@#$%^&*()'
random.seed = (os.urandom(1024))

firstNames = json.loads(open('fNames.json').read())
lastNames = json.loads(open('lNames.json').read())

fName, lname = [], []

for fname in firstNames:
    fn = fname.lower()

for lname in lastNames:
    ln = lname.lower()

fullName = [{"Name: ": fn, ln} for fn, ln in zip(fName, lName)]

print(fullName)