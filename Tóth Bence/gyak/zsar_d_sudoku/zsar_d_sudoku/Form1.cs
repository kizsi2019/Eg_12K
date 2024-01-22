using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zsar_d_sudoku
{
    public partial class Form1 : Form
    {
        TextBox[,] allTextbox = new TextBox[9, 9];
        Random r = new Random();
        public Form1()
        {
            InitializeComponent();
            Start();
            placeTextBoxes();
            placeNumber(18);
        }

        void Start()
        {
            BackColor = Color.DarkGreen;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        void placeTextBoxes()
        {
            for(int i = 0; i < 9; i++)
            {
                for(int j = 0; j < 9; j++)
                {
                    allTextbox[i, j] = new TextBox();
                    allTextbox[i, j].Width = 20;
                    Controls.Add(allTextbox[i, j]);
                    allTextbox[i, j].Top = i * 20;
                    allTextbox[i, j].Left = j * 20;
                }
            }
        }

        void placeNumber(int num)
        {
            int placedNumbers = 0;
            while(placedNumbers < num)
            {
                int randomRow = r.Next(9);
                int randomCol = r.Next(9);
                int randomNum = r.Next(1, 10);
                if (check(randomNum, randomRow, randomCol))
                {
                    allTextbox[randomRow, randomCol].Text = randomNum.ToString();
                    allTextbox[randomRow,randomCol].Enabled = false;
                    placedNumbers++;
                }
            }
        }




















































        bool rowCheck(int num, int rowNum)
        {
            for(int i = 0; i < 9; i++)
            {
                if (allTextbox[rowNum, i].Text.Length != 0)
                {
                    if (Convert.ToInt32(allTextbox[rowNum, i].Text) == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        bool colCheck(int num, int colNum)
        {
            for (int i = 0; i < 9; i++)
            {
                if(allTextbox[i, colNum].Text.Length != 0)
                {
                    if (Convert.ToInt32(allTextbox[i, colNum].Text) == num)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        
        bool boxCheck(int num, int rowNum, int colNum)
        {
            int boxRow = (int)Math.Floor(Convert.ToDouble(rowNum) / 3);
            int boxCol = (int)Math.Floor(Convert.ToDouble(colNum) / 3);

            for(int i = boxRow * 3; i < boxRow * 3 + 3; i++)
            {
                for(int j = boxCol * 3; j < boxCol * 3 + 3; j++)
                {
                    if (allTextbox[i,j].Text.Length != 0)
                    {
                        if (Convert.ToInt32(allTextbox[i, j].Text) == num)
                        {
                            return false;
                        }
                    }
                }
            }
            return false;
        }     

        bool check(int num, int rowNum, int colNum)
        {
            if(!rowCheck(num, rowNum))
            {
                return false;
            }

            if(!colCheck(num, colNum))
            {
                return false;
            }
            if(!boxCheck(num, rowNum, colNum))
            {
                return false;
            }
            return true;
        }

    }
}
