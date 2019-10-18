namespace TestNinja.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService(null);
            var title = service.ReadVideoTitle();
        }
    }
}
