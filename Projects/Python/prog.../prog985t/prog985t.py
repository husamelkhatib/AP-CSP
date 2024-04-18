class Mergesort:
  @staticmethod
  def sort(A):
   if len(A) > 1:
    middle = len(A) // 2
    L = A[:middle]
    R = A[middle:]
    Mergesort.sort(L)
    Mergesort.sort(R)
    Mergesort.merge(A, L, R)
   return A

  def merge(A, L, R):
    i = 0 
    j = 0
    k = 0 
    while i < len(L) and j < len(R):
      if L[i] < R[j]:
         A[k] = L[i]
         i = i + 1
      else:
         A[k] = R[j]
         j = j + 1
      k = k + 1
    while i < len(L):
      A[k] = L[i]
      i = i + 1
      k = k + 1

    while j < len(R):
      A[k] = R[j]
      j = j + 1
      k = k + 1