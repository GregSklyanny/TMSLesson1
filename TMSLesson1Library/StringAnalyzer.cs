namespace TMSLesson1Library
{
    internal class StringAnalyzer
    {
        public string OddOrEvenAnalyzer(string str)
        {
            int number;
            if (int.TryParse(str, out number))
            {
                return number % 2 == 0 ?  $"Число {number} четное" : $"Число {number} нечетное";
            }

            return "Это не целое число";
        }
    }
}
