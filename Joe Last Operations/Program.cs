using System;

namespace Joe_Last_Operations
{
    internal class Program
    {
        static void Main(string[] args){}
                    // Write a program that asks the user for their age and then displays the year that they will turn after 10 years.
                    Console.WriteLine("What is your age?");
                    int age = int.Parse(Console.ReadLine());
                    int ageAfterTenYears = age + 10;
                    Console.WriteLine("In ten years you will be " + ageAfterTenYears);

                    //Write a program that asks the user for their first name and last name, then prints it.
                    string firstName = "Joe";
                    string lastName = "Edoho";
                    Console.WriteLine(firstName + " " + lastName);

                    //
                    Console.WriteLine("What is your age?");
                    int age2 = int.Parse(Console.ReadLine());
                    DateTime date = DateTime.Now;
                    int year = date.Year;
                    int birthYear = year - age2;
                    Console.WriteLine("You were born in " + birthYear);

                    // Implicit conversion example
                    int numInt = 123456789;
                    long numLong = numInt; // Implicit conversion from int to long

                    Console.WriteLine("Implicit Conversion: int to long");
                    Console.WriteLine("int value: " + numInt);
                    Console.WriteLine("long value: " + numLong);

                    // Explicit conversion example
                    double numDouble = 123.45;
                    int numInt2 = (int)numDouble; // Explicit conversion from double to int

                    Console.WriteLine("\nExplicit Conversion: double to int");
                    Console.WriteLine("double value: " + numDouble);
                    Console.WriteLine("int value: " + numInt2); // Note: Value is truncated

                    //expression example
                    int x = 10;
                    int y = 3;
                    int a = 14;
                    int b = 5;
                    int result = x / y;
                    int result2 = a / b;
                    Console.WriteLine(result); // Output: 3
                    Console.WriteLine(result2); // Output: 2

                    //Calculates the square root of 64
                    double answer = Math.Sqrt(64);
                    Console.WriteLine(answer);

                    //area of trapezoid
                    Console.WriteLine("Enter the height of the trapezoid:");
                    double height = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the length of the first base:");
                    double base1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the length of the second base:");
                    double base2 = double.Parse(Console.ReadLine());

                    double area = 0.5 * (base1 + base2) * height;
                    Console.WriteLine("The area of the trapezoid is: " + area);

                    //assigning variables to data types
                    string personName = "John";
                    int personAge = 30;
                    char gender = 'M';
                    bool isStudent = true;
                    double gpa = 3.5;

                    //check if a number is even or odd
                    Console.WriteLine("Enter a number:");
                    int number = int.Parse(Console.ReadLine());
                    if (number % 2 == 0)
                    {
                        Console.WriteLine($"{number} is even.");
                    }
                    else if (number % 2 != 0)
                    {
                        Console.WriteLine($"{number} is odd.");
                    }

                    // Declare several variables by selecting for each one of them the most appropriate of the types sbyte, byte, short, ushort, int, uint, long and ulong in order to assign them the following values: 52,130; -115; 4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000; 1990; 123456789123456789. 
                    sbyte var1 = 52;
                    byte var2 = 130;
                    sbyte var3 = -115;
                    int var4 = 4825932;
                    byte var5 = 97;
                    short var6 = -10000;
                    ushort var7 = 20000;
                    byte var8 = 224;
                    uint var9 = 970700000;
                    byte var10 = 112;
                    sbyte var11 = -44;
                    int var12 = -1000000;
                    short var13 = 1990;
                    long var14 = 123456789123456789;

                    //Write a program, which compares correctly two real numbers with accuracy at least 0.000001. 
                    Console.WriteLine("Enter the first real number:");
                    double number1 = double.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the second real number:");
                    double number2 = double.Parse(Console.ReadLine());

                    double epsilon = 0.000001;

                    if (Math.Abs(number1 - number2) < epsilon)
                    {
                        Console.WriteLine("The numbers are equal.");
                    }
                    else
                    {
                        Console.WriteLine("The numbers are not equal.");
                    }

                    //A Rock, Paper, Scissors game

                    Console.WriteLine("Enter the number of players: ");
                    int count = Convert.ToInt32(Console.ReadLine());
                    MultiplePlayers(count);
                }
                static string Game()
                {
                    Random random = new Random();
                    string[] choices = { "Rock", "Paper", "Scissors" };
                    int index = random.Next(choices.Length);
                    string computerChoice = choices[index];
                    return computerChoice;
                }
                static void Check(string player1, string player2)
                {
                    while (player1 != player2)
                    {
                        if (player1 == "Rock" && player2 == "Scissors")
                        {
                            Console.WriteLine("Player 1 wins");
                            break;
                        }
                        else if (player1 == "Paper" && player2 == "Rock")
                        {
                            Console.WriteLine("Player 1 wins");
                            break;
                        }
                        else if (player1 == "Scissors" && player2 == "Paper")
                        {
                            Console.WriteLine("Player 1 wins");
                            break;
                        }
                        else if (player2 == "Rock" && player1 == "Scissors")
                        {
                            Console.WriteLine("Player 2 wins");
                            break;
                        }
                        else if (player2 == "Paper" && player1 == "Rock")
                        {
                            Console.WriteLine("Player 2 wins");
                            break;
                        }
                        else if (player2 == "Scissors" && player1 == "Paper")
                        {
                            Console.WriteLine("Player 2 wins");
                            break;
                        }
                    }
                }
                static string CheckMultiple(string[] players)
                {
                    string winner = players[0];

                    for (int i = 1; i < players.Length; i++)
                    {
                        string opponent = players[i];
                        Console.WriteLine("--------------------------------------------------------");
                        Console.WriteLine($"Match: {winner} vs {opponent}");

                        // Replay until there's a winner
                        while (winner == opponent)
                        {
                            Console.WriteLine("It's a tie! Replaying...");
                            winner = Game();
                            opponent = Game();
                            Console.WriteLine("--------------------------------------------------------");
                            Console.WriteLine($"New match: {winner} vs {opponent}");
                        }

                        // Decide who wins
                        if ((winner == "Rock" && opponent == "Scissors") ||
                            (winner == "Paper" && opponent == "Rock") ||
                            (winner == "Scissors" && opponent == "Paper"))
                        {
                            Console.WriteLine("Winner: " + winner);
                        }
                        else
                        {
                            winner = opponent;
                            Console.WriteLine("Winner: " + winner);
                        }
                    }

                    return winner;
                }
                static void CheckTie(string player1, string player2)
                {
                    while (player1 == player2)
                    {
                        Console.WriteLine("It's a tie! Let's play again.");
                        player1 = Game();
                        Console.WriteLine("Player 1 chose: " + player1);
                        player2 = Game();
                        Console.WriteLine("Player 2 chose: " + player2);
                        Check(player1, player2);
                    }
                }
                static void MultiplePlayers(int count)
                {
                    Console.WriteLine("Welcome to Rock, Paper, Scissors!");
                    Console.WriteLine("--------------------------------------------------------");
                    string[] players = new string[count];

                    for (int i = 0; i < count; i++)
                    {
                        players[i] = Game();
                        Console.WriteLine("Player " + (i + 1) + " chose: " + players[i]);
                    }

                    string finalWinner = CheckMultiple(players);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.WriteLine("Final Winner: " + finalWinner);
                }
            }







        }
    }
}