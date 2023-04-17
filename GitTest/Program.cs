using Microsoft.Win32.SafeHandles;
using System.Threading.Channels;

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


            // 11번

            Console.Write("첫 번째 배열의 크기를 입력하세요: ");
            int n1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[n1];       // 크기가 n1인 배열 arr1 생성

            Console.WriteLine("첫 번째 배열의 원소들을 입력하세요:");
            for (int i = 0; i < n1; i++)
            {
                Console.Write($"arr1[{i}] = ");
                arr1[i] = int.Parse(Console.ReadLine());      // arr1의 0번째부터 i번째 원소까지를 입력
            }

            Console.Write("두 번째 배열의 크기를 입력하세요: ");
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[n2];

            Console.WriteLine("두 번째 배열의 원소들을 입력하세요:");
            for (int i = 0; i < n2; i++)
            {
                Console.Write($"arr2[{i}] = ");
                arr2[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("세 번째 배열의 크기를 입력하세요: ");
            int n3 = int.Parse(Console.ReadLine());
            int[] arr3 = new int[n3];

            Console.WriteLine("세 번째 배열의 원소들을 입력하세요:");
            for (int i = 0; i < n3; i++)
            {
                Console.Write($"arr3[{i}] = ");
                arr3[i] = int.Parse(Console.ReadLine());
            }

            int[] commonItems = FindCommonItems(arr1, arr2, arr3);

            if (commonItems.Length == 0)
            {
                Console.WriteLine("공통 항목이 없습니다.");
            }
            else
            {
                Console.WriteLine("공통 항목:");
                for (int i = 0; i < commonItems.Length; i++)
                {
                    Console.WriteLine(commonItems[i]);
                }
            }

            Console.WriteLine("0~999 사이의 숫자 하나를 입력하세요.");
            UpDown();
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


        // 11번 함수

        static int[] FindCommonItems(int[] arr1, int[] arr2, int[] arr3)    // 정렬된 배열 셋에서 공통 항목을 찾는 메서드
            
        {
            List<int> commonItems = new List<int>();        // 공통항목을 저장할 List 선언


            // arr1 배열을 기준으로 각 항목이 나머지 배열에도 있는지 확인
            for (int i = 0; i < arr1.Length; i++)
            {
                int currentItem = arr1[i];      // 현재 항목

                // 다른 배열에서도 현재 항목이 있는지 확인
                // Indexof() 메서드를 사용해 배열에서 해당 항목의 인덱스를 찾음
                // 인덱스를 찾을 수 없을 경우 -1을 반환하므로 0이상인 경우에만 해당 항목이 존재하는 것으로 판단
                if (Array.IndexOf(arr2, currentItem) >= 0 &&
                    Array.IndexOf(arr3, currentItem) >= 0)
                {
                    // 중복되지 않게 추가
                    if (!commonItems.Contains(currentItem))
                    {
                        commonItems.Add(currentItem);
                    }
                }
            }
            // List를 배열로 변환하여 반환
            return commonItems.ToArray(); 
        }


        // 12번
        static void UpDown()
        {
            Random rand = new Random();
            int answer = rand.Next(0, 999);     // 컴퓨터가 출력한 랜덤값

            for(int i = 0; i < 10; i++)          // 10번 반복하는 for문 생성
            {
                int user = int.Parse(Console.ReadLine());
                
                if(user == answer)
                {
                    Console.WriteLine("정답입니다!");
                    break;
                }
                else if (user > answer)
                {
                    Console.WriteLine("정답보다 큰 수입니다.");
                    if (i == 9)
                    {
                        Console.WriteLine("정답은 " + answer + "입니다.");
                        Console.WriteLine("재시작 하시겠습니까?");

                        string choice = Console.ReadLine();

                        if (choice == "네")
                        {
                            Console.WriteLine("0~999 사이의 숫자 하나를 입력하세요.");
                            UpDown();
                        }

                        else
                        {
                            Console.WriteLine("게임이 종료되었습니다.");
                        }
                    }
                }
                else if (user < answer)
                {
                    Console.WriteLine("정답보다 작은 수입니다.");
                    if (i == 9)
                    {
                        Console.WriteLine("정답은 " + answer + "입니다.");
                        Console.WriteLine("재시작 하시겠습니까?");

                        string choice = Console.ReadLine();

                        if (choice == "네")
                        {
                            Console.WriteLine("0~999 사이의 숫자 하나를 입력하세요.");
                            UpDown();
                        }

                        else
                        {
                            Console.WriteLine("게임이 종료되었습니다.");
                        }
                    }

                }
            }

            // SlidePuzzle
            /*
            SlidePuzzle.GetInstance().Init();
            SlidePuzzle.GetInstance().PrintBoard();
            SlidePuzzle.GetInstance().Run();
            */

        }

    }
}