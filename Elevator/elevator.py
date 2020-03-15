import random
from tkinter import *
from tkinter import messagebox
from tkinter import ttk


class Elevator:
    def game(self):
        window = Tk()
        window.title("Elevator Game") # writes title in title bar
        window.geometry('350x700') # establishes window size
        window.configure(background = "Black") # changes the background color
        content = ttk.Frame(window) # makes frame for adding form elements
        frame = ttk.Frame(content, borderwidth=1, relief="sunken", width=800, height=600) 

        # add first floor
        btnSpin = Button(window, text="Floor 1", command = Elevator.move(self))
        btnSpin.grid(column= 1, row = 1, padx=10, pady=10)


        # display the GUI
        window.mainloop()
    
    def move(self):
        print("\n\n\n\n moved me \n\n\n\n")


if __name__ == "__main__":
    a = Elevator()
    a.game()