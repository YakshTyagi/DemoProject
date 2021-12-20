using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackendEcom.Models
{
    public class ResponsePara
    {
        public String SuccessMessage { get; set; }
        public String ErrorMessage { get; set; }
        public Guid id { get; set; }
    }
}
