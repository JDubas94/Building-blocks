using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building_blocks
{
    class Block
    {
        public int Width;
        public int Length;
        public int Height;

        public Block(int[] blockArray)
        {
            Width = blockArray[0];
            Length = blockArray[1];
            Height = blockArray[2];
        }
        public int GetWidth()
        {
            return Width;
        }
        public int GetLenght()
        {
            return Length;
        }
        public int GetHeight()
        {
            return Height;
        }
        public int GetVolume() 
        {
            int volume = Width * Length * Height;
            return volume;
        }
        public int GetSurfaceArea()
        {
            int suffaArae = 2 * (Height * Width + Width * Length + Height * Length);
            return suffaArae;
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Block block = new Block(new int[] { 2, 4, 6 });

            block.GetWidth();
            block.GetLenght();
            block.GetHeight();
           Console.WriteLine(block.GetVolume());
           Console.WriteLine(block.GetSurfaceArea());

            Console.ReadLine();
        }
    }
}
