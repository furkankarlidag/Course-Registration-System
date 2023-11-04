using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_Registration_System
{
    public static class Settings
    {
        static bool _teacherStatus = true;

        public static bool teacherStatus
        {
            get
            {
                return _teacherStatus;
            }
            set
            {
                _teacherStatus = value;
            }
        }
    }
}
