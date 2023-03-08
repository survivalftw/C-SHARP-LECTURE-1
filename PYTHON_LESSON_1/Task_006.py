print("Input 6-digit ticket number:")
n = input()
if int(n) < 100000 or int(n) > 999999:
    print("Wrong number of digits, restart the program and enter 6-digit number")
elif int(n[0]) + int(n[1]) + int(n[2]) == int(n[3]) + int(n[4]) + int(n[5]):
    print("Your ticket is lucky")
elif int(n[0]) + int(n[1]) + int(n[2]) != int(n[3]) + int(n[4]) + int(n[5]):
    print("Your ticket is not lucky")