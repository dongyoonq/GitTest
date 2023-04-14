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

            // 8번

            Console.WriteLine("문장을 입력하세요. : ");
            string sentence = Console.ReadLine();
            string[] word = sentence.Split(' ');	// 공백을 기준으로 쪼갠다
            Console.WriteLine(word.Length);		// 쪼갠 단어의 길이(개수)를 출력


        }
    }
}