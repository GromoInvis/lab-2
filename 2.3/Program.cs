using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть текстовий рядок:");
        string inputText = Console.ReadLine();

        // Підрахунок кількості великих літер у тексті
        int uppercaseCount = inputText.Count(char.IsUpper);
        Console.WriteLine($"Кількість великих літер у тексті: {uppercaseCount}");

        // Розділення тексту на слова
        string[] words = inputText.Split(new char[] { ' ', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

        // Знаходження слова з мінімальною кількістю літер
        string minLetterWord = words.OrderBy(w => w.Length).FirstOrDefault();
        Console.WriteLine($"Слово з найменшою кількістю літер: {minLetterWord}");

        // Видалення слів, що починаються з малої літери
        string[] filteredWords = words.Where(w => !char.IsLower(w[0])).ToArray();
        string resultText = string.Join(" ", filteredWords);
        Console.WriteLine($"Текст без слів, що починаються з малої літери:\n{resultText}");
    }
}