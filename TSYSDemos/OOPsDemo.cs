using System;

namespace TSYSDemos {
    public class OOPsDemo : IDisposable {
        public static void GetFamilyMember() {
            Father familyPerson = new Father();
            Print<Father>(familyPerson);
        }

        public void WriteTrasaction() {
            System.Console.WriteLine("transaction successfully written!!!");
        }

        private static void Print<T>(T familyMember) where T : GrandFather {
            familyMember.Print();
        }

        public void Dispose() {
            Console.WriteLine("Disposed!!!");
        }
    }

    public class GrandFather {
        public virtual void Print() {
            System.Console.WriteLine("Grand Father");
        }
    }
    public class Father : GrandFather {
        public override void Print() {
            System.Console.WriteLine("Father");
        }
    }
    public class Child : Father {
        public override void Print() {
            System.Console.WriteLine("Child");

        }
    }
}
