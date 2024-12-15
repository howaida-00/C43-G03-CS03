using System;

namespace Assignment03
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1.Enter a number and print it

            //double number;
            //do
            //{
            //    Console.Write("Enter a number: ");
            //} while (!double.TryParse(Console.ReadLine(), out number));

            //Console.WriteLine($"You entered: {number}");

            #endregion


            #region Q2.Convert a string with non-numeric characters to an integer

            //string input = "983abz";
            //int number = Convert.ToInt32(input);
            //Console.WriteLine($"Converted number: {number}");

            // The program will throw a FormatException because the string contains non-numeric characters.

            #endregion


            #region Q3. Perform arithmetic with floating-point numbers

            //float num1 = 5.5f;
            //float num2 = 2.4f;
            //float result = num1 + num2;
            //Console.WriteLine($"Result: {result}");

            /*
            Explanation of What Will Happen:
            - Floating-Point Numbers: The program uses float to represent floating-point numbers.
              The suffix 'f' is required when specifying a floating-point literal to tell the compiler
              that it should be treated as a float rather than a double (the default floating-point type).
            - Arithmetic Operation: The program adds two floating-point numbers, num1 and num2, and stores the result in the variable result.
            - Output: It prints the result of the addition to the console.

            Potential Outcomes:
            - Precision Loss: Since float has limited precision (about 7 digits),
            there could be a loss of precision for operations involving very large or very small numbers.
            If precision is a concern, using double might be a better choice.

            - Overflow/Underflow: For extremely large or small floating-point numbers,
            we might encounter overflow or underflow. 
            However, in this simple example, the numbers are within the range of the float type,
            so such issues are unlikely.
             */
            #endregion


            #region Q4. Extract a substring from a string 

            //string text = "Operating Systems :(";
            //string substring = text.Substring(10, 10);
            //Console.WriteLine($"substring: {substring}");

            #endregion


            #region Q5. Assign value type variable and modify one

            //int x = 10;
            //int y = x;
            //y = 20;

            // Output: x = 10, y = 20
            // Value types are copied, so modifying one doesn't affect the other.

            #endregion


            #region Q6. Assign reference type and modify the object

            //int[] arr1 = { 1, 2, 3 };
            //Console.WriteLine("Initial values in arr1: " + string.Join(", ", arr1));

            //int[] arr2 = arr1;

            //arr2[1] = 20;

            //Console.WriteLine("Values in arr1 after modification through arr2: " + string.Join(", ", arr1));
            //Console.WriteLine("Values in arr2: " + string.Join(", ", arr2));

            // When we assign arr1 to arr2, both variables reference the same array in memory.
            // Modifying the array through arr2 (e.g., setting arr2[1] = 20) also modifies the array referenced by arr1.

            #endregion


            #region Q7. Concatenate two strings

            //string first = "Hello";
            //string second = "C#";
            //string combined = first + " " + second;
            //Console.WriteLine($"Combined: {combined}");

            #endregion


            #region Q8. Calculate simple interest

            //double principal, rate, time;

            //do
            //{
            //    Console.Write("Enter principal: ");
            //} while (!double.TryParse(Console.ReadLine(), out principal) || principal <= 0);

            //do
            //{
            //    Console.Write("Enter rate: ");
            //} while (!double.TryParse(Console.ReadLine(), out rate) || rate <= 0);

            //do
            //{
            //    Console.Write("Enter time: ");
            //} while (!double.TryParse(Console.ReadLine(), out time) || time <= 0);

            //double interest = (principal * rate * time) / 100;
            //Console.WriteLine($"Interest: {interest}");

            #endregion


            #region Q9. Calculate BMI

            //double weight, height;

            //do
            //{
            //    Console.Write("Enter weight (kg): ");
            //} while (!double.TryParse(Console.ReadLine(), out weight) || weight <= 0);

            //do
            //{
            //    Console.Write("Enter height (m): ");
            //} while (!double.TryParse(Console.ReadLine(), out height) || height <= 0);

            //double bmi = weight / (height * height);
            //Console.WriteLine($"BMI: {bmi}");


            #endregion


            #region Q10. Use ternary operator for temperature

            //double temp;

            //do
            //{
            //    Console.Write("Enter temperature: ");
            //} while (!double.TryParse(Console.ReadLine(), out temp));

            //string result = temp < 10 ? "Just Cold" : (temp > 30 ? "Just Hot" : "Just Good");
            //Console.WriteLine($"The temperature is: {result}");

            #endregion


            #region Q11.Format date

            //DateTime date;

            //do
            //{
            //    Console.Write("Enter a date (yyyy-mm-dd): ");
            //} while (!DateTime.TryParse(Console.ReadLine(), out date));

            //Console.WriteLine($"Today's date: {date.Day},{date.Month},{date.Year}");
            //Console.WriteLine($"Today's date: {date.Day}/{date.Month}/{date.Year}");
            //Console.WriteLine($"Today's date: {date.Day}-{date.Month}-{date.Year}");

            #endregion


            #region Q12. Divisible by 3 and 4

            //int number;

            //do
            //{
            //    Console.Write("Enter an integer number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //Console.WriteLine(number % 3 == 0 && number % 4 == 0 ? "Yes" : "No");

            #endregion


            #region Q13. Positive or Negative

            //double number;

            //do
            //{
            //    Console.Write("Enter a number: ");
            //} while (!double.TryParse(Console.ReadLine(), out number));

            //Console.WriteLine(number < 0 ? "Negative" : "Positive");

            #endregion


            #region Q13. Max and Min of Three Numbers

            //int num1 = 0, num2 = 0, num3 = 0;
            //bool flag;
            //string input;
            //string[] numbers;

            //do
            //{
            //    Console.WriteLine("Enter three integers separated by spaces or commas:");
            //    input = Console.ReadLine();
            //    numbers = input.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            //    if (numbers.Length != 3)
            //    {
            //        flag = false;
            //    }
            //    else
            //    {
            //        flag = int.TryParse(numbers[0], out num1)
            //                    && int.TryParse(numbers[1], out num2)
            //                    && int.TryParse(numbers[2], out num3);
            //    }

            //} while (!flag);

            //int max = num1;
            //if (num2 > max) max = num2;
            //if (num3 > max) max = num3;

            //int min = num1;
            //if (num2 < min) min = num2;
            //if (num3 < min) min = num3;

            //Console.WriteLine($"Max element = {max}");
            //Console.WriteLine($"Min element = {min}");

            #endregion


            #region Q14. Even or Odd

            //int number;
            //do
            //{
            //    Console.WriteLine("Enter an integer number:");

            //} while (!int.TryParse(Console.ReadLine(), out number));
            //Console.WriteLine(number % 2 == 0 ? "Even" : "Odd");

            #endregion


            #region Q15.Vowel or Consonant

            //char ch;
            //do
            //{
            //    Console.WriteLine("Enter an alphabet character:");

            //} while (!char.TryParse(Console.ReadLine(), out ch) || !((ch >= 'A' && ch <= 'Z') || (ch >= 'a' && ch <= 'z')));

            //Console.WriteLine("aouieAOUIE".Contains(ch) ? "Vowel" : "Consonant");

            #endregion


            #region Q16. Days in a Month

            //int month;
            //int days = 0;
            //bool isValid;

            //do
            //{
            //    Console.Write("Enter month number (1-12): ");
            //    isValid = int.TryParse(Console.ReadLine(), out month);

            //    if (isValid && month >= 1 && month <= 12)
            //    {
            //        switch (month)
            //        {
            //            case 1:
            //            case 3:
            //            case 5:
            //            case 7:
            //            case 8:
            //            case 10:
            //            case 12:
            //                days = 31;
            //                break;
            //            case 4:
            //            case 6:
            //            case 9:
            //            case 11:
            //                days = 30;
            //                break;
            //            case 2:
            //                days = 28; // Ignoring leap years for simplicity, as they are not mentioned.
            //                break;
            //        }
            //        Console.WriteLine($"Days in Month: {days}");
            //    }

            //} while (!isValid || month < 1 || month > 12);


            #endregion


            #region Q17. Simple Calculator

            //double num1, num2, result;
            //char op;
            //bool isValidInput;

            //Console.WriteLine("Simple Calculator");

            //do
            //{
            //    Console.Write("Enter the first number: ");
            //    isValidInput = double.TryParse(Console.ReadLine(), out num1);
            //    if (!isValidInput)
            //    {
            //        Console.WriteLine("Invalid input!");
            //    }
            //} while (!isValidInput);

            //do
            //{
            //    Console.Write("Enter the operator (+, -, *, /): ");
            //    op = Console.ReadLine()[0];
            //    if (op != '+' && op != '-' && op != '*' && op != '/')
            //    {
            //        Console.WriteLine("Invalid operator!");
            //    }
            //} while (op != '+' && op != '-' && op != '*' && op != '/');

            //do
            //{
            //    Console.Write("Enter the second number: ");
            //    isValidInput = double.TryParse(Console.ReadLine(), out num2);
            //    if (!isValidInput)
            //    {
            //        Console.WriteLine("Invalid input!");
            //    }
            //} while (!isValidInput);

            //if (op == '/' && num2 == 0)
            //{
            //    Console.WriteLine("Error: Division by zero is not allowed.");
            //}
            //else
            //{
            //    switch (op)
            //    {
            //        case '+':
            //            result = num1 + num2;
            //            break;
            //        case '-':
            //            result = num1 - num2;
            //            break;
            //        case '*':
            //            result = num1 * num2;
            //            break;
            //        case '/':
            //            result = num1 / num2;
            //            break;
            //        default:
            //            Console.WriteLine("Invalid operator!");
            //            return;
            //    }
            //    Console.WriteLine($"Result: {result}");
            //}

            #endregion


            #region Q18. Numbers from 1 to N

            //int number;

            //do
            //{
            //    Console.WriteLine("Enter a positive integer number (greater than 0):");

            //} while (!int.TryParse(Console.ReadLine(), out number) || number <= 0);

            //Console.Write($"Numbers from 1 to {number} are: ");
            //for (int i = 1; i <= number; i++)
            //{
            //    Console.Write(i + (i == number ? "" : ", "));
            //}

            #endregion


            #region Q19.  Multiplication Table up to 12

            //int number;

            //do
            //{
            //    Console.WriteLine("Enter an integer number:");

            //} while (!int.TryParse(Console.ReadLine(), out number));

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine($"{number} x {i} = {number * i}");
            //}

            #endregion


            #region Q20. Even Numbers from 1 to N

            //int number;

            //do
            //{
            //    Console.WriteLine("Enter a positive integer number (greater than 1):");

            //} while (!int.TryParse(Console.ReadLine(), out number) || number <= 1);

            //Console.Write($"Even numbers from 1 to {number} are: ");
            //for (int i = 2; i <= number; i += 2)
            //{
            //    Console.Write(i + " ");
            //}


            #endregion


            #region Q21. Power Calculation

            //int @base = 0, exponent = 0;
            //float result;
            //string[] input;
            //do
            //{
            //    Console.Write("Enter base and exponent separated by space (Both are integers): ");
            //    input = Console.ReadLine().Split();

            //} while (input.Length != 2 || !int.TryParse(input[0], out @base) || !int.TryParse(input[1], out exponent));

            //if (@base == 0 && exponent == 0)
            //{
            //    Console.WriteLine("0^0 is indeterminate. Defaulting to 1.");
            //    result = 1;
            //}
            //else
            //{

            //    result = 1;

            //    if (exponent >= 0)
            //    {
            //        for (int i = 0; i < exponent; i++)
            //        {
            //            result *= @base;
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 0; i < -exponent; i++)
            //        {
            //            result *= @base;
            //        }
            //        result = 1 / result;
            //    }
            //}
            //Console.WriteLine($"{@base} ^ {exponent} = {result}");

            #endregion


            #region Q22. Reversed Number
            //int number;

            //do
            //{
            //    Console.Write("Enter an integer number: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //int reversed = 0;
            //int original = number;

            //while (number != 0)
            //{
            //    int remainder = number % 10;
            //    reversed = (reversed * 10) + remainder;
            //    number /= 10;
            //}

            //Console.WriteLine($"Reversed of {original} is {reversed}");


            #endregion


            #region Q23. Prime Numbers Within a Range.

            //int start, end;
            //bool isValidInput;

            //do
            //{
            //    Console.Write("Input starting number of range: ");
            //    isValidInput = int.TryParse(Console.ReadLine(), out start);

            //    if (!isValidInput || start < 0)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            //    }

            //} while (!isValidInput || start < 0);

            //do
            //{
            //    Console.Write("Input ending number of range: ");
            //    isValidInput = int.TryParse(Console.ReadLine(), out end);

            //    if (!isValidInput || end < 0)
            //    {
            //        Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            //    }

            //} while (!isValidInput || end < 0);

            //Console.WriteLine($"The prime numbers between {start} and {end} are:", start, end);

            //for (int i = start; i <= end; i++)
            //{
            //    if (i > 1)
            //    {
            //        bool isPrime = true;
            //        for (int j = 2; j <= Math.Sqrt(i); j++)
            //        {
            //            if (i % j == 0)
            //            {
            //                isPrime = false;
            //                break;
            //            }
            //        }

            //        if (isPrime)
            //        {
            //            Console.Write(i + " ");
            //        }
            //    }
            //}

            #endregion


            #region Q24. Convert Decimal Number to Binary.

            //int number;
            //do
            //{
            //    Console.Write("Enter an integer number to convert: ");
            //} while (!int.TryParse(Console.ReadLine(), out number));

            //string binary = "";
            //int temp = number;

            //if (temp == 0)
            //{
            //    binary = "0";
            //}
            //else
            //{
            //    bool isNegative = temp < 0;
            //    if (isNegative)
            //    {
            //        temp = -temp;
            //    }

            //    while (temp > 0)
            //    {
            //        binary = (temp % 2) + binary;
            //        temp /= 2;
            //    }
            //    if (isNegative)
            //    {
            //        binary = "-" + binary;
            //    }
            //}

            //Console.WriteLine($"The Binary of {number} is " + binary);

            #endregion


            #region Q25. Sum of All Elements in an Array.

            //int size;
            //do
            //{
            //    Console.Write("Enter the size of the array (greater than 0): ");

            //} while (!int.TryParse(Console.ReadLine(), out size) || size <= 0);

            //int[] arr = new int[size];
            //int sum = 0;
            //Console.WriteLine("Enter the elements of the array (integer numbers):");
            //for (int i = 0; i < size; i++)
            //{
            //    do
            //    {
            //        Console.Write($"Element [{i}]: ");

            //    } while (!int.TryParse(Console.ReadLine(), out arr[i]));

            //    sum += arr[i];
            //}

            //Console.WriteLine($"The sum of all elements in the array is: {sum}");

            #endregion
        }
    }
}
