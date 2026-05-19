namespace LawFirmApp.Api.Services;

public sealed class FirmDataStore
{
    public IReadOnlyList<LegalService> Services { get; } =
    [
        new("criminal-law", "Criminal Law", "Bail applications, unlawful arrest, police station support, criminal defence, and urgent family intake.", "Rapid intake, attorney assignment, police station coordination, court preparation, and status updates.", ["ID copy", "Case number", "Police station details", "Charge sheet", "Witness details"], ["Request Legal Help", "Emergency Bail Assistance"]),
        new("family-law", "Family Law", "Maintenance, custody consultations, domestic matters, divorce, settlement, and court process guidance.", "Consultation, document review, negotiation, court filing, hearing preparation, and settlement tracking.", ["ID copy", "Marriage certificate", "Children's birth certificates", "Income proof", "Existing court orders"], ["Book Consultation"]),
        new("civil-litigation", "Civil Litigation", "Disputes, demand letters, summons, pleadings, court dates, settlement tracking, and judgment follow-up.", "Merits assessment, demand, pleadings, discovery, court dates, settlement, and enforcement.", ["Contracts", "Correspondence", "Proof of payment", "Summons", "Court notices"], ["Request Legal Help"]),
        new("labour-matters", "Labour Matters", "Employee and employer consultations, disciplinary processes, CCMA support, and workplace disputes.", "Consultation, evidence review, CCMA preparation, representation planning, and outcome tracking.", ["Employment contract", "Payslips", "Warnings", "Disciplinary records", "CCMA referral"], ["Book Consultation"]),
        new("immigration", "Immigration", "Permits, status issues, documentation guidance, appeals, and appointment-led consultation workflows.", "Eligibility review, document checklist, application support, appeal tracking, and appointment updates.", ["Passport", "Permit documents", "Proof of address", "Employment records", "Home Affairs correspondence"], ["Book Consultation"]),
        new("raf-claims", "RAF Claims", "Road Accident Fund intake, police case details, medical reports, claim milestones, and settlement tracking.", "Accident intake, evidence collection, claim submission, RAF response tracking, and settlement follow-up.", ["Accident report", "Police case number", "Medical reports", "Employment impact proof", "ID copy"], ["Request Legal Help"]),
        new("wills-trusts-estates", "Wills, Trusts, and Estates", "Will drafting, trust support, estate administration, master reference tracking, and beneficiary communication.", "Consultation, estate inventory, master reference tracking, beneficiary communication, and milestone reporting.", ["ID copy", "Existing will", "Asset list", "Liability records", "Death certificate"], ["Book Consultation"]),
        new("property-law", "Property Law", "Property transfers, lease disputes, sale agreements, occupation issues, landlord/tenant support, and document reviews.", "Document review, party identification, deadline tracking, negotiation, filing support, and status updates.", ["Lease agreement", "Sale agreement", "Title deed", "Proof of ownership", "Correspondence"], ["Request Legal Help"]),
        new("eviction-services", "Eviction Services", "Lawful eviction intake, notices, court process tracking, occupier details, property documentation, and hearing milestones.", "Notice review, occupier details, court filing, hearing preparation, order tracking, and client updates.", ["Property address", "Owner details", "Lease documents", "Notice records", "Occupier details"], ["Request Legal Help"])
    ];

    public IReadOnlyList<LegalWorkflow> Workflows { get; } =
    [
        new("Bail intake", ["Accused name", "Police station", "Case number", "Offence", "Urgency", "Family contact"], ["Urgent intake", "Attorney assignment", "Police station contact", "Bail application", "Court update"]),
        new("RAF claims", ["Accident date", "Police case", "Medical documents", "Employment impact"], ["Intake", "Evidence collection", "Claim submission", "RAF response", "Settlement"]),
        new("Divorce", ["Consultation", "Summons", "Settlement", "Parenting or maintenance issues"], ["Document checklist", "Court date", "Settlement", "Decree"]),
        new("Estate administration", ["Deceased details", "Master reference", "Executor", "Beneficiaries"], ["Estate inventory", "Master engagement", "Claims", "Distribution"]),
        new("Property matters", ["Property address", "Ownership or lease documents", "Parties", "Deadlines"], ["Review", "Notice or agreement", "Negotiation", "Filing", "Resolution"]),
        new("Eviction matters", ["Property address", "Landlord details", "Occupier details", "Notice status"], ["Notice", "Court filing", "Hearing", "Order", "Execution"])
    ];

    public PortalDashboard Dashboard { get; } = new(3, 2, 4, 1, "Consultation: 22 May 2026, 10:00", "RAF claim milestone updated to evidence review.");

    public IReadOnlyList<Matter> Matters { get; } =
    [
        new("MAT-2026-001", "RAF Claim - Mokoena", "RAF Claims", "Evidence review", "Adv. N. Chauke", "Upload outstanding medical report", ["Intake complete", "Police case captured", "Medical documents pending", "Claim preparation"]),
        new("MAT-2026-014", "Lease Dispute - Dlamini", "Property Law", "Demand letter drafted", "Mr M. Baloyi", "Review draft letter", ["Consultation complete", "Documents received", "Demand letter drafted"]),
        new("MAT-2026-022", "Bail Application - Urgent", "Criminal Law", "Attorney assigned", "Ms K. Maseko", "Awaiting police station confirmation", ["Emergency intake", "Attorney assigned", "Police station contact"])
    ];

    public IReadOnlyList<Invoice> Invoices { get; } =
    [
        new("INV-2026-1001", "MAT-2026-001", 2500m, 0m, "Paid", new DateOnly(2026, 5, 16)),
        new("INV-2026-1024", "MAT-2026-014", 1800m, 1800m, "Due", new DateOnly(2026, 5, 28))
    ];

    public IReadOnlyList<PortalMessage> Messages { get; } =
    [
        new("MAT-2026-001", "Adv. N. Chauke", "Medical report required", "Please upload the latest hospital report before claim submission.", DateTimeOffset.Now.AddHours(-5), true),
        new("MAT-2026-014", "Reception", "Appointment confirmed", "Your property consultation has been confirmed.", DateTimeOffset.Now.AddDays(-1), false)
    ];
}
