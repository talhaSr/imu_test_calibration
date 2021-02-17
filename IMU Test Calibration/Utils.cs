using System;

namespace IMU_Test_Calibration
{
    class Utils
    {
        public static String[] SplitString(char delimeter, String bufferStr)
        {
            String[] tempStirng = bufferStr.Split(delimeter);
            return tempStirng;
        }
    }
}
