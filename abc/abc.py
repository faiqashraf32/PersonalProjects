import string

# get user input
inp = input("Enter a word you want represented with numbers >>> ")

# convert input to lowercase
inp = inp.lower()
# converts input into list so that we can individually change each number
outList = []
for x in inp:
   outList.append(ord(x) - 96)
out = ''.join(str(e) for e in outList)
# print(outList)
print("Your entry of ",inp," corresponds to ", out , " in number form.")