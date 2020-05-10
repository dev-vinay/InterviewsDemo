using System;

namespace InterviewDemo {
    class Program {
        static void Main(string[] args) {
            //CrediCardAccounts ccAcc = new CrediCardAccounts();
            //string car = "Maruti";
            //Car maruti = null;
            //Vehicle.Print(maruti);
            //ActionTypeDemo.GetPerson();

            //OOPsDemo.GetFamilyMember();

            //using (var oops = new OOPsDemo()) {
            //    oops.WriteTrasaction();
            //    Console.WriteLine("Using Statement");
            //}

            //VersionFilters versionFilters = new VersionFilters();
            //versionFilters.GetOldestVersion();

            //string city = "Pune";
            //static string country = "India";
            //const string state = "MH";

            //Console.WriteLine(string.Format("You are in {0} {1} {2}", city, state, country));

            SimplifyHealthCareTest simplifyTest = new SimplifyHealthCareTest();
            int[] marks = new int[] { 4, 9, 4, 3, 2, 10 };
            simplifyTest.GetSelctionChances(20, new int[] {20,19,18,17,16,15,14,13,12,11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });
            Console.ReadLine();
        }
    }
}
