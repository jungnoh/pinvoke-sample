using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;

namespace csharp
{
    // Note: 디자인 패턴에서 이야기 하는 어댑터가 아닙니다.
    static class InitialPosAdapter
    {
        [DllImport("cpp.dll")]
        private static extern int initialPos(int h, int w, [In, Out] int[] map, [In, Out] int[] ret);

        public static Vector2[] InitialPos(int[,] map)
        {
            var result = new List<Vector2>();

            int h = map.GetLength(0);
            int w = map.GetLength(1);
            var mapArray = new int[h * w];
            for (int i=0; i<h*w; i++)
            {
                mapArray[i] = map[i / w, i % w];
            }
            var resultArr = new int[2 * h * w];
            var count = initialPos(h, w, mapArray, resultArr);
            for (int i=0; i<count; i++)
            {
                result.Add(new Vector2(resultArr[2 * i], resultArr[2 * i + 1]));
            }

            return result.ToArray();
        }
    }
}
