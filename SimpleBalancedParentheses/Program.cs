using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleBalancedParentheses
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            BalancedExpression bal=new BalancedExpression();
            bal.CheckBalanced();
           
        }
    }
}
