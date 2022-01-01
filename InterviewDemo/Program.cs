using System;
using IcertisDemo;
namespace InterviewDemo {
    public class Program {
        static void Main(string[] args) {

            //IcertisDemo.VersionFilters versionFilters = new IcertisDemo.VersionFilters();
            //versionFilters.Message = "Hello December!!!";
            //versionFilters.PrintMessage(versionFilters.Message);

            MyDerived myDerived = new MyDerived();


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

            //SimplifyHealthCareTest simplifyTest = new SimplifyHealthCareTest();
            //int[] marks = new int[] { 4, 9, 4, 3, 2, 10 };
            //simplifyTest.GetSelctionChances(20, new int[] { 20, 19, 18, 17, 16, 15, 14, 13, 12, 11, 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 });

            //CitiBank citiBank = new CitiBank();
            //IA aRef = new CitiBank();
            //IB bRef = new CitiBank();
            //aRef.Show("IA interface calling.");
            //bRef.Show("IB interface calling.");
            //citiBank.Show("citi bank interview");
            //NiceParent child = new NiceChild();
            //child.Print();

            // AccessModifier_Derived accessModifier_Derived = new AccessModifier_Derived();
            //accessModifier_Derived.Print2();

            //AccessModifier_Derived2 accessModifier_Derived2 = new AccessModifier_Derived2();
            //accessModifier_Derived2.Print();

            // Maths2 t = new Maths2(10);
            Console.WriteLine("Enter the number...");
            int n = Convert.ToInt32(Console.ReadLine().Trim());

            AmazonTest.fizzBuzz(n);
            Console.WriteLine("Do you want to run again, press Y...");
            string choice = Console.ReadLine().Trim();
            IsRunAgain(choice);
            Console.ReadLine();
        }

        static void IsRunAgain(string choice) {
            switch (choice) {
                case "y":
                case "Y":
                    Console.WriteLine("Enter the number...");
                    int n = Convert.ToInt32(Console.ReadLine().Trim());

                    AmazonTest.fizzBuzz(n);
                    break;
                default:
                    Console.WriteLine("Press enter to exit.");
                    break;
            }
        }
    }
}
