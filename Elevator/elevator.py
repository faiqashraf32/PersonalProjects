import random
from tkinter import *
from tkinter import messagebox
from tkinter import ttk


class Elevator:
    def game(self):
        window = Tk()
        window.title("Slots") # writes title in title bar
        window.geometry('350x700') # establishes window size
        window.configure(background = "Black") # changes the background color
        content = ttk.Frame(window) # makes frame for adding form elements
        frame = ttk.Frame(content, borderwidth=1, relief="sunken", width=800, height=600) 


        window.mainloop()


if __name__ == "__main__":
    a = Elevator()
    a.game()