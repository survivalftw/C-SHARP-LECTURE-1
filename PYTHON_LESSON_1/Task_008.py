n = int(input('Input number of chocolate segments (lenght): '))
m = int(input('Input number of chocolate segments (width): '))
k = int(input('Input possible segment number of a chocolate piece after one line crack: '))
if k >= n * m or k < 0:
    print ("It is not possible to line crack a piece with", k, "segments")
elif k % n == 0 or k % m == 0:
    print("It is possible to line crack a piece with", k, "segments")
else:
    print ("It is not possible to line crack a piece with", k, "segments")