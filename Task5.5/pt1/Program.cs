namespace pt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст: ");
            string[] userText = SplitText(Console.ReadLine());
            Console.WriteLine("текст состоит из следующих слов: ");
            ArrayPrint(userText);
        }

        static string[] SplitText(string text) 
        {
            return text.Split(" ");
        }

        static void ArrayPrint(string[] text) 
        {
            for (int i = 0; i < text.Length; i++) 
            {
                Console.WriteLine(text[i]);
            }
        }
    }
}