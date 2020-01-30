using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1Mozard
{
    class Program
    {
        static int[,] WorkFlow1 = new int[16, 11] {
            { 96, 32, 69, 40, 148, 104, 152, 119, 98, 3, 54 }, //1
            { 22, 6, 95, 17, 74, 157, 60, 84, 142, 87, 130 }, //2
            { 141, 128, 158, 113, 163, 27, 171, 114, 42, 165, 10 }, //3
            { 41, 63, 13, 85, 45, 167, 53, 50, 156, 61, 103 }, //4
            { 105, 146, 153, 161, 80, 154, 99, 140, 75, 135, 28 }, //5
            { 122, 46, 55, 2, 97, 68, 133, 86, 129, 47, 37 }, //6
            { 11, 134, 110, 159, 36, 118, 21, 169, 62, 147, 106 }, //7
            { 30, 81, 24, 100, 107, 91, 127, 94, 123, 33, 5 }, //8
            { 70, 117, 66, 90, 25, 138, 16, 120, 65, 102, 35 }, //9
            { 121, 39, 139, 176, 143, 71, 155, 88, 77, 4, 20 }, //10
            { 26, 126, 15, 7, 64, 150, 57, 48, 19, 31, 108 }, //11
            { 9, 56, 132, 34, 125, 29, 175, 166, 82, 164, 92 }, //12
            { 112, 174, 73, 67, 76, 101, 43, 51, 137, 144, 12 }, //13
            { 49, 18, 58, 160, 136, 162, 168, 115, 38, 59, 124 }, //14
            { 109, 116, 145, 52, 1, 23, 89, 72, 149, 173, 44 }, //15
            { 14, 83, 79, 170, 93, 151, 172, 111, 8, 78, 131 }  //16
        };
        static int[,] WorkFlow2 = new int[16, 6] {
            { 72, 56, 75, 40, 83, 18}, //17
            { 6, 82, 39, 73, 3, 45}, //18
            { 59, 42, 54, 16, 28, 62}, //19
            { 25, 74, 1, 68, 53, 38}, //20
            { 81, 14, 65, 29, 37, 4}, //21
            { 41, 7, 43, 55, 17, 27}, //22
            { 89, 26, 15, 2, 44, 52}, //23
            { 13, 71, 80, 61, 70, 94}, //24
            { 36, 76, 9, 22, 63, 11}, //25
            { 5, 20, 34, 67, 85, 92}, //26
            { 46, 64, 93, 49, 32, 24 }, //27
            { 79, 84, 48, 77, 96, 86}, //28
            { 30, 8, 69, 57, 12, 51}, //29
            { 95, 35, 58, 87, 23, 60}, //30
            { 19, 47, 90, 33, 50, 78}, //31
            { 66, 88, 21, 10, 91, 31}, //32
        };

        static string FilePath = @"C:\Users\seba6474\Documents\H1\MozardMusik";
        static string fileType = ".wav";
        static System.Media.SoundPlayer soundPlayer = new System.Media.SoundPlayer();
        public static Random rnd = new Random();
        static void Main(string[] args)
        {
            for (int i = 0; i < WorkFlow1.GetUpperBound(0) + 1; i++)
            {
                int dice = rnd.Next(1, 7);
                int dice2 = rnd.Next(1, 7);

                soundPlayer.SoundLocation = $@"{FilePath}\M\M{WorkFlow1[i, dice + dice2 - 2]}{fileType}";
                soundPlayer.Load();
                Console.WriteLine($"{i + 1}: Playing M{WorkFlow1[i, dice + dice2 - 2]}");
                soundPlayer.PlaySync();
            }
            for (int i = 0; i < WorkFlow2.GetUpperBound(0) + 1; i++)
            {
                int dice = rnd.Next(1, 7);

                soundPlayer.SoundLocation = $@"{FilePath}\T\T{WorkFlow2[i, dice - 1]}{fileType}";
                soundPlayer.Load();
                Console.WriteLine($"{i + 17}: Playing T{WorkFlow2[i, dice - 1]}");
                soundPlayer.PlaySync();
            }

            Console.WriteLine("Done. CLAP SALME");
            Console.ReadKey();
        }
    }
}
