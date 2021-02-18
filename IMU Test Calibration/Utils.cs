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

        public double[] FFT(double[] data)
        {
            double[] fft = new double[data.Length];
            Complex[] fftComplex = new Complex[data.Length];
            for (int i = 0; i < data.Length; i++)
            {
                fftComplex[i] = new Complex(data[i], 0.0);
            }
            Accord.Math.FourierTransform.FFT(fftComplex, Accord.Math.FourierTransform.Direction.Forward);
            for (int i = 0; i < data.Length; i++)
            {
                fft[i] = fftComplex[i].Magnitude;
                //fft[i] = Math.Log10(fft[i]);    /* dB Scale */
            }
            return fft;
        }
    }
}
