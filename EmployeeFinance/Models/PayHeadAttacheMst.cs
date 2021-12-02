using System;
using System.Collections.Generic;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class PayHeadAttacheMst
    {
        public int Id { get; set; }
        public string AttachTo { get; set; }
        public string Allias { get; set; }
    }
}
