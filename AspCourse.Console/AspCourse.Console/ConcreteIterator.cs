using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspCourse.Console
{
    public class ConcreteIterator : Iterator
    {

        private readonly object[] _objects;
        private int current;

        public ConcreteIterator(object[] objects)
        {
            this._objects = objects;    
        }

        public override object Current() => _objects[current];

        public override bool IsDone() => current >= _objects.Count();

        public override object MoveNext() => ++current < _objects.Count() ? _objects[current] : null;

    }
}
