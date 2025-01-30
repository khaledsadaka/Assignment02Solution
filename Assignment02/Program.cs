using System.Collections;

namespace Assignment02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.

            /*
            int[] nums = { 1, 10, 30, 44, 55 };
            int queries = 2;
            Helper.CheckArray(nums, queries);
            */

            /////////////////////////////////////////////////////////////////////

            //2.

            /*

            int N = int.Parse(Console.ReadLine());


            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            bool isPalindrome = true;
            for (int i = 0; i < N / 2; i++)
            {
                if (arr[i] != arr[N - i - 1])
                {
                    isPalindrome = false;
                    break;
                }
            }
            Console.WriteLine(isPalindrome ? "YES" : "NO");

            */


            /////////////////////////////////////////////////////////////////////



            //3.

            /*

            Queue queue = new Queue();

            for (int i = 1; i <= 15; i++)
            {
                queue.Enqueue(i);
            }

            Console.WriteLine("Queue Before Reverse");
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.Write("\n");


            queue = Helper.ReverseQueue(queue);
            Console.WriteLine("Queue After Reverse");

            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }


            */

            /////////////////////////////////////////////////////////////////////


            //4.




            /////////////////////////////////////////////////////////////////////



            //5. 

            /*

            int[] nums = { 1, 2, 3, 2, 4, 4, 3, 2 };

            nums = Helper.RemoveDuplicate(nums);
            foreach (int item in nums)
            {
                Console.Write(item + " ");
            }

            */


            /////////////////////////////////////////////////////////////////////


            //6.

            /*

            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 9, 11, 13 };

            Helper.RemoveAllOddNumbers(list);

            Console.WriteLine(string.Join(" ", list));

            */

            /////////////////////////////////////////////////////////////////////



            //7. 

            /*
            Helper.CreateQueue();
            */


            /////////////////////////////////////////////////////////////////////


            //8.



            /////////////////////////////////////////////////////////////////////


            //9.

            /*

            int[] array1 = { 1, 2, 3, 4, 4 };
            int[] array2 = { 10, 4, 4 };

            int[] result = Helper.FindIntersection(array1, array2);

            Console.WriteLine($"Intersection: [" + string.Join(", ", result) + "]");

            */


            /////////////////////////////////////////////////////////////////////



            //10.

            
            ArrayList arrList = new ArrayList() { 1, 2, 3, 7, 5 };
            int target = 12;
            int[]? result = Helper.FindTarget(arrList, target);

            foreach (int item in result)
            {
                Console.Write(item + " ");
            }



            /////////////////////////////////////////////////////////////////////



            //11. 


        }
    }
}