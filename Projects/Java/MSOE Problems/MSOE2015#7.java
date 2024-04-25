import java.util.*;

class MSOE2015Q7 {
  public static void main(String[] args) {
    Scanner input = new Scanner(System.in);
    System.out.print("Enter a number: ");
    int num = input.nextInt();

    ArrayList<Integer> tri = new ArrayList<Integer>();

    tri.add(0);
    for (int c = 1; tri.get(c - 1) <= num; c++) {
      tri.add((c * (c + 1)) / 2);
    }
    tri.remove(tri.size() - 1);

    int value = num;
    int tri1 = 0;
    int tri2 = 0;
    int tri3 = 0;
    while (value != 0) {
      value = num;
      tri1 = tri.get(tri.size() - 1);
      value -= tri1;

      for (int c = 0; c < tri.size(); c++) {
        if (tri.get(c) <= value) {
          tri2 = tri.get(c);
        }
      }
      value -= tri2;

      for (int c = 0; c < tri.size(); c++) {
        if (tri.get(c) <= value) {
          tri3 = tri.get(c);
        }
      }
      value -= tri3;

      tri.remove(tri.size() - 1);
    }

    System.out.print(tri1 + " " + tri2 + " " + tri3);
  }
}