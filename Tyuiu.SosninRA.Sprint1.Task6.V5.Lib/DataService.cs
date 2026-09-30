using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.SosninRA.Sprint1.Task6.V5.Lib
{
    public class DataService : ISprint1Task6V5
    {
        public string CheckSymmetricalWords(string value)
        {
            string[] words = value.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string result = "";

            foreach (string word in words)
            {
                // Переворачиваем слово для проверки на симметричность
                char[] charArray = word.ToCharArray();
                Array.Reverse(charArray);
                string reversedWord = new string(charArray);

                // Сравниваем исходное слово с перевёрнутым (без учёта регистра)
                if (word.Equals(reversedWord, StringComparison.OrdinalIgnoreCase))
                {
                    if (result.Length > 0)
                    {
                        result += " ";
                    }
                    result += word;
                }
            }

            return result;
        }
    }
}
