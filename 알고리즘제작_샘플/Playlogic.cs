namespace Reversi_Playlogic
{
    using Play;
    using System;
    using System.Collections.Generic;

    public class Playlogic : IPlay
    {
        public string PlayerNickName => "밍";

        public int Player { get; set; }

        public void Move(out int row, out int col, List<List<int>> reversiBoard)
        {
            // 랜덤으로 칸을 선택한다.
            Random rnd = new Random();
            col = rnd.Next(0, reversiBoard.Count);
            row = rnd.Next(0, reversiBoard[0].Count);
        }
    }
}
