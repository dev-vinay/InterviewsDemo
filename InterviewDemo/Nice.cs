using System;

namespace InterviewDemo {
    public class NiceParent {
        public NiceParent() {
            Console.WriteLine("Parent Constructor.");
        }

        public virtual void Print() {
            Console.WriteLine("Parent Print Called.");
        }
    }
    public class NiceChild : NiceParent {
        public NiceChild() {
            Console.WriteLine("Chile Constructor.");
        }
        public new void Print() {

            Console.WriteLine("Child Print Called.");
            //NiceChild child = new NiceChild();
            //child.Print();
            base.Print();
        }

    }
    public abstract class NiceAbstract {
        internal abstract void Print1();
        internal abstract void Print2();
        internal abstract void Print3();
        internal abstract void Print4();
    }
    public class Maths0 {
        internal int i;
        public Maths0(int ii) {
            ii = 12;
            int j = 12;
            int r = ii * j;
            Console.WriteLine(r);
        }

        public string doA() {
            return "a1";
        }

        public virtual int EmpId { get; set; }
        public static string message = string.Empty;
        public delegate void Notify();
        public virtual event Notify ProcessCompleted;
    }

    class Maths1 : Maths0 {
        public Maths1(int a) : base(a) {
            a = 13;
            int b = 21;
            Console.WriteLine(a + b);
        }

        public new string doA() {
            return "b1";
        }
    }

    class Maths2 : Maths1 {
        public Maths2(int k) : base(k) {
            k = 24;
            int o = 16;
            Console.WriteLine(k / o);

            int i = 2, j = i;
            if (Convert.ToBoolean((i | j & 5) & (j - 25 * 1)))
                Console.WriteLine(1);
            else
                Console.WriteLine(0);
        }

        public int func1() { return 1; }
        public string func1(string a) { return "a"; }
    }
}
