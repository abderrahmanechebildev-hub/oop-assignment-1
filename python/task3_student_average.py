count = int(input("How many grades? "))

total = 0

for i in range(count):
    grade = float(input(f"Grade {i+1}: "))
    total += grade

average = total / count

print(f"Average: {average:.2f}")

if average >= 3.0:
    print("The student passed.")
else:
    print("The student failed.")