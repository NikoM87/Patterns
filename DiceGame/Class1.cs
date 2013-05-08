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

            scope += GetScopeMix( count );
            scope += GetScopeFive( count );
            scope += GetScopeFour( count );
            scope += GetScopeThee( count );
            scope += GetScopeOne( count );

            return scope;
        }

        private static int GetScopeMix( int[] count )
        {
            int scope = 0;

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

            return scope;
        }

        private static int GetScopeFive( int[] count )
        {
            if ( count[1] >= 5 )
            {
                count[1] -= 5;
                return 4000;
            }
            return 0;
        }

        private static int GetScopeFour( int[] count )
        {
            if ( count[1] >= 4 )
            {
                count[1] -= 4;
                return 2000;
            }
            return 0;
        }

        private static int GetScopeOne( int[] count )
        {
            int scope = 0;
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

        private static int GetScopeThee( int[] count )
        {
            int scope = 0;

            for ( int i = 0; i < count.Length; i++ )
            {
                if ( count[i] >= 3 )
                {
                    if ( i == 1 )
                    {
                        scope += 1000;
                    }
                    else
                    {
                        scope += i * 100;
                    }
                    count[i] -= 3;
                }
            }

            return scope;
        }
    }
}
