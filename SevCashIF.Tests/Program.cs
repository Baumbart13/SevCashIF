// See https://aka.ms/new-console-template for more information

using SevCashIF.Core.Handler;

Console.WriteLine("Hello, World!");

var hasSomethingHappened = false;
for (var i = 0; i < args.Length; i++) {
    if (args[i].Contains("pdf")) {
        TestPdf();
    } else if (args[i].Contains("api")) { // test api
        if (i + 1 < args.Length) {
            TestApi(args[i+1]);
        }
    }
}

Console.WriteLine(!hasSomethingHappened ? "There were no tests" : "All tests done!");

void TestPdf() {
    hasSomethingHappened = true;
    const string inPdf = @"C:\Users\Thomas\Documents\Odens – Best of Swedish Snus.pdf";
    const string outPdf = @"C:\Users\Thomas\Documents\test.pdf";

    var pdf = PdfSharp.Pdf.IO.PdfReader.TestPdfFile(inPdf);

    Console.WriteLine($"Code of test-pdf is {pdf}");

    var handler = new HelloCashHandler();
    handler.GetInvoice(1);
}

void TestApi(string api) {
    Console.WriteLine("Testing API...");
    hasSomethingHappened = true;
    if (api.Contains("hellocash")) {
        TestApi_HelloCash();
    }else if (api.Contains("sevdesk")) {
        TestApi_Sevdesk();
    } else {
        hasSomethingHappened = false;
    }
}

void TestApi_HelloCash() {
    
}

void TestApi_Sevdesk() {
    
}