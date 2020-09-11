using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    public class ProgramHelper: ProgramConverter, IСodeChecker
    {
        public override string ConvertToCSharp(string code)
        {
            return "ProgramHelper.ConvertToCSharp";
        }

        public override string ConvertToVB(string code)
        {
            return "ProgramHelper.ConvertToVB";
        }

        public bool CheckCodeSyntax(string code, string language)
        {
            return false;
        }
    }
}
