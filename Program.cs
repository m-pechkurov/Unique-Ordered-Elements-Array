using WorkArea;

// Пример использования на строке
var example1 = UniqueOrderedElementsArray.DoIt("aaaaaaaaaaasdasdasdasdasdazzzzzzq");
Console.WriteLine("Пример 1 (строка):");
PrintCollection(example1);

// Пример использования на массиве целых чисел
var example2 = UniqueOrderedElementsArray.DoIt(new[] { 1, 2, 38, 1, 1, 1, 2, 2, 2, 42, 16, 16 });
Console.WriteLine("\nПример 2 (массив целых чисел):");
PrintCollection(example2);

// Пример использования на очереди
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(2);
queue.Enqueue(3);
queue.Enqueue(3);
var example4 = UniqueOrderedElementsArray.DoIt(queue);
Console.WriteLine("\nПример 4 (очередь):");
PrintCollection(example4);

// Пример использования на списке
List<double> list = new List<double> { 1.1, 2.2, 3.3, 3.3, 4.4, 4.4 };
var example5 = UniqueOrderedElementsArray.DoIt(list);
Console.WriteLine("\nПример 5 (список):");
PrintCollection(example5);

Console.ReadLine();


// Метод для вывода элементов коллекции
static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (var item in collection)
    {
        Console.Write(item);
    }
}