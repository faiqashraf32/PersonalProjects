
from datetime import datetime
from datetime import date

dob_year = input("What year were they born? >> ")
dob_month = input("What month were they born in? >> (1 = Jan, 2 = Feb, 3 = Mar, 4 = Apr, 5 = May, etc)")
# convert for function-friendly input
if dob_month == "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9":
    dob_month = "0" + dob_month

dob_day = input("What day were they born on? >> ")

# convert for function-friendly input
if dob_day == "1" or "2" or "3" or "4" or "5" or "6" or "7" or "8" or "9":
    dob_day = "0" + dob_day

# age = input("How old are they? >> ")
# calculate age
today = date.today()
age = today.year - int(dob_year) - ((today.month, today.day) < (int(dob_month), int(dob_day)))

print("\n\n\n\nAge = " + str(age))