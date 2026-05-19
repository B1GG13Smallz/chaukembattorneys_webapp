using LawFirmApp.Web.Models;

namespace LawFirmApp.Web.Services;

public sealed class FirmContentService
{
    public IReadOnlyList<ServicePage> Services { get; } =
    [
        new("criminal-law", "Criminal Law", "Bail applications, unlawful arrest, police station support, criminal defence, and urgent family intake.", "We capture urgent facts, assign the correct attorney, coordinate with the police station or court process, and keep the family informed.", ["ID copy", "Case number", "Police station details", "Charge sheet", "Witness details"], ["Emergency bail support", "Police station representation", "Unlawful arrest guidance"]),
        new("family-law", "Family Law", "Maintenance, custody-related consultations, domestic matters, divorce, settlement, and court process guidance.", "The team reviews your family matter, confirms the correct forum, prepares the required documents, and supports negotiation or court steps.", ["ID copy", "Marriage certificate", "Children's birth certificates", "Income proof", "Court orders"], ["Maintenance", "Divorce", "Custody consultations"]),
        new("civil-litigation", "Civil Litigation", "Disputes, demand letters, summons, pleadings, court dates, settlement tracking, and judgment follow-up.", "We assess merits, prepare correspondence or pleadings, track court dates, and report settlement or judgment milestones.", ["Contracts", "Correspondence", "Proof of payment", "Summons", "Court notices"], ["Demand letters", "Court process", "Settlement tracking"]),
        new("labour-matters", "Labour Matters", "Employee and employer consultations, disciplinary processes, CCMA-related support, and workplace disputes.", "We review workplace facts, documents, deadlines, and representation options for disciplinary or CCMA-related processes.", ["Employment contract", "Payslips", "Warnings", "Disciplinary records", "CCMA referral"], ["CCMA support", "Disciplinary hearings", "Workplace disputes"]),
        new("immigration", "Immigration", "Permits, status issues, documentation guidance, appeals, and appointment-led consultation workflows.", "We review status, identify missing documents, map the application or appeal path, and manage appointment-led updates.", ["Passport", "Permit documents", "Proof of address", "Employment records", "Home Affairs correspondence"], ["Permits", "Appeals", "Status issues"]),
        new("raf-claims", "RAF Claims", "Road Accident Fund intake, police case details, medical reports, claim milestones, and settlement tracking.", "We gather accident, police, medical, and employment impact records before preparing and tracking the claim.", ["Accident report", "Police case number", "Medical reports", "Employment impact proof", "ID copy"], ["Claim milestones", "Medical evidence", "Settlement tracking"]),
        new("wills-trusts-estates", "Wills, Trusts, and Estates", "Will drafting, trust support, estate administration, master reference tracking, and beneficiary communication.", "We help organise estate or trust information, track master reference milestones, and communicate required steps clearly.", ["ID copy", "Existing will", "Asset list", "Liability records", "Death certificate"], ["Will drafting", "Trust support", "Estate administration"]),
        new("property-law", "Property Law", "Property transfers, lease disputes, sale agreements, occupation issues, landlord/tenant support, and document reviews.", "We review property records, identify parties and deadlines, prepare legal correspondence, and track transaction or dispute progress.", ["Lease agreement", "Sale agreement", "Title deed", "Proof of ownership", "Correspondence"], ["Lease disputes", "Sale agreements", "Document reviews"]),
        new("eviction-services", "Eviction Services", "Lawful eviction intake, notices, court process tracking, occupier details, property documentation, and hearing milestones.", "We confirm ownership or landlord standing, review notice status, prepare filing steps, and track hearing and order milestones.", ["Property address", "Owner details", "Lease documents", "Notice records", "Occupier details"], ["Notice review", "Court filing", "Hearing tracking"])
    ];

    public IReadOnlyList<PortalMetric> PortalMetrics { get; } =
    [
        new("Active matters", "3", "Two matters have client actions pending"),
        new("Next appointment", "22 May", "Consultation at 10:00"),
        new("Unread messages", "2", "Latest from assigned attorney"),
        new("Open invoices", "1", "R1,800 due")
    ];

    public IReadOnlyList<PortalMatter> Matters { get; } =
    [
        new("MAT-2026-001", "RAF Claim - Mokoena", "RAF Claims", "Evidence review", "Adv. N. Chauke", "Upload latest medical report"),
        new("MAT-2026-014", "Lease Dispute - Dlamini", "Property Law", "Demand letter drafted", "Mr M. Baloyi", "Review draft letter"),
        new("MAT-2026-022", "Bail Application - Urgent", "Criminal Law", "Attorney assigned", "Ms K. Maseko", "Awaiting police station confirmation")
    ];

    public IReadOnlyList<PortalInvoice> Invoices { get; } =
    [
        new("INV-2026-1001", "MAT-2026-001", "Paid", "R2,500", "16 May 2026"),
        new("INV-2026-1024", "MAT-2026-014", "Due", "R1,800", "28 May 2026")
    ];
}
