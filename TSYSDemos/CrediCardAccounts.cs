using System;
using System.Collections;
using System.Linq;

namespace TSYSDemos {
    #region 2nd Round
    public class CrediCardAccounts {
        public CrediCardAccounts() {
            int numberOfAccounts = 100;
            //List<Account> _accountList = new List<Account>();
            Account[] accountArray = new Account[numberOfAccounts];
            ArrayList arrayList = new ArrayList();
            Random rnd = new Random();

            for (int i = 0; i < numberOfAccounts; i++) {
                var account = new Account();

                account.AccountHolderName = "Vinay_" + i.ToString();
                account.AccountNumber = 7090 + i;
                account.HolderId = 101 + i;
                account.OutstandingBalance = rnd.Next(32432, 80000);
                account.Balance = 906 + rnd.Next(10, 100);

                accountArray[i] = account;
                arrayList.Add(account);
                // _accountList.Add(account);
            }
            GetAccount(accountArray);
        }
        public void GetAccount(Account[] accountList) {

            var result = accountList.Where(acc => acc.Balance == 0);

            var riskyAccounts = from account in accountList
                                where account.OutstandingBalance >= 75000
                                select account;
            foreach (var item in riskyAccounts) {
                Console.WriteLine("{0} has risky account.", item.AccountHolderName);
            }


            //return riskyAccounts.ToList();
        }
    }

    #endregion

    public class Vehicle {
        public static void Print(Car car) {
            try {
                Console.WriteLine(car.Name);

            } catch (ArgumentException ex) {

                Console.WriteLine("ArgumentException");
            } catch (NullReferenceException) {
                Console.WriteLine("NullReferenceException");
            } catch (Exception) {
                Console.WriteLine("Exception");
            }
        }
    }

    public class ActionTypeDemo {

        public static void GetPerson() {

            var person = new Person() {
                FirstName = "Vinay",
                LastName = "pal"
            };

            Action print = () => Console.WriteLine($"{person.FirstName} {person.LastName}");

            person.FirstName = "Kihu";
            person.LastName = "Singh";

            print();
        }
    }

}
