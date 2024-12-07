// Practice number sizes and ranges
//Q1.
// Console.WriteLine($"sbyte: {sizeof(sbyte)} bytes, Min: {sbyte.MinValue}, Max: {sbyte.MaxValue}");
// Console.WriteLine($"byte: {sizeof(byte)} bytes, Min: {byte.MinValue}, Max: {byte.MaxValue}");
// Console.WriteLine($"short: {sizeof(short)} bytes, Min: {short.MinValue}, Max: {short.MaxValue}");
// Console.WriteLine($"ushort: {sizeof(ushort)} bytes, Min: {ushort.MinValue}, Max: {ushort.MaxValue}");
// Console.WriteLine($"int: {sizeof(int)} bytes, Min: {int.MinValue}, Max: {int.MaxValue}");
// Console.WriteLine($"uint: {sizeof(uint)} bytes, Min: {uint.MinValue}, Max: {uint.MaxValue}");
// Console.WriteLine($"long: {sizeof(long)} bytes, Min: {long.MinValue}, Max: {long.MaxValue}");
// Console.WriteLine($"ulong: {sizeof(ulong)} bytes, Min: {ulong.MinValue}, Max: {ulong.MaxValue}");
// Console.WriteLine($"float: {sizeof(float)} bytes, Min: {float.MinValue}, Max: {float.MaxValue}");
// Console.WriteLine($"double: {sizeof(double)} bytes, Min: {double.MinValue}, Max: {double.MaxValue}");
// Console.WriteLine($"decimal: {sizeof(decimal)} bytes, Min: {decimal.MinValue}, Max: {decimal.MaxValue}");


//Q2
// Console.Write("Enter number of centuries: ");
// int centuries = int.Parse(Console.ReadLine());
//
// int years = centuries * 100;
// int days = (int)(years * 365.2425); 
// long hours = days * 24L;
// long minutes = hours * 60L;
// long seconds = minutes * 60L;
// long milliseconds = seconds * 1000L;
// long microseconds = milliseconds * 1000L;
// decimal nanoseconds = microseconds * 1000m; 
//
// Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {milliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");







//Practise Loops and operators
//Q1.
//Part 1
// for (int i = 1; i <= 100; i++)
// {
//     if (i % 3 == 0 && i % 5 == 0)
//     {
//         Console.WriteLine("fizzbuzz");
//     }
//     else if (i % 3 == 0)
//     {
//         Console.WriteLine("fizz");
//     }
//     else if (i % 5 == 0)
//     {
//         Console.WriteLine("buzz");
//     }
//     else
//     {
//         Console.WriteLine(i);
//     }
// }

//Part 2
// int max = 500;
// for (byte i = 0; i < max; i++)
// {
//     Console.WriteLine(i);
// }

// This code is creating infinite never ending loop. To fix this we need to change byte type to int type.
//If you want to use byte, adjust max to be in the range 0-255.
//We can use conditional statements like if-statements to check if the range is out and print a warning message if the range out.

//Part 3
// int correctNumber = new Random().Next(3) + 1;
// Console.WriteLine("Guess the number between 1 and 3:");
//
// int guessedNumber = int.Parse(Console.ReadLine());
// if (guessedNumber < 1 || guessedNumber > 3)
// {
//     Console.WriteLine("Invalid guess! Please guess a number between 1 and 3.");
// }
// else if (guessedNumber < correctNumber)
// {
//     Console.WriteLine("Your guess is too low!");
// }
// else if (guessedNumber > correctNumber)
// {
//     Console.WriteLine("Your guess is too high!");
// }
// else
// {
//     Console.WriteLine("Correct! You guessed the right number.");
// }

//Q2
// int n = 5; 
//         
// for (int i = 1; i <= n; i++) 
// {
//     for (int j = 1; j <= n - i; j++)
//     {
//         Console.Write(" "); 
//     }
//     for (int k = 1; k <= 2 * i - 1; k++)
//     {
//         Console.Write("*"); 
//     }
//     Console.WriteLine();
// }

//Q3
// int correctNumber = new Random().Next(3) + 1;
// Console.WriteLine("Guess the number between 1 and 3:");
//
// int guessedNumber = int.Parse(Console.ReadLine());
// if (guessedNumber < 1 || guessedNumber > 3)
// {
//     Console.WriteLine("Invalid guess! Please guess a number between 1 and 3.");
// }
// else if (guessedNumber < correctNumber)
// {
//     Console.WriteLine("Your guess is too low!");
// }
// else if (guessedNumber > correctNumber)
// {
//     Console.WriteLine("Your guess is too high!");
// }
// else
// {
//     Console.WriteLine("Correct! You guessed the right number.");
// }


