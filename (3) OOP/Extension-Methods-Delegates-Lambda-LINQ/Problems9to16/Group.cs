using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems9to16
{
    class Group
    {
        public int GroupNumber { get; private set; }
        public string DepartmentName { get; private set; }

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }
    }
}
