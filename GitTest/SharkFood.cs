using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest
{
    internal class SharkFood
        // 열라 강한 상어밥
    {
        private int hp = 100000;
        private int ap = 200000000;

        public void TakeDamage(int damage)
        {
            Console.WriteLine("상돌이가 데미지를 받음");
            Console.WriteLine("상돌이가 울부짖는다");
        }
    }
}
