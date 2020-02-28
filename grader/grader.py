class Grader:

    def start(self):
        # greeting message
        o = input("Welcome to gradermatic.\nTo enter responses, enter 1.\nTo enter an answer key, enter 2.\nTo grade, enter 3.\nTo change a response, enter 4.\nPress any other key to quit. >> ")
        if o == "1":
            # enter responses
            self.numOfQuestions = input("How many questions are there? >> ")
            a.enterResponses()
        elif o == "2":
            # enter answer key
            a.answerKey()
        elif o == "3":
            # grade the exam
            a.grade()
        # elif 0 == "4":
        #     a.changeAns()
        else:
            exit(0)
        # get number of questions
    
    def enterResponses(self):
        # start gathering answers
        i = 1
        self.responses = []
        while i <= int(self.numOfQuestions):
            entry = input("\nWhat is your answer for question #" + str(i) + " >> ")
            self.responses += entry
            i += 1
        
        # display user responses
        print("\n\n\n")
        print("\nResponses:\n")
        j = 1
        for r in self.responses:
            print(str(j) + ". " + r)
            j+=1
        # change any answers?
        # change = input("Would you like to change any answers? 1 = yes, 2 = no")
        # if change == "1":
        #     a.changeAns()
        print("\n\n\n")
        a.start() # take us back to the main menu
    
    def answerKey(self):
        # input answer key
        x = 1
        self.answers = []
        while x <= int(self.numOfQuestions):
            aentry = input("\nWhat is the correct answer for question #" + str(x) + " >> ")
            self.answers += aentry
            x += 1
        
        # display answer key
        print("\n\n\n")
        print("\nResponses:\n")
        y = 1
        for z in self.answers:
            print(str(y) + ". " + z)
            y+=1
        print("\n\n\n")
        a.start()

    def grade(self):
        # grade the responses
        # time to actually grade the exam
        numCorrect = 0
        self.incorrect = []
        for p, q in zip(self.responses, self.answers):
            if p == q:
                # correct answer, so add 1 to their score
                numCorrect += 1
            else:
                # incorrect answer, let us record this instance to show them that they entered something in wrong
                #                tells us what problem number                    user entry                  correct answer
                print("index of self.responses.index: "+str(self.responses.index(p)))
                # since computers start counting at 0, we must increment self.responses.index(p) by 1, or else our "wrong answer" will be attributed to the wrong question
                zebra = self.responses.index(p) + 1
                goingIn = "#" + str(zebra) + " user entered: " + p + " correct answer: " + q
                self.incorrect.append(goingIn) # put it all together in 1 list position
                goingIn = "" # reset, incase we need to add more stuff

                
        # issue a grade
        print(str(numCorrect))
        print("Number of correct answers = " + str(numCorrect) + " out of " + str(self.numOfQuestions))
        grade = int(numCorrect) / int(self.numOfQuestions)
        print("Your score is: " + str(grade))

        # display incorrect answers:
        print("Here are the questions the user got wrong, as well as their correct answers:")
        for l in self.incorrect:
            print(l)

        # end the program
        exit(0)

        # def changeAns(self):
        #     # time to change answers
        #     whatToChange = input("What question's answer do you want to change? Enter a number between 1 and " + str(numOfQuestions))
        #     if whatToChange <= int(numOfQuestions):
        #         # change the answer
        #             # figure out where we shall change the answer
        #             # for b in responses:
        #                 # changing = 
        #             # figure out what the new answer is
        #         newAns = input("What do you want the answer to be? >> ")      
        #             # change the entry at the correct spot
                # responses[whatToChange] == newAns
            


if __name__ == "__main__":
    a = Grader()
    a.start()