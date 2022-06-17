// Написать программу , которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символам.Первоначальный массив можно ввести с клавиатуры, 
// либо задать на страте выполнения алгоритма.
// Прирешении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Создаем массив 
internal class  Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите количество элементов массива ");
        int n = Convert.ToInt32(Console.ReadLine());
        string[] array = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Введите данные для заполнения строки массива ");
            string? str = Console.ReadLine();
            if(str == null)
            {
              str = "";
            }
            array[i] = str; 
        }
        PrintArray(array);
        Console.Write("--");
        Select(array);

        //Вывести массив (процедура PrintArray)
        void PrintArray(string[] arr)
          {
            for (int i = 0; i < arr.Length; i++)
            Console.Write("[" + array[i] + "]");    
          }
     //Отбор слов содержащих 3 или менее  символов (процедура Select)
        void Select(string[] arr)
        {
            for (int i = 0; i < array.Length; i++)
            {
              if (array[i].Length <= 3)
              Console.Write("[" + array[i] + "]");
            }
        }
    }
}      