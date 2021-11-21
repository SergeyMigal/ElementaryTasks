using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LuckyTickets
{
    class CountingLuckyTickets
    {
        int countFirstMethod;
        int countSecondMethod;
        bool isLuckyNumberFirstMethod;
        bool isLuckyNumberSecondMethod;

        List<int> NumberTicketAfterConvertatoin = new List<int>();
        List<int> vs = new List<int>();
        public CountingLuckyTickets(InputDataReader inputDataReader)
        {
            this.vs = inputDataReader.ReadData();
        }
        public int CreateArrayLuckyNumbers()
        {
            for (int a = vs.ElementAt(0); a <= vs.ElementAt(1); a++)
            {
                string b = Convert.ToString(a);

                int[] NumberTicketsAfterConvertation = b.Select(x => (int)Char.GetNumericValue(x)).ToArray();
                if (isLuckyNumberFirstMethod = NumberTicketsAfterConvertation[0] + NumberTicketsAfterConvertation[1] + NumberTicketsAfterConvertation[2] == NumberTicketsAfterConvertation[3] + NumberTicketsAfterConvertation[4] + NumberTicketsAfterConvertation[5])
                {
                    countFirstMethod += 1;
                }
                else if (isLuckyNumberSecondMethod = NumberTicketsAfterConvertation.Where(x => x % 2 == 0).Sum() == NumberTicketsAfterConvertation.Where(x => x % 2 != 0).Sum())
                {
                    countSecondMethod += 1;
                }
            }
            if (countFirstMethod > countSecondMethod)
            {
                return countFirstMethod;
            }
            else
            {
                return countSecondMethod;
            }
        }
    }
}
