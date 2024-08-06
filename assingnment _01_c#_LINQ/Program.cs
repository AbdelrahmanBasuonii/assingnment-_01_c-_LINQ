using assingnment__01_c__LINQ;

namespace assingnment__01_c__LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q1 restriction
            //1. Find all products that are out of stock.
            var outOfStockProducts = ListGenerator.ProductsList.Where(p => p.UnitsInStock == 0);

            Console.WriteLine("Products that are out of stock:");
            foreach (var product in outOfStockProducts)
            {
                Console.WriteLine(product.ProductName);
            }

            //2. Find all products that are in stock and cost more than 3.00 per unit.
            var inStockAndExpensiveProducts = ListGenerator.ProductsList
                .Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);

            Console.WriteLine("Products in stock and cost more than 3.00:");
            foreach (var product in inStockAndExpensiveProducts)
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            }


            //3. Returns digits whose name is shorter than their value.
            string[] arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var digitsWithShorterName = arr.Where((name, index) => name.Length < index);

            Console.WriteLine("Digits whose name is shorter than their value:");
            foreach (var digit in digitsWithShorterName)
            {
                Console.WriteLine(digit);
            }
            #endregion



            #region 1. Sort a list of products
            // 1. Sort a list of products by name 
            var sortedProducts = ListGenerator.ProductsList.OrderBy(p => p.ProductName, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Products sorted by name:");
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product.ProductName);
            } 
            #endregion



            #region 2.  Uses a custom
            // 2.  Uses a custom comparer to do a case-insensitive sort of the words in an array.
            string[] arr1 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedArr = arr1.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("\nWords sorted case-insensitively:");
            foreach (var word in sortedArr)
            {
                Console.WriteLine(word);
            } 
            #endregion



            #region 3. Sort a list
            // 3. Sort a list of products by units in stock from highest to lowest
            var sortedByStockDescending = ListGenerator.ProductsList.OrderByDescending(p => p.UnitsInStock);

            Console.WriteLine("Products sorted by units in stock (highest to lowest):");
            foreach (var product in sortedByStockDescending)
            {
                Console.WriteLine($"{product.ProductName} - {product.UnitsInStock}");
            } 
            #endregion


            #region 4. Sort
            // 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself
            string[] arr3 = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var sortedDigits = arr3
                .OrderBy(word => word.Length)
                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("\nDigits sorted by length and then alphabetically:");
            foreach (var word in sortedDigits)
            {
                Console.WriteLine(word);
            } 
            #endregion

            #region 5. Sort
            //5. Sort first by word length and then by a case-insensitive sort of the words in an array.
            string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWords = words
                .OrderBy(word => word.Length)
                .ThenBy(word => word, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("Words sorted by length and then case-insensitively:");
            foreach (var word in sortedWords)
            {
                Console.WriteLine(word);
            } 
            #endregion


            #region 6.Sort
            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            var sortedByCategoryAndPrice = ListGenerator.ProductsList
            .OrderBy(p => p.Category)
            .ThenByDescending(p => p.UnitPrice);

            Console.WriteLine("Products sorted by category and then by unit price (highest to lowest):");
            foreach (var product in sortedByCategoryAndPrice)
            {
                Console.WriteLine($"{product.Category} - {product.ProductName}: {product.UnitPrice:C}");
            } 
            #endregion



            #region 7. Sort
            //7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            string[] words2 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var sortedWordsDescending = words2
                .OrderBy(word2 => word2.Length)
                .ThenByDescending(word2 => word2, StringComparer.OrdinalIgnoreCase);

            Console.WriteLine("\nWords sorted by length and then case-insensitively descending:");
            foreach (var word2 in sortedWordsDescending)
            {
                Console.WriteLine(word2);
            } 
            #endregion


            #region 8.Create
            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var filteredAndReversed = digits
                .Where(word => word.Length > 1 && word[1] == 'i')
                .Reverse();

            Console.WriteLine("\nDigits whose second letter is 'i' in reverse order:");
            foreach (var digit in filteredAndReversed)
            {
                Console.WriteLine(digit);
            } 
            #endregion

        }
    }
}
