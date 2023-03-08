print("Input a 3-digit number:")
n = int(input())
if int(n) < 100 or int(n) > 999:
    print("Wrong number of digits, restart the program and enter 3-digit number")
else:
    sum = 0
    while n > 0:
        x = n % 10
        sum += x
        n = n // 10
    print("The sum of number's digits = ", sum)