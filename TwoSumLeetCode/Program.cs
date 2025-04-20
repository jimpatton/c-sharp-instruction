namespace TwoSumLeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Two Sum Leet Code Challenge/n");

            int[] nums = [2, 7, 11, 15];
            //test case 1
            int[] indicies = TwoSum(nums, 9);
            DisplayResults(indicies, "Test Case 1");

            nums = [3, 2, 4];
            //test case 1
            indicies = TwoSum(nums, 6);
            DisplayResults(indicies, "Test Case 2");

            nums = [1, 3, 7, 12, 15];
            //test case 1
            indicies = TwoSum(nums, 19);
            DisplayResults(indicies, "Test Case 3");

            PrintLine("Bye");
        }

        static void DisplayResults(int[] indicies, string msg)
        {
            PrintLine(msg);
            foreach (int i in indicies)
            {
                Print($"index: {i}, ");
            }
            PrintLine("");
        }
        static public int[] TwoSum(int[] nums, int target)
        {
            int[] indicies = new int[2];
            //nums - array of ints, one pair of numbers, summed = target
            //return indicies of those 2 numbers
            //my 1st number
            bool found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                if (found)
                {
                    break;
                }
                // my second number
                for (int j = 0; j < nums.Length; j++)
                {

                    if (i != j) { 
                    //Print($"{nums[i]} + {nums[j]},  ");
                    int sum = nums[i] + nums[j];
                        if (sum == target)
                        {
                            //Print("Target!!! ");
                            indicies = [i, j];
                            found = true;
                            break;
                        }
                    }
                }
            
            //PrintLine("");
        }


            return indicies;
        }




            static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }


    }
}
