choice = input("Convert from Celsius (C) or Fahrenheit (F)? ")

temperature = float(input("Enter temperature: "))

if choice.upper() == "C":
    result = temperature * 1.8 + 32
    print(f"{temperature}°C = {result:.2f}°F")

elif choice.upper() == "F":
    result = (temperature - 32) / 1.8
    print(f"{temperature}°F = {result:.2f}°C")

else:
    print("Invalid choice")