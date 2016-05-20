using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HP5890
{
    public interface IHP5890mgr
    {
        char TermChar { get; set; }
        string PreCmdStr { get; set; }
    }
}
