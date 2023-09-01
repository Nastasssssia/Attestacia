using System.Security.Cryptography.X509Certificates;

namespace Task;

class Program
{
    static void Main(string[] args)
    {
       string Input(string text)
       {
          Console.Write(text);
          return Console.ReadLine();
       }

       string [] InputArray (int length)
       {
          string[]array = new string[length];
          for(int i = 0; i < array.Length; i++)
          {
               array[i] = Input($"Введите {i+1}-й элемент:");
          }
          return array;

       }

       void PrintArray(string[]array)
       {
          for(int i = 0; i < array.Length; i++)
          {
             Console.WriteLine($"{array[i]}");
          }

       }

       int length = 6;
       string []array = InputArray(length);
       PrintArray(array);
    }
}
