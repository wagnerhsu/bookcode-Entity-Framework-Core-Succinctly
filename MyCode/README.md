# README

## EF Commands

```powershell
# Add migration
dotnet ef migrations add Initial -s .\Wagner.Portal\ -p .\Wagner.Data\ -c ProjectsContext -v
# Update Database
dotnet ef database update  -s .\Wagner.Portal\ -p .\Wagner.Data\ -c ProjectsContext -v
```

## Reference

- Design-time DbContext Creation [>>](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dbcontext-creation)
- Entity Framework Core tools reference - \.NET CLI [>>](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)