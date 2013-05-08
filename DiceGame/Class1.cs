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

            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            int count4 = 0;
            int count5 = 0;
            int count6 = 0;

            foreach ( int a in x )
            {
                switch ( a )
                {
                    case 1:
                        count1++;
                        break;
                    case 2:
                        count2++;
                        break;
                    case 3:
                        count3++;
                        break;
                    case 4:
                        count4++;
                        break;
                    case 5:
                        count5++;
                        break;
                    case 6:
                        count6++;
                        break;
                }
            }

            if ( count1 >= 1 && count2 >= 1 && count3 >= 1 && count4 >= 1 && count5 >= 1 )
            {
                scope += 8000;
                count1 -= 1;
                count2 -= 1;
                count3 -= 1;
                count4 -= 1;
                count5 -= 1;
            }

            if ( count2 >= 1 && count3 >= 1 && count4 >= 1 && count5 >= 1 && count6 >= 1 )
            {
                scope += 8000;
                count2 -= 1;
                count3 -= 1;
                count4 -= 1;
                count5 -= 1;
                count6 -= 1;
            }

            if ( count1 >= 5 )
            {
                scope += 4000;
                count1 -= 5;
            }
            
            if ( count1 >= 4 )
            {
                scope += 2000;
                count1 -= 4;
            }

            if ( count1 >= 3 )
            {
                scope += 1000;
                count1 -= 3;
            }

            if ( count2 >= 3 )
            {
                scope += 200;
                count2 -= 3;
            }

            if ( count3 >= 3 )
            {
                scope += 300;
                count3 -= 3;
            }

            if ( count4 >= 3 )
            {
                scope += 400;
                count4 -= 3;
            }

            if ( count5 >= 3 )
            {
                scope += 500;
                count5 -= 3;
            }

            if ( count6 >= 3 )
            {
                scope += 600;
                count6 -= 3;
            }

            if ( count1 >= 1 )
            {
                scope += 100;
                count1 -= 1;
            }

            if ( count5 >= 1 )
            {
                scope += 50;
                count5 -= 1;
            }

            return scope;
        }
    }
}

