using System.Security.Cryptography.X509Certificates;

namespace Task;

class Program
{
    static void Main(string[] args)
    {
       
       int length = 5;
       string []array = InputArray(length);
       string[] newArray = Filter(array);
       PrintArray(newArray);

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

       string [] Filter(string[] strings)
       {
          int count = 0;
          for(int i = 0; i < strings.Length; i++)
          {
               if(strings[i].Length <= 3)
               {
                    count++;
               }
          }
          string[] newArray = new string[count];
          int newIndex = 0 ;
          for(int i = 0; i < strings.Length; i++)
          {
               if(strings[i].Length <= 3)
               {
                    newArray[newIndex]=strings[i];
                    newIndex++;
               }
          }
          return newArray;

       }

     
       
    }
}
