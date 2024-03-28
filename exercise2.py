def main():
    while True:
        print("Choose an option:")
        print("1. Rectangle tower")
        print("2. Triangle tower")
        choice = input("Enter your choice number (1/2): ")

        if choice == '1':
            height = int(input("Enter height of rectangle: "))
            width = int(input("Enter width of rectangle: "))
            if width == height or abs(width - height) > 5:
                print("Area of the rectangle:", height * width)
            else:
                print("Perimeter of the rectangle:", 2 * (height + width))

        elif choice == '2':
            height = int(input("Enter height of triangle: "))
            width = int(input("Enter width of triangle: "))
            print("Choose an option:")
            print("1. Calculate the area of the triangle")
            print("2. Print the triangle")
            choice = input("Enter your choice number: ")
            if choice == '1':
                print("Perimeter of the triangle:", 3 * width)
            if choice == '2':
                if width % 2 == 0 or width / 2 > height:
                    print("Cannot print the triangle")
                else:
                    number = (width - 3) // 2
                    numline = (height - 2) // number
                    addition = height - (2 + number * numline)

                    # Loop through each line
                    for i in range(1, width + 1, 2):
                        if i == 3:
                            for j in range(numline + addition):
                                print(" " * ((width - i) // 2) + "*" * i)
                        elif i == 1 or i == width:
                            print(" " * ((width - i) // 2) + "*" * i)
                        else:
                            for j in range(numline):
                                print(" " * ((width - i) // 2) + "*" * i)


        elif choice == '3':
            print("Thank you for using the program.")
            break
        else:
            print("Invalid selection, please select again.")


main()