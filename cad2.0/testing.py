
def convert(a):
    ntc = ["1","2","3","4","5","6","7","8","9"]
    if a in ntc:
        a = "0" + a
        print(a + "\n")
    else:
        print("nope\n")

convert("1")
convert("5")
convert("8")
convert("2")
convert("12")
convert("100")
convert("31i432orji342")
convert("18")