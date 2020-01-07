# import the os module
import os

class Grade:
    grade = ""
    # detect the current working directory and print it
    path = os.getcwd() + "/gradeCalc/gradeLogs/"
    print ("The current working directory is %s\n" % path)
    print("\nWelcome to grade calculator\n")
    print("Select a class.\n")

    def mainMenu(self):
        pass

        


    def enterWeights(self):
        # get weights
        print("Hello World")

    def enterData(self):
        className = input("Enter a class name >> ")
        entry = ""
        while entry != "bye":
            print("Enter bye to exit")
            entry = input("Enter catagory >> ")
            try:
                a.path = a.path + entry + "/"
                os.mkdir(a.path)
                temp = entry
                entry = ""
            except OSError:
                print ("Creation of the directory %s failed" % a.path)
                entry = ""
            else:
                print ("Successfully created the directory %s " % a.path)
                temp = entry
                entry = ""
            entry = input("Enter grade weight >> ")

            try:
                a.path = a.path + className + "_weights.txt"
                f = open(a.path, "w")
                f.write("Grading information for: " + className)
                f.write("Catagory = " + temp)
                f.write("Weight = " + entry)
            except OSError:
                print ("Creation of the file %s failed" % a.path)
            else:
                print ("Successfully created the file %s " % a.path)
                f.close()
            




if __name__ == "__main__":
    a = Grade()
    a.enterData()