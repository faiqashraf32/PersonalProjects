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

        self.setEdit = input("Which set would you like to edit? (a-f) or universe (u) >> ")
        a.editSet()

    def editSet(self):
        if self.setEdit == "a":
            print("Editing set a. Please enter values, when finished, enter 'stop' \n")
            entry = ""
            while True:
                entry = input("give me something >>> ")
                if entry != "stop": 
                    self.a.append(entry) 
                    print("I have added " + entry + " to the set a.\n")
                else:
                    # display values in a
                    print(self.u)
                    a.whatNow()
        elif self.setEdit == "b":
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
        elif self.setEdit == "c":
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
        elif self.setEdit == "d":
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
        elif self.setEdit == "e":
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
        elif self.setEdit == "f":
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
        elif self.setEdit == "u":
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
        go = input("To overwrite a set, enter 1\nTo use union, enter 2\nTo use intersection, enter 3.\nTo check compliments, enter 4.\nTo quit, enter any other key.\n")
        if go == "1":
            a.editSet()
        elif go == "2": 
            a.union()
        else:
            exit(0)
        
    def union(self):
        self.uWho = []
        entry = ""
        while True:
            entry = input("Which set you want to unionize? (a-f, enter stop to end) >> ")
            if entry != "stop":
                if entry == "a":
                    self.uWho.append(self.a)
                elif entry == "b":
                    self.uWho.append(self.b)
                elif entry == "c":
                    self.uWho.append(self.c)
                elif entry == "d":
                    self.uWho.append(self.d)
                elif entry == "e":
                    self.uWho.append(self.e) 
                elif entry == "f":
                    self.uWho.append(self.f)   
            else:
                # print the union
                print(self.uWho)
                uWho = []
                a.whatNow()
                
        

if __name__ == "__main__":
    a = Logica()
    a.start()