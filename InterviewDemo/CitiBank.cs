using System;

namespace InterviewDemo {
    public class BaseClass {
        public string Show(string message) {
            Console.WriteLine("Base Class message : {0}", message);
            return message;
        }
    }
    public class CitiBank : BaseClass, IA, IB {
       
    }

    public interface IA {
        string Show(string message);
    }
    public interface IB {
        string Show(string message);
    }
}
//public string Show(string message) {
//    System.Console.WriteLine("Derived Class message : {0}", message);
//    return message;
//}