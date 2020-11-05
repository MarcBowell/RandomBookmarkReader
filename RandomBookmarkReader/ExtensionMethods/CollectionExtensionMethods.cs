using System;
using System.Collections.Generic;
using System.Linq;

namespace Marcware.RandomBookmarkReader.ExtensionMethods
{
    internal static class CollectionExtensionMethods
    {
        /// <summary>
        /// Take a random selection of items from a list of items
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="collection"></param>
        /// <param name="count">Maximum number of items to take from the list</param>
        /// <returns></returns>
        public static List<T> TakeRandom<T>(this List<T> collection, int count)
        {
            Random randomizer = new Random(Guid.NewGuid().GetHashCode());

            List<KeyValuePair<int, double>> itemsToSort = new List<KeyValuePair<int, double>>();
            for (int item = 0; item < collection.Count; item++)
            {
                itemsToSort.Add(new KeyValuePair<int, double>(item, randomizer.NextDouble()));                
            }
            itemsToSort = itemsToSort
                .OrderBy(i => i.Value)
                .Take(count)
                .ToList();

            List<T> result = new List<T>();
            foreach (KeyValuePair<int, double> item in itemsToSort)
            {
                result.Add(collection[item.Key]);
            }

            return result;
        }
    }
}
