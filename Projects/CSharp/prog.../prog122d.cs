using System;
class Prog122d {
    public static void Main (String[] args) {

        int lcv = -12;
        int y;

        Console.WriteLine("x" + "        " + "y");
        while (lcv <= 16) {

            y = (int)(Math.Pow(lcv,6) -3*Math.Pow(lcv,5) - 93*Math.Pow(lcv,4) + 87*Math.Pow(lcv,3) + 1596*Math.Pow(lcv,2) - 1380*lcv - 2800);

            Console.WriteLine(lcv + "    " + y);

            lcv +=1;
        }
    }
}