using System.Collections.Generic;
namespace IcertisDemo {
    public class VersionFilters {
        internal int number = 10;
        public string Message = "Hello Pushkar";
        private protected string InheritMessage = "Use of Protected";
        private protected bool Choice;
        public VersionFilters() {
            Choice = true;
        }

        internal void GetOldestVersion() {
            var fileData = System.IO.File.ReadAllLines(@"D:\Practices\InterviewsDemo\IcertisDemo\Data\Product.txt");
            var products = new Dictionary<string, string>();

        }

        public void PrintMessage(string msg) {
            System.Console.WriteLine(msg);

        }

        protected void PrintInheritMessage(string msg) {
            System.Console.WriteLine(msg);

        }
    }
}
