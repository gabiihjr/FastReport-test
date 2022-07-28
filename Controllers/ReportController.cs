namespace Fastreportdemo.Controllers;
using Microsoft.AspNetCore.Mvc;
using Fastreportdemo.Services;
using FastReport.Export.PdfSimple;

// [ApiController]
// [Route("[controller]")]
public class ReportController : Controller
{ 

    public readonly IWebHostEnvironment _webHostEnvironment;

    public readonly ReportService _reportService;

    public ReportController(ReportService reportService, IWebHostEnvironment webHostEnvironment)
    {
        _reportService = reportService;
        _webHostEnvironment = webHostEnvironment;
    }

    [HttpGet]
    public IActionResult CreateReport()
    {
        var reportFile = Path.Combine(_webHostEnvironment.WebRootPath, @"Reports\Report.frx");
        
        var r = new FastReport.Report();
        var listReports = _reportService.GetReports();

       r.Report.Dictionary.RegisterBusinessObject(listReports, "listReports", 10, true);
        
        r.Save(reportFile);

        return Ok("Report created");
    }

    [HttpGet]

    public IActionResult Report()
    {
        var reportFile = Path.Combine(_webHostEnvironment.WebRootPath, @"Reports\Report.frx");
        
        var r = new FastReport.Report();
        var listReports = _reportService.GetReports();

        r.Load(reportFile);

        r.Report.Dictionary.RegisterBusinessObject(listReports, "listReports", 10, true);
        
        r.Prepare();

        var pdfExport = new PDFSimpleExport(); 
        using MemoryStream ms = new MemoryStream();

        pdfExport.Export(r.Report, ms);
        ms.Flush();

        return File(ms.ToArray(), "application/pdf");
    }

}