using System;

namespace InterviewDemo {
    public class SimplifyHealthCareTest {
        public SimplifyHealthCareTest() {

        }

        public int[] GetSelctionChances(int noOfStudents, int[] marks) {
            try {

                int[] results = new int[noOfStudents];
                int counter = 0;
                int j = 0;
                for (int i = 0; i < marks.Length; i++) {
                    j = i;
                    counter = 0;
                    if (i == 0) {
                        counter = 0;
                    } else {
                        while (j > 0) {
                            if (marks[i] < marks[j - 1]) {
                                counter++;
                            }
                            j--;
                        }
                    }
                    results[i] = counter;
                }

                Print(results);
                return results;
            } catch (Exception ex) {

                throw ex;
            }
        }

        public void Print(int[] results) {
            Console.Write("{{");
            for (int i = 0; i < results.Length; i++) {
                Console.Write(results[i] + ",");
            }
            Console.Write("}}");
        }
    }
}
