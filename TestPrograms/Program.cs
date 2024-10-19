namespace TestPrograms
{
    public class Proagram
    {
        static void Main(string[] args)
        {
            ArrayTechniques _arrayTechniques = new();
            ArrayProblems _arrayProblems = new();

            //_arrayTechniques.SlidingWindow();
            //_arrayTechniques.TwoPointer();
            //_arrayTechniques.BinarySearch();

            int[] sortedArr = { 1, 2, 3, 4, 6 };
            Console.WriteLine(_arrayProblems.FindPairWithGivenSum(sortedArr, 3));
        }
    }
}



