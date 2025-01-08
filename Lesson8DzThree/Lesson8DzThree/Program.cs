using System.Text;
namespace Lesson8DzThree
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Введите строку: ");
      string input = Console.ReadLine();

      string noSpaces = RemoveSpaces(input);

      string allLowercase = input.ToLower();
      string allUppercase = input.ToUpper();
      string titleCase = ToTitleCase(input);

      Console.WriteLine("Все строчные буквы: " + allLowercase);
      Console.WriteLine("Все заглавные буквы: " + allUppercase);
      Console.WriteLine("Первая буква каждого слова в заглавную: " + titleCase);
      Console.ReadKey();
    }

    static string RemoveSpaces(string str)
    {
      StringBuilder sb = new StringBuilder();
      foreach (char c in str)
      {
        if (c != ' ')
        {
          sb.Append(c);
        }
      }
      return sb.ToString();
    }

    static string ToTitleCase(string str)
    {
      string[] words = str.Split(' ');
      for (int i = 0; i < words.Length; i++)
      {
        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
      }
      return string.Join(" ", words);
    }
  }
}
