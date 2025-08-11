namespace Challenge_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] helloAscii = { 72, 101, 108, 108, 111 }; // Hello
            int[] nameAscii = { 84, 114, 105, 112, 111, 100}; // Tripod
            // Convert ASCII values to characters and concatenate them
            Console.WriteLine($"{string.Concat(helloAscii.Select( c => (char)c) )}, {string.Concat(nameAscii.Select(c => (char)c) )}");

        }
    }
}
