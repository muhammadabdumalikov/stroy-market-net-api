namespace StroyMarket.Helpers
{
    public class CodeGeneraor
    {
        public int Generate()
        {
            return new Random().Next(10000, 99999);
        }
    }
}
