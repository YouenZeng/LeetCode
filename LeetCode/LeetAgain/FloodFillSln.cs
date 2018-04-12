using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.LeetAgain
{
    internal class FloodFillSln : ISolution
    {
        private int _fullFilled;
        private int _imageWidth;
        private int _imageHeight;

        public int[,] FloodFill(int[,] image, int sr, int sc, int newColor)
        {
            _fullFilled = image[sr, sc];
            _imageWidth = image.GetLength(0);
            _imageHeight = image.GetLength(1);
            Handle(image, sr, sc, newColor);
            return image;
        }

        private void Handle(int[,] image, int sr, int sc, int newColor)
        {
            if (sr < 0 || sr >= _imageWidth) return;
            if (sc < 0 || sc >= _imageHeight) return;

            if (image[sr, sc] == newColor) return;
            if (image[sr, sc] != _fullFilled) return;
            image[sr, sc] = newColor;
            Handle(image, sr - 1, sc, newColor);
            Handle(image, sr + 1, sc, newColor);
            Handle(image, sr, sc + 1, newColor);
            Handle(image, sr, sc - 1, newColor);
        }

        public void Execute()
        {
            FloodFill(new int[,]
            {
                {1, 1, 1},
                {1, 1, 0},
            }, 1, 1, 1);
        }
    }
}