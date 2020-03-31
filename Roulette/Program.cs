using System;
using System.Linq;

namespace Roulette
{
    class Program
    {
        public static int NumRandomizer()    //method to generate a random number
        {
            Random random = new Random();
            int randomIndex = random.Next(0, 38); //randomizes numbers from 0 to 37
            return randomIndex;
        }
        public static char CharRandomizer()
        {
            char[] chars = "abcdefghijkl".ToCharArray();
            Random r = new Random();
            int randomIndex = r.Next(chars.Length);
            return chars[randomIndex];
        }
        //int[] RedNums = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
        //int[] BlackNums = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
        static void Main(string[] args)
        {
           // Console.ForegroundColor = ConsoleColor.Yellow;
            // int[] rouletteNum = new int[38];  //number array
            //
            // string[] rouletteColor = new string[] { "black", "red" }; //colors
            // {
            //     Console.WriteLine("Place you bet: ");
            //     Console.ReadLine();
            // rnd.Next
            Console.WriteLine(" \n\t\t\t\t\t$$ -- Welcome to Roulette! Have fun -- $$");
            Console.Write("\t\t\t\t\t\t\t How to play?");
            Console.WriteLine("");
            Console.WriteLine();
            Console.WriteLine("\t\t(1) Numbers: the number of the bin");
            Console.WriteLine("\t\t(2) Evens/Odds: even or odd numbers");
            Console.WriteLine("\t\t(3) Reds/Blacks: red or black colored numbers");
            Console.WriteLine("\t\t(4) Lows/Highs: low (1 – 18) or high (19 – 38) numbers");
            Console.WriteLine("\t\t(5) Dozens: row thirds, 1 – 12, 13 – 24, 25 – 36");
            Console.WriteLine("\t\t(6) Columns: first, second, or third columns");
            Console.WriteLine("\t\t(7) Street: rows, e.g., 1/2/3 or 22/23/24");
            Console.WriteLine("\t\t(8) 6 Numbers: double rows, e.g., 1/2/3/4/5/6 or 22/23/24/25/26/26");
            Console.WriteLine("\t\t(9) Split: at the edge of any two contiguous numbers, e.g., 1/2, 11/14, and 35/36");
            Console.WriteLine("\t\t(10) Corner: at the intersection of any four contiguous numbers, e.g., 1/2/4/5, or 23/24/26/27");
            // Random rnd = new Random();
            //int caseSwitch = rnd.Next(1, 4);

            //public static void ArrayNum(int[] houseNum)
            //{ 
            //int[] RedNums = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            //int[] BlackNums = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };
            //}
            try
            {
                int UserChoice;
                Console.WriteLine("\t\t\nSelect 1 - 10: ");
                UserChoice = int.Parse(Console.ReadLine());

                // int caseSwitch = 5;
                int caseSwitch = UserChoice;
                switch (caseSwitch)
                {
                    case 1:
                        Numbers();
                        break;
                    case 2:
                        EvenOddBet();
                        break;
                    case 3:
                        RedsBlacks();

                        break;
                    case 4:
                        LowsHighs();
                        break;
                    case 5:
                        Dozens();
                        break;
                    case 6:
                        Columns();
                        break;
                    case 7:
                        Street();
                        break;
                    case 8:
                        Console.WriteLine("8");
                        break;
                    case 9:
                        Console.WriteLine("9");
                        break;
                    case 10:
                        Console.WriteLine("10");
                        break;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("This is Not a valid option");
            }
        }
        public static int Numbers() 
        {
            bool CompareNum = true;
            int UserNum = 0;
            Console.WriteLine($"You placed a bet on (1)");
            Console.WriteLine("Select a number: ");
            UserNum = Convert.ToInt32(Console.ReadLine());
            int HouseNum = NumRandomizer();
            Console.WriteLine($"the winning number is: {HouseNum}");
            if (UserNum != HouseNum)
            {
                Console.WriteLine("you lose");
                CompareNum = false;
            }
            else {
                Console.WriteLine("you win");
                CompareNum = true;
            }
            return UserNum;                  
        }
        public static void EvenOddBet()     //method to place a bet and then house chooses number
        {
            int myInt;
            Console.WriteLine("You placed a bet on (2)");
            Console.Write("Select Odds/Evens: \n\nEnter 1 for Odds, 2 for Evens : ");
            myInt = int.Parse(Console.ReadLine());

            //house chooses number with NumRandomizer method
            int house = NumRandomizer();

            Console.WriteLine(house);
            //Console.WriteLine($"The house number is: {NumRandomizer()}");    //i am not using this
            EvenOddCompare(myInt, house);
        }
        public static bool EvenOddCompare(int myInt, int house)   //method to compare mynumber and house number by compare the result of mod
        {
            if ((myInt % 2 == 0 && house % 2 == 0) || myInt % 2 != 0 && house % 2 != 0)
            {
                Console.WriteLine("You Win");
                return true;             //TODO this keeps returning yes 4 times.              
            }
            else
            {
                Console.WriteLine("You Lose");
                return false;
            }
        }
        public static bool RedsBlacks()
        {
            int myInt;
            Console.WriteLine("You placed a bet on (3)");
            Console.Write("Select Odds/Evens: \n\nEnter 1 for Reds, 2 for Blacks : ");
            myInt = int.Parse(Console.ReadLine());
            int[] RedNums = new int[18] { 1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36 };
            //int[] BlackNums = new int[18] { 2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35 };

            int house = NumRandomizer();
            Console.WriteLine(house);   
            foreach (int Num in RedNums)
                if (house == Num)
                {
                    Console.WriteLine("REDS WINS");
                    return true;
                }
            Console.WriteLine("BLACKS WINS");
            return false;
        }
        public static bool LowsHighs()
        {
            int myInt;
            Console.WriteLine("You placed a bet on (4)");
            Console.Write("Select 1-18 for Lows OR Select 19-37 for Highs: ");
            myInt = int.Parse(Console.ReadLine());

            int[] LowNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18 };
            int[] HighNums = { 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38 };
            int house = 4;

            int result1 = LowNums.Length;
            foreach (int compareNum in LowNums)
                if (house != compareNum && myInt != compareNum)
                {
                    Console.WriteLine($"house number is: {compareNum}");
                    Console.WriteLine("Lows WIN");
                    return true;
                }
            Console.WriteLine("Highs WIN");
            return false;
        }
        public static bool Dozens()
        {
            int UserNum = 0;

            Console.WriteLine("Select (1): for Row 1-12...(13): for Row 13-24...(25) for Row 25-36");
            UserNum = Convert.ToInt32(Console.ReadLine());
            int House = NumRandomizer();
            Console.WriteLine($"winning number is:{House}");

            if (House >= 1 && House <= 12 && UserNum >= 1 && UserNum <= 12)    
            {
                Console.WriteLine("win");
                return true;
            }   
            else if (House >= 13 && House <= 24 && UserNum >= 13 && UserNum <= 24)
                {     
                    Console.WriteLine("win");
                    return true;
                }
            else if (House >= 25 && House<=36 && UserNum >=25 && UserNum<=36)
                {       
                    Console.WriteLine("win");
                    return true;
                }
            Console.WriteLine("lose");
            return false;
            }
        public static void Columns()
        {
            int house = NumRandomizer();
            string guess;
            Console.WriteLine("(g) for 1st 12,  (h) for 2nd 12, (i) for 3rd 12");           
            guess = Convert.ToString(Console.ReadLine());
            int[] firstColumn = { 1, 4, 7, 10, 13, 16, 19, 22, 25, 28, 31, 34 };
                int[] secondColumn = { 2, 5, 8, 11, 14, 17, 20, 23, 26, 29, 32, 35 };
                int[] thirdColumn = { 3, 6, 9, 12, 15, 18, 21, 24, 27, 30, 33, 36 };          
            switch (guess)
            {
                case "g":
                    foreach (int ColumnNum in firstColumn)
                        if (house == ColumnNum)                            
                        {
                            Console.WriteLine($"winning number is: {house}");
                            Console.WriteLine("you win");
                            return; }
                        else { Console.WriteLine("you lose"); 
                            return; }
                    break;
                case "h":
                    foreach (int ColumnNum in secondColumn)
                        if (house == ColumnNum)
                        { Console.WriteLine($"winning number is: {house}");
                            Console.WriteLine("you win"); 
                            return; }
                        else { 
                            Console.WriteLine("you lose"); 
                            return; }
                    break;
                case "i":
                    foreach (int ColumnNum in thirdColumn)
                        if (house == ColumnNum)
                        {
                            Console.WriteLine($"winning number is: {house}");
                            Console.WriteLine("you win");
                            return; }
                        else { Console.WriteLine("you lose");
                            return;
                        }
                    break;
            }
            return;
        }
        public static bool Street()
        {
          int house = 3;
            Console.WriteLine( $"computer chose: {house}" );
          char guess;
           // int[] streeNums = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36 };
            Console.WriteLine("Bet on a street, Select (a)for 1-3 (b) 4-6 (c) 7-9 (d) 10-12 (e) 13-15 (f) 16-18 (g)19-21" +
                "(h) 22-24 (i) 25-27 (j)28-30 (k)31-33 (l)34-36 ");
            guess = Convert.ToChar(Console.ReadLine());

          //  int[] guess;
           // if ( guess >0 && guess <4)             
                int [] a = { 1, 2, 3 };
                int[] b = { 4, 5, 6 };
                int[] c = { 7, 8, 9 };
                int[] d = { 10, 11, 12 };
                int[] e = { 13, 14, 15 };
                int[] f = { 16, 17, 18 };
                int[] g = { 19, 20, 21 };
                int[] h = { 22, 23, 24 };
                int[] i = { 25, 26, 27 };
                int[] j = { 28, 29, 30 };
                int[] k = { 31, 32, 33 };
                int[] l = { 34, 35, 36 };
            if(house == guess)
            {
                Console.WriteLine("you win");
                return true;              
            }
            else
            {
                Console.WriteLine("you lose");
                return false;
            }

        }
    }
}





  





