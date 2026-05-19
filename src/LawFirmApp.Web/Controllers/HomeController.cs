using LawFirmApp.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace LawFirmApp.Web.Controllers;

public sealed class HomeController(FirmContentService content) : Controller
{
    public IActionResult Index() => View(content.Services);
    public IActionResult About() => View();
    public IActionResult Services() => View(content.Services);

    public IActionResult Service(string id)
    {
        var service = content.Services.FirstOrDefault(item => item.Slug.Equals(id, StringComparison.OrdinalIgnoreCase));
        return service is null ? NotFound() : View(service);
    }

    public IActionResult EmergencyBail() => View();
    public IActionResult Booking() => View(content.Services);
    public IActionResult Contact() => View();
}
