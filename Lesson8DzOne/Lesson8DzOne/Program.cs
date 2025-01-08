namespace Lesson8DzOne
{
  internal class Program
  {
    static void Main(string[] args)
    {
      Console.Write("Введите строку: ");
      string input = Console.ReadLine().ToLower().Replace(" ", "");


      Console.WriteLine("Введенная строка " + (!IsPalindrome(input) ? "не " : null) + "является палиндромом.");


      Console.ReadKey();
    }

    static bool IsPalindrome(string str)
    {
      int left = 0;
      int right = str.Length - 1;

      while (left < right)
      {
        if (str[left] != str[right])
        {
          return false;
        }

        left++;
        right--;
      }

      return true;
    }
  }
}
