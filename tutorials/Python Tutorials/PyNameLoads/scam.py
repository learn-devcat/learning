import os
import random
import string
import json

fNamesPath = 'C:\\Users\\rcorley\\Desktop\\RandomFirstNames.py'
lNamesPath = 'C:\\Users\\rcorley\\Desktop\\RandomLastNames.py'
chars = string.ascii_letters + string.digits + '!@#$%^&*()'
random.seed = (os.urandom(1024))

fnames = json.loads(open(fNamesPath).read())

lnames = json.loads(open(lNamesPath).read())

for name in names:
    extra_chars = ''.join(random.choice(string.digits))
    full_name = fnames + ' ' + lnames
    email = fnames[:1].lower() + lnames.lower() + extra_chars + '@gmail.com'

print('Fullname: %s' % (full_name))
print('Email Address: %s' % (email))
