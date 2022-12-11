﻿using System.Drawing;

namespace Tetris
{
    class S : Figure
    {
        public S()
        {
            position[0, 0] = 4;
            position[0, 1] = 0;

            position[1, 0] = 5;
            position[1, 1] = 0;

            position[2, 0] = 3;
            position[2, 1] = 1;

            position[3, 0] = 4;
            position[3, 1] = 1;
            figure_color = Color.Green;
        }
    }
}
