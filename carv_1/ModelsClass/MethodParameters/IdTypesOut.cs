using ModelsClass.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModelsClass.MethodParameters
{
    public class IdTypesOut: BaseOut
    {
        public List<IdType> IdTypes { get; set; }
    }

    public class IdType
    {
        public int Id { get; set; }

        public string IdentificationName { get; set; }

        public string Code { get; set; }
    }
}
