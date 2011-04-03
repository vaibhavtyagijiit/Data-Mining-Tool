using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/* Other Included Libraries */
using System.IO;      //Added for file read/write

namespace CIS375_Project3
{
    public partial class Main : Form
    {
        #region /* Global Variables */

        public int caseFileSize = 0;
        public int testFileSize = 0;
        public int actualFileSize = 0;

        #endregion

        #region /* Form Main Functions */

        public Main()
        {
            InitializeComponent();
        }
        private void Main_Load(object sender, EventArgs e)
        {
        }

        #endregion

        #region /* Buttons */

        private void CaseLibBrowBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                CaseFileTxt.Text = openFileDialog.FileName.ToString();
            }
        }

        private void TestCaseBrowBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                TestCaseFileTxt.Text = openFileDialog.FileName.ToString();
            }
        }

        private void ActualFaultBrowBtn_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ActualFaultFileTxt.Text = openFileDialog.FileName.ToString();
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            CaseFileTxt.Text = "";
            TestCaseFileTxt.Text = "";
            ActualFaultFileTxt.Text = "";
            NumModTxt.Text = "";
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            string[] modResults = new string[10];
            double stdDev = 0.00;
            double meanSqrd = 0.00;
            
            //If Any feild is blank, quit function
            if ((CaseFileTxt.Text == "") || (TestCaseFileTxt.Text == "") || NumModTxt.Text == "")
            {
                return;
            }
            if (IncludeActualFaultCb.Checked && ActualFaultFileTxt.Text == "") //If Actual is included and blank, quit function
            {
                return;
            }
            if (Convert.ToInt32(NumModTxt.Text) <= 0)   //If nearest neighbor is 0 or less, no computation to be done. quit function
            {
                MessageBox.Show("Number of Modules to Compare must be > 0");
                return;
            }

            //Validate all files
            if (validateFile(CaseFileTxt.Text, ref caseFileSize))
            {
                if(validateFile(TestCaseFileTxt.Text, ref testFileSize))
                {
                    if (IncludeActualFaultCb.Checked)
                    {
                        if (validateFile(ActualFaultFileTxt.Text, ref actualFileSize))
                        {
                            string[][] tempResults = PredictFaults(TestCaseFileTxt.Text, CaseFileTxt.Text);
                            //Calculate Stats
                            CalcStats(tempResults, ref meanSqrd, ref stdDev);
                            //Display results & Stats
                            Results resForm = new Results(tempResults,
                                                          stdDev, 
                                                          meanSqrd,
                                                          caseFileSize,
                                                          testFileSize,
                                                          actualFileSize);
                            resForm.ShowDialog();
                        }
                        else
                        {
                           //display results NO Stats
                            Results resForm = new Results(PredictFaults(TestCaseFileTxt.Text, CaseFileTxt.Text),
                                                          stdDev,
                                                          meanSqrd,
                                                          caseFileSize,
                                                          testFileSize,
                                                          actualFileSize);
                            resForm.ShowDialog();
                        }
                    }
                    else
                    {
                        //Display results NO STATS
                        Results resForm = new Results(PredictFaults(TestCaseFileTxt.Text, CaseFileTxt.Text),
                                                      stdDev,
                                                      meanSqrd,
                                                      caseFileSize,
                                                      testFileSize,
                                                      actualFileSize);
                        resForm.ShowDialog();
                    }
                }

            }
        }
        
        #endregion

        #region /* Checkbox */

        private void IncludeActualFaultCb_CheckedChanged(object sender, EventArgs e)
        {
            if (IncludeActualFaultCb.Checked)   //If checked enable actual fault file
            {
                ActualFaultFileTxt.Enabled = true;
                ActualFaultBrowBtn.Enabled = true;
                ActualFaltGb.Enabled = true;
            }
            else
            {
                ActualFaultFileTxt.Enabled = false;
                ActualFaultBrowBtn.Enabled = false;
                ActualFaltGb.Enabled = false;
            }
        }

        #endregion

        #region /* Menu Bar */

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();  //exit program
        }

        #endregion

        #region /* Main Functions */

            #region /* Validate File */

        private bool validateFile(string fileName, ref int fileSize)
        {/*  Pre:  Passed proper fileName to validate in standard string format
          * Post:  Returns True if file exists and is in valid format,
          *        Returns False if file does not exist or is in invalid format.
          *        
          *        Valid format is when number of columns = the number of columns
          *        in every row of the file.
          */
            if (File.Exists(@fileName))  //If the file exists
            {
                FileStream file = new FileStream(@fileName, FileMode.Open);
                StreamReader sr = new StreamReader(file);
                try
                {
                    string str = sr.ReadLine();              //Read first line
                    string[] columns = str.Split(',');       //Parse Line
                    int colCount = columns.Length;           //Set number of columns template
                    int lineCount = 1;                       //Count lines for error reporting
                    while ((str = sr.ReadLine()) != null)    //not end of file
                    {                                        
                        lineCount++;
                        Array.Clear(columns, 0, columns.Length);
                        columns = str.Split(',');
                        if (columns.Length != colCount)      //If number of columns in row do not match number of column template
                        {
                            MessageBox.Show("Error File: " + fileName + "\n" + "Error in text: Line " + lineCount.ToString(), "File Validation Error");
                            return false;
                        }
                    }
                    fileSize = lineCount;
                }
                catch    //Catch any errors
                {
                    MessageBox.Show("Error opening or reading file.");
                    return false;
                }
                finally  //Close open System.IO objects
                {
                    sr.Close();
                    sr.Dispose();
                    file.Close();
                    file.Dispose();
                }
            }
            else
            {
                MessageBox.Show("File: " + @fileName + " does not exist.");
                return false;
            }
            return true;  //Return valid file
        }

            #endregion

            #region /* Calculate Statistics */

        private void CalcStats(string[][] results, ref double meanSqrd, ref double stdDev)
        {
            FileStream actualFile = new FileStream(@ActualFaultFileTxt.Text, FileMode.Open);
            StreamReader actualSR = new StreamReader(actualFile);
            double sumMS = 0.00;
            double sumSD = 0.00;
            string actualLine = actualSR.ReadLine();
            double actualFaults = 0.00;
            double estimatedFaults = 0.00;
            double meanPreFaults = 0.00;


            for (int y = 0; y < results.Count(); y++)  //Sum faults
            {
                meanPreFaults += Convert.ToDouble(results[y][1]);
            }
            meanPreFaults = meanPreFaults / results.Count();  //mean of predicted faults

            try
            {
                for (int x = 0; x < results.Count(); x++)   //mean squared error
                {
                    actualFaults = (Convert.ToDouble(actualSR.ReadLine().Trim()));
                    estimatedFaults = (Convert.ToDouble(results[x][1]));
                    sumMS += Math.Pow((actualFaults) - estimatedFaults, 2);   //Sum of Mean squared error
                    sumSD += Math.Pow((actualFaults - meanPreFaults), 2);      //Sum of Standard devation
                }
                meanSqrd = (sumMS) / (results.Count());
                stdDev = Math.Pow(((1.00 / results.Count()) * sumSD), .5);  //Standard devation
            }
            catch
            {
                MessageBox.Show("Error opening file, it may already be in use");
                return;
            }
            finally
            {
                actualFile.Close();
                actualFile.Dispose();
                actualSR.Close();
                actualSR.Dispose();
            }

        }

            #endregion

            #region /* Predict Faults */

        private string[][] PredictFaults(string testFileName, string caseFileName)
        {
            FileStream testFile = new FileStream(@testFileName, FileMode.Open);
            FileStream caseFile = new FileStream(@caseFileName, FileMode.Open);
            StreamReader testSR = new StreamReader(testFile);
            StreamReader caseSR = new StreamReader(caseFile);
            string testLine = testSR.ReadLine();
            string caseLine = caseSR.ReadLine();
            double dist = 0.00;
            double linePreFaults = 0.00;
            double preNumFaults = 0.00;
            int modCount = 0;
            string[][] results = new string[testFileSize-1][];
            int x = 0;

            try
            {

                while ((testLine = testSR.ReadLine()) != null) //While not end of test case file  ReadLine
                {
                    //MessageBox.Show(testLine);
                    while ((caseLine = caseSR.ReadLine()) != null) //While not end of Case Library file ReadLine
                    {
                        dist = EuclideanDist(testLine, caseLine, ref linePreFaults);
                        //MessageBox.Show("If " + dist.ToString() + " <= " + NumModTxt.Text);
                        if (dist <= Convert.ToDouble(NumModTxt.Text))  //If <= Nearest Neighbor
                        {
                            preNumFaults += linePreFaults;  //Add predicted faults to total
                            modCount++;
                            //mods.Add(dist, caseLine);
                        }
                    }
                    caseSR.BaseStream.Seek(0, SeekOrigin.Begin); //Go back to begining of file
                    caseLine = caseSR.ReadLine(); //Skip header
                    preNumFaults /= modCount;    //Divide by number of modules added
                    results[x] = new string[2] { testLine, preNumFaults.ToString() };
                    x++;
                }
            }
            catch
            {
                MessageBox.Show("Error opening file, it may be in use");
            }
            finally
            {
                testFile.Close();
                testFile.Dispose();
                caseFile.Close();
                caseFile.Dispose();
                testSR.Close();
                testSR.Dispose();
                caseSR.Close();
                caseSR.Dispose();
            }
            return results;
        }

        #endregion

            #region /* Euclidean Distance */

        private double EuclideanDist(string testLine, string caseLine, ref double linePreFaults)
        {
            double dist = 0;
            string[] testX = testLine.Split(',');   //parse test case line
            string[] caseX = caseLine.Split(',');   //parse case library line
            for (int x = 0; x < testX.Count()-1; x++)
            {
                 dist += Math.Pow((Convert.ToDouble(testX[x])) - (Convert.ToDouble(caseX[x])), 2); //Calculate distance
            }
            dist = Math.Sqrt(dist);  
            linePreFaults = Convert.ToDouble(caseX[caseX.Count() - 1]);  //Set predicted fault
            return dist;
        }

            #endregion


        #endregion

    }
}
