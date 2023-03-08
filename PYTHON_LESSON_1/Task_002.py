print("Input a number:")
n = int(input())
sum = 0
while n > 0:
    x = n % 10
    sum += x
    n = n // 10
print("The sum of number's numeric letters = ", sum)