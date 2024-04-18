import time
from SearchAlgorithms import *
def main():
  try:
    data = []
    with open("prog408b.dat", 'r') as f:
      data = [int(line) for line in f]
    for lcv in range(3):
      num = int(input("enter a number: "))
      startTime = time.perf_counter()
      result = linear_search(data, num)
      endTime = time.perf_counter()
      print(result)

  except Exception as e:
    print("Error:", e)
  pass


if __name__ == "__main__":
  main()