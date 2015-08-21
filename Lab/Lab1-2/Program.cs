using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        static void Main(string[] args)
		{
            

			input ();

		}

		public static void input()
		{ 
			string a;
			Console.WriteLine ("INPUT NUMBER: ");
			a = Console.ReadLine ();
			process (a);
		}

            // process
		public static void process(string input1)
		{
			int[] xinput = new int[Convert.ToInt32 (input1)];

			for(int i=0 ; i <= Convert.ToInt32 (input1) ; i++)
			{
				xinput [i] = Convert.ToInt32 (Console.ReadLine ());
			}

			int[] input = xinput;


			bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }

			output (input);
		}

            // output
		public static void output(int[] input)
		{
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }

    }
}
