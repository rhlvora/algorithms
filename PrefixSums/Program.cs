using System;

namespace PrefixSums
{
    class Program
    {
        static void Main(string[] args)
        {	
			Mushrooms();
        }

		static void Mushrooms()
		{
			//mushroom picker problem
			//given an array of the number of mushrooms growing in consecutive spots
			//A=[2,3,7,5,1,3,9]
			//k = starting spot
			//m = number of moves
			//maximize the number of mushrooms collected

			//if we were to walk along this path, with an arbitrary starting position
			//we'd only want to change direction once (if at all)

			int[] A = new int[] {2,3,7,5,1,3,9};

			int k = 3;
			int m = 6;

			//move to the right by i, then move to the left by m-i
			for(int i = 0; i < m; i++)
			{
				//number of moves the other direction
				int j = m-i;
			}

			Console.WriteLine(CalcNumberMushrooms(A, 3, 2, 2));
		}

		//move i to the right
		//move j to the left
		//if I go beyond the boundary of the array, add 0s
		static int CalcNumberMushrooms(int[] A, int k, int i, int j)
		{
			//assume you pick up the mushrooms at the starting spot
			int Acc = A[k];
			A[k] = 0;

			Console.WriteLine("starting " + k);
			
			//move to the right
			for(int x = 0; x < i; x++)
			{
				k++;
				//if we haven't gone off the edge to the right
				if(k < A.Length)
				{
					Console.WriteLine("right " + k);

					Acc = Acc + A[k];
					//don't want to double count, set it to 0
					A[k] = 0;
				}
			}

			//move to the left
			for(int x = j; x > 0; x--)
			{
				k--;
				//if we haven't gone off the edge to the left
				if(k > 0 && k < A.Length)
				{
					Console.WriteLine("left " + k);

					Acc = Acc + A[k];

					A[k] = 0;
				}

			}

			return Acc;
		}

    }
}
