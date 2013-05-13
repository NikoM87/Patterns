using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DiceGame
{
    public class Calculator
    {
        private int[] count;

        public int Run( int[] x )
        {
            Init( x );
            return CalcScope();
        }

        private void Init( int[] x )
        {
            count = new int[7];
            foreach ( int a in x )
            {
                count[a]++;
            }
        }

        private int CalcScope()
        {
            int scope = 0;

            scope += GetScope( new int[] { 1, 1, 1, 1, 1, 0 }, 8000 );
            scope += GetScope( new int[] { 0, 1, 1, 1, 1, 1 }, 8000 );
            scope += GetScope( new int[] { 5, 0, 0, 0, 0, 0 }, 4000 );
            scope += GetScope( new int[] { 4, 0, 0, 0, 0, 0 }, 2000 );
            scope += GetScope( new int[] { 3, 0, 0, 0, 0, 0 }, 1000 );
            scope += GetScope( new int[] { 0, 0, 0, 0, 0, 3 }, 600 );
            scope += GetScope( new int[] { 0, 0, 0, 0, 3, 0 }, 500 );
            scope += GetScope( new int[] { 0, 0, 0, 3, 0, 0 }, 400 );
            scope += GetScope( new int[] { 0, 0, 3, 0, 0, 0 }, 300 );
            scope += GetScope( new int[] { 0, 3, 0, 0, 0, 0 }, 200 );
            scope += GetScope( new int[] { 1, 0, 0, 0, 0, 0 }, 100 );
            scope += GetScope( new int[] { 0, 0, 0, 0, 1, 0 }, 50 );

            return scope;
        }

        private bool CheckSet( int[] set )
        {
            bool res = true;
            for ( int i = 0; i < set.Length; i++ )
            {
                res &= count[i + 1] >= set[i];
            }

            return res;
        }

        private void RemoveSet( int[] set )
        {
            for ( int i = 0; i < set.Length; i++ )
            {
                count[i + 1] -= set[i];
            }
        }

        private int GetScope( int[] set, int scope )
        {
            if ( CheckSet( set ) )
            {
                RemoveSet( set );
                return scope;
            }
            return 0;
        }
    }
}
