namespace ProgrammingChallenges.Levels.Easy
{
    /// <summary>
    /// Create a function that takes a base number and an exponent number and returns the calculation.
    /// Example: СalculateExponent(5, 5) ➞ 3125
    /// </summary>
    public class PowerOf
    {
        private decimal _numberBase; 
        private int _exponent; 

        public PowerOf(decimal numberBase, int exponent)
        {
            _numberBase = numberBase;
            _exponent = exponent;

            CalculateExponent();
        }

        private void CalculateExponent()
        {
            decimal result = _numberBase;

            for (var i = 1; i < _exponent; i++) //i = 1 because don't multiply the first time (ex: if expoent == 5, the for need to run 4 times)
            {
                result = result * _numberBase;
            }

            Console.WriteLine($"Result = {result}");
        }
    }
}
