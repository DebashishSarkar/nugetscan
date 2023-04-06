namespace nugetscan
{
    internal class NugetInfo
    {
        /// <summary>
        /// Nuget Package ID (Newtonsoft.Json)
        /// </summary>
        public string? PackageID { get; set; }
        /// <summary>
        /// current nuget package version being used (6.5.0)
        /// </summary>
        public string? CurrentVersion { get; set; }
        /// <summary>
        /// latest nuget package version available with sources
        /// </summary>
        public string? LatestVersion { get; set; }

    }
}
