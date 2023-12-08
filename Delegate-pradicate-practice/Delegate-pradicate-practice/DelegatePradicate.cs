using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_pradicate_practice
{
    internal class DelegatePradicate
    {

        //public delegate bool CheckNums(int num);

        //public bool CheckOddNums(int num)
        //{
        //    return num % 2 == 1;
        //}

        //public bool CheckEvenNums(int num)
        //{
        //    return num % 2 == 0;
        //}

        public void SumOfNums(List<int> nums , Predicate<int> func)
        {
            int sum = 0;
            foreach (int num in nums)
            {
                if(func(num))
                {
                    sum += num;
                }
            }
            Console.WriteLine(sum);

        }


        public void ShowResult()
        {
            List<int> nums = new List<int>() { 1,2,3,4,5,6,7,8};

            SumOfNums(nums, num => num %2 == 1);
            SumOfNums(nums, num => num % 2 == 0);
        }


    }
}
