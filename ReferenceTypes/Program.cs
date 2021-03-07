using System;

namespace ReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Arr = new int[2] {10,10};


			Console.WriteLine("array is passed as usual");
			Console.WriteLine("we can change the values of the array");
			Console.WriteLine("but we cannot change the actual array reference");

			Console.WriteLine(Arr[0]);

			DoSomething(Arr);

			Console.WriteLine(Arr[0]);

			Console.WriteLine("array ref is passed this time");
			Console.WriteLine("this time we can change the reference itself");

			Arr = new int[2] {10, 10};
			Console.WriteLine(Arr[0]);

			DoSomething2(ref Arr);

			Console.WriteLine(Arr[0]);

			
        }


		//testing reference type array
		static void DoSomething(int[] arr)
		{
			//this sets arr[0] to 0
			//because the reference is passed by value
			//to actually change the reference itself, you have to use the ref tag
			arr[0] = 0;

			//this won't work
			arr = new int[2] {3,3};
		}

		static void DoSomething2(ref int[] arr)
		{
			//this time use the ref

			arr[0] = 0;

			//this will work
			arr = new int[2] {3,3};
		}


    }
}
