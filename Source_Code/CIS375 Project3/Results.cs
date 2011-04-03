using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CIS375_Project3
{
    public partial class Results : Form
    {
        /* Global Variables */

        string[][] preResults;
        int actualFileSize = 0;
        int testFileSize = 0;
        int caseFileSize = 0;

        public Results(string[][] predictedResults, double stdDev, double meanSqrd,
                       int CFsize, int TFsize, int AFsize)
        {  
            InitializeComponent();                  //Set variables
            preResults = predictedResults;
            MeanSqrdTxt.Text = meanSqrd.ToString();
            StdDevTxt.Text = stdDev.ToString();
            actualFileSize = AFsize;
            testFileSize = TFsize;
            caseFileSize = CFsize;
        }
        public Results()
        {
            InitializeComponent();
        }

        private void Results_Load(object sender, EventArgs e)  //Load Result info passed from Main
        {
            for (int x = 0; x < preResults.Count(); x++)
            {
                listBox.Items.Add(preResults[x][1] + " \t " + preResults[x][0]);
            }
        }
    }
}
