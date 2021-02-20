using System;

namespace VisitorExercise
{
    public class Demo
    {
        public static void Show()
        {
            var wavFile = WavFile.Read("myfile.wav");
            wavFile.ApplyFilter(new NoiseReductionFilter());
            wavFile.ApplyFilter(new ReverbFilter());
            wavFile.ApplyFilter(new NormaliseFilter());
        }
    }
}
