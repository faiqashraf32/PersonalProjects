class FSB:
        # arrays to store flight information
        airline = []
        flightNumbers = []
        destination = []
        gate = []
        status = []
        input = ""

        def addFlight(self):
            
                # testing
                a.airline.append("Delta") 
                a.airline.append("American")
                a.airline.append("United")
                a.flightNumbers.append("DL1485")
                a.flightNumbers.append("AA465")
                a.flightNumbers.append("UA1217")
                a.destination.append("Atlanta")
                a.destination.append("Chicago")
                a.destination.append("Louisville")
                a.gate.append("D1")
                a.gate.append("A12")
                a.gate.append("B6")
                a.status.append("Ontime")
                a.status.append("Delayed, now 12:45pm")
                a.status.append("Cancelled")

                a.showAll()
   
            # while input != "bye":
                # get inputs
                # air = input("Enter an airline name >> ")
                # fn = input("Enter a flight number >> ")
                # dest = input("Enter a destination >> ")
                # g = input("Enter a gate number >> ")
                # stat = input("Enter a flight status >> ")
                # self.air = air
                # self.fn = fn
                # self.dest = dest
                # self.g = g
                # self.stat = stat
                

                # add inputs to appropiate arrays
                # a.airline.append(self.air)
                # a.flightNumbers.append(self.fn)
                # a.destination.append(self.dest)
                # a.gate.append(self.g)
                # a.status.append(self.stat)
                # print("Data stored sucessfully.\n")
            
        def showAll(self):
            print("Airline\t\t\t" +"| Flight Number\t\t" +"| Destination\t\t" +"| Gate \t\t" +"| Status")
            for x in range(len(a.airline)):
                print("-------------------------------------------------------------------------------------------------------------------")
                print(str(a.airline[x] + "\t\t") + str(a.flightNumbers[x] + "\t\t") + str(a.destination[x] + "\t\t\t\t") + str(a.gate[x] + "\t\t")  + str(a.status[x]))

            go = input("To add a new entry, enter 1.\nTo reprint list, enter 2.\nTo exit, enter 3.\n")
            if go == "1":
                a.addFlight()
            elif go == "2":
                for x in range(1,26):
                    print(" ")
                a.showAll()
            elif go == "3":
                exit()

if __name__ == "__main__":
    a = FSB()
    a.addFlight()