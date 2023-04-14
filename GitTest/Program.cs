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
            Console.WriteLine(word.Length);     // 쪼갠 단어의 길이(개수)를 출력


            // 9번

            int num = 0;
            bool deci = true;

            Console.WriteLine("숫자를 입력하시오 : ");
            num = int.Parse(Console.ReadLine());        // 형변환

            if (num == 2)        // 입력값이 2일때 true
            {
                deci = true;
            }

            else if (num % 2 == 0)     // 짝수면 false
            {
                deci = false;
            }

            else
            {
                for (int i = 3; i < num; i++)     // num을 i=3부터 나누는 판별식
                {
                    if (num % i == 0)              // 나눈 나머지가 0일 경우
                    {
                        deci = false;
                        break;                  // 바로 반복 중지
                    }
                    else
                    {
                        deci = true;
                    }
                }
            }
            if (deci == true)
                Console.WriteLine(num + "은 소수입니다.");
            else
            {
                Console.WriteLine(num + "은 소수가 아닙니다.");
            }

            // 10번

            Console.WriteLine("양의 정수를 입력하시오 : ");
            int input = int.Parse(Console.ReadLine());
            int result = SumOfDigits(input);
            Console.WriteLine(result);

        }

        static int SumOfDigits(int num)
        {
            int answer = 0;

            while (num != 0)                // num/10이 0보다 클 경우 계속 반복
            {
                answer += num % 10;
                num = num / 10;
            }

            return answer;



        }
    }
}