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
- Use dotnet list command options to get nuget info for projects using <ProjectReference>
- Use nuget cli command options to get nuget info for projects using packages.config
- Consolidate into a unified report

### How to run?
- TBD
