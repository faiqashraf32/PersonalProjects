class Grader:
    def grade(self):
        # get number of questions
        numOfQuestions = input("How many questions are there? >> ")

        # start gathering answers
        i = 1
        responses = []
        while i <= int(numOfQuestions):
            entry = input("\nWhat is your answer for question #" + str(i) + " >> ")
            responses += entry
            i += 1
        
        # display user responses
        print("\nResponses:\n")
        j = 1
        for r in responses:
            print(str(j) + ". " + r)
            j+=1
        # change any answers?
        # change = input("Would you like to change any answers? 1 = yes, 2 = no")
        # if change == "1":
        #     a.changeAns()
        
        # grade the responses
        # input answer key
        x = 1
        answers = []
        while x <= int(numOfQuestions):
            aentry = input("\nWhat is the correct answer for question #" + str(x) + " >> ")
            answers += aentry
            x += 1
        
        # display answer key
        print("\nResponses:\n")
        y = 1
        for z in answers:
            print(str(y) + ". " + z)
            y+=1

        # time to actually grade the exam
        numCorrect = 0
        for p, q in zip(responses, answers):
            if p == q:
                numCorrect += 1
                
        # issue a grade
        print(str(numCorrect))
        print("Number of correct answers = " + str(numCorrect) + " out of " + str(numOfQuestions))
        grade = int(numOfQuestions) - int(numCorrect)
        grade = grade / int(numOfQuestions)
        print("Your score is: " + str(grade))

        # def changeAns(self):
        #     # time to change answers
        #     whatToChange = input("What question's answer do you want to change? Enter a number between 1 and " + str(numOfQuestions))
        #     if whatToChange <= int(numOfQuestions):
        #         # change the answer
        #         newAns = input("What do you want the answer to be? >> ")
        #         responses[whatToChange] == newAns
            


if __name__ == "__main__":
    a = Grader()
    a.grade()