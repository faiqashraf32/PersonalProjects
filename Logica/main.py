class Logica:

    def start(self):
        # welcome user
        print("Welcome to Logica!\n")

        # seek user input
        # a,b,c,d,e,f = [],[],[],[],[],[]
        self.a = []
        self.b = []
        self.c = []
        self.d = []
        self.e = []
        self.f = []
        self.u = [] # universal set

        setEdit = input("Which set would you like to edit? (a-f) or universe (u) >> ")
        if setEdit == "a":
            print("Editing set a. Please enter values, when finished, enter 'stop' \n")
            entry = ""
            while True:
                entry = input("give me something >>> ")
                if entry != "stop": 
                    self.a.append(entry) 
                    print("I have added " + entry + " to the set a.\n")
                else:
                    # display values in a
                    print(self.a)
                    a.whatNow()

        elif setEdit == "b":
            print("Editing set b. Please enter values, when finished, enter 'stop' \n")
            entry = ""
            while True:
                entry = input("give me something >>> ")
                if entry != "stop": 
                    self.b.append(entry)
                    print("I have added " + entry + " to the set b.\n")
                else:
                    # display values in b
                    print(self.b)
                    a.whatNow()

        elif setEdit == "c":
            print("Editing set c. Please enter values, when finished, enter 'stop' \n")
            entry = ""
            while True:
                entry = input("give me something >>> ")
                if entry != "stop": 
                    self.c.append(entry)
                    print("I have added " + entry + " to the set c.\n")
                else:
                    # display values in c
                    print(self.c)
                    a.whatNow()

        elif setEdit == "d":
            print("Editing set d. Please enter values, when finished, enter 'stop' \n")
            entry = ""
            while True:
                entry = input("give me something >>> ")
                if entry != "stop": 
                    self.d.append(entry)
                    print("I have added " + entry + " to the set d.\n")
                else:
                    # display values in d
                    print(self.d)
                    a.whatNow()

        elif setEdit == "e":
            print("Editing set e. Please enter values, when finished, enter 'stop' \n")
            entry = ""
            while True:
                entry = input("give me something >>> ")
                if entry != "stop": 
                    self.e.append(entry)
                    print("I have added " + entry + " to the set e.\n")
                else:
                    # display values in e
                    print(self.e)
                    a.whatNow()

        elif setEdit == "f":
            print("Editing set f. Please enter values, when finished, enter 'stop' \n")
            entry = ""
            while True:
                entry = input("give me something >>> ")
                if entry != "stop": 
                    self.f.append(entry)
                    print("I have added " + entry + " to the set f.\n")
                else:
                    # display values in f
                    print(self.f)
                    a.whatNow()

        elif setEdit == "u":
            print("Editing set u. Please enter values, when finished, enter 'stop' \n")
            entry = ""
            while True:
                entry = input("give me something >>> ")
                if entry != "stop": 
                    self.u.append(entry)
                    print("I have added " + entry + " to the set u.\n")
                else:
                    # display values in u
                    print(self.u)
                    a.whatNow()

    def whatNow(self):
        print("Here are your options: \n")
        exit(0)       
        


if __name__ == "__main__":
    a = Logica()
    a.start()