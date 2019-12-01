﻿using System;

namespace Advent_of_Code_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Day1();
        }
        #region Day One
        private static int[] DayOneInput { set; get; } = new int[] { 108356, 111312, 137196, 128616, 117950, 110687, 149855, 106679, 108283, 109674, 130693, 115970, 139102, 92402, 51187, 109371, 70666, 54387, 128163, 94570, 74413, 117655, 134559, 145383, 129820, 83945, 86672, 56044, 52237, 117451, 51745, 144767, 109782, 128636, 70508, 140779, 113920, 58512, 116036, 57614, 63442, 102753, 56205, 51487, 98089, 132630, 66180, 138042, 71889, 57474, 58566, 133510, 90960, 74920, 91702, 51396, 112592, 91050, 55641, 116282, 65960, 84625, 65758, 109305, 107023, 86523, 55909, 81584, 145804, 147259, 117323, 122480, 101046, 148804, 81935, 148541, 120652, 60031, 75792, 149544, 114685, 142754, 141287, 142735, 147108, 143915, 137950, 111655, 121805, 91835, 117756, 147393, 134534, 85136, 139815, 137344, 84791, 82886, 143721, 118304 };
        private static void Day1()
        {
            Console.WriteLine("Running Day One");
            int result = 0;
            for (int i = 0; i < DayOneInput.Length; i++)
            {
                result += (int)(MathF.Floor(DayOneInput[i] / 3f) - 2f);
            }
            Console.WriteLine("What is the sum of the fuel requirements for all of the modules on your spacecraft?\n" + result);
        }

        #endregion
    }
}
