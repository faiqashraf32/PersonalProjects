
from datetime import datetime
from datetime import date
import os.path


class CADSYS:
    def login(self):
        print("Main Menu\n")
        uName = input("Username >> ")
        uNames = ["e1ectricpancake", "contract56", "choclateairlines95", "admin"]
        if uName not in uNames:
            print("Username not found. Try again.\n")
            a.login()
        else:
            now = datetime.now()
            dt = now.strftime("%d/%m/%Y %H:%M:%S")
            print(uName, " Logged in successfully. Current log on: ",dt,"\n")
            # cop or crook
            coc = input("What do you want to do? 1 for cop, 2 for criminal. ")
            if coc == "1":
                a.cop()
            elif coc == "2":
                a.criminal()
    def cop(self):
        print("Welcome to the cop screen you upstanding law person\n")
        # cop screen


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
            dob_day = input("What day were they born on? >> ")
            age = input("How old are they? >> ")
            # calculate age
            # birthDate = int(dob_year) + int(dob_day) + int(dob_month)
            # days_in_year = 365.2425    
            # agei = int((date.today() - birthDate).days / days_in_year) 
            # age = str(agei)
            # print("So that means that their age is = ", age)
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



            # save new character to text file
            pf = open("files/people/" + name + "_civilian.txt", "a")
            pf.write("\n")
            pf.write("Name: " + name)
            pf.write("\n")
            pf.write("Gender: " + gender)
            pf.write("\n")
            pf.write("Age: " + age)
            pf.write("\n")
            pf.write("Date of birth: " + dob)
            pf.write("\n")
            pf.write("License Status: " + lstat)
            pf.write("\n")
            pf.write("Wanted Status: " + wanted)
            pf.write("\n")
            pf.close()
            print("File created sucessfully.")
            a.criminal()
        elif coc == "2":
            # edit a record
            pass
        elif coc == "3":
            # register a vehicle
            # get input
            make = input("What is the make of the car? >> ")
            model = input("What is the model of the car? >> ")
            ro = input("Who is the registered owner of the car? >> ")
            insur = input("What is the vehicle insurance status? [Valid, Expired, Not Insured] >> ")
            notes = input("Anything else we need to know about the car? >> ")

            # write file for vehicle
            cf = open("files/cars/" + make + "_" + model + "_civ_car.txt", "a")
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
            print(" ")
            print(" ")
            print(" ")
            print(" ")
            print(" ")
            a.cop()

        elif coc == "5":
            # quit
            exit()





if __name__ == "__main__":
    a = CADSYS()
    a.login()