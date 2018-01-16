/************************************************************

   CSCI 680-00V3   Assignment 5       Fall 2017                                             
                                                          
   Programmers: RAHUL MARUPAKA(Z1802041)
                GAYATRI THOTA(Z1807846)
                SNEHAVI ATLURI(Z1803731)



   Date Due:   12/06/2017       
   
   Description about the Application: 
   This is a Memory testing game and we called it as Memory Master.
   In this game, the player is required to match similar elements.
   For example, this game has 16 square blocks and it is composed of 8 pairs of symbols, 
   face down in random order. The player has to click over two square blocks at a time, 
   with the goal of turning over a matching pair, by using their memory.

   The player can exit the game in between the game by clicking on the "X" mark 
   on the Topmost Right corner of the form or it will show the completion message after you
   successfully finish the game and exits the application.


 ***********************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assgn5
{
    public partial class Form1 : Form
    {

        Random random = new Random(); //Random Constructor 

        List<string> icons = new List<string>()  //Used for assigning symbols to squares
        {
            "e", "e", "Y", "Y", "T", "T", "j", "j",
            "G", "G", "m", "m", "Z", "Z", "C", "C"
        };

        Label firstClicked, secondClicked; 


        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares(); //This function assigns the symbols to each square block randomly
        }

        private void label_Click(object sender, EventArgs e) //This is a function to the click events of the application
        {
            //The following are different conditions if two seclections of symbols are not a match
            if (firstClicked != null && secondClicked != null)
                return;

            Label clickedLabel = sender as Label; //as keyword will convert the symbol into label, if that is not done, clickedLabel is left NULL

            if (clickedLabel == null)
                return;

            if (clickedLabel.ForeColor == Color.Black)
                return;
            
            if(firstClicked == null)
            {
                firstClicked = clickedLabel;
                firstClicked.ForeColor = Color.Black;
                return;
            }

            
            secondClicked = clickedLabel;
            secondClicked.ForeColor = Color.Black;

            //It checks the CheckForWinner function if it is a match
            CheckForWinner();

            //If it a match they are left revealed for the player to find the other matches
            if(firstClicked.Text == secondClicked.Text)
            {
                firstClicked = null;
                secondClicked = null;
            }
            else
            timer1.Start(); // This is given as 750msec and this is the reveal time if it is not a match

        }

        private void CheckForWinner() //This function checks if all the matches are true, ensuring the victory of player and end of the game 
        {
            Label label;
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++) //this is the count for the square blocks for tableLablePanel
            {
                label = tableLayoutPanel1.Controls[i] as Label;

                if (label != null && label.ForeColor == label.BackColor)
                    return;
            }

            MessageBox.Show("Congratulations Champ!!! Your Memory is Amazing!"); //This is poped up if the payer finishes all the matches
            Close();
                        
        }



        private void timer1_Tick(object sender, EventArgs e) //This the function for the timer
        {
            timer1.Stop(); //timer stops at this point

            firstClicked.ForeColor = firstClicked.BackColor; //It resets the square blocks selected
            secondClicked.ForeColor = secondClicked.BackColor; //It resets the square blocks selected 

            firstClicked = null;
            secondClicked = null;


        }

        private void Exitbutton_Click(object sender, EventArgs e) // to exit the form app
        {
            Application.Exit();
        }

        private void AssignIconsToSquares() //This function assigns symbols to the square blocks of the table layout panel randomly
        {
            Label label;
            int randomNumber;

            for(int i=0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                if (tableLayoutPanel1.Controls[i] is Label)
                    label = (Label)tableLayoutPanel1.Controls[i];
                else
                    continue;

                randomNumber = random.Next(0, icons.Count);
                label.Text = icons[randomNumber];


                icons.RemoveAt(randomNumber);
            }


        }



    }
}
