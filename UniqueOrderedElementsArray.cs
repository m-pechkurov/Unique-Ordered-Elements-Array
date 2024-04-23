using System;
namespace WorkArea
{
    public class UniqueOrderedElementsArray
    {
        public static IEnumerable<T> GetUniqueOrderedElements<T>(IEnumerable<T> collection)
        {
            T prevElem = default(T);
            var enumerator = collection.GetEnumerator();

            while (enumerator.MoveNext())
            {
                var currentItem = enumerator.Current;

                if (EqualityComparer<T>.Default.Equals(prevElem, currentItem))
                {
                    continue;
                }

                yield return currentItem;
                prevElem = currentItem;
            }
        }
    }
}
