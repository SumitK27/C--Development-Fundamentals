using System;
using System.Globalization;
using System.Text;

namespace CSharpTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OperatorTypes();

            // ********* Default Values **********
            int defaultInt; // 0
            bool defaultBool; // false

            MembersIntegerBoolean();
            MembersCharacter();
            MembersDateTime();
            MembersTimeSpan();
            MembersString();
            StringBuilderOperations();
            StringParsing();
        }

        private static void StringParsing()
        {
            string intStr = "123";
            string doubleStr = "123.45";
            string boolStr = "true";
            string dateTimeStr = "07/24/2023";
            string timeSpanStr = "08:35:00";

            int intNumber;
            double doubleNumber;
            bool boolValue;
            DateTime dateTime;
            TimeSpan timeSpan;

            //int intNumber = int.Parse(intStr); // 123
            //double doubleNumber = double.Parse(doubleStr); // 123.45
            //bool boolValue = bool.Parse(boolStr); // True
            //DateTime dateTime = DateTime.Parse(dateTimeStr); // 7/24/2023 12:00:00 AM
            //TimeSpan timeSpan = TimeSpan.Parse(timeSpanStr); // 08:35:00

            bool isInt = int.TryParse(intStr, out intNumber); // True
            bool isDouble = double.TryParse(doubleStr, out doubleNumber); // True
            bool isBool = bool.TryParse(boolStr, out boolValue); // True
            bool isDateTime = DateTime.TryParse(dateTimeStr, out dateTime); // True
            bool isTimeSpan = TimeSpan.TryParse(timeSpanStr, out timeSpan); // True

            var cultureInfo = new CultureInfo("nl-BE");
            string birthDateString = "28 Maart 1984";//Dutch, spoken in Belgium
            var birthDate = DateTime.Parse(birthDateString, cultureInfo);
            Console.WriteLine($"Birth Date: {birthDate}"); // 3/28/1984 12:00:00 AM
        }

        private static void StringBuilderOperations()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Hello");
            stringBuilder.Append(" ");
            stringBuilder.Append("World");

            Console.WriteLine($"String Builder: {stringBuilder}"); // Hello World

            stringBuilder.Replace("World", "C#");
            stringBuilder.Insert(0, "Hi ");
            stringBuilder.AppendLine("!");

            Console.WriteLine($"String Builder: {stringBuilder}"); // Hi Hello C#!
        }

        private static void MembersString()
        {
            string hello = "Hello";
            string empty = string.Empty;
            var implicitStr = "Implicit String";
            string nullStr = null;
            string declaredStr;

            Console.WriteLine($"Hello: {hello}");
            Console.WriteLine($"Empty: {empty}");
            Console.WriteLine($"Implicit String: {implicitStr}");
            Console.WriteLine($"Null String: {nullStr}");

            Console.WriteLine($"Length: {hello.Length}"); // 5
            Console.WriteLine($"ToUpper: {hello.ToUpper()}"); // HELLO
            Console.WriteLine($"ToLower: {hello.ToLower()}"); // hello
            Console.WriteLine($"Contains: {hello.Contains("ll")}"); // true
            Console.WriteLine($"Replace: {hello.Replace("ll", "LL")}"); // HeLLo
            Console.WriteLine($"Substring: {hello.Substring(1, 2)}"); // el
            Console.WriteLine($"Chain: {hello.ToUpper().Replace("LL", "ll").Substring(1, 2)}"); // E

            Console.WriteLine($"Concatenation: {hello + " World"}"); // Hello World
            Console.WriteLine($"Concatenation: {string.Concat(hello, " World")}"); // Hello World
            Console.WriteLine($"Interpolation: {hello} World"); // Hello World
            Console.WriteLine($"Interpolation: {string.Format("{0} World", hello)}"); // Hello World

            Console.WriteLine($"Double Quotes: \""); // "
            Console.WriteLine($"Single Quotes: \'"); // '
            Console.WriteLine($"Backslash: \\"); // \
            Console.WriteLine($"New Line: \n"); // New Line
            Console.WriteLine($"Carriage Return: \r"); // Carriage Return
            Console.WriteLine($"Tab: \t"); // Tab
            Console.WriteLine($"Vertical Tab: \v"); // Vertical Tab
            Console.WriteLine($"Alert: \a"); // Alert
            Console.WriteLine($"Backspace: \b"); // Backspace
            Console.WriteLine($"Form Feed: \f"); // Form Feed
            Console.WriteLine($"Unicode: \u0061"); // a
            Console.WriteLine($"File Path: C:\\Users\\"); // C:\Users\

            Console.WriteLine($"Compare: {"Hello" == "Hello"}"); // 0
            Console.WriteLine($"Compare: {string.Compare("Hello", "Hello")}"); // 0
            Console.WriteLine($"Compare: {string.Compare("Hello", "World")}"); // -1
            Console.WriteLine($"Compare: {string.Compare("World", "Hello")}"); // 1
            Console.WriteLine($"Compare: {"Hello".CompareTo("Hello")}"); // 0
            Console.WriteLine($"Compare: {"Hello".Equals("Hello")}"); // True
        }

        private static void MembersTimeSpan()
        {
            DateTime startHour = DateTime.Now;
            TimeSpan workTime = new TimeSpan(8, 35, 0);
            DateTime endHour = startHour.Add(workTime);

            Console.WriteLine($"Start Hour: {startHour}");
            Console.WriteLine($"Work Time: {workTime}");
            Console.WriteLine($"End Hour: {endHour}");
            Console.WriteLine($"Long Date String: {startHour.ToLongDateString()}");
            Console.WriteLine($"Short Time String: {endHour.ToShortTimeString()}");
        }

        private static void MembersDateTime()
        {
            DateTime date = new DateTime(2023, 07, 24);
            DateTime today = DateTime.Today;
            DateTime twoDaysInFuture = date.AddDays(2);
            DayOfWeek dayOfWeek = date.DayOfWeek;
            bool isDST = date.IsDaylightSavingTime();

            Console.WriteLine($"Date: {date}");
            Console.WriteLine($"Today: {today}");
            Console.WriteLine($"Two Days in Future: {twoDaysInFuture}");
            Console.WriteLine($"Day of Week: {dayOfWeek}");
            Console.WriteLine($"Is Daylight Saving Time: {isDST}");
        }

        private static void MembersCharacter()
        {
            char character = 'a';
            char upperCaseCharacter = char.ToUpper(character);
            bool isWhiteSpace = char.IsWhiteSpace(character);
            bool isDigit = char.IsDigit(character);
            bool isLetter = char.IsLetter(character);
            bool isLetterOrDigit = char.IsLetterOrDigit(character);
            bool isPunctuation = char.IsPunctuation(character);
            bool isNumber = char.IsNumber(character);
            bool isSeparator = char.IsSeparator(character);
            bool isSymbol = char.IsSymbol(character);

            Console.WriteLine($"Character: {character}");
            Console.WriteLine($"Upper Case Character: {upperCaseCharacter}");
            Console.WriteLine($"Is White Space: {isWhiteSpace}");
            Console.WriteLine($"Is Digit: {isDigit}");
            Console.WriteLine($"Is Letter: {isLetter}");
            Console.WriteLine($"Is Letter or Digit: {isLetterOrDigit}");
            Console.WriteLine($"Is Punctuation: {isPunctuation}");
            Console.WriteLine($"Is Number: {isNumber}");
            Console.WriteLine($"Is Separator: {isSeparator}");
            Console.WriteLine($"Is Symbol: {isSymbol}");
        }

        private static void MembersIntegerBoolean()
        {
            // ********* Members of Premetive Types **********
            int minInt = int.MinValue;
            int maxInt = int.MaxValue;
            double minDouble = double.MinValue;
            double maxDouble = double.MaxValue;

            Console.WriteLine($"Minimum Integer: {minInt}");
            Console.WriteLine($"Maximum Integer: {maxInt}");
            Console.WriteLine($"Minimum Double: {minDouble}");
            Console.WriteLine($"Maximum Double: {maxDouble}");
        }

        private static void OperatorTypes()
        {
            // ********* Assignment Operator **********
            int monthlyWages = 1234;
            int months = 12, bonus = 1000;

            bool isActive = true;

            double rating = 99.25;
            //byte numberOfEmployees = 300; // Error: byte only can store upto 255
            byte worldWideBranches = 243;

            //monthlyWages = true; // Error: Int cannot store a Boolean value

            double ratePerHour = 12.34;
            int numberOfHoursorked = 165;

            // ********* Arithmetic Operator **********
            double currentMonthWage = ratePerHour * numberOfHoursorked + bonus;
            Console.WriteLine(currentMonthWage);

            ratePerHour += 3;

            // ********* Comparision Operator **********
            if (currentMonthWage > 2000)
            {
                Console.WriteLine("Top paid employee.");
            }

            int numberOfEmployees = 15;
            numberOfEmployees--;

            Console.WriteLine(numberOfEmployees);
        }
    }
}