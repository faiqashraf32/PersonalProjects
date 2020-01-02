import turtle
import random
from turtle import *

tim = turtle.Turtle()
tim.speed(0)
tim.width(5)

colors = ['red', 'blue', 'green', 'purple', 'yellow', 'orange', 'black']

def up():
    tim.setheading(90)
    tim.forward(100)

def down():
    tim.setheading(270)
    tim.forward(100)

def left():
    tim.setheading(180)
    tim.forward(100)

def right():
    tim.setheading(0)
    tim.forward(100)

def clickLeft(x,y):
    tim.color(random.choice(colors))
    
  
def clickRight(x,y):
    tim.stamp()


turtle.listen() # finds key board input

# 1 = left, 2 = middle, 3 = right
turtle.onscreenclick(clickLeft, 1)
turtle.onscreenclick(clickRight, 3)


turtle.onkey(up, 'Up') # runs function up if you click up arrow
turtle.onkey(down, 'Down')
turtle.onkey(left, 'Left')
turtle.onkey(right, 'Right')

turtle.mainloop()