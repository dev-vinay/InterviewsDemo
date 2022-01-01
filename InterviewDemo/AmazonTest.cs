using System;

namespace InterviewDemo {
    public class AmazonTest {
        public static void fizzBuzz(int n) {
            if ((n % 3 == 0) && (n % 5 == 0)) {
                Console.WriteLine("FizzBuzz");
            } else if ((n % 3 == 0) && (n % 5 != 0)) {
                Console.WriteLine("Fizz");
            } else if ((n % 3 != 0) && (n % 5 == 0)) {
                Console.WriteLine("Buzz");
            } else if ((n % 3 != 0) && (n % 5 != 0)) {
                Console.WriteLine(n);
            }
        }
    }
}
