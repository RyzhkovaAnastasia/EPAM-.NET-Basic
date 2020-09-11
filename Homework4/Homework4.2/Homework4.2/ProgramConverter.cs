using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    public class ProgramConverter : IConvertible
    {
        public virtual string ConvertToCSharp(string code)
        {
            return "ProgramConverter.ConvertToCSharp";
        }

        public virtual string ConvertToVB(string code)
        {
            return "ProgramConverter.ConvertToVB";
        }
    }
}
