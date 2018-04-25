namespace StrongKeys.Common.GAModels
{
    /// <summary>
    /// Contains a percentage values of matching
    /// </summary>
    public class FitnessValues
    {
        public double MainCoef { get; set; }
        public double Direct { get; set; }
        public double Approximate { get; set; }
        public double R { get; set; }
        public double G { get; set; }
        public double B { get; set; }

        public FitnessValues(double direct,
            double approximate,
            double r,
            double g,
            double b)
        {
            Direct = direct;
            Approximate = approximate;
            R = r;
            G = g;
            B = b;
            MainCoef = CalculateMainCoef();
        }

        private double CalculateMainCoef()
        {
            return Direct + Approximate + R + G + B;
        }
    }
}
