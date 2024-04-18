def bubble_sort(list1):
  for i in range(0, len(list1) - 1):
    for j in range(0, len(list1) - i - 1):
      if list1[j] > list1[j + 1]:
        temp = list1[j]
        list1[j] = list1[j + 1]
        list1[j + 1] = temp
  return list1

def selection_sort(list1)
  for i in range(0, len(list1) - 1):
    min_index = i
    for j in range(i + 1, len(list1)):
     if (list1[j] < list1[min_index]:
      min_index = j
    temp = list1[i]
    list1[i] = list[mid_index]
    list1[mid_index] = temp
  return list1

def insertion_sort(list1):
for i in range(1, len(list1)):
  key = list1[i]
  j = i - 1
  while j >= 0 and list1[j] > key:
    list1[j + 1] = list1[j]
    j = j - 1
    list1[j + 1] = key