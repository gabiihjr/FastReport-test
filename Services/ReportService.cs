#nullable enable
using Fastreportdemo.Models;
using Bogus;

namespace Fastreportdemo.Services;
public class ReportService
{
    public List<Report> GetReports()
    {
        // var reportId = 0;
        // var reports = new Faker<Report>("pt_BR")
        //     .StrictMode(true)
        //     .RuleFor(r => r.id, f => reportId++)
        //     .RuleFor(r => r.title, f => f.Lorem.Sentence(5))
        //     .RuleFor(r => r.status, f => f.Lorem.Sentence(5))
        //     .RuleFor(r => r.type, f => f.Lorem.Sentence(1))
        //     .RuleFor(r => r.priority, f => f.Lorem.Sentence(1))
        //     .RuleFor(r => r.demand, f => f.Lorem.Sentence(1))
        //     .RuleFor(r => r.disapprovalsNumber, f => f.PickRandom<int>())
        //     .RuleFor(r => r.bugReporter, f => f.Lorem.Sentence(1))
        //     .RuleFor(r => r.bugResponsible, f => f.Lorem.Sentence(1))
        //     .FinishWith((f, r) =>
        //     {
        //         Console.WriteLine($"Report created: {r.id}");
        //     });



        var results = new List<Report>();

        


        return results;
    }
}