using Play;
using System.Collections.Generic;

namespace ClassLibrary2
{
    public class Performance : IPlay
    {
        // 참가자 닉네임
        public string PlayerNickName => "Performance";

        // 흑돌인지 백돌인지 알 수 있는 속성
        // 1 = 흑돌 / 2 = 백돌 입니다.
        public int Player { get; set; }

        // 0: 1순위, 1: 2순위, 2: 나머지
        public List<List<int>> orderList;

        public List<int> resultList;

        // 플레이의 해당 턴이 되면 칸을 선택하는 메서드. (실제 플레이 알고리즘 구현) 자동으로 호출합니다.
        public void Move(out int row, out int col, List<List<int>> reversiBoard)
        {
            if (orderList == null)
            {
                InitOrderList(reversiBoard.Count);
                resultList = new List<int>();
            }

            resultList.Clear();

            for (int r = 0; r < reversiBoard.Count; r++)
            {
                for (int c = 0; c < reversiBoard[r].Count; c++)
                {
                    if (reversiBoard[r][c] > (int)STATUS.NONE)
                        continue;

                    Scan(r, c, 0, -1, reversiBoard); // ←
                    Scan(r, c, -1, -1, reversiBoard); // ↖
                    Scan(r, c, -1, 0, reversiBoard); // ↑
                    Scan(r, c, -1, 1, reversiBoard); // ↗
                    Scan(r, c, 0, 1, reversiBoard); // →
                    Scan(r, c, 1, 1, reversiBoard); // ↘
                    Scan(r, c, 1, 0, reversiBoard); // ↓
                    Scan(r, c, 1, -1, reversiBoard); // ↙
                }
            }

            int value;

            value = col = row = -1;

            foreach (int item in resultList)
            {
                if (orderList[0].Contains(item))
                {
                    value = item;
                    break;
                }
                else if (orderList[1].Contains(item))
                    value = item;
            }

            if (value == -1 && resultList.Count > 0)
                value = resultList[0];

            if (value > -1)
            {
                col = value / reversiBoard.Count;
                row = value - (reversiBoard.Count * col);
            }
        }

        private void InitOrderList(int size)
        {
            orderList = new List<List<int>>()
            {
                new List<int>(),
                new List<int>(),
                new List<int>()
            };

            // 1순위
            orderList[0].Add(0);
            orderList[0].Add(size - 1);
            orderList[0].Add(size * size - size);
            orderList[0].Add(size * size - 1);

            // 2순위 시작점
            int[] s = new int[4];
            s[0] = 0;
            s[1] = size / 2 + 1;
            s[2] = size * s[1];
            s[3] = s[2] + s[1];

            int loopSize = size / 4;

            // 2순위
            for (int m = 0; m < 4; m++)
            {
                for (int k = 0; k < loopSize; k++)
                {
                    int temp = s[m] + (size * k) * 2;
                    for (int i = 0; i < loopSize; i++)
                    {
                        orderList[1].Add(temp);
                        temp += 2;
                    }
                }
            }
        }

        private void Scan(int r, int c, int addRow, int addCol, List<List<int>> reversiBoard)
        {
            bool door = false;
            int _r = r;
            int _c = c;

            while (true)
            {
                _r += addRow;
                _c += addCol;

                if (_r < 0 || _c < 0 || _r >= reversiBoard.Count || _c >= reversiBoard[_r].Count)
                    break;

                if (reversiBoard[_r][_c] == (int)STATUS.NONE)
                    break;

                if (door == false)
                {
                    if (reversiBoard[_r][_c] != Player)
                        door = true;
                    else
                        break;
                }

                if (door == true && reversiBoard[_r][_c] == Player)
                {
                    resultList.Add(reversiBoard.Count * r + c);
                    break;
                }
            }
        }
    }

    enum STATUS
    {
        NONE = 0,
        BLACK = 1,
        WHITE = 2
    }
}
