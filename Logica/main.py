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
                    self.a += entry
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
                    self.b += entry
                    print("I have added " + entry + " to the set b.\n")
                else:
                    # display values in b
                    bb = []
                    for response in self.b:
                        # print(str(response) + ",")
                        bb += str(response)
                    print(bb)
                    a.whatNow()

    def whatNow(self):
        print("Here are your options: \n")
        exit(0)       
        


if __name__ == "__main__":
    a = Logica()
    a.start()