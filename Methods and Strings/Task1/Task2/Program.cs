using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a new method called FunWithStrings that will have one input parameter(string)
            //and it will have no return
            //In that method you should display in console the following tasks for the string:
            //print the reverse string
            //print total number of vowels
            //check if string is palindrome
            //print the largest word
            //print the smallest word
            //print the count of words
            //print the most used character(not space obviously)
            //Ask the user to enter a string and call the method with that string.
            static void FunWithStrings(string userSentence)
            {
                char[] firstUserSentence = userSentence.ToCharArray();
                char[] reversedUserSentence = userSentence.ToCharArray();
                Array.Reverse(reversedUserSentence);
                Console.Write("The reversed sentence is: ");
                foreach (char item in reversedUserSentence)
                {
                    Console.Write(item);
                }
               
                Console.WriteLine(" ");
                Array.Reverse(firstUserSentence);
                int vowelCounter = 0;
                foreach( char item in firstUserSentence)
                {
                    if(item=='a'|| item == 'e' || item == 'o' || item == 'u' || item == 'i' || item == 'y')
                    {
                        vowelCounter++;
                    }
                }
                Console.WriteLine($"The total number of vowels in this sentence is {vowelCounter}!");


                string userSentenceLowerCase = userSentence.ToLower();
                char[] userSentencePalindrom = userSentenceLowerCase.ToCharArray();
                char[] reversedUserSentencePalindrom = userSentenceLowerCase.ToCharArray();
                Array.Reverse(reversedUserSentencePalindrom);
                int matchingCounter = 0;

               for(int i=0; i<userSentence.Length;i++)
                {
                    if(userSentencePalindrom[i]==reversedUserSentencePalindrom[i])
                    {
                        matchingCounter++;
                    }
                }
               if(matchingCounter==userSentence.Length)
                {
                    Console.WriteLine("This is a palindrom!");
                }
               else
                {
                    Console.WriteLine("This is not a palindrom!");
                }


                string[] splitedUserSentence = userSentence.Split(" ");
                int largestWord = 0;
                
                foreach( string item in splitedUserSentence)
                {
                    if (largestWord >= item.Length) largestWord = largestWord;
                    else largestWord=item.Length;
                }
                Console.WriteLine("The largest word/s in this given sentence is/are:");

                foreach (string item in splitedUserSentence)
                {
                    if (item.Length == largestWord) Console.WriteLine(item); 
                }

                int smallestWord =int.MaxValue;
               foreach(string item in splitedUserSentence)
                {
                    if (item.Length < smallestWord) smallestWord = item.Length;
                }

                Console.WriteLine("The smallest word/s in this given sentence is/are:");
                foreach (string item in splitedUserSentence)
                {
                    if (item.Length == smallestWord)
                    {
                        Console.WriteLine(item);

                    }
                }

                Console.WriteLine($"This sentence has total of {splitedUserSentence.Length} words!");

                char[] forFindingTheMostUsedCharacter = userSentence.ToCharArray();
                int maxNoOfCharacterAppearing = 0;
                int noOfCharacterAppearing = 0;
                Console.WriteLine("The character/s that appears the most in this given sentence is/are:");

                foreach (char item in forFindingTheMostUsedCharacter)
                {
                    if(maxNoOfCharacterAppearing<noOfCharacterAppearing)
                    {
                        maxNoOfCharacterAppearing = noOfCharacterAppearing;
                        
                    }
                     noOfCharacterAppearing = 0;


                    foreach (char element in forFindingTheMostUsedCharacter)
                    {
                        if(item==element)
                        {
                            if(item!=' ')
                            {
                                noOfCharacterAppearing++;

                            }

                        }
                    }

                }

                char[] maxRepeatingElements = new char[0];

            foreach(char item in forFindingTheMostUsedCharacter)
                {
                    matchingCounter = 0;
                    foreach(char element in forFindingTheMostUsedCharacter)
                    {
                        if(item==element)
                        {
                            matchingCounter++;
                            if(matchingCounter==maxNoOfCharacterAppearing)
                            {
                                
                                Array.Resize(ref maxRepeatingElements, maxRepeatingElements.Length + 1);
                                maxRepeatingElements[maxRepeatingElements.Length - 1] = item;
                            }
                        }
                    }
                }
           
                char[] finalArray = new char[0] ;

            foreach(char item in maxRepeatingElements)
                {
                    bool itemHere = false;

                    foreach (char element in finalArray)
                    {
                        if (item == element)
                        {
                            itemHere = true;
                        }
                        

                    }
                    if (!itemHere)
                    {
                        if(item!=' ')
                        {
                            Array.Resize(ref finalArray, finalArray.Length + 1);
                            finalArray[finalArray.Length - 1] = item;
                        }
                        
                    }
                }


            foreach(char item in finalArray)
                {
                    Console.WriteLine(item);
                }
            }

            Console.WriteLine("Please enter a sentence!");
            string userSentence = Console.ReadLine();

            FunWithStrings(userSentence);
        }
    }
}
