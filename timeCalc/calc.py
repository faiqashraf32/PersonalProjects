


class time:
    def calc(self):
        # get user input
        time = input("Enter a time")
        now = datetime.datetime.now()
        print(now + datetime.timedelta(hours=1, minutes=23, seconds=10))


if __name__ == "__main__":
    a = time()
    a.calc()