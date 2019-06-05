// Course: CS 4242
// Student name: Alex Henson
// Student ID: 000244901
// Assignment #1
// Due Date: June 14, 2019
// Signature: Alex Henson
// Score: 

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// all pictureboxes have been made protected

namespace SimpleReflexVacuumAgent
{

    public partial class AI : Form
    {
        bool checkLeft = false;
        bool checkRight = false; // both are set to false because the ai does not know whether they are clean or not, this simply means they are unchecked
        string choice;
        PictureBox location;

        public AI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            choice = (string)checkedListBox1.SelectedItem;
            switch (choice)
            {
                case "Environment 1":
                    Environment1Async();
                    PerceptAsync(location);
                    break;

                case "Environment 2":
                    Environment2Async();
                    PerceptAsync(location);
                    break;

                case "Environment 3":
                    Environment3Async();
                    PerceptAsync(location);
                    break;

                case "Environment 4":
                    Environment4Async();
                    PerceptAsync(location);
                    break;

                case "Environment 5":
                    Environment5Async();
                    PerceptAsync(location);
                    break;

                case "Environment 6":
                    Environment6Async();
                    PerceptAsync(location);
                    break;

                default:
                    break;
            }
        }

        // there is a clever use of our location variable being simultaneously used to determine whether dirt is in the same room
        // if the location of our vacuum is in the location of dirt, then we'll know we can call Suck()
        public async Task PerceptAsync(PictureBox dirt)
        {
            textBox1.AppendText("Percept \n");
            await Task.Delay(1000);

            // The line of code below would make the agent omniscient, since he always knows whether or not there is dirt somewhere.
            //if(right.Visible == true || left.Visible == true)

            if (checkLeft == false || checkRight == false) // the agent makes sure he's checked both rooms
            {
                if (dirt.Visible == true) // if there is dirt in the same room as the vacuum, we call Suck()
                {
                    await SuckAsync(dirt);
                }
                else // if there is no dirt in this room but we know dirt exists somewhere, let's move to the room we aren't in
                {
                    await MoveAsync(dirt);
                }
            }

            else // our agent has learned that both rooms have been checked and cleaned, he will pause for 10 seconds and then check the rooms again
            {
                textBox1.AppendText("Rooms are cleaned");
            }
        }

        public async Task MoveAsync(PictureBox location)
        {
            if ((string)location.Name == "left")
            {
                checkLeft = true;
            }
            else if ((string)location.Name == "right")
            {
                checkRight = true;
            }

            if (checkLeft == true && checkRight == true)
            {
                textBox1.AppendText("Rooms are cleaned");
                return;
            }

            if (location == right)
            {
                //checkRight = true;
                textBox1.AppendText("Moving left \n");
                await Task.Delay(1000);
                vacuumRight.Visible = false;
                vacuumLeft.Visible = true;
                location = left;
            }
            else if(location == left)
            {
                //checkLeft = true;
                textBox1.AppendText("Moving right \n");
                await Task.Delay(1000);
                vacuumRight.Visible = true;
                vacuumLeft.Visible = false;
                location = right;
            }

           await PerceptAsync(location);
        }

        
        public async Task SuckAsync(PictureBox side)
        {
            textBox1.AppendText("Cleaning " + (string)side.Name + "\n");
            await Task.Delay(1000);

            side.Visible = false;

            if ((string)side.Name == "left")
            {
                checkLeft = true;
            }
            else if ((string)side.Name == "right")
            {
                checkRight = true;
            }

            await PerceptAsync(side);
            //return side;
        }
        
        // vacuum on right side, dirt on both right and left sides
        private async Task Environment1Async() 
        {
            right.Visible = true;
            left.Visible = true;
            vacuumRight.Visible = true;
            location = right;
        }

        // vacuum on left side, dirt on both right and left sides
        private async Task Environment2Async()
        {
            right.Visible = true;
            left.Visible = true;
            vacuumLeft.Visible = true;
            location = left;
        }

        // vacuum on right side, dirt on right side
        private async Task Environment3Async()
        {
            right.Visible = true;
            left.Visible = false;
            vacuumRight.Visible = true;
            location = right;
        }

        // vacuum on right side, dirt on left side
        private async Task Environment4Async()
        {
            right.Visible = false;
            left.Visible = true;
            vacuumRight.Visible = true;
            location = right;
        }

        // vacuum on left side, dirt on left side
        private async Task Environment5Async()
        {
            right.Visible = false;
            left.Visible = true;
            vacuumLeft.Visible = true;
            location = left;
        }

        // vacuum on left side, dirt on right side
        private async Task Environment6Async()
        {
            right.Visible = true;
            left.Visible = false;
            vacuumLeft.Visible = true;
            location = left;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            vacuumLeft.Visible = false;
            vacuumRight.Visible = false;
            left.Visible = false;
            right.Visible = false;
            checkLeft = false;
            checkRight = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
