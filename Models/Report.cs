using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fastreportdemo.Models;

public class Report {
    public int id { get; set; }

    public string title { get; set; }

    public string type { get; set; }

    public string status { get; set; }

    public string priority { get; set; }

    public string demand { get; set; }

    public int disapprovalsNumber { get; set; }

    public string bugReporter { get; set; }

    public string bugResponsible { get; set; }

}