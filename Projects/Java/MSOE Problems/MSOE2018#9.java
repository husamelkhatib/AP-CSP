import java.util.*;
import java.text.*;

class Main {
  public static void main(String[] args) {
    Scanner input = new Scanner(System.in);
    System.out.print("Enter plain of cipher text: ");
    String text = input.nextLine().toUpperCase();

    while (text.length() % 5 != 0) {
      text += " ";
    }

    System.out.print("\nEnter key: ");
    int key = input.nextInt();
    ArrayList<String> chr = new ArrayList<String>();

    for (int c = 0; c < text.length(); c++) {
      chr.add(text.substring(c, c + 1));
    }

    ArrayList<Integer> ascii = new ArrayList<Integer>();
    for (int c = 0; c < chr.size(); c++) {
      ascii.add((int)chr.get(c).charAt(0));
    }

    for (int c = 0; c < ascii.size(); c++) {
      ascii.set(c, ascii.get(c) - 32);
    }

    ArrayList<String> binary = new ArrayList<String>();
    for (int c = 0; c < ascii.size(); c++) {
      String b = Integer.toBinaryString(ascii.get(c));
      while (b.length() < 6) {
        b = "0" + b;
      }
      binary.add(b);
    }

    ArrayList<String> grouped = new ArrayList<String>();
    for (int c = 0; c < binary.size(); c = c + 5) {
      grouped.add(binary.get(c) + binary.get(c + 1) + binary.get(c + 2) + binary.get(c + 3) + binary.get(c + 4));
    }

    String keyb = Integer.toBinaryString(key);
    while (keyb.length() < 30) {
      keyb = "0" + keyb;
    }

    for (int c = 0; c < grouped.size(); c++) {
      String b = grouped.get(c);
      for (int i = 0; i < b.length(); i++) {
        if (keyb.substring(i, i + 1).equals("1")) {
          if (b.substring(i, i + 1).equals("1")) {
            b = b.substring(0, i) + "0" + b.substring(i + 1);
          } else {
            b = b.substring(0, i) + "1" + b.substring(i + 1);
          }
        }
      }
      grouped.set(c, b);
      keyb = keyb.substring(1) + keyb.substring(0, 1);
    }

    ArrayList<String> bin = new ArrayList<String>();
    for (int c = 0; c < grouped.size(); c++) {
      String b = grouped.get(c);
      for (int i = 0; i < b.length(); i = i + 6) {
        bin.add(b.substring(i, i + 6));
      }
    }

    ArrayList<Integer> vals = new ArrayList<Integer>();
    for (int c = 0; c < bin.size(); c++) {
      vals.add(Integer.parseInt(bin.get(c), 2) + 32);
      int val = vals.get(c);
      char a = (char) val;
      System.out.print(a);
    }
  }
}