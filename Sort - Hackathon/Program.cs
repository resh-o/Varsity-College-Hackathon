namespace Sort___Hackathon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 5, 2, 9, 1, 5, 6, 3 };
            Console.WriteLine("Original List: " + numbers);

            SortList(numbers);

            Console.WriteLine("Sorted List in Ascending Order: ");
            foreach (int number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        public static void SortList(List<int> list)
        {
            for (int i = 0; i < list.Count - 1; i++)
            {
                for (int j = i + 1; j < list.Count; j++)
                {
                    if (list[i] > list[j])
                    {
                        int temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }
    }
}
