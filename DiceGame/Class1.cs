using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    public static class TCalculator
    {
        public static int Run( int[] x )
        {
            int scope = 0;

            int[] count = new int[7];
            
            foreach ( int a in x )
            {
                count[a]++;
            }

            if ( count[1] >= 1 && count[2] >= 1 && count[3] >= 1 && count[4] >= 1 && count[5] >= 1 )
            {
                scope += 8000;
                count[1] -= 1;
                count[2] -= 1;
                count[3] -= 1;
                count[4] -= 1;
                count[5] -= 1;
            }

            if ( count[2] >= 1 && count[3] >= 1 && count[4] >= 1 && count[5] >= 1 && count[6] >= 1 )
            {
                scope += 8000;
                count[2] -= 1;
                count[3] -= 1;
                count[4] -= 1;
                count[5] -= 1;
                count[6] -= 1;
            }

            if ( count[1] >= 5 )
            {
                scope += 4000;
                count[1] -= 5;
            }
            
            if ( count[1] >= 4 )
            {
                scope += 2000;
                count[1] -= 4;
            }

            if ( count[1] >= 3 )
            {
                scope += 1000;
                count[1 ]-= 3;
            }

            if ( count[2] >= 3 )
            {
                scope += 200;
                count[2] -= 3;
            }

            if ( count[3] >= 3 )
            {
                scope += 300;
                count[3] -= 3;
            }

            if ( count[4] >= 3 )
            {
                scope += 400;
                count[4] -= 3;
            }

            if ( count[5] >= 3 )
            {
                scope += 500;
                count[5] -= 3;
            }

            if ( count[6 ]>= 3 )
            {
                scope += 600;
                count[6] -= 3;
            }

            if ( count[1] >= 1 )
            {
                scope += 100;
                count[1] -= 1;
            }

            if ( count[5] >= 1 )
            {
                scope += 50;
                count[5] -= 1;
            }

            return scope;
        }
    }
}
