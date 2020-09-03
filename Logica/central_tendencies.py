class Central:
    def main(self):
        a = []
        entry = ""
        while True:
            if entry != "stop":
                entry = input("give me a number >>> ")
                a.append(entry)
                entry = ""
            else:
                for x in a:
                    print(x)

if __name__ == "__main__":
    a = Central()
    a.main()