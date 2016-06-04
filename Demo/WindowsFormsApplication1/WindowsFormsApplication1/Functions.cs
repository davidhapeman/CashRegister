using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public class Functions
    {
        Models.denominations oDenom = new Models.denominations();
        decimal dChgDue = 0; Boolean bDiv3 = false;
        int iChg100 = 0; int iChg50  = 0; int iChg20 = 0; int iChg10 = 0; int iChg5 = 0; int iChg1 = 0;
        int iChgC25 = 0; int iChgC10 = 0; int iChgC5 = 0; int iChgC1 = 0;

        #region "Output Processes"
        public Models.denomOuts RunItAllClass(string sFileName)
        {
            return outputChangeModel(loadData(sFileName));
        }
        public DataTable RunItAllDataTable(string sFileName)
        {
            return outputChangeDataTable(loadData(sFileName));
        }
        #endregion

        // get a dialog for the user to choose the file to obtain and load the path into the desired text box.
        public void getFilename(string sInitialDirectory, TextBox oTextbox)
        {
            //string sInitialDirectory = this.txtFileName.Text.Trim();
            OpenFileDialog fd = new OpenFileDialog();
            string sFileName = "";

            fd.Title = "Open File Dialog";
            fd.InitialDirectory = sInitialDirectory;
            fd.Filter = "All files (*.*)|*.*|All files (*.*)|*.*";
            fd.FilterIndex = 2;
            fd.RestoreDirectory = true;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                sFileName = fd.FileName;
            }

            oTextbox.Text = sFileName;
        }

        #region "Handle the input file"
        // load the information from the desired filename in the textbox into a datatable for processing.
        public Models.fileInputs loadInputFile(string sFileName)
        {
            Models.fileInputs oIns = new Models.fileInputs();
            string[] lines = System.IO.File.ReadAllLines(sFileName);
            foreach (string line in lines)
            {
                string owed = ""; string paid = ""; int iPos = 0;

                iPos = line.IndexOf(",");
                owed = line.Substring(0, iPos);
                paid = line.Substring((iPos + 1), line.Length - (iPos + 1));

                Models.fileInput oIn = new Models.fileInput()
                {
                    amountOwed = Convert.ToDecimal(owed.Trim()),
                    amountPaid = Convert.ToDecimal(paid.Trim())
                };
                oIns.Add(oIn);
            }
            return oIns;
        }

        public DataTable loadData(string sFileName)
        {
            DataTable oDT = new DataTable();
            oDT.Columns.Add("amountOwed"); oDT.Columns.Add("AmountPaid");

            string[] lines = System.IO.File.ReadAllLines(sFileName);
            foreach (string line in lines)
            {
                string owed = ""; string paid = ""; int iPos = 0;

                iPos = line.IndexOf(",");
                owed = line.Substring(0, iPos);
                paid = line.Substring((iPos + 1), line.Length - (iPos + 1));

                DataRow oDR = oDT.NewRow();
                oDR["amountOwed"] = owed.Trim();
                oDR["amountPaid"] = paid.Trim();
                oDT.Rows.Add(oDR);
            }



            return oDT;
        }
        #endregion  

        // used to take the amount owed and paid and determine amount due
        public decimal determineTotalChange(decimal dOwed, decimal dPaid)
        {
            decimal dAmountDue = 0;
            dAmountDue = dPaid - dOwed;
            return dAmountDue;
        }

        // Used to determine if the amount owed is divisible by three and set a flag
        public Boolean determineDiv3(decimal dValue, int iDivisor)
        {
            Boolean bDiv3 = false;
            if ((dValue * 100) % iDivisor == 0) { bDiv3 = true; }
            return bDiv3;
        }

        // Used to determine the number of items needed for the value.  For example, if due is 150 and the value is 100 the number of 100's is 1.
        public int determineNumberItems(int dDue, int dValue)
        {
            int iNum = dDue / dValue; // Note: in C#, the integer returned in a division is always the quotient.
            return iNum;
        }



        private void reset()
        {
            dChgDue = 0; bDiv3   = false;
            iChg100 = 0; iChg50  = 0; iChg20 = 0; iChg10 = 0; iChg5 = 0; iChg1 = 0;
            iChgC25 = 0; iChgC10 = 0; iChgC5 = 0; iChgC1 = 0;
            oDenom.b1 = false; oDenom.b10 = false; oDenom.b100 = false; oDenom.b20 = false; oDenom.b5 = false; oDenom.b50 = false; oDenom.bC1 = false;
            oDenom.bC10 = false; oDenom.bC25 = false; oDenom.bC5 = false;
            
        }

        #region "Random Number Generators"
        // This function will provide the program with an integer that is applicable to the change due to ensure that a part of the change can undergo a breakdown.
        protected int GetRandomInt(int min, int max, int iTotalChg) 
        {
            if (iTotalChg > 4999) { min = 1; }
            else
            {
                if (iTotalChg > 1999) { min = 2; }
                else
                {
                    if (iTotalChg > 999) { min = 3; }
                    else
                    {
                        if (iTotalChg > 499) { min = 4; }
                        else
                        {
                            if (iTotalChg > 99) { min = 5; }
                            else
                            {
                                if (iTotalChg > 24) { min = 6; }
                                else
                                {
                                    if (iTotalChg > 9) { min = 7; }
                                    else
                                    {
                                        if (iTotalChg > 4) { min = 8; }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        protected int GetRandomInt(int max)
        {
            Random rnd = new Random();
            return rnd.Next(1, max);
        }
        #endregion

        // This function will provide the program with an integer that is applicable to the change due to ensure that a part of the change can undergo a breakdown.
        private Boolean FoundItem(int iDen)
        {
            Boolean bFound = false;
            switch(iDen)
            {
                case 0: if (oDenom.b100) { bFound = true; } break;
                case 1: if (oDenom.b50)  { bFound = true; } break;
                case 2: if (oDenom.b20)  { bFound = true; } break;
                case 3: if (oDenom.b10)  { bFound = true; } break;
                case 4: if (oDenom.b5)   { bFound = true; } break;
                case 5: if (oDenom.b1)   { bFound = true; } break;
                case 6: if (oDenom.bC25) { bFound = true; } break;
                case 7: if (oDenom.bC10) { bFound = true; } break;
                case 8: if (oDenom.bC5)  { bFound = true; } break;

                default: break;
            }
            return bFound;
        }

        // This function ReCalc the change based on the fact that the amount owed was divisible by 3
        public void ReCalc(int iDen)
        {
            int iChgDue = 0;
            int ixChg50 = 0; int ixChg20 = 0; int ixChg10 = 0; int ixChg5 = 0; int ixChg1 = 0; int ixChgC25 = 0; int ixChgC10 = 0; int ixChgC5 = 0; int ixChgC1 = 0;

            int iHowMany = 0; // To be a random number for the number of coins available

            switch(iDen)
            {
                case 0: 
                    iHowMany = GetRandomInt(iChg100);
                    iChgDue = 9999 + ((iHowMany - 1) * 10000);
                    iChg100 -= iHowMany; iChgC1 +=1; 
                    ixChg50  = determineNumberItems(iChgDue, 5000); iChgDue -= 5000 * ixChg50;  iChg50  += ixChg50;
                    ixChg20  = determineNumberItems(iChgDue, 2000); iChgDue -= 2000 * ixChg20;  iChg20  += ixChg20;
                    ixChg10  = determineNumberItems(iChgDue, 1000); iChgDue -= 1000 * ixChg10;  iChg10  += ixChg10;
                    ixChg5   = determineNumberItems(iChgDue, 500);  iChgDue -= 500  * ixChg5;   iChg5   += ixChg5;
                    ixChg1   = determineNumberItems(iChgDue, 100);  iChgDue -= 100  * ixChg1;   iChg1   += ixChg1;
                    ixChgC25 = determineNumberItems(iChgDue, 25);   iChgDue -= 25   * ixChgC25; iChgC25 += ixChgC25;
                    ixChgC10 = determineNumberItems(iChgDue, 10);   iChgDue -= 10   * ixChgC10; iChgC10 += ixChgC10;
                    ixChgC5  = determineNumberItems(iChgDue, 5);    iChgDue -= 5    * ixChgC5;  iChgC5  += ixChgC5;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;
                case 1:
                    iHowMany = GetRandomInt(iChg50);
                    iChgDue = 4999 + ((iHowMany - 1) * 5000);
                    iChg50 -= iHowMany; iChgC1 += 1;
                    ixChg20  = determineNumberItems(iChgDue, 2000); iChgDue -= 2000 * ixChg20;  iChg20  += ixChg20;
                    ixChg10  = determineNumberItems(iChgDue, 1000); iChgDue -= 1000 * ixChg10;  iChg10  += ixChg10;
                    ixChg5   = determineNumberItems(iChgDue, 500);  iChgDue -= 500  * ixChg5;   iChg5   += ixChg5;
                    ixChg1   = determineNumberItems(iChgDue, 100);  iChgDue -= 100  * ixChg1;   iChg1   += ixChg1;
                    ixChgC25 = determineNumberItems(iChgDue, 25);   iChgDue -= 25   * ixChgC25; iChgC25 += ixChgC25;
                    ixChgC10 = determineNumberItems(iChgDue, 10);   iChgDue -= 10   * ixChgC10; iChgC10 += ixChgC10;
                    ixChgC5  = determineNumberItems(iChgDue, 5);    iChgDue -= 5    * ixChgC5;  iChgC5  += ixChgC5;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;
                case 2:
                    iHowMany = GetRandomInt(iChg20);
                    iChgDue = 1999 + ((iHowMany - 1) * 2000);
                    iChg20 -= iHowMany; iChgC1 += 1;
                    ixChg10  = determineNumberItems(iChgDue, 1000); iChgDue -= 1000 * ixChg10;  iChg10  += ixChg10;
                    ixChg5   = determineNumberItems(iChgDue, 500);  iChgDue -= 500  * ixChg5;   iChg5   += ixChg5;
                    ixChg1   = determineNumberItems(iChgDue, 100);  iChgDue -= 100  * ixChg1;   iChg1   += ixChg1;
                    ixChgC25 = determineNumberItems(iChgDue, 25);   iChgDue -= 25   * ixChgC25; iChgC25 += ixChgC25;
                    ixChgC10 = determineNumberItems(iChgDue, 10);   iChgDue -= 10   * ixChgC10; iChgC10 += ixChgC10;
                    ixChgC5  = determineNumberItems(iChgDue, 5);    iChgDue -= 5    * ixChgC5;  iChgC5  += ixChgC5;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;
                case 3:
                    iHowMany = GetRandomInt(iChg10);
                    iChgDue = 999 + ((iHowMany - 1) * 1000);
                    iChg10 -= iHowMany; iChgC1 += 1; 
                    ixChg5   = determineNumberItems(iChgDue, 500);  iChgDue -= 500  * ixChg5;   iChg5   += ixChg5;
                    ixChg1   = determineNumberItems(iChgDue, 100);  iChgDue -= 100  * ixChg1;   iChg1   += ixChg1;
                    ixChgC25 = determineNumberItems(iChgDue, 25);   iChgDue -= 25   * ixChgC25; iChgC25 += ixChgC25;
                    ixChgC10 = determineNumberItems(iChgDue, 10);   iChgDue -= 10   * ixChgC10; iChgC10 += ixChgC10;
                    ixChgC5  = determineNumberItems(iChgDue, 5);    iChgDue -= 5    * ixChgC5;  iChgC5  += ixChgC5;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;
                case 4:
                    iHowMany = GetRandomInt(iChg5);
                    iChgDue = 499 + ((iHowMany - 1) * 500);
                    iChg5 -= iHowMany; iChgC1 += 1;
                    ixChg1   = determineNumberItems(iChgDue, 100);  iChgDue -= 100  * ixChg1;   iChg1   += ixChg1;
                    ixChgC25 = determineNumberItems(iChgDue, 25);   iChgDue -= 25   * ixChgC25; iChgC25 += ixChgC25;
                    ixChgC10 = determineNumberItems(iChgDue, 10);   iChgDue -= 10   * ixChgC10; iChgC10 += ixChgC10;
                    ixChgC5  = determineNumberItems(iChgDue, 5);    iChgDue -= 5    * ixChgC5;  iChgC5  += ixChgC5;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;
                case 5:
                    iHowMany = GetRandomInt(iChg1);
                    iChgDue = 99 + ((iHowMany - 1) * 100);
                    iChg1 -= iHowMany; iChgC1 += 1; 
                    ixChgC25 = determineNumberItems(iChgDue, 25);   iChgDue -= 25   * ixChgC25; iChgC25 += ixChgC25;
                    ixChgC10 = determineNumberItems(iChgDue, 10);   iChgDue -= 10   * ixChgC10; iChgC10 += ixChgC10;
                    ixChgC5  = determineNumberItems(iChgDue, 5);    iChgDue -= 5    * ixChgC5;  iChgC5  += ixChgC5;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;
                case 6:
                    iHowMany = GetRandomInt(iChgC25);
                    iChgDue = 24 + ((iHowMany - 1) * 25);
                    iChgC25 -= iHowMany; iChgC1 += 1; 
                    ixChgC10 = determineNumberItems(iChgDue, 10);   iChgDue -= 10   * ixChgC10; iChgC10 += ixChgC10;
                    ixChgC5  = determineNumberItems(iChgDue, 5);    iChgDue -= 5    * ixChgC5;  iChgC5  += ixChgC5;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;
                case 7:
                    iHowMany = GetRandomInt(iChgC10);
                    iChgDue = 9 + ((iHowMany - 1) * 10);
                    iChgC10 -= iHowMany; iChgC1 += 1; 
                    ixChgC5  = determineNumberItems(iChgDue, 5);    iChgDue -= 5    * ixChgC5;  iChgC5  += ixChgC5;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;
                case 8:
                    iHowMany = GetRandomInt(iChgC5);
                    iChgDue = 4 + ((iHowMany - 1) * 5);
                    iChgC5 -= iHowMany; iChgC1 += 1;
                    ixChgC1  = determineNumberItems(iChgDue, 1);    iChgDue -= 1    * ixChgC1;  iChgC1  += ixChgC1;
                    break;

                default: break;
            }

        }

        private string OutputWording()
        {
            string sOutput = "";
            string sComma  = "";

            if (iChg100 > 1) { sOutput += sComma + iChg100 + " Hundreds"; sComma = ", "; } else { if (iChg100 == 1) { sOutput += sComma + iChg100 + " Hundred"; sComma = ", "; } }
            if (iChg50  > 1) { sOutput += sComma + iChg50  + " Fifties";  sComma = ", "; } else { if (iChg50  == 1) { sOutput += sComma + iChg50  + " Fifty";   sComma = ", "; } }
            if (iChg20  > 1) { sOutput += sComma + iChg20  + " Twenties"; sComma = ", "; } else { if (iChg20  == 1) { sOutput += sComma + iChg20  + " Twenty";  sComma = ", "; } }
            if (iChg10  > 1) { sOutput += sComma + iChg10  + " Tens";     sComma = ", "; } else { if (iChg10  == 1) { sOutput += sComma + iChg10  + " Ten";     sComma = ", "; } }
            if (iChg5   > 1) { sOutput += sComma + iChg5   + " Fives";    sComma = ", "; } else { if (iChg5   == 1) { sOutput += sComma + iChg5   + " Five";    sComma = ", "; } }
            if (iChg1   > 1) { sOutput += sComma + iChg1   + " Ones";     sComma = ", "; } else { if (iChg1   == 1) { sOutput += sComma + iChg1   + " One";     sComma = ", "; } }
            if (iChgC25 > 1) { sOutput += sComma + iChgC25 + " Quarters"; sComma = ", "; } else { if (iChgC25 == 1) { sOutput += sComma + iChgC25 + " Quarter"; sComma = ", "; } }
            if (iChgC10 > 1) { sOutput += sComma + iChgC10 + " Dimes";    sComma = ", "; } else { if (iChgC10 == 1) { sOutput += sComma + iChgC10 + " Dime";    sComma = ", "; } }
            if (iChgC5  > 1) { sOutput += sComma + iChgC5  + " Nickels";  sComma = ", "; } else { if (iChgC5  == 1) { sOutput += sComma + iChgC5  + " Nickel";  sComma = ", "; } }
            if (iChgC1  > 1) { sOutput += sComma + iChgC1  + " Pennies";  sComma = ", "; } else { if (iChgC1  == 1) { sOutput += sComma + iChgC1  + " Penny";   sComma = ", "; } }

            return sOutput;
        }

        private DataTable processChange(DataTable oDGFile)
        {
            DataTable oDT = new DataTable();
            oDT.Columns.Add("chgDue"); oDT.Columns.Add("chgDiv3");
            oDT.Columns.Add("chgHundreds"); oDT.Columns.Add("chgFiftys"); oDT.Columns.Add("chgTwentys");
            oDT.Columns.Add("chgTens"); oDT.Columns.Add("chgFives"); oDT.Columns.Add("chgOnes");
            oDT.Columns.Add("chgQuarters"); oDT.Columns.Add("chgNickels"); oDT.Columns.Add("chgDimes"); oDT.Columns.Add("chgPennies");
            oDT.Columns.Add("chgWording");

            for (int i = 0; i < oDGFile.Rows.Count; i++)
            {
                reset();
                decimal dOwed = Convert.ToDecimal(oDGFile.Rows[i][0].ToString());
                decimal dPaid = Convert.ToDecimal(oDGFile.Rows[i][1].ToString());

                dChgDue = determineTotalChange(dOwed, dPaid);
                bDiv3   = determineDiv3(dOwed, 3);

                DataRow oDR = oDT.NewRow();
                oDR["chgDue"]  = dChgDue;
                oDR["chgDiv3"] = bDiv3;

                int iChgDue = 0;
                iChgDue = Convert.ToInt32(dChgDue * 100);
                iChg100 = determineNumberItems(iChgDue, 10000); iChgDue -= 10000 * iChg100;
                iChg50  = determineNumberItems(iChgDue, 5000);  iChgDue -= 5000  * iChg50;
                iChg20  = determineNumberItems(iChgDue, 2000);  iChgDue -= 2000  * iChg20;
                iChg10  = determineNumberItems(iChgDue, 1000);  iChgDue -= 1000  * iChg10;
                iChg5   = determineNumberItems(iChgDue, 500);   iChgDue -= 500   * iChg5;
                iChg1   = determineNumberItems(iChgDue, 100);   iChgDue -= 100   * iChg1;
                iChgC25 = determineNumberItems(iChgDue, 25);    iChgDue -= 25    * iChgC25;
                iChgC10 = determineNumberItems(iChgDue, 10);    iChgDue -= 10    * iChgC10;
                iChgC5  = determineNumberItems(iChgDue, 5);     iChgDue -= 5     * iChgC5;
                iChgC1  = determineNumberItems(iChgDue, 1);     iChgDue -= 1     * iChgC1;

                if (iChg100 > 0) { oDenom.b100 = true; }
                if (iChg50  > 0) { oDenom.b50  = true; }
                if (iChg20  > 0) { oDenom.b20  = true; }
                if (iChg10  > 0) { oDenom.b10  = true; }
                if (iChg5   > 0) { oDenom.b5   = true; }
                if (iChg1   > 0) { oDenom.b1   = true; }
                if (iChgC25 > 0) { oDenom.bC25 = true; }
                if (iChgC10 > 0) { oDenom.bC10 = true; }
                if (iChgC5  > 0) { oDenom.bC5  = true; }
                if (iChgC1  > 0) { oDenom.bC1  = true; }

                if (bDiv3)
                {
                    int iRandom = GetRandomInt(0, 8, Convert.ToInt32(dChgDue * 100));
                    Boolean bFound = false;
                    do
                    {
                        iRandom = GetRandomInt(0, 8, Convert.ToInt32(dChgDue * 100));
                        bFound = FoundItem(iRandom);
                    } while (!bFound);
                    ReCalc(iRandom);
                }



                oDR["chgHundreds"] = iChg100.ToString(); oDR["chgFiftys"] = iChg50.ToString();  oDR["chgTwentys"] = iChg20.ToString();
                oDR["chgTens"]     = iChg10.ToString();  oDR["chgFives"]  = iChg5.ToString();   oDR["chgOnes"]    = iChg1.ToString();
                oDR["chgQuarters"] = iChgC25.ToString(); oDR["chgDimes"]  = iChgC10.ToString(); oDR["chgNickels"] = iChgC5.ToString(); oDR["chgPennies"] = iChgC1.ToString();
                oDR["chgWording"]  = OutputWording();

                oDT.Rows.Add(oDR);
            }

            return oDT;            
        }

        public Models.denomOuts outputChangeModel(DataTable oDGFile)
        {
            DataTable oDT = new DataTable();
            oDT = processChange(oDGFile);

            Models.denomOuts oOuts = new Models.denomOuts();
            for (int i = 0; i < oDT.Rows.Count; i++)
            {
                Models.denomOut oOut = new Models.denomOut()
                {
                    outChange = oDT.Rows[i]["chgWording"].ToString()
                };
                oOuts.Add(oOut);
            }
            return oOuts;
        }

        // Load the table to display the change based on the file that was brought in.
        public DataTable outputChangeDataTable(DataTable oDGFile)
        {
            return processChange(oDGFile);
        }

    }
}
