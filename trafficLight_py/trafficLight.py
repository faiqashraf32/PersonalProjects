import turtle
import time
from turtle import *


wn = turtle.Screen()
wn.title("Traffic Light")
wn.bgcolor("black")

# draw yellow box around traffic light
p = turtle.Turtle()
p.color("yellow")
p.width(3)
p.hideturtle()
p.penup()
p.goto(-30,60)
p.pendown()
p.fd(60)
p.rt(90)
p.fd(120)
p.rt(90)
p.fd(60)
p.rt(90)
p.fd(120)

# draw red light
red = turtle.Turtle()
red.shape("circle")
red.color("grey")
red.penup()
red.goto(0,40)

# draw yellow light
yellow = turtle.Turtle()
yellow.shape("circle")
yellow.color("grey")
yellow.penup()
yellow.goto(0,0)

# draw green light
green = turtle.Turtle()
green.shape("circle")
green.color("grey")
green.penup()
green.goto(0,-40)


# functionality for traffic light
flash = False

def demo():
    while True:
        red.color("black")
        yellow.color("black")
        green.color("black")
        time.sleep(5)
        red.color("red")
        yellow.color("black")
        green.color("black")
        time.sleep(5)
        red.color("black")
        yellow.color("black")
        green.color("Olive Drab")
        time.sleep(5)
        red.color("black")
        yellow.color("yellow")
        green.color("black")
        time.sleep(5)
        red.color("red")
        yellow.color("black")
        green.color("black")
        time.sleep(5)
    

def display():
    flash = False
    red.color("red")
    yellow.color("yellow")
    green.color("green")

def all():
    flash = True
    while flash == True:
        time.sleep(0.5)
        red.color("red")
        yellow.color("yellow")
        green.color("green")
        time.sleep(0.5)
        red.color("black")
        yellow.color("black")
        green.color("black")

def redLight():
    flash = False
    yellow.color("black")
    green.color("black")
    red.color("red")

def yellowLight():
    flash = False
    red.color("black")
    green.color("black")
    yellow.color("yellow")

def greenLight():
    flash = False
    red.color("black")
    yellow.color("black")
    green.color("Olive Drab")

def flashRed():
    red.color("red")
    yellow.color("black")
    green.color("black")
    flash = True
    while flash == True:
        time.sleep(0.5)
        red.color("black")
        time.sleep(0.5)
        red.color("red")

def flashYellow():
    red.color("black")
    yellow.color("yellow")
    green.color("black")
    flash = True
    while flash == True:
        time.sleep(0.5)
        yellow.color("black")
        time.sleep(0.5)
        yellow.color("yellow")
    
def flashGreen():
    red.color("black")
    yellow.color("black")
    green.color("Olive Drab")
    flash = True
    while flash == True:
        time.sleep(0.5)
        green.color("black")
        time.sleep(0.5)
        green.color("Olive Drab")


turtle.listen() # finds key board input
# wn.onkey(function,key)
wn.onkey(all,"a") # turns on all of the lights
wn.onkey(redLight, "r") # turns on red light only
wn.onkey(yellowLight, "y") # turns on yellow light only
wn.onkey(greenLight, "g") # turns on green light only
wn.onkey(flashRed, "1") # flashing red light
wn.onkey(flashYellow, "2") # flashing red light
wn.onkey(flashGreen, "3") # flashing red light
wn.onkey(display, "d") # shows all of the lights
wn.onkey(demo, "x")



# while True:
#     yellow.color("grey")
#     red.color("red")
#     time.sleep(4)

#     red.color("grey")
#     green.color("olive drab")
#     time.sleep(3)

#     green.color("grey")
#     yellow.color("yellow")
#     time.sleep(2)



wn.mainloop()