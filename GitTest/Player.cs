using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    internal class Player
    {
        private int hp;
        private int mp;
        private string name;

        // 플레이어 개발 시작

        public void UseItem(Item item)
        {
            // Item 클래스를 가져와 Player 클래스에서 사용
            Console.WriteLine($"{name}이 아이템 사용.");
        }
    }
}
