using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Others
{
    public class PascalTriangle
    {
        public  IList<IList<int>> Generate(int numRows)
        {
            var triangle = new List<IList<int>>();

            for (int i = 0; i < numRows; i++)
            {
                var row = new List<int>();
                for (int j = 0; j <= i; j++)
                {
                    if (j == 0 || j == i)
                    {
                        row.Add(1); // First and last element of the row is always 1
                    }
                    else
                    {
                        int val = triangle[i - 1][j - 1] + triangle[i - 1][j];
                        row.Add(val); // Sum of two numbers above
                    }
                }
                triangle.Add(row);
            }

            return triangle;
        }
    }
}
