Просим пользователя ввести длину нового массива 
Формируем новый массив  заданного пользователем размера содержащий строковые элементы
Пользователья с клавиатуры вводит строкоые данные для заполнения элементов массива 
В случае , если строковая переменная принимает значение NULL,присваиваем текущей строке пустое значение, чтобы программа работала корректно
Заполняем массив    
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