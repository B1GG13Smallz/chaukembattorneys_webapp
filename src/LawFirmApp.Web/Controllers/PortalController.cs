using LawFirmApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace LawFirmApp.Web.Controllers;

public sealed class PortalController(FirmContentService content) : Controller
{
    public IActionResult Dashboard() => View(content);
    public IActionResult Login() => View();
}
