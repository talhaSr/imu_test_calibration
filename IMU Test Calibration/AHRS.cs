using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMU_Test_Calibration
{
    class AHRS
    {
        public float[] q = new float[4];
        public float beta;
        
        public void MadgwickInit()
        {
            q[0] = 1.0f;
            q[1] = 0.0f;
            q[2] = 0.0f;
            q[3] = 0.0f;
            beta = 0.1f;
        }
        

        public static void MadgwickUpdate(float[] a, float[] g, float[] m)
        {
            float recipNorm;
            float[] s = new float[4];
            float[] qDot = new float[4];
            float hx, hy;
            float _2q0mx, _2q0my, _2q0mz, _2q1mx, _2bx, _2bz, _4bx, _4bz, _2q0, _2q1, _2q2, _2q3, _2q0q2, _2q2q3, q0q0, q0q1, q0q2, q0q3, q1q1, q1q2, q1q3, q2q2, q2q3, q3q3;

            if (m[0] == 0.0f && m[1] == 0.0f && m[2] == 0.0f)
            {
                MadgwickUpdateIMU(a, m);
                return;
            }

            qDot[0] = 0.5f;

        }

        public static void MadgwickUpdateIMU(float[] a, float[] g)
        {

        }
        public float InverseSqrt(float x)
        {
            return 1.0f / (float)Math.Sqrt(x);
        }
    }
}
