namespace GitTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 7번 IndexOf() 사용

            Console.WriteLine("문장을 입력하세요. : ");
            string yummy = Console.ReadLine();
            Console.WriteLine("단어를 입력하세요 : ");
            string fruit = Console.ReadLine();

            int a = yummy.IndexOf(fruit);

            Console.WriteLine(a);

        }
    }
}