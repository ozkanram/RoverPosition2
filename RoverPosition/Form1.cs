using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RoverPosition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            StringBuilder result = new StringBuilder();
           string [] inputArray = rtxtInput.Text.Split('\n');
            string [] plateuCoordStr = inputArray[0].Split(' ');
            int plateauX = Convert.ToInt32(plateuCoordStr[0].Trim());
            int plateauY = Convert.ToInt32(plateuCoordStr[1].Trim());
            for(int i =1;i< inputArray.Length-1;i++)
            {
                string[] roverValues = inputArray[i].Split(' ');

                Rover rover = new Rover(plateauX, plateauY, roverValues[2].Trim(), Convert.ToInt32(roverValues[0].Trim()), Convert.ToInt32(roverValues[1].Trim()));
                rover.Process(inputArray[i + 1].Trim());
                result.AppendLine(rover.GetLastStatus());
                i = i + 1;
            }
            rTxtOutPut.Text = result.ToString();

        }



    }
}
