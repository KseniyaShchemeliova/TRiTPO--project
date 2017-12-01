namespace konverter1
{
    public interface IConverting
    {
        double Convert(double amount, double fromRate, double toRate);
    }

    internal class Converter : IConverting
    {
        public double Convert(double amount, double fromRate, double toRate)
        {
            return fromRate / toRate * amount;
        }
    }
}