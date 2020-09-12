using System;
using System.Collections.Generic;
using System.Text;

namespace Pug.Effable
{
    public interface IDescribedInfo<T> : IDescribed<T>
    {
        new T Description { get; set; }
    }
}
