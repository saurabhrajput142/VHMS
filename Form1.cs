using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace TICTACK
{
    public partial class Form1 : Form
    {
        //making array and   
        //by default I am providing 0-9 where no use of zero  
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1; //By default player 1 is set  
        static int choice; //This holds the choice at which position user want to mark   

        // The flag veriable checks who has won if it's value is 1 then some one has won the match if -1 then Match has Draw if 0 then match is still running  
        static int flag = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int btnvalue = 1;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn1.Text = msg;
                
            }
           
        }

        private static string Calc(int btnvalue)
        {
           
                //Console.Clear();// whenever loop will be again start then screen will be clear  
                //Console.WriteLine("Player1:X and Player2:O");
                //Console.WriteLine("\n");
                string msg = "";
                //if (player % 2 == 0)//checking the chance of the player  
                //{
                //    Console.WriteLine("Player 2 Chance");
                //}
                //else
                //{
                //    Console.WriteLine("Player 1 Chance");
                //}
                //Console.WriteLine("\n");

                choice = btnvalue;//Taking users choice   

                // checking that position where user want to run is marked (with X or O) or not  
                if (arr[choice] != 'X' && arr[choice] != 'O')
                {
                    if (player % 2 == 0) //if chance is of player 2 then mark O else mark X  
                    {
                        arr[choice] = 'O';
                        msg = "O";
                        player++;
                    }
                    else
                    {
                        arr[choice] = 'X';
                        msg = "X";
                        player++;
                    }
                }
                else //If there is any possition where user want to run and that is already marked then show message and load board again  
                {
                    MessageBox.Show(string.Format("Sorry the row {0} is already marked with {1}", choice, arr[choice]));
                    //Console.WriteLine("\n");
                    //Console.WriteLine("Please wait 2 second board is loading again.....");
                    Thread.Sleep(2000);
                }
                flag = CheckWin();// calling of check win  
                      
            if (flag == 1)// if flag value is 1 then some one has win or means who played marked last time which has win  
            {
                DisableControls(Form1.ActiveForm);
                //EnableControls(btnreset_Click);
                
                 MessageBox.Show(string.Format("Player {0} has won", (player % 2) + 1));
            }
            else if(flag == -1)// if flag value is -1 the match will be draw and no one is winner  
            {
                 MessageBox.Show("Draw");
            }
            Console.ReadLine();
            return msg;
        }
        private static void DisableControls(Control con)
        {
            foreach (Control c in con.Controls)
            {
                DisableControls(c);
            }
            con.Enabled = false;
        }
        private static void EnableControls(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                EnableControls(con.Parent);
            }
        }
        //Checking that any player has won or not  
        private static int CheckWin()
        {
            #region Horzontal Winning Condtion
            //Winning Condition For First Row   
            if (arr[1] == arr[2] && arr[2] == arr[3])
            {
                return 1;
            }
            //Winning Condition For Second Row   
            else if (arr[4] == arr[5] && arr[5] == arr[6])
            {
                return 1;
            }
            //Winning Condition For Third Row   
            else if (arr[6] == arr[7] && arr[7] == arr[8])
            {
                return 1;
            }
            #endregion

            #region vertical Winning Condtion
            //Winning Condition For First Column       
            else if (arr[1] == arr[4] && arr[4] == arr[7])
            {
                return 1;
            }
            //Winning Condition For Second Column  
            else if (arr[2] == arr[5] && arr[5] == arr[8])
            {
                return 1;
            }
            //Winning Condition For Third Column  
            else if (arr[3] == arr[6] && arr[6] == arr[9])
            {
                return 1;
            }
            #endregion

            #region Diagonal Winning Condition
            else if (arr[1] == arr[5] && arr[5] == arr[9])
            {
                return 1;
            }
            else if (arr[3] == arr[5] && arr[5] == arr[7])
            {
                return 1;
            }
            #endregion

            #region Checking For Draw
            // If all the cells or values filled with X or O then any player has won the match  
            else if (arr[1] != '1' && arr[2] != '2' && arr[3] != '3' && arr[4] != '4' && arr[5] != '5' && arr[6] != '6' && arr[7] != '7' && arr[8] != '8' && arr[9] != '9')
            {
                return -1;
            }
            #endregion

            else
            {
                return 0;
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int btnvalue = 2;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn2.Text = msg;

            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int btnvalue = 3;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn3.Text = msg;

            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int btnvalue = 4;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn4.Text = msg;

            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int btnvalue = 5;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn5.Text = msg;

            }
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int btnvalue = 6;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn6.Text = msg;

            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int btnvalue = 7;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn7.Text = msg;

            }
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            int btnvalue = 8;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn8.Text = msg;

            }
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            int btnvalue = 9;
            string msg = Calc(btnvalue);
            if (msg != "")
            {
                btn9.Text = msg;

            }

        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            btn1.Text = "";
            btn2.Text = "";
            btn3.Text = "";
            btn4.Text = "";
            btn5.Text = "";
            btn6.Text = "";
            btn7.Text = "";
            btn8.Text = "";
            btn9.Text = "";
             player = 1; //By default player 1 is set  
            flag = 0;
            
        }

       

    }
}
