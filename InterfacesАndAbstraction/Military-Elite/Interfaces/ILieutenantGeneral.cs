using System;
using System.Collections.Generic;
using System.Text;

namespace Military_Elite
{
    public interface ILieutenantGeneral:IPrivate
    {
        public ICollection<Private> Privates { get; }
    }
}
