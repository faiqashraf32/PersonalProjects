import random 

class Dares:
    def main(self):
        # get a range
        lower = input("Name the lower bound for the dare >> ")
        upper = input("Name the upper bound for the dare >> ")

        # generate a random number
        compNum = random.randrange(lower, upper)
        print("Random Number: >> " + str(compNum))

        dares = ["Shave your head bald.","Streak in front of showalter fountain",""]


if __name__ == "__main__":
    a = Dares()
    a.main()