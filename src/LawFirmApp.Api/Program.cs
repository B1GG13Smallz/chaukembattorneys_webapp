using LawFirmApp.Api.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();

builder.Services.AddSingleton<FirmDataStore>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Frontend", policy =>
        policy.WithOrigins("https://localhost:7241", "http://localhost:5241")
            .AllowAnyHeader()
            .AllowAnyMethod());
});

var app = builder.Build();

app.UseHttpsRedirection();
app.UseCors("Frontend");

app.MapGet("/api/services", (FirmDataStore store) => store.Services);
app.MapGet("/api/services/{slug}", (string slug, FirmDataStore store) =>
{
    var service = store.Services.FirstOrDefault(item => item.Slug.Equals(slug, StringComparison.OrdinalIgnoreCase));
    return service is null ? Results.NotFound() : Results.Ok(service);
});

app.MapGet("/api/workflows", (FirmDataStore store) => store.Workflows);
app.MapGet("/api/portal/dashboard", (FirmDataStore store) => store.Dashboard);
app.MapGet("/api/portal/matters", (FirmDataStore store) => store.Matters);
app.MapGet("/api/portal/invoices", (FirmDataStore store) => store.Invoices);
app.MapGet("/api/portal/messages", (FirmDataStore store) => store.Messages);

app.MapPost("/api/intake/emergency-bail", (EmergencyBailRequest request) =>
{
    var reference = $"BAIL-{DateTimeOffset.UtcNow:yyyyMMddHHmmss}";
    return Results.Created($"/api/intake/emergency-bail/{reference}", new IntakeResponse(reference, "Emergency bail intake captured. Callback SLA should be triggered."));
});

app.MapPost("/api/bookings", (BookingRequest request) =>
{
    var reference = $"CONSULT-{DateTimeOffset.UtcNow:yyyyMMddHHmmss}";
    return Results.Created($"/api/bookings/{reference}", new IntakeResponse(reference, "Consultation request captured."));
});

app.MapPost("/api/portal/documents", (DocumentUploadRequest request) =>
{
    var reference = $"DOC-{DateTimeOffset.UtcNow:yyyyMMddHHmmss}";
    return Results.Created($"/api/portal/documents/{reference}", new IntakeResponse(reference, "Document metadata captured. Configure private storage before accepting files in production."));
});

app.MapPost("/api/portal/messages", (PortalMessageRequest request) =>
{
    var reference = $"MSG-{DateTimeOffset.UtcNow:yyyyMMddHHmmss}";
    return Results.Created($"/api/portal/messages/{reference}", new IntakeResponse(reference, "Message queued for the assigned legal team."));
});

app.Run();

public record EmergencyBailRequest(string AccusedName, string PoliceStation, string CaseNumber, string Offence, string Urgency, string FamilyContact, string PreferredContact);
public record BookingRequest(string ServiceType, string ClientName, string Email, string Phone, string ConsultationMode, string PreferredDate, string MatterSummary, bool PopiaConsent);
public record DocumentUploadRequest(string MatterReference, string Category, string FileName, string UploadedBy);
public record PortalMessageRequest(string MatterReference, string Subject, string Body);
public record IntakeResponse(string Reference, string Message);
