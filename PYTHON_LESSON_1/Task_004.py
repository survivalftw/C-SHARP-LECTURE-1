print("Peter, Kate and Sergei construct paper cranes, it is known that Peter and Sergei do that with the same pace and Kate does that with 4x pace.")
print("Input the number of total paper cranes constructed:")
n = int(input())
print("Peter's crane number =", n//6)
print("Kate's crane number =", 4*(n//6))
print("Sergei's crane number =", n//6)
print("Discarded crane number =", n % 6)