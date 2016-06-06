using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class Models
    {
        public class denominations
        {
            public Boolean b100 { get; set; }
            public Boolean b50  { get; set; }
            public Boolean b20  { get; set; }
            public Boolean b10  { get; set; }
            public Boolean b5   { get; set; }
            public Boolean b1   { get; set; }
            public Boolean bC25 { get; set; }
            public Boolean bC10 { get; set; }
            public Boolean bC5  { get; set; }
            public Boolean bC1  { get; set; }
        }

        public class denomOuts : List<denomOut>
        {
            public denomOuts() { }
            public denomOuts(List<denomOut> denomOuts) : base(denomOuts) { }
        }
        public class denomOut
        {
            public string outChange { get; set; }
        }

        public class fileInputs : List<fileInput>
        {
            public fileInputs() { }
            public fileInputs(List<fileInput> fileInputs) : base(fileInputs) { }
        }
        public class fileInput
        {
            public decimal amountOwed { get; set; }
            public decimal amountPaid { get; set; }
        }

    }
}
