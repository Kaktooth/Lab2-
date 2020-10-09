using System;

namespace ConsoleApp70
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr=Enter();
            Arr a = new Arr(arr);
            a.ShowArray();
            Console.WriteLine(" min: "+a.Min());
            Console.WriteLine(" max: " + a.Max());
            Arr b = new Arr();
            b.ShowArray();
            Console.WriteLine(" min: " + b.Min());
            Console.WriteLine(" max: " + b.Max());


        }
        public static int[] Enter()
        {
            int[] arr;
            Console.WriteLine("Enter length of array");
            int l = int.Parse(Console.ReadLine());
            arr = new int[l];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
      
    }
    class Arr
    {
        private int[] array;
        public Arr() { array=EnterArr(); }
        public Arr(int[] arr)
        {
            array = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }

        }
        public int[] EnterArr()
        {
           int[] arr;
            Console.WriteLine("Enter length of array");
            int l = int.Parse(Console.ReadLine());
            arr = new int[l];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }
        public int Length
        {
            get{ return this.array.Length; }
        }
        public void ShowArray()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]+" ");
            }
            Console.WriteLine();
        }
        public int[] GetArray()
        {
            return array;
        }
        public int Max()
        {
            int max;
            int max2=0;
            for (int i = 1; i < array.Length; i++)
            {
                max = Math.Max(array[i], array[i - 1]);
                max2 = Math.Max(max, max2);
            }
            return max2;
        }
        public int Min()
        {
            int min;
            int min2=Max();
            for (int i = 1; i < array.Length; i++)
            {
                min = Math.Min(array[i],array[i-1]);
                min2 = Math.Min(min, min2);
            }
            return min2;
        }
        public int this[int index]
        {
            get
            {
                if(index>=0&& index<array.Length)
                {
                    return array[index];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                if(index >= 0 && index < array.Length)
                {
                    array[index] = value;
                }
            }
        }

    }
}
