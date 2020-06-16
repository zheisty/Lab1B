using System;

class MainClass {
  public static void Main (string[] args) {
     string number1 = ("First Number= ");
            int one = (15);

            string number2 = ("Second Number= ");
            int two = (8);

            string sum = ("Sum= ");
            int s = (one + two);

            string diff = ("Difference= ");
            int d = (one - two);

            string prod = ("Product= ");
            int p = (one * two);

            string quot = ("Quotient= ");
            int q = (one / two);

            string rem = ("Remainder= ");
            int r = (one % two);

            Console.WriteLine(number1 + one);

            Console.WriteLine(number2 + two);

            Console.WriteLine(sum + s);

            Console.WriteLine(diff + d);

            Console.WriteLine(prod + p);

            Console.WriteLine(quot + q);

            Console.WriteLine(rem + r);
  }
}