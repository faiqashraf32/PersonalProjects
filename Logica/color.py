# testing out color coding text in the terminal in python

# format:
# "\033[style;text color;background color"
# "\033 = ANSI code"

# to add text in, just type it in after the ;;; sequence:
print("\033[0;37;40m Normal text\n")

# to add variable values in, concatonate:
a = 12
b = "apple pie"
print("\033[0;33;40m Style 0" + str(a) + b)

# text color codes
    # - black = 30
    # - red = 31
    # - green = 32
    # - yellow = 33
    # - blue = 34
    # - purple = 35
    # - cyan = 36
    # - white = 37

# background colors
    # - black = 40
    # - red = 41
    # - green = 42
    # - yellow = 43
    # - blue = 44
    # - purple = 45
    # - cyan = 46
    # - white = 47


print("\033[1;33;40m Style 1:" + str(a) + b)
print("\033[2;33;40m Style 2:" + str(a) + b)
print("\033[3;33;40m Style 3:" + str(a) + b)
print("\033[5;33;40m Style 4:" + str(a) + b)