# this file is used by me to understand how time works in Python

# from time import time
# import time
# now = str(time.gmtime(0))
# print(now)

# A = ["a","b","c","d"]
# z = input("enter a letter >> ")


# for i in A:
#     if z not in A:
#         print("not found")
#     else:
#         print(i)
#     break

origin = input("enter >> ")
A = ["EVV", "JVY", "IND"]
rai = True

if rai == True:
    for i in A:
        if origin == A[1]:
            print("origin: " + origin + " A[1]: " + str(A[1]))
        else:
            print("A[1]: " + str(A[1]))
        break