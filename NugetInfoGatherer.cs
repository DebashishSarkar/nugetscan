using CsvHelper;
using System.Globalization;

namespace nugetscan
{
    internal class NugetInfoGatherer
    {
        public void GetLatestNugetInfo()
        {
            var packages = ReadNugetList();
            GetLatestNugetInfo(packages);
            SaveResults(packages);
        }

        private List<NugetInfo> GetLatestNugetInfo(List<NugetInfo> packages)
        {
            return packages;
        }
        private List<NugetInfo> ReadNugetList()
        {
            List<NugetInfo> packages;
            using (var reader = new StreamReader("input.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                packages = new List<NugetInfo>();
                while (csv.Read())
                {
                    packages.Add(new NugetInfo() { PackageID = csv[0] });
                }
            }
            return packages;
        }

        private void SaveResults(List<NugetInfo> packages)
        {

        }
    }
}
