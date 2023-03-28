using MessagePack;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace BAP.Types
{
    [MessagePackObject]
    public class ButtonImage
    {
        [Key(0)]
        public ulong[] ImageData { get; set; } = new ulong[64];
        public ButtonImage(ulong[] imageData)
        {
            ImageData = imageData;
        }
        public ButtonImage()
        {
            ImageData = new ulong[64]; ;
        }
        public ButtonImage(ulong[,] imageDataMatrix)
        {
            List<ulong> data = new List<ulong>();
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    data.Add(imageDataMatrix[r, c]);
                }
            }
            ImageData = data.ToArray();
        }

        public ButtonImage(List<Byte> bytes, BapColor bapColor)
        {
            //This is not the most effecient. But it is the simpliest way I could think of to reverse each row. 
            ulong[,] imageDataMatrix = new ulong[8, 8];
            BitArray bitArray = new BitArray(bytes.ToArray());
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    imageDataMatrix[i, j] = bitArray[i * 8 + 7 - j] ? bapColor.LongColor : 0;
                }
            }
            List<ulong> data = new List<ulong>();
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    data.Add(imageDataMatrix[r, c]);
                }
            }
            ImageData = data.ToArray();
        }
    }

    public static class ButtonImageExtensions
    {
        public static ulong[,] GetImageMatrix(this ButtonImage buttonImage)
        {
            ulong[,] matrix = new ulong[8, 8];
            int currentLocation = 0;
            for (int r = 0; r < 8; r++)
            {
                for (int c = 0; c < 8; c++)
                {
                    matrix[r, c] = buttonImage.ImageData[currentLocation];
                    currentLocation++;
                }
            }
            return matrix;
        }

        //easy way to set a pattern
    }
}
