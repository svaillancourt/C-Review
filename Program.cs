using System;

namespace C_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 30;
            Console.WriteLine("Hello Stephane!\n\n" + x + "\n" );

            if (x < 30 ) 
            {
                Console.WriteLine("X is less than thirty!\n");
            }else if (x == 30) {
                Console.WriteLine("X is thirty!\n");            
            }else{
                Console.WriteLine("X is greater than Thirty!\n");
            }
            
            int a = 4;
            switch ( a )
            {
                case 1 : 
                    Console.WriteLine( "Value is 1!" );
                    break;
                case 2 : 
                    Console.WriteLine( "Value is 2!" );
                    break;
                case 3 : 
                    Console.WriteLine( "Value is 3!" );
                    break;
                default : 
                    Console.WriteLine( "\nCongrats you won a $20 gift card to panago! \n\nClick here!\n\n" );
                    break; 
            }    
        }
    }
}
