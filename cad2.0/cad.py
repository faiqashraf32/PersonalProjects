
from datetime import datetime
from datetime import date
import os.path


class CADSYS:
    import os
    path = os.getcwd()
    print("\n\n\n\n" + path + "\n\n\n\n")
    path = "/Users/faiqashraf/Desktop/github site/PersonalProjects/cad2.0"
    print("\n\n\n\n" + path + "\n\n\n\n")

    def login(self):
        


        print("Welcome to CAD. Login Screen. \n")
        # uName = input("Username >> ")
        # uNames = ["e1ectricpancake", "contract56", "choclateairlines95", "admin"]
        # if uName == "quit" or uName == "logout" or uName == "exit":
        #     exit()
        # elif uName not in uNames:
        #     print("Username not found. Try again.\n")
        #     a.login()
        # else:
        now = datetime.now()
        dt = now.strftime("%d/%m/%Y %H:%M:%S")
        print("Logged in successfully. Current log on: ",dt,"\n")
        # cop or crook
        coc = input("What do you want to do? 1 for cop, 2 for criminal. 3 to quit. ")
        if coc == "1":
            a.cop()
        elif coc == "2":
            a.criminal()
        elif coc == "3":
            exit()
                
    def cop(self):
        print("Welcome to the cop screen you upstanding law person\n")
        print("To look up a civilian in the database, enter 1.\nTo look up a license plate in the database, enter 2.\nTo switch to criminal mode, enter 3.\nTo quit the program, enter 4.\n")
        choice = input("Make a decision >> ")
        # path for files:
        # /Users/faiqashraf/Desktop/github site/PersonalProjects/cad2.0/files/cars/MAKE_MODEL_civ_car.txt
        if choice == "1":
            # look up civilian
            name = input("Who are we looking up in the database? >> ")
            # first, we need to determine what the file is called, luckily, we know the path to be:
            # /Users/faiqashraf/Desktop/github site/PersonalProjects/cad2.0/files/people/NAMEOFCRIMINAL_criminal.txt
            # so lets tell the computer to look there:
            filename = a.path + "/files/people/"+ name + "_civilian.txt"
            # print("File name is = " + filename)
            # now lets see if a file exists with that person
            try:
                f = open(filename)
                # great we found it, lets reveal its contents
                print("-------------------------")
                s = f.read() # read file contents
                print(s) # print file contents
                print("-------------------------")
                f.close()
            except IOError:
                # no file found, sad, so sad
                print("No such record was found. Try again.\n")
                a.cop()
            finally:
                # close the file. release from memory
                a.cop()

        elif choice == "2":
            # look up license plate
            # get license plate number
            plate = input("What is the license plate number? >> ")
            # tell the computer where to look for the record
            filename = a.path + "/files/people/"+ plate + "_civ_car.txt"
             # now lets see if a file exists with that person
            try:
                f = open(filename)
                # great we found it, lets reveal its contents
                print("-------------------------")
                s = f.read() # read file contents
                print(s) # print file contents
                print("-------------------------")
            except IOError:
                # no file found, sad, so sad
                print("No such record was found. Try again.\n")
                a.cop()
            finally:
                # close the file. release from memory
                f.close()
                a.cop()

        elif choice == "3":
            # switch to criminal mode
            for x in range(1, 50): # clear the console
                print(" ")
            a.criminal()
            pass
        elif choice == "4":
            # exit the program
            exit()


    def criminal(self):
        print("Welcome to criminal screen, you filthy animal.\n")
        print("To create a new character, enter 1.\nTo edit an existing character, enter 2.\nTo register a vehicle, enter 3.\nTo switch to cop, enter 4.\nTo quit, enter 5.\n")
        coc = input("Make a choice >> ")
        if coc == "1":
            # create new character
            print("Let's make a new character, shall we? \n")
            name = input("What is their name? >> ")
            dob_year = input("What year were they born? >> ")
            dob_month = input("What month were they born in? >> (1 = Jan, 2 = Feb, 3 = Mar, 4 = Apr, 5 = May, etc)")

            needToConvert = ["1","2","3","4","5","6","7","8","9"]

            # convert for function-friendly input
            if dob_month in needToConvert:
                dob_month = "0" + dob_month

            dob_day = input("What day were they born on? >> ")

            # convert for function-friendly input
            if dob_day in needToConvert:
                dob_day = "0" + dob_day

            # age = input("How old are they? >> ")
            # calculate age
            today = date.today()
            age = today.year - int(dob_year) - ((today.month, today.day) < (int(dob_month), int(dob_day)))
            print("\nWith that birthdate, their age is: " + str(age))

            dob = dob_month + " / " + dob_day + " / " + dob_year # dob for the file
            gender = input("What is their gender? >> ")
            lstati = input("What is their license status? [Options: 1 = Valid, 2 = Suspended, 3 = Revoked, 4 = Permit]>> ")
            if lstati == "1":
                lstat = "Valid"
            elif lstati == "2":
                lstat = "Suspended"
            elif lstati == "3":
                lstat = "Revoked"
            elif lstati == "4":
                lstat = "Permit"
            else:
                print("Entry invalid, lets just assume that it is valid...\n")
                lstat = "valid"
            wanted = input("Are they wanted? If so, what are they wanted for? (Please separate all crimes by comma)>> ")
            location = a.path + "/files/people/"+ name + "_civilian.txt" # save location for file
            # save new character to text file
            pf = open(location, "a")
            pf.write("\n")
            pf.write("Name: " + name)
            pf.write("\n")
            pf.write("Gender: " + gender)
            pf.write("\n")
            pf.write("Age: " + str(age))
            pf.write("\n")
            pf.write("Date of birth: " + dob)
            pf.write("\n")
            pf.write("License Status: " + lstat)
            pf.write("\n")
            pf.write("Wanted Status: " + wanted)
            pf.write("\n")
            pf.close()
            print("File created sucessfully.\n")
            a.criminal()
        elif coc == "2":
            # edit a record
            pass
        elif coc == "3":
            # register a vehicle
            # get input
            make = input("What is the make of the car? >> ")
            model = input("What is the model of the car? >> ")
            lp = input("What is the license plate number? >> ")
            ro = input("Who is the registered owner of the car? >> ")
            insur = input("What is the vehicle insurance status? [1 = Valid, 2 = Expired, 3 = Not Insured] >> ")
            if insur == "1":
                insur = "Valid"
            elif insur == "2":
                insur = "Expired"
            elif insur == "3":
                insur = "Not Insured"
            else:
                print("Invalid entry. Lets assume that they have valid insurance")
                insur = "Valid"
            notes = input("Anything else we need to know about the car? >> ")
            ploco = a.path + "/files/people/"+ lp + "_civ_car.txt" # plate location = ploco
            # write file for vehicle
            cf = open(ploco, "a")
            cf.write("\n")
            cf.write("Make: " + make)
            cf.write("\n")
            cf.write("Model: " + model)
            cf.write("\n")
            cf.write("Registered Owner: " + ro)
            cf.write("\n")
            cf.write("Insurance Status: " + insur)
            cf.write("\n")
            cf.write("Notes: " + notes)
            cf.write("\n")
            cf.close()
            a.criminal()
        elif coc == "4":
            # switch to cop mode
            for x in range(1, 50): # clear the console
                print(" ")
            a.cop()
        elif coc == "5":
            # quit
            exit()

if __name__ == "__main__":
    a = CADSYS()
    a.login()