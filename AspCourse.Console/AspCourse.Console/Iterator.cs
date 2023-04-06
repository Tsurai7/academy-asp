using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCourse.Console
{
    abstract class Iterator
    {
        public abstract object MoveNext();
        public abstract bool IsDone();
        public abstract object Current();
    }
}
