using System;
using System.Numerics;
using Accord.Math;


namespace IMU_Test_Calibration
{
    class Utils
    {
        public static String[] SplitString(char delimeter, String bufferStr)
        {
            String[] tempString = bufferStr.Split(delimeter);
            return tempString;
        }
        public double[] FFT(double[] data, bool dB)
        {
            double[] fft = new double[data.Length];
            Complex[] fftComplex = new Complex[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                fftComplex[i] = new Complex(data[i], 0.0);
            }
            FourierTransform.FFT(fftComplex, FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
            {
                if (dB)
                    fft[i] = Math.Log10(fft[i]);
                else
                    fft[i] = fftComplex[i].Magnitude;
            }
            return fft;
        }
        public float[] CalcAccel(string[] raw, float coefficient)
        {
            float[] acc = new float[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                acc[i] = int.Parse(raw[i]) * coefficient;
            }
            return acc;
        }
        public float[] CalcGyro(string[] raw, float coefficient)
        {
            float[] gyro = new float[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                gyro[i] = int.Parse(raw[i]) * coefficient;
            }
            return gyro;
        }
        public float[] CalcMag(string[] raw, float coefficient)
        {
            float[] mag = new float[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                mag[i] = int.Parse(raw[i]) * coefficient;
            }
            return mag;
        }
        public float CalcTemp(string raw, float coefficient)
        {
            return (float)(int.Parse(raw) * coefficient);
        }
    }
}
