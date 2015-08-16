using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit64Array
{
    interface IIndexable<T>
    {
        T this[int index] { get; set; }
    }
}
