

string[] input = {"hello", "2", "world", ":-)"};  // Инициализация Массива.
string[] output = {}; // Создали хранилище для выделанных массивов 

for (int i = 0; i < input.Length; i++) //К каждому проделанному шагу массива будет добовляться +1 что бы массив обработал остальные данные.
{
    if (input[i].Length <= 3) // Импут i будет строчкой больше или равно 3.
    {
        Array.Resize(ref output, output.Length + 1);  //
        output[output.Length - 1] = input[i];         //
    }
}

foreach (var element in output)
{
    Console.WriteLine(element);  //Показ Элементов
}