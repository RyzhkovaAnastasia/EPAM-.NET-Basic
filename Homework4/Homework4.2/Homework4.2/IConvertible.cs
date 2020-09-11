using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4._2
{
    public interface IConvertible
    {
        string ConvertToCSharp(string code);
        string ConvertToVB(string code);
    }
}
