namespace LawFirmApp.Api.Services;

public record LegalService(string Slug, string Name, string Summary, string Process, string[] CommonDocuments, string[] CallsToAction);
public record LegalWorkflow(string Name, string[] KeyData, string[] Milestones);
public record PortalDashboard(int ActiveMatters, int UnreadMessages, int PendingDocuments, int OpenInvoices, string NextAppointment, string RecentUpdate);
public record Matter(string Reference, string Name, string ServiceArea, string Status, string ResponsibleAttorney, string NextAction, string[] Milestones);
public record Invoice(string Number, string MatterReference, decimal Amount, decimal Balance, string Status, DateOnly DueDate);
public record PortalMessage(string MatterReference, string From, string Subject, string Preview, DateTimeOffset SentAt, bool IsUnread);
