using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Book_Fair
{
    public partial class getID : Form
    {
        public getID()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random R = new Random();
            long NID;
            bool isValid;
            string SNID;
            while (true)
            {

                NID = LongRandom(28001010100000, 31212318800000, new Random());
                SNID = NID.ToString();
                isValid = Is_Valid_National_ID(SNID);
                if (isValid == true)
                {
                    textBox1.Text = SNID;
                    break;
                }
            }
            
        }

        long LongRandom(long min, long max, Random rand)
        {
            byte[] buf = new byte[8];
            rand.NextBytes(buf);
            long longRand = BitConverter.ToInt64(buf, 0);

            return (Math.Abs(longRand % (max - min)) + min);
        }

        private bool Is_Valid_National_ID(string NID)
        {
            int[] NID_array = new int[14];

            int i = 0;
            foreach (Char c in NID)
            {
                NID_array[i] = Convert.ToInt32(c.ToString());
                i++;
            }

            int year, month, day, codeG, NofBith;

            year = NID_array[1] * 10 + NID_array[2];

            month = NID_array[3] * 10 + NID_array[4];

            day = NID_array[5] * 10 + NID_array[6];

            codeG = NID_array[7] * 10 + NID_array[8];

            NofBith = NID_array[9] * 1000 + NID_array[10] * 100 + NID_array[11] * 10 + NID_array[12];

            if (NID_array[0] == 2)
            {
                if (year > 79 && year < 100)
                {
                    if (month > 0 && month < 13)
                    {
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            if (day <= 0 || day >= 31)
                                return false;
                        }
                        else if (month == 2)
                        {
                            if (day <= 0 || day >= 30)
                                return false;
                        }
                        else if (day > 0 && day < 32)
                        {
                            if (codeG == 01 || codeG == 02 || codeG == 03 || codeG == 04 || codeG == 11 || codeG == 12 || codeG == 13 ||
                                codeG == 14 || codeG == 15 || codeG == 16 || codeG == 17 || codeG == 18 || codeG == 19 || codeG == 21 ||
                                codeG == 22 || codeG == 23 || codeG == 24 || codeG == 25 || codeG == 26 || codeG == 27 || codeG == 28 ||
                                codeG == 29 || codeG == 31 || codeG == 32 || codeG == 33 || codeG == 34 || codeG == 35 || codeG == 88)
                                        return true;
                            else
                                return false;
                        }
                    }
                }
            }
            else if (NID_array[0] == 3)
            {
                if (year > -1 && year < 13)
                {
                    if (month > 0 && month < 13)
                    {
                        if (month == 4 || month == 6 || month == 9 || month == 11)
                        {
                            if (day <= 0 || day >= 31)
                                return false;
                        }
                        else if (month == 2)
                        {
                            if (day <= 0 || day >= 30)
                                return false;
                        }
                        else if (day > 0 && day < 32)
                        {
                            if (codeG == 01 || codeG == 02 || codeG == 03 || codeG == 04 || codeG == 11 || codeG == 12 || codeG == 13 ||
                                codeG == 14 || codeG == 15 || codeG == 16 || codeG == 17 || codeG == 18 || codeG == 19 || codeG == 21 ||
                                codeG == 22 || codeG == 23 || codeG == 24 || codeG == 25 || codeG == 26 || codeG == 27 || codeG == 28 ||
                                codeG == 29 || codeG == 31 || codeG == 32 || codeG == 33 || codeG == 34 || codeG == 35 || codeG == 88)
                                        return true;
                            else
                                return false;
                        }
                    }

                }
            }
            return false;
        }
    
}
}
