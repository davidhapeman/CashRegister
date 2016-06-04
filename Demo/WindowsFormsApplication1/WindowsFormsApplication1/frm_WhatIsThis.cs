using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frm_WhatIsThis : Form
    {
        public frm_WhatIsThis()
        {
            InitializeComponent();
        }

        private void frm_WhatIsThis_Load(object sender, EventArgs e)
        {
            string output = "";
            output += "Task:\n\n";

            output += "Creative Cash Draw Solutions is a client who wants to provide something different for the cashiers who use their system.  The function of the application is to tell the cashier how much change is owed, and what denominations should be used. In most cases the app should return the minimum amount of physical change, but the client would like to add a twist. If the 'owed' amount is divisible by 3, the app should randomly generate the change denominations (but the math still needs to be right :))\n\n";

            output += "Please write a program which accomplishes the clients goals. The program should:\n\n";

            output += "1. Accept a flat file as input\n";
            output += "		i. Each line will contain the amount owed and the amount paid separated by a comma (for example: 2.13,3.00)\n";
            output += "		ii. Expect that there will be multiple lines\n";
            output += "2. Output the change the cashier should return to the customer\n";
            output += "		i. The return string should look like: 1 dollar,2 quarters,1 nickel, etc ...\n";
            output += "		ii. Each new line in the input file should be a new line in the output file\n\n";

            output += "Approach:\n\n";

            output += "Based on the information provided, there is one part of the process that lends to being open to interpretation.  The requirement of “random” when the amount owed is divisible by 3 can be considered in many ways, for example, random in any or all items or with some structure.\n\n";

            output += "I made the assumption that the process will be done random in that two possibilities occur.\n";
            output += "	1.	The first round of random is to determine which denomination of the change will be broken apart.\n";
            output += "	2.	The second round of random is determine “how much” of that denomination will be changed.\n\n";

            output += "I used Windows forms due to the fact that it is easy to build a result display with minimal formatting needed so as to spend more time on the solution without the need to worry about formatting.\n\n";

            output += "An assumption that was made is that the change denominations will not utilize bills greater than a $100 bill.\n\n";

            output += "Step 1:\n";
            output += "	  Get the data file from the user.  The user file is provided in a TextBox.  The UI gives the ability to browse for a file on the Computer.\n\n";

            output += "Step 2:\n";
            output += "	Once the data file has been defined, the user clicks the Load button which does the following:\n";
            output += "		1.	Parse the file based on the requirements and loads into a DataTable.\n";
            output += "		2.	Perform the Calculation of the Change:\n";
            output += "			a.	First, determine the change of the based on the most effective method ignoring \n";
            output += "				if the amount owed is divisible by 3 and load to a datatable and in this datatable, flag\n";
            output += "				the record as divisible by three.\n";
            output += "			b.	During the load, should the record be divisible by 3, perform the random recalculation.\n";
            output += "				i.	During Recalculation do the following:\n";
            output += "					1.	Randomly determine which denomination will be altered.\n";
            output += "					2.	Randomly determine how many of that denomination will be altered.\n";
            output += "					3.	Subtract a penny and place into the penny count.\n";
            output += "					4.	Recalculate the most efficient method based on what is left in the denomination.\n";
            output += "		3.	Creation of two functions that will produce the output with two different methods.\n";
            output += "			a.	Method 1: A DataTable output so that the user can use the UI interface to have to \n";
            output += "						  complete level of information.\n";
            output += "			b.	Method 2: A new class (List) that will provide the specific wording of the requirement.  \n";
            output += "						  From there, the User Interface can do what is needed with the information.\n\n\n";

            this.richTextBox1.Text = output;
        
        }
    }
}
