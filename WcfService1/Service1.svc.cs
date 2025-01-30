using System;
using System.Linq;



namespace WcfService1
{
    public class Service1 : IService1
    {
        public int c2f(int celsius)
        {
            // Check for absolute zero in Celsius
            if (celsius < -273)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(celsius),
                    "Value cannot be lower than absolute zero (-273°C)."
                );
            }
            return (int)(celsius * 9.0 / 5 + 32);
        }

        public int f2c(int fahrenheit)
        {
            // Check for absolute zero in Fahrenheit
            if (fahrenheit < -459)
            {
                throw new ArgumentOutOfRangeException(
                    nameof(fahrenheit),
                    "Value cannot be lower than absolute zero (-459°F)."
                );
            }
            return (int)((fahrenheit - 32) * 5.0 / 9);
        }

        public string sort(string commaSeparatedNumbers)
        {
            if (string.IsNullOrWhiteSpace(commaSeparatedNumbers))
            {
                throw new ArgumentException("Input cannot be null or empty.", nameof(commaSeparatedNumbers));
            }

            // Split by commas, parse to int, sort ascending, then join back into a comma-separated string.
            var sortedNumbers = commaSeparatedNumbers
                .Split(',')
                .Select(num => int.Parse(num.Trim()))
                .OrderBy(n => n);

            return string.Join(",", sortedNumbers);
        }
    }
}

