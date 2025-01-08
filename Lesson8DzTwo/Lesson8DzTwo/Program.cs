using System;
using System.Text;

namespace Lesson8DzTwo
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Введите строку: ");
      string input = Console.ReadLine();

      string result = RemoveSpaces(input);
      Console.WriteLine("Результат: " + result);
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
  }
}