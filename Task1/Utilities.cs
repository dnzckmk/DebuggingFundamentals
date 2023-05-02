using System;

namespace Task1
{
    public static class Utilities
    {
        /// <summary>
        /// Sorts an array in ascending order using bubble sort.
        /// </summary>
        /// <param name="numbers">Numbers to sort.</param>
        /// <exception cref="ArgumentNullException">Throws ArgumentNullException if the numbers array is null.</exception>
        public static void Sort(int[] numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers));
            }

            int temp;
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[i] > numbers[j])
                    {
                        temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// Searches for the index of a product in an <paramref name="products"/>
        /// based on a <paramref name="predicate"/>.
        /// </summary>
        /// <param name="products">Products used for searching.</param>
        /// <param name="predicate">Product predicate.</param>
        /// <returns>If match found then returns index of product in <paramref name="products"/>
        /// otherwise -1.</returns>
        /// <exception cref="ArgumentNullException">Throws ArgumentNullException if either products array or predicate is null.</exception>
        public static int IndexOf(Product[] products, Predicate<Product> predicate)
        {
            if (products == null)
            {
                throw new ArgumentNullException(nameof(products));
            }

            if (predicate == null)
            {
                throw new ArgumentNullException(nameof(predicate));
            }

            for (int i = 0; i < products.Length; i++)
            {
                var product = products[i];
                if (predicate(product))
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
