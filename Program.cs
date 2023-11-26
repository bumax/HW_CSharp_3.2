namespace GB
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine(Bits.SetBit<int>(0, 1, true));
            Console.WriteLine(Bits.SetBit<long>(0, 1, true));
            Console.WriteLine(Bits.SetBit<byte>(0, 1, true));
        }
    }
}