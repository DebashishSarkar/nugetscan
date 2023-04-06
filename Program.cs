namespace nugetscan
{
    class Program
    {
        public static void Main(string[] args)
        {
            NugetInfoGatherer nugethelper = new NugetInfoGatherer();
            nugethelper.GetLatestNugetInfo();
        }
    }
}
