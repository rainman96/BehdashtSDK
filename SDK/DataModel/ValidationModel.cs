using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ditas.SDK.DataModel
{
    internal class ValidationModel
    {
        internal bool IsValid { get; set; }
        internal string Message { get; set; }
        internal string FieldName { get; set; }
    }
}
