import sys
class Logistics:

    def start(self):
        # We have our 4 trucks A - d, whose routes are detailed in times.txt
        A = ["EVV", "JVY", "IND"]
        B = ["HUF", "BMG", "IND"]
        C = ["GYY", "LAF", "IND"]
        D = ["SBN", "FWA", "IND"]
        ALL = ["EVV", "HUF", "BMG", "IND", "LAF", "GYY", "SBN", "FWA", "JVY"]
        self.A = A
        self.B = B
        self.C = C
        self.D = D

        print("HOOSIER SHIPPING COMPANY")
        origin = input("Please enter the destination (EVV, HUF, BMG, IND, LAF, GYY, SBN, FWA, JVY) >> ")
        destination = input("Please enter the destination (EVV, HUF, BMG, IND, LAF, GYY, SBN, FWA, JVY) >> ")
        origin = origin.upper()
        destination = destination.upper()
        # timeRecieved = input("Please enter the time the item was dropped off (e.g. 01:34pm) >> ")
        # travelLog = ["Outbound from: " + str(origin), "\n"]
        self.origin = origin
        self.destination = destination
        # self.timeRecieved = timeRecieved
        # self.travelLog = travelLog

        # User Entry Validation - makes sure the origin/destination are within the lists we have of places we serve
        if origin not in ALL:
            print("Origin entry invalid. Please try again.")
            origin = ""
            destination = ""
            a.start()
        elif destination not in ALL:
            print("Destination entry invalid. Please try again.")
            origin = ""
            destination = ""
            a.start()
        else:
            a.route()

    def route(self):
        # lets figure out what trucks this item will go on for INBOUND IND    
        #  rai = ROUTE A INBOUND
        rai = False
        rbi = False
        rci = False
        rdi = False

        if self.origin in self.A:
            # so its on truck a
            rai = True
            print("Outbound truck A from " + self.origin)
        elif self.origin in self.B:
            # so its on truck b
            rbi = True
            print("Outbound truck B " + self.origin)
        elif self.origin in self.C:
            # so its on truck c
            rci = True
            print("Outbound truck C " + self.origin)
        elif self.origin in self.D:
            # so its on truck d
            rdi = True
            print("Outbound truck D " + self.origin)

        # lets figure out our second stop, because in each truck route, there might be a second stop
        if rai == True:
            for i in self.A:
                if self.A[1] == self.destination:
                    # this means our parcel is getting of at our second stop, so its trip, and the algorithm, end here
                    print("Arrived at " + self.A[1])
                    sys.exit()
                if self.origin == self.A[1]:
                    # this means we don't need to print anything, since our origin is the same as the second stop
                    print("In transit from " + str(self.A[1]))
                    break
                else:
                    # our second stop is different, so we will print out the arrival at the second stop
                    print("Arrival at " + str(self.A[1]))
                    print("Deoared from " + str(self.A[1]))
                    break
                break
        if rbi == True:
            for i in self.A:
                if self.B[1] == self.destination:
                    # this means our parcel is getting of at our second stop, so its trip, and the algorithm, end here
                    print("Arrived at " + self.B[1])
                    sys.exit()
                if self.origin == self.B[1]:
                    # this means we don't need to print anything, since our origin is the same as the second stop
                    print("In transit from " + str(self.B[1]))
                    break
                else:
                    # our second stop is different, so we will print out the arrival at the second stop
                    print("Arrival at " + str(self.B[1]))
                    print("Depared from " + str(self.B[1]))
                    break
                break        
        if rci == True:
            for i in self.C:
                if self.C[1] == self.destination:
                    # this means our parcel is getting of at our second stop, so its trip, and the algorithm, end here
                    print("Arrived at " + self.C[1])
                    sys.exit()                
                if self.origin == self.C[1]:
                    # this means we don't need to print anything, since our origin is the same as the second stop
                    print("In transit from " + str(self.C[1]))
                    break
                else:
                    # our second stop is different, so we will print out the arrival at the second stop
                    print("Arrival at " + str(self.C[1]))
                    print("Departed from " + str(self.C[1]))
                    break
                break
        if rdi == True:
            for i in self.D:
                if self.D[1] == self.destination:
                    # this means our parcel is getting of at our second stop, so its trip, and the algorithm, end here
                    print("Arrived at " + self.D[1])
                    sys.exit()                
                if self.origin == self.D[1]:
                    # this means we don't need to print anything, since our origin is the same as the second stop
                    print("In transit from " + str(self.D[1]))
                    break
                else:
                    # our second stop is different, so we will print out the arrival at the second stop
                    print("Arrival at " + str(self.D[1]))
                    print("Departed from " + str(self.D[1]))
                    break
                break
            
        # check to see if an item's destination is indianapolis
        if self.destination == "IND":
            print("Arrived at " + str(self.destination))
            sys.exit()

        print("Arrived IND")
        # lets figure out what trucks this item will go on for OUTBOUND IND
        # RAO = ROUTE A OUTBOUND
        rao = False
        rbo = False
        rco = False
        rdo = False

        if self.destination in self.A:
            # so its on truck a
            rao = True
            print("Outbound truck A from " + "IND")
        elif self.destination in self.B:
            # so its on truck b
            rbo = True
            print("Outbound truck B from " + "IND")
        elif self.destination in self.C:
            # so its on truck c
            rco = True
            print("Outbound truck C from " + "IND")
        elif self.destination in self.D:
            # so its on truck d
            rdo = True
            print("Outbound truck D from " + "IND")

        # lets figure out our first stop after leaving IND, because in each truck route, there might be a second stop
        if rao == True:
            for i in self.A:
                if self.A[1] == self.destination:
                    # this means our parcel is getting of at our second stop, so its trip, and the algorithm, end here
                    print("Arrived at " + self.A[1])
                    sys.exit()
                if self.destination == self.A[1]:
                    # this means we don't need to print anything, since our origin is the same as the second stop
                    print("In transit from " + str(self.A[1]))
                else:
                    # our second stop is different, so we will print out the arrival at the second stop
                    print("Arrival at " + str(self.A[1]))
                    print("Deoared from " + str(self.A[1]))
                break
        if rbo == True:
            for i in self.B:
                if self.B[1] == self.destination:
                    # this means our parcel is getting of at our second stop, so its trip, and the algorithm, end here
                    print("Arrived at " + self.B[1])
                    sys.exit()
                if self.destination == self.B[1]:
                    # this means we don't need to print anything, since our origin is the same as the second stop
                    print("In transit from " + str(self.B[1]))
                else:
                    # our second stop is different, so we will print out the arrival at the second stop
                    print("Arrival at " + str(self.B[1]))
                    print("Depared from " + str(self.B[1]))
                break        
        if rco == True:
            for i in self.C:
                if self.C[1] == self.destination:
                    # this means our parcel is getting of at our second stop, so its trip, and the algorithm, end here
                    print("Arrived at " + self.C[1])
                    sys.exit()
                if self.destination == self.C[1]:
                    # this means we don't need to print anything, since our origin is the same as the second stop
                    print("In transit from " + str(self.C[1]))
                else:
                    # our second stop is different, so we will print out the arrival at the second stop
                    print("Arrival at " + str(self.C[1]))
                    print("Departed from " + str(self.C[1]))
                break
        if rdo == True:
            for i in self.D:
                if self.D[1] == self.destination:
                    # this means our parcel is getting of at our second stop, so its trip, and the algorithm, end here
                    print("Arrived at " + self.D[1])
                    sys.exit()
                if self.destination == self.D[1]:
                    # this means we don't need to print anything, since our origin is the same as the second stop
                    print("In transit from " + str(self.D[1]))
                else:
                    # our second stop is different, so we will print out the arrival at the second stop
                    print("Arrival at " + str(self.D[1]))
                    print("Departed from " + str(self.D[1]))
                break

        # finally annouce we made it

        print("Arrived at " + self.destination)

if __name__ == "__main__":
    a = Logistics()
    a.start()