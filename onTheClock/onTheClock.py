from datetime import datetime

class On:
   log = "logs/log.txt"
   def main(self):
       #name = input("Enter your full name >> ")
       z = input("\nClock in - 1, Clock out - 2 >> ")
       if z == "1":
           a.clockIn()
       if z == "2":
           a.clockOut() 
           

   def clockIn(self):
       # record system date and time
       clockInDateTime = str(datetime.now())
       
       # save to text file


       # tell the user that they are clocked in
       print("Clocked in")


   def clockOut(self):
       pass    
 



if __name__ == "__main__":
    a = On()
    a.main()