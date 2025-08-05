namespace C44_G02_C_ADV01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.The Bubble Sort algorithm has a time complexity of O(n^2) in its worst and average cases, which makes it inefficient for large datasets. How we can optimise the Bubble Sort algorithm And implement the code of this optimised bubble sort algorithm

            int[] ints = { 3, 5, 4, 8, 6, 1, 2, 9, 8 };
            helper.OptimizedBubbleSort(ints);

            foreach (int item in ints)
            {
                Console.WriteLine(item);
            }
         


            #endregion


            #region 2.create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. The range should support basic operations such as checking if a value is within the range and determining the length of the range.

            var intRange = new Range<int>(10 , 20);

            Console.WriteLine($"Range : {intRange}");

            bool flag =  intRange.IsInRang(15);

            Console.WriteLine($"array containes 15? =>  {flag}");
            var length = intRange.Length();

            Console.WriteLine($"Length = {length}");

            #endregion









            Console.ReadLine();


        }
    }
}
