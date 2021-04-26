using System;
using System.Collections.Generic;
using System.Text;
using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    class StandardGradeBook: BaseGradeBook 
    {
       public StandardGradeBook(string name,bool isWeighted) : base(name,isWeighted)
        {
            this.type=GradeBookType.Standard;      //?
        }
    }
}
