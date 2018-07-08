using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
   public static class EnumerableExtensions
    {
        public static bool MyAll<T>(this IEnumerable<T> collection, Func<T, bool> predicate)
        {
            bool response = false;
            foreach(T item in collection)
            {
                if (predicate(item))
                    response = true;
                else
                    return false;
            }
            return response;
        }

        public static T MyFirst<T>(this IEnumerable<T> collection)
        {
            T firstELement= default(T);
            if (collection.Count() == 0)
            {
                throw new Exception("No first index");
            }

            foreach (T item in collection)
            {
                firstELement = item;
                break;
            }
            return firstELement;
        }

        public static T MyFirstOrDefault<T>(this IEnumerable<T> collection)
        {
            T firstELement = default(T);
            foreach (T item in collection)
            {
                firstELement = item;
                break;
            }
            return firstELement;
        }

        public static IEnumerable<T> MyReverse<T>(this IEnumerable<T> collection)
        {
            List<T> reversedCollection = new List<T>();
            for (int i = collection.Count()-1; i >= 0; i--)
            {
                ((List<T>)reversedCollection).Add(collection.ElementAt(i));
            }
            return reversedCollection;
        }
    }
}
