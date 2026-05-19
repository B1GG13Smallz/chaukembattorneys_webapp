namespace LawFirmApp.Web.Models;

public record ServicePage(string Slug, string Name, string Summary, string Process, string[] Documents, string[] Highlights);
public record PortalMetric(string Label, string Value, string Detail);
public record PortalMatter(string Reference, string Title, string Area, string Status, string Attorney, string NextAction);
public record PortalInvoice(string Number, string MatterReference, string Status, string Amount, string DueDate);