//Q4
// DateTime birthDate = new DateTime(2000, 5, 8); // Replace with the actual birth date
// DateTime currentDate = DateTime.Now;
// int daysAlive = (currentDate - birthDate).Days;
// Console.WriteLine($"You are {daysAlive} days old.");
// int daysToNextAnniversary = 10000 - (daysAlive % 10000);
// DateTime nextAnniversary = currentDate.AddDays(daysToNextAnniversary);
// Console.WriteLine($"Your next 10,000-day anniversary will be on {nextAnniversary.ToShortDateString()}.");

//Q5
// DateTime currentTime = DateTime.Now;
// int currentHour = currentTime.Hour;
//
// if (currentHour >= 6 && currentHour < 12)
// {
//     Console.WriteLine("Good Morning");
// }
// if (currentHour >= 12 && currentHour < 17)
// {
//     Console.WriteLine("Good Afternoon");
// }
// if (currentHour >= 17 && currentHour < 21)
// {
//     Console.WriteLine("Good Evening");
// }
// if ((currentHour >= 21 && currentHour <= 23) || (currentHour >= 0 && currentHour < 6))
// {
//     Console.WriteLine("Good Night");
// }

//Q6
// for (int increment = 1; increment <= 4; increment++)
// {
//     for (int i = 0; i <= 24; i += increment)
//     {
//         Console.Write(i);
//         if (i + increment <= 24) 
//         {
//             Console.Write(",");
//         }
//     }
//     Console.WriteLine(); 
// }







//Practise Arrays and Strings
//Q1
// int[] originalArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
//
// int[] copiedArray = new int[originalArray.Length];
//
// for (int i = 0; i < originalArray.Length; i++)
// {
//     copiedArray[i] = originalArray[i];
// }
//
// Console.WriteLine("Original Array:");
// for (int i = 0; i < originalArray.Length; i++)
// {
//     Console.Write(originalArray[i] + " ");
// }
// Console.WriteLine();
//
// Console.WriteLine("Copied Array:");
// for (int i = 0; i < copiedArray.Length; i++)
// {
//     Console.Write(copiedArray[i] + " ");
// }
// Console.WriteLine();

//Q2
// string[] itemList = new string[10];
// int itemCount = 0;
//
// while (true)
// {
//     Console.WriteLine("Enter command (+ [item], - [item], -- to clear, !! to stop):");
//     string userInput = Console.ReadLine();
//
//     if (userInput.StartsWith("+ "))
//     {
//         string itemToAdd = userInput.Substring(2).Trim();
//         if (itemCount < itemList.Length)
//         {
//             itemList[itemCount] = itemToAdd;
//             itemCount++;
//             Console.WriteLine($"Added: {itemToAdd}");
//         }
//         else
//         {
//             Console.WriteLine("List is full! Cannot add more items.");
//         }
//     }
//     else if (userInput.StartsWith("- "))
//     {
//         string itemToRemove = userInput.Substring(2).Trim();
//         bool found = false;
//
//         for (int i = 0; i < itemCount; i++)
//         {
//             if (itemList[i] == itemToRemove)
//             {
//                 found = true;
//                 // Shift elements left after removal
//                 for (int j = i; j < itemCount - 1; j++)
//                 {
//                     itemList[j] = itemList[j + 1];
//                 }
//                 itemList[itemCount - 1] = null;  // Clear last item
//                 itemCount--;
//                 Console.WriteLine($"Removed: {itemToRemove}");
//                 break;
//             }
//         }
//
//         if (!found)
//         {
//             Console.WriteLine("Item not found in list.");
//         }
//     }
//     else if (userInput == "--")
//     {
//         itemCount = 0;
//         Console.WriteLine("List cleared.");
//     }
//     else
//     {
//         Console.WriteLine("Invalid command. Please use +, -, or --.");
//     }
//     
//     Console.WriteLine("Current List:");
//     if (itemCount == 0)
//     {
//         Console.WriteLine("The list is empty.");
//     }
//     else
//     {
//         for (int i = 0; i < itemCount; i++)
//         {
//             Console.WriteLine(itemList[i]);
//         }
//     }
//
//     if (userInput.StartsWith("!!"))
//     {
//         break;
//     }
// }

