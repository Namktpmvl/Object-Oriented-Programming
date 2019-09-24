using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            HorizontalLine(20, '*'); Console.WriteLine();
            
            VerticalLine(10, '*'); Console.WriteLine();
            
            DiagonalLine(1,'*'); Console.WriteLine();
            DiagonalLine(2,'*'); Console.WriteLine();
            DiagonalLine(3,'*'); Console.WriteLine();
            DiagonalLine(4,'*'); Console.WriteLine();

            DrawTriangle(10, '*'); Console.WriteLine();
        
        }

        static void HorizontalLine (int n, char c )
        {
            for (int i = 0; i < n; i++)
                Console.Write(c);
        }
        
        static void VerticalLine(int n, char c)
        {
            for (int i = 0; i < n; i++)
                Console.WriteLine(c);
        }


        static void DiagonalLine (int n, char c)
        {
            for ( int i = 0; i < n; i++)
                HorizontalLine(i,' ');
                Console.WriteLine(" " + c);
        }

        //first line: n-1 spaces , 1 star
        // second line: n-2 spaces, 1 star , 1 space , 1 star
        // third line: n-3 spaces, 1 star , 3 space , 1 star
        // fourth line: n-4 spaces, 1 star , 4 space , 1 star
        //last line : 2n-1 star
        static void DrawTriangle (int n, char c)
        {
            //first line
            HorizontalLine(n-1, ' '); HorizontalLine(1,'*');
            
            int a = 2, b = 1;
            for (int i = 0; i < n-2; i++ )
            {
                HorizontalLine(n - a, ' '); HorizontalLine(1, '*');
                HorizontalLine(b, ' '); HorizontalLine(2, '*'); Console.WriteLine();
                a = a + 1;
                b = b +2;
            }

            //last line
            HorizontalLine(2*n-1, '*');Console.WriteLine();
        }
    }
}
