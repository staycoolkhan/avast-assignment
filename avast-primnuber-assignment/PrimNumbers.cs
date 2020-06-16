using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace avast_primnuber_assignment
{
    public class PrimNumbers
    {
        public bool DisplayPrimerNumber(int end)
        {
            var primList = new List<int>();

            for (var num = 1; num <= end; num++)
            {

                var x = 0;

                for (var i = 2; i <= num / 2; i++)
                {
                    if (num % i == 0)
                    {
                        x++;
                        break;
                    }
                }

                if (x == 0 && num != 1)
                {
                    Console.WriteLine(num);
                    primList.Add(num);
                }

            }

            bool isExist = primList.Any();

            if (isExist)
            {
                return true;
            } else
            {
                return false;
            }
        }

    }
}
