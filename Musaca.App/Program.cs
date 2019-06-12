using SIS.MvcFramework;

namespace Musaca.App
{
    public static class Program
    {
        public static void Main()
        {
            WebHost.Start(new StartUp());
        }
    }
}
