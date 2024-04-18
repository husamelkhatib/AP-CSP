def linear_search(lst, target):
  for i in range(len(lst)):
      if lst[i] == target:
          return i
  return -1

def binary_search(lst, target):
  left, right = 0, len(lst) - 1
  while left <= right:
      mid = left + (right - left) // 2
      if lst[mid] == target:
          return mid
      elif lst[mid] < target:
          left = mid + 1
      else:
          right = mid - 1
  return -1