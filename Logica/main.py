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
                    aa = []
                    for response in self.a:
                        # print(str(response) + ",")
                        aa += str(response)
                    print(aa)
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
                    bb = []
                    for response in self.b:
                        # print(str(response) + ",")
                        bb += str(response)
                    print(bb)
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
                    cc = []
                    for response in self.c:
                        # print(str(response) + ",")
                        cc += str(response)
                    print(cc)
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
                    dd = []
                    for response in self.d:
                        # print(str(response) + ",")
                        dd += str(response)
                    print(dd)
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
                    ee = []
                    for response in self.e:
                        # print(str(response) + ",")
                        ee += str(response)
                    print(ee)
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
                    ff = []
                    for response in self.f:
                        # print(str(response) + ",")
                        ff += str(response)
                    print(ff)
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
                    print("{", *self.u, sep=', ', end = "}")
                    # uu = []
                    # for response in self.u:
                    #     # print(str(response) + ",")
                    #     uu += str(response)
                    # print(uu)
                    a.whatNow()

    def whatNow(self):
        print("Here are your options: \n")
        exit(0)       
        


if __name__ == "__main__":
    a = Logica()
    a.start()