using System;

namespace basic_code
{
    internal class Assignment
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n========= ASSIGNMENT MENU =========");

                // 1–10
                Console.WriteLine("1. Flip Coin");
                Console.WriteLine("2. Leap Year");
                Console.WriteLine("3. Power of 2");
                Console.WriteLine("4. Harmonic Number");
                Console.WriteLine("5. Prime Factors");
                Console.WriteLine("6. Vowel or Consonant");
                Console.WriteLine("7. Perfect Number");
                Console.WriteLine("8. Prime Number");
                Console.WriteLine("9. Reverse Number");
                Console.WriteLine("10. Largest Among Three Numbers");

                // 11–20
                Console.WriteLine("11. Fibonacci Series");
                Console.WriteLine("12. Coupon Numbers");
                Console.WriteLine("13. Stopwatch Program");
                Console.WriteLine("14. Student Grade Classification");
                Console.WriteLine("15. Temperature Conversion");
                Console.WriteLine("16. Movie Ticket Price Calculator");
                Console.WriteLine("17. Login System");
                Console.WriteLine("18. Calculator Program");
                Console.WriteLine("19. AQI Calculator");
                Console.WriteLine("20. Rock Paper Scissors Game");

                // 21–30
                Console.WriteLine("21. Library Fine Calculator");
                Console.WriteLine("22. Traffic Light Simulator");
                Console.WriteLine("23. Library Reservation System");
                Console.WriteLine("24. Reverse String");
                Console.WriteLine("25. Palindrome String");
                Console.WriteLine("26. Anagram Check");
                Console.WriteLine("27. Longest Substring Without Repeating");
                Console.WriteLine("28. String Compression");
                Console.WriteLine("29. First Non-Repeating Character");
                Console.WriteLine("30. Count Vowels and Consonants");

                // 31–40
                Console.WriteLine("31. String Rotation");
                Console.WriteLine("32. Longest Palindromic Substring");
                Console.WriteLine("33. Substring Search");
                Console.WriteLine("34. Find Pairs with Given Sum");
                Console.WriteLine("35. Find Missing Number");
                Console.WriteLine("36. Move Zeros to End");
                Console.WriteLine("37. Array Intersection");
                Console.WriteLine("38. Rotate Array");
                Console.WriteLine("39. Longest Consecutive Subsequence");
                Console.WriteLine("40. Find Duplicate Number");

                // 41–50
                Console.WriteLine("41. Merge Sorted Arrays");
                Console.WriteLine("42. Majority Element");
                Console.WriteLine("43. Subarray Sum Equals K");
                Console.WriteLine("44. Product of Array Except Self");
                Console.WriteLine("45. Maximum Subarray");
                Console.WriteLine("46. Sort 0s 1s 2s");
                Console.WriteLine("47. Container With Most Water");
                Console.WriteLine("48. Search in Rotated Array");
                Console.WriteLine("49. Find Peak Element");
                Console.WriteLine("50. Trapping Rain Water");

                Console.WriteLine("0. Exit");

                Console.Write("\nEnter your choice: ");
                string input = Console.ReadLine() ?? "";

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("Invalid input.");
                    continue;
                }

                switch (choice)
                {
                    case 1: new FlipCoin().FlipCoinPercentage(); break;
                    case 2: new LeapYear().CheckLeapYear(); break;
                    case 3: new PowerOf2().CalculatePower(); break;
                    case 4: new HarmonicNumber().CalculateHarmonic(); break;
                    case 5: new PrimeFactors().FindFactors(); break;
                    case 6: new VowelConsonant().CheckAlphabet(); break;
                    case 7: new PerfectNumber().CheckPerfect(); break;
                    case 8: new PrimeNumber().CheckPrime(); break;
                    case 9: new ReverseNumber().Reverse(); break;
                    case 10: new LargestOfThree().FindLargest(); break;

                    case 11: new FibonacciSeries().GenerateSeries(); break;
                    case 12: new CouponNumbers().CollectCoupons(); break;
                    case 13: new StopwatchProgram().MeasureTime(); break;
                    case 14: new GradeCalculator().CalculateGrade(); break;
                    case 15: new TemperatureConversion().ConvertTemperature(); break;
                    case 16: new MovieTicket().CalculatePrice(); break;
                    case 17: new LoginSystem().Login(); break;
                    case 18: new CalculatorProgram().Calculate(); break;
                    case 19: new AQIProgram().CalculateAQI(); break;
                    case 20: new RockPaperScissors().PlayGame(); break;

                    case 21: new LibraryFine().CalculateFine(); break;
                    case 22: new TrafficLightSimulator().StartSimulation(); break;
                    case 23: new LibraryReservationSystem().ReserveBook(); break;

                    case 24: new ReverseString().Reverse(); break;
                    case 25: new PalindromeString().Check(); break;
                    case 26: new AnagramCheck().Check(); break;
                    case 27: new LongestSubstring().Find(); break;
                    case 28: new StringCompression().Compress(); break;
                    case 29: new FirstNonRepeating().Find(); break;
                    case 30: new VowelConsonantCount().Count(); break;

                    case 31: new StringRotation().Check(); break;
                    case 32: new LongestPalindrome().Find(); break;
                    case 33: new SubstringSearch().Search(); break;

                    case 34: new FindPairsWithSum().Find(); break;
                    case 35: new MissingNumber().Find(); break;
                    case 36: new MoveZeros().Move(); break;
                    case 37: new ArrayIntersection().Find(); break;
                    case 38: new ArrayRotation().Rotate(); break;
                    case 39: new LongestConsecutive().Find(); break;
                    case 40: new FindDuplicate().Find(); break;

                    case 41: new MergeSortedArrays().Merge(); break;
                    case 42: new MajorityElement().Find(); break;
                    case 43: new SubarraySumK().Find(); break;
                    case 44: new ProductExceptSelf().Calculate(); break;
                    case 45: new MaximumSubarray().Find(); break;

                    case 46: new Sort012().Sort(); break;
                    case 47: new ContainerWithMostWater().Find(); break;
                    case 48: new SearchRotatedArray().Search(); break;
                    case 49: new FindPeakElement().Find(); break;
                    case 50: new TrappingRainWater().Calculate(); break;

                    case 0:
                        Console.WriteLine("Exiting...");
                        return;

                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
    }
}