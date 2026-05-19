# LawFirmApp UI

ASP.NET Core scaffold for Chauke MB Attorneys Inc, based on the BRD dated 19 May 2026.

## Structure

- `src/LawFirmApp.Web` - ASP.NET Core MVC frontend for the public website and lite client portal prototype.
- `src/LawFirmApp.Api` - ASP.NET Core backend API with seeded legal services, workflows, matters, invoices, and messages.

## Requirements

- .NET 8 SDK or later.

`dotnet` was not available on this machine when this scaffold was created, so the project files were generated manually.

## Run

From this folder:

```powershell
dotnet restore
dotnet run --project .\src\LawFirmApp.Api\LawFirmApp.Api.csproj
dotnet run --project .\src\LawFirmApp.Web\LawFirmApp.Web.csproj
```

Default local URLs:

- Web: `https://localhost:7241`
- API: `https://localhost:7141`

## Included BRD Scope

- Premium public website with home, services, emergency bail, booking, about, and contact routes.
- Individual service catalogue covering criminal, family, civil litigation, labour, immigration, RAF, wills/trusts/estates, property, and eviction services.
- Lite client portal screens for matters, status, secure uploads, messages, invoices, and appointments.
- Backend API endpoints for public content, portal dashboard data, intake, booking, document upload metadata, and messages.
- Basic role-aware domain structure for future client, attorney, finance, reception, admin, and managing partner workflows.