//Q4
//Need more understanding of the question

//Q5
// int[] arr = { 2, 1, 1, 2, 3, 3, 2, 2, 2, 1 };
//         
// int maxCount = 1;  
// int currentCount = 1;  
// int maxStartIndex = 0;
//
// for (int i = 1; i < arr.Length; i++)
// {
//     if (arr[i] == arr[i - 1])
//     {
//         currentCount++;
//     }
//     else
//     {
//         if (currentCount > maxCount)
//         {
//             maxCount = currentCount;
//             maxStartIndex = i - currentCount;
//         }
//         currentCount = 1;
//     }
// }
//
// if (currentCount > maxCount)
// {
//     maxCount = currentCount;
//     maxStartIndex = arr.Length - currentCount;
// }
//
// Console.WriteLine("Longest sequence: ");
// for (int i = maxStartIndex; i < maxStartIndex + maxCount; i++)
// {
//     Console.Write(arr[i] + " ");
// }

//Q7
// int[] arr = { 4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3 };
//
// int mostFrequent = arr[0];
// int maxCount = 1;
//
// for (int i = 0; i < arr.Length; i++)
// {
//     int currentCount = 1;
//     
//     for (int j = i + 1; j < arr.Length; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             currentCount++;
//         }
//     }
//     if (currentCount > maxCount)
//     {
//         mostFrequent = arr[i];
//         maxCount = currentCount;
//     }
// }
// Console.WriteLine($"The number {mostFrequent} is the most frequent (occurs {maxCount} times)");




//Practise Strings
//Q1
// Console.WriteLine("Enter a string:");
// string input = Console.ReadLine();
//         
// char[] charArray = input.ToCharArray();
// Array.Reverse(charArray);
// string reversedString = new string(charArray);
//
// Console.WriteLine("Reversed string: " + reversedString);

//OR
// Console.WriteLine("Enter a string:");
// string input = Console.ReadLine();
//
// Console.Write("Reversed string: ");
// for (int i = input.Length - 1; i >= 0; i--)
// {
//     Console.Write(input[i]);
// }
// Console.WriteLine();
    
//Q3
// class Program
// {
//     static void Main()
//     {
//         Console.WriteLine("Enter the text:");
//         string input = Console.ReadLine();
//
//         List<string> palindromes = new List<string>();
//         string word = "";
//
//         for (int i = 0; i < input.Length; i++)
//         {
//             char c = input[i];
//
//             if (Char.IsLetter(c))
//             {
//                 word += Char.ToLower(c);
//             }
//             else
//             {
//                 if (word.Length > 1 && IsPalindrome(word))
//                 {
//                     if (!palindromes.Contains(word))
//                     {
//                         palindromes.Add(word);
//                     }
//                 }
//                 word = ""; 
//             }
//         }
//
//         if (word.Length > 1 && IsPalindrome(word) && !palindromes.Contains(word))
//         {
//             palindromes.Add(word);
//         }
//
//         palindromes.Sort();
//
//         Console.WriteLine(string.Join(", ", palindromes));
//     }
//
//     static bool IsPalindrome(string word)
//     {
//         int start = 0;
//         int end = word.Length - 1;
//
//         while (start < end)
//         {
//             if (word[start] != word[end])
//             {
//                 return false;
//             }
//             start++;
//             end--;
//         }
//         return true;
//     }
// }


//Q4
// Console.WriteLine("Enter the URL:");
// string url = Console.ReadLine();
//
// string protocol = "";
// string server = "";
// string resource = "";
//
// int protocolEndIndex = url.IndexOf("://");
//
// if (protocolEndIndex != -1)
// {
//     protocol = url.Substring(0, protocolEndIndex);
//     url = url.Substring(protocolEndIndex + 3); 
// }
//
// int resourceStartIndex = url.IndexOf("/");
//
// if (resourceStartIndex != -1)
// {
//     server = url.Substring(0, resourceStartIndex);
//     resource = url.Substring(resourceStartIndex + 1); 
// }
// else
// {
//     server = url;
// }
//
// Console.WriteLine($"[protocol] = \"{protocol}\"");
// Console.WriteLine($"[server] = \"{server}\"");
// Console.WriteLine($"[resource] = \"{resource}\"");




