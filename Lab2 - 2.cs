using System;
using System.Threading.Tasks;

namespace ConsoleApp71
{
   public class Program
    {
        static void Main(string[] args)
        {
            TVector2D vec1 = new TVector2D();
            vec1.EnterVec();
            vec1.ShowVec();
            TVector2D vec2 = new TVector2D(22, 3);
            vec2.ShowVec();
            TVector2D vec3 = new TVector2D(vec1);
            vec3.ShowVec();
            vec3.EnterVec(8, 9);
            vec3.ShowVec();
            Console.WriteLine(vec1.VecLength());
            vec1.VecNormal();
            vec1.VecEquals(vec2);
            Console.WriteLine(vec1+vec2);
            Console.WriteLine(vec1 - vec2);
            Console.WriteLine(vec1 * vec2);

        }
    }
   public class TVector2D
    {
        private double a_;
        private double b_;
        public double a
        {
            get { return a_; }
            set
            {
                a_ = value;
            }
        }
        public double b
        {
            get { return b_; }
            set
            {
                b_ = value;
            }
        }
        public TVector2D() { }
        public TVector2D(double a, double b)
        {
            this.a = a;
            this.b = b;
        }
        public TVector2D(TVector2D vec)
        {
            this.a = vec.a;
            this.b = vec.b;
        }
        override public string ToString()
        {
            return "a: " + a +" "+ "b: " + b;
        }
        public virtual void EnterVec()
        {
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            this.a = a;
            this.b = b;
        }
        public virtual void EnterVec(double a, double b)
        {

            this.a = a;
            this.b = b;
        }
       public virtual void ShowVec()
        {

            Console.WriteLine("a: " + a + "  " + "b: " + b);
        }
       public virtual double VecLength()
        {
            return Math.Abs(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2)));
        }
       public virtual void VecNormal()
        {

            double n = a / this.VecLength();
            double m = b / this.VecLength();
            Console.WriteLine("Normalized Vec: (" + n + ";" + m + ")");

        }
        public virtual void VecEquals(TVector2D vec)
        {
            string equals = "";
            if (a == vec.a && b == vec.b)
            {
                equals = "Vec1 equals Vec2";
            }
            else
            {
                equals = "Vec1 not equals to vec2";
            }
            Console.WriteLine(equals);
        }
        public static TVector2D operator +(TVector2D a, TVector2D b)
        {
            double n = a.a + b.a;
            double m = a.b + b.b;
            TVector2D vec = new TVector2D(n,m);
            return vec;
         
        }
        public static TVector2D operator -(TVector2D a, TVector2D b)
        {
            double n = a.a - b.a;
            double m = a.b -b.b;
            TVector2D vec = new TVector2D(n, m);
            return vec;

        }
        public static double operator *(TVector2D a, TVector2D b)
        {
            double n = a.a * b.a;
            double m = a.b * b.b;
            
            return n+m;

        }
    }
   public class TVector3D : TVector2D
    {
        private double c_;
        public double c
        {
            get { return c_; }
            set
            {
                c_ = value;
            }
        }
        public TVector3D() { }
        public TVector3D(double a,double b,double c) :base(a,b)
        {
            this.c = c;
        }
        public TVector3D(TVector3D vec)
        {
            this.a = vec.a;
            this.b = vec.b;
            this.c = vec.c;
        }
        override public string ToString()
        {
            return "a: " + a  + " b: " + b+" c: "+c;
        }
     override public void EnterVec()
        {
            Console.WriteLine("Enter a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter b");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter c");
            int c = int.Parse(Console.ReadLine());
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void EnterVec(double a, double b,double c)
        {

            this.a = a;
            this.b = b;
            this.c = c;
        }
       override public void ShowVec()
        {

            Console.WriteLine("a: " + a + " b: " + b+" c: "+c);
        }
      override public double VecLength()
        {
            return Math.Abs(Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2) + Math.Pow(c, 2)));
        }
        public new void VecNormal()
        {

            double n = a / this.VecLength();
            double m = b / this.VecLength();
            double z = c / this.VecLength();
            Console.WriteLine("Normalized Vec: (" + n + ";" + m + ";" + z+ ")");

        }
        public void VecEquals(TVector3D vec)
        {
            
            if (a == vec.a && b == vec.b&& c == vec.c)
            {
                Console.WriteLine("Vec1 equals Vec2");
            }
            else
            {
                Console.WriteLine("Vec1 not equals to vec2");
            }
           
        }
        public static TVector3D operator +(TVector3D a, TVector3D b)
        {
            double n = a.a + b.a;
            double m = a.b + b.b;
            double z = a.c + b.c;
            TVector3D vec = new TVector3D(n, m, z);
            return vec;

        }
        public static TVector3D operator -(TVector3D a, TVector3D b)
        {
            double n = a.a - b.a;
            double m = a.b - b.b;
            double z = a.c - b.c;
            TVector3D vec = new TVector3D(n, m, z);
            return vec;

        }
        public static double operator *(TVector3D a, TVector3D b)
        {
            double n = a.a * b.a;
            double m = a.b * b.b;
            double z = a.c * b.c;

            return n + m + z;

        }

    }
}



