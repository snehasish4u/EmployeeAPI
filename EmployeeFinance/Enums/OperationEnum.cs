using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeManagement.Enums
{
    public class OperationEnum
    {
        public enum Operations
        {
            INSERT,
            UPDATE,
            DELETE,
            SELECT,
            SELECTBYID,
            SEARCH
        }
    }
}