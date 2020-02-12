using System;

namespace C_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMethod();

            // Let's try an array!
            int[] myarray = new int[5] { 3, 4, 5, 6, 7};    // [5] determines the amount of slots {#,#,#,#,#} 
            myarray[0] = 2;     // replacing the first index with a 2
            Console.WriteLine( myarray[0]);

            // lets try a for a loop!
            for (int i = 0; i < 5; i++){        // intializing, setting a contidion, interate
                Console.WriteLine("Array Index: " + i + " | Array Value: "+ myarray[i]);
            }

            // Let's try a while loop
            int n = 0;
            while(n < 5){
                Console.WriteLine("Array Index: " + n + " | Array Value: "+ myarray[n]);
                n = n + 2;  // or n += 2;  you can determine the value
            }
            // Let's try a foreach! // they stop themselves at the end of the collection.
            foreach ( int e in myarray){  // foreach (int element in fibNumbers)
                Console.WriteLine("Current Foreach Value is: " + e);
            }
            
            Console.WriteLine("Please enter your name: "); // good idea to ask a user so they what you wnat:p
            string myname  = Console.ReadLine();  // Stores their input, or it will be lost forver >.<
            Console.WriteLine("Thank you, " + myname + "! Nice to meet you!");
        }

            // let's try making a mehtod.
        static void MyMethod()
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
