import os

filename = input("Enter a file name >> ")
text = input("Enter text to save to the file >> ")

dirpath = os.getcwd()
print(dirpath)

a = open("files/cars/" + filename + "_car.txt", "a")
a.write(text)
a.close()