from os import kill
import string
import sys
while True:
    # get user input
    inp = input("Enter a word you want represented with numbers (enter '-' to end) >>> ")
    if inp is "-":
        sys.exit()
    else:
        # convert input to lowercase
        inp = inp.lower()
        # converts input into list so that we can individually change each number
        outList = []
        for x in inp:
            # figures out corresponding number to each letter in inp
            outList.append(ord(x) - 96)
        # converts list to string so that it shows up normally for user
        out = ''.join(str(e) for e in outList)
        # print(outList)
        print("Your entry of ",inp," corresponds to ", out , " in number form.")