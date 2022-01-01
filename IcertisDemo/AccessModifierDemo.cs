using System;
namespace IcertisDemo {
    internal class AccessModifierDemo : VersionFilters {
        public AccessModifierDemo() {
            number = 20;
            Message = "New Message Hello Pushkar";
            InheritMessage = "New Inherit Message";

            GetOldestVersion();
            PrintMessage(Message);
            PrintInheritMessage(InheritMessage);
        }

        private string _name = "1023";// string.Empty;   //1002   Reference Type
        public int Id { get; set; }

        private int _id = 101;  //Value Type



        //Value Type & Reference Type
        //Swallow Copy and Deep Copy
        //Boxing and Un-Boxing

        public string Name {
            get { return _name; }
            set { _name = value; }
        }

        public string PrintName() {
            string nme = _name;

            _name = _id.ToString();   //This assignment of variables are known as BOXING.
            _id = Convert.ToInt32(_name);   //UnBoxing

            int idName = 90;
            idName = _id;
            string emp = "id : " + Id.ToString() + " Name : " + _name;
            return emp;
        }
    }

    public class MyDerived {


        public MyDerived() {
            AccessModifierDemo accessModifierDemo = new AccessModifierDemo();
            //VersionFilters versionFilters = new VersionFilters();
            accessModifierDemo.Id = 101;
            accessModifierDemo.Name = "Vinay";
            System.Console.WriteLine(accessModifierDemo.PrintName());
        }
    }
}
