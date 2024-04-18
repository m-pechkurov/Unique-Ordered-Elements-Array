using System;
namespace WorkArea 
{
    public class UniqueOrderedElementsArray
    {
        public static List<T> DoIt<T>(IEnumerable<T> collection)
        {
            List<T> uniqueElements = new List<T>();
            T prevElem = default(T);
            var enumerator = collection.GetEnumerator();
            while (enumerator.MoveNext())
            {
                var currentItem = enumerator.Current;
                if (EqualityComparer<T>.Default.Equals(prevElem, currentItem))
                {
                    continue;
                }
                uniqueElements.Add(currentItem);
                prevElem = currentItem;
            }
            return uniqueElements;
        }
    }
}
