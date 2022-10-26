using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSubmissionAssignment
{
    class IntegerOperator
    {
        public int Obj(int data, int optionalint = 10)//method taking in 2 parameters, one being optional
        {
            int result = optionalint + data;//defines integer varaible 'result' to equal parameter one plus parameter two
            return result;//returns result
        }
    }
}
