from tkinter import *
from tkinter import messagebox
from tkinter import ttk

class FSB:
        # arrays to store flight information
        airline = []
        flightNumbers = []
        destination = []
        gate = []
        status = []
        input = ""
    # def build(self):
        # window = Tk()
        # window.title("Flight Status Board") # writes title in title bar
        # window.geometry('1000x350') # establishes window size
        # window.configure(background = "Black") # changes the background color
        # content = ttk.Frame(window) # makes frame for adding form elements
        # frame = ttk.Frame(content, borderwidth=1, relief="sunken", width=800, height=600) 
        # 
        def addFlight(self):
   
            while input != "bye":
                # get inputs
                air = input("Enter an airline name >> ")
                fn = input("Enter a flight number >> ")
                dest = input("Enter a destination >> ")
                g = input("Enter a gate number >> ")
                stat = input("Enter a flight status >> ")
                self.air = air
                self.fn = fn
                self.dest = dest
                self.g = g
                self.stat = stat
                

                # add inputs to appropiate arrays
                a.airline.append(self.air)
                a.flightNumbers.append(self.fn)
                a.destination.append(self.dest)
                a.gate.append(self.g)
                a.status.append(self.stat)
                print("Data stored sucessfully.\n")
                a.showAll()
            
        def showAll(self):
            print("Airline | Flight Number | Destination | Gate | Status")
            for x in a.airline, a.flightNumbers, a.destination, a.gate, a.status:
                print(a.airline[x] + [" | "] + a.flightNumbers[x] + [" | "] + a.destination[x] + [" | "] +  a.gate[x] + [" | "]+  a.status[x])
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