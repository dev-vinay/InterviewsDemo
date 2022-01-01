using System;

namespace InterviewDemo {
    class AccessModeifiersDemo {
        protected int numBase1 = 1;
        public AccessModeifiersDemo() {
            Console.WriteLine("Base 1");
        }

        protected internal void Print() {
            Console.WriteLine("Base 1 print");
        }
    }

    class AccessModifier_Derived : AccessModeifiersDemo {
        protected int numBase2 = 2;

        public AccessModifier_Derived() {
            Console.WriteLine("Derived of Base 1. Used as Base 2 for next level");
        }

        protected void Print2() {

            Console.WriteLine("Base 2 print");
        }
    }

    class AccessModifier_Derived2 : AccessModifier_Derived {
        protected int numDerived = 3;
        public AccessModifier_Derived2() {
            Console.WriteLine("Derived 2 Constructor");
        }

        protected void Print3() {

            Console.WriteLine("Derived class");
        }
    }
}
