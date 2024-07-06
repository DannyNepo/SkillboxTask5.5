namespace pt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите текст: ");
            string text = Console.ReadLine();
            Console.WriteLine("текст наоборот: ");
            Console.WriteLine(ReverseText(text));
        }

        static string[] SplitText(string text)
        {
            return text.Split(" ");
        }

        static string ReverseText(string text) 
        {
            string[] textArray = SplitText(text);
            string[] textArrayInversed = new string[textArray.Length];
            textArrayInversed[0] = textArray[textArray.Length - 1];
            string resultText = textArrayInversed[0] + " ";
            for (int i = 1; i < textArray.Length; i++)
            {
                textArrayInversed[i] = textArray[textArray.Length - 1 - i];
                resultText += textArrayInversed[i] + " ";
            }
            return resultText;
        }
    }
}