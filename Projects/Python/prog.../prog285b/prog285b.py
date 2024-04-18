from Cl285b import Salesperson

def main():
    try:
        print("Number   Code   Sales   Commission")
        people = []

        with open("Projects/Python//prog.../prog285b/prog285b.txt", 'r') as f:
            for line in f:
                ldata = line.split(" ")
                id = int(ldata[0])
                code = int(ldata[1])
                sales = float(ldata[2])
                dude = Salesperson(id, code, sales)
                people.append(dude)

        for sp in people:  # for-each loop properly indented within the main function
            sp.calc()
            print(sp)  # print statement indented within the for loop

    except Exception as e:
        print("Error:", e)


if __name__ == "__main__":
  main()