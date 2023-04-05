# nugetscan
Consolidated report on nuget packages for a project/solution

### Report Content
- ID
- Resolved Version
- Latest Version
- Status: Vulnerable | Outdated | Deprecated | Up-To-Date
- Notes

### Report Format
- JSON
- CSV

### Approach
- Input: Solution directory Path with projects as subfolders
- Get list of .csproj files with path
- Categorize .csproj into using ProjectReference and PackageConfig categories
- Use dotnet list command options to get nuget info for projects using <ProjectReference>
- Use nuget cli command options to get nuget info for projects using packages.config
- Consolidate into a unified report

### How to run?
- TBD
