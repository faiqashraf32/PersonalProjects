class Logica:

    def start(self):
        # welcome user
        print("Welcome to Logica!\n")

        # seek user input
        # a,b,c,d,e,f = [],[],[],[],[],[]
        self.a = []
        setEdit = input("Which set would you like to edit? (a-f) >> ")
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
                    exit(0)

            
        


if __name__ == "__main__":
    a = Logica()
    a.start()