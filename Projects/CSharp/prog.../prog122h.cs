using System;


int lcv = 1;
int square;
double squareRoot;
int cube;
double fourthRoot;

Console.WriteLine("Number    Square    Square Root    Cube    Fourth Root");
while (lcv <= 20) {

    square = (int)Math.Pow(lcv,2);
    squareRoot = Math.Sqrt(lcv);
    cube = (int)Math.Pow(lcv,3);
    fourthRoot = Math.Pow(lcv,0.25);

    Console.WriteLine(lcv + "    " + square + "    " + squareRoot + "    " + cube + "    " + fourthRoot);

    lcv+=1;
}