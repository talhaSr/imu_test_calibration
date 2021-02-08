using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMU_Test_Calibration
{
    class Utils
    {
        public static String[] SplitString(char delimeter, String bufferStr)
        {
            String[] tempStirng = bufferStr.Split('#');
            return tempStirng;
        }
    }
}
