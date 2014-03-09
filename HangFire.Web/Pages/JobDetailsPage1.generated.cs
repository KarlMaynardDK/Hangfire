﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HangFire.Web.Pages
{
    
    #line 2 "..\..\Pages\JobDetailsPage.cshtml"
    using System;
    
    #line default
    #line hidden
    using System.Collections.Generic;
    
    #line 3 "..\..\Pages\JobDetailsPage.cshtml"
    using System.Linq;
    
    #line default
    #line hidden
    
    #line 4 "..\..\Pages\JobDetailsPage.cshtml"
    using System.Runtime.CompilerServices;
    
    #line default
    #line hidden
    using System.Text;
    
    #line 5 "..\..\Pages\JobDetailsPage.cshtml"
    using System.Web;
    
    #line default
    #line hidden
    
    #line 6 "..\..\Pages\JobDetailsPage.cshtml"
    using Common;
    
    #line default
    #line hidden
    
    #line 8 "..\..\Pages\JobDetailsPage.cshtml"
    using HangFire.Storage;
    
    #line default
    #line hidden
    
    #line 7 "..\..\Pages\JobDetailsPage.cshtml"
    using Pages;
    
    #line default
    #line hidden
    
    #line 9 "..\..\Pages\JobDetailsPage.cshtml"
    using Storage.Monitoring;
    
    #line default
    #line hidden
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("RazorGenerator", "2.0.0.0")]
    internal partial class JobDetailsPage : RazorPage
    {
#line hidden

        public override void Execute()
        {


WriteLiteral("\r\n");











            
            #line 11 "..\..\Pages\JobDetailsPage.cshtml"
  
    JobDetailsDto job;
    using (var monitor = JobStorage.Current.CreateMonitoring())
    {
        job = monitor.JobDetails(JobId.ToString());
    }

    string title = null;

    if (job != null && job.Method != null)
    {
        title = HtmlHelper.DisplayMethod(job.Method);
    }

    title = title ?? "Job";

    Layout = new LayoutPage { Title = title, Subtitle = HtmlHelper.JobId(JobId.ToString(), false).ToString() };


            
            #line default
            #line hidden
WriteLiteral("\r\n");


            
            #line 30 "..\..\Pages\JobDetailsPage.cshtml"
 if (job == null)
{

            
            #line default
            #line hidden
WriteLiteral("    ");

WriteLiteral(" The job with id \'");


            
            #line 32 "..\..\Pages\JobDetailsPage.cshtml"
                   Write(JobId);

            
            #line default
            #line hidden
WriteLiteral("\' was expired or was not existed on the server.\r\n");


            
            #line 33 "..\..\Pages\JobDetailsPage.cshtml"
}
else
{

            
            #line default
            #line hidden
WriteLiteral("    <div class=\"job-snippet\">\r\n        <div class=\"job-snippet-code\">\r\n");


            
            #line 38 "..\..\Pages\JobDetailsPage.cshtml"
             if (job.CreatedAt.HasValue)
            {

            
            #line default
            #line hidden
WriteLiteral("                <div class=\"pull-right job-creation-date\">\r\n                    C" +
"reated\r\n                    <span data-moment=\"");


            
            #line 42 "..\..\Pages\JobDetailsPage.cshtml"
                                  Write(JobHelper.ToStringTimestamp(job.CreatedAt.Value));

            
            #line default
            #line hidden
WriteLiteral("\"></span>\r\n                </div>\r\n");


            
            #line 44 "..\..\Pages\JobDetailsPage.cshtml"
            }

            
            #line default
            #line hidden

            
            #line 45 "..\..\Pages\JobDetailsPage.cshtml"
             if (job.Method != null)
            {

            
            #line default
            #line hidden
WriteLiteral("                <pre><code>");


            
            #line 47 "..\..\Pages\JobDetailsPage.cshtml"
                      Write(JobMethodCallRenderer.Render(job.Method, job.Arguments, job.OldFormatArguments));

            
            #line default
            #line hidden
WriteLiteral("</code></pre>\r\n");


            
            #line 48 "..\..\Pages\JobDetailsPage.cshtml"
            }

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"clearfix\"></div>\r\n        </div>\r\n\r\n");


            
            #line 52 "..\..\Pages\JobDetailsPage.cshtml"
         if (job.Properties.Count > 0)
        {

            
            #line default
            #line hidden
WriteLiteral("            <div class=\"job-snippet-properties\">\r\n                <dl>\r\n");


            
            #line 56 "..\..\Pages\JobDetailsPage.cshtml"
                     foreach (var property in job.Properties)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <dt>");


            
            #line 58 "..\..\Pages\JobDetailsPage.cshtml"
                       Write(property.Key);

            
            #line default
            #line hidden
WriteLiteral("</dt>\r\n");



WriteLiteral("                        <dd><pre>");


            
            #line 59 "..\..\Pages\JobDetailsPage.cshtml"
                            Write(property.Value);

            
            #line default
            #line hidden
WriteLiteral("</pre></dd>\r\n");


            
            #line 60 "..\..\Pages\JobDetailsPage.cshtml"
                    }

            
            #line default
            #line hidden
WriteLiteral("                </dl>\r\n            </div>\r\n");


            
            #line 63 "..\..\Pages\JobDetailsPage.cshtml"
        }

            
            #line default
            #line hidden
WriteLiteral("    </div>\r\n");


            
            #line 65 "..\..\Pages\JobDetailsPage.cshtml"

    if (job.History.Count > 0)
    {

            
            #line default
            #line hidden
WriteLiteral("        <h3>History</h3>\r\n");


            
            #line 69 "..\..\Pages\JobDetailsPage.cshtml"
        var index = 0;
        foreach (var entry in job.History)
        {
            var background = JobHistoryRenderer.BackgroundStateColors.ContainsKey(entry["State"])
               ? JobHistoryRenderer.BackgroundStateColors[entry["State"]]
               : null;

            if (index == 0)
            {
                background = JobHistoryRenderer.ForegroundStateColors.ContainsKey(entry["State"])
                    ? JobHistoryRenderer.ForegroundStateColors[entry["State"]]
                    : null;
            }


            
            #line default
            #line hidden
WriteLiteral("            <div class=\"job-history ");


            
            #line 83 "..\..\Pages\JobDetailsPage.cshtml"
                                Write(index == 0 ? "job-history-current" : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                <div class=\"job-history-heading\" style=\"");


            
            #line 84 "..\..\Pages\JobDetailsPage.cshtml"
                                                    Write(background != null ? String.Format("background-color: {0};", background) : null);

            
            #line default
            #line hidden
WriteLiteral("\">\r\n                    <span class=\"pull-right\" data-moment=\"");


            
            #line 85 "..\..\Pages\JobDetailsPage.cshtml"
                                                     Write(entry["CreatedAt"]);

            
            #line default
            #line hidden
WriteLiteral("\">");


            
            #line 85 "..\..\Pages\JobDetailsPage.cshtml"
                                                                          Write(JobHelper.FromStringTimestamp(entry["CreatedAt"]));

            
            #line default
            #line hidden
WriteLiteral("</span>\r\n                    <h4 class=\"job-history-title\">\r\n                    " +
"    ");


            
            #line 87 "..\..\Pages\JobDetailsPage.cshtml"
                   Write(entry["State"]);

            
            #line default
            #line hidden
WriteLiteral("\r\n\r\n");


            
            #line 89 "..\..\Pages\JobDetailsPage.cshtml"
                         if (!String.IsNullOrEmpty(entry["Reason"]))
                        {

            
            #line default
            #line hidden
WriteLiteral("                            <small>");


            
            #line 91 "..\..\Pages\JobDetailsPage.cshtml"
                              Write(entry["Reason"]);

            
            #line default
            #line hidden
WriteLiteral("</small>\r\n");


            
            #line 92 "..\..\Pages\JobDetailsPage.cshtml"
                        }

            
            #line default
            #line hidden
WriteLiteral("                    </h4>\r\n                </div>\r\n\r\n");


            
            #line 96 "..\..\Pages\JobDetailsPage.cshtml"
                 if (JobHistoryRenderer.Exists(entry["State"]))
                {
                    var rendered = JobHistoryRenderer.Render(entry["State"], entry);
                    if (rendered != null)
                    {

            
            #line default
            #line hidden
WriteLiteral("                        <div class=\"job-history-body\">\r\n                         " +
"   ");


            
            #line 102 "..\..\Pages\JobDetailsPage.cshtml"
                       Write(rendered);

            
            #line default
            #line hidden
WriteLiteral("\r\n                        </div>\r\n");


            
            #line 104 "..\..\Pages\JobDetailsPage.cshtml"
                    }
                }
                else
                {

            
            #line default
            #line hidden
WriteLiteral("                    <div class=\"job-history-body\">\r\n                        <dl c" +
"lass=\"dl-horizontal\">\r\n");


            
            #line 110 "..\..\Pages\JobDetailsPage.cshtml"
                             foreach (var item in entry.Where(x => x.Key != "State" && x.Key != "Date" && x.Key != "Reason"))
                            {

            
            #line default
            #line hidden
WriteLiteral("                                <dt>");


            
            #line 112 "..\..\Pages\JobDetailsPage.cshtml"
                               Write(item.Key);

            
            #line default
            #line hidden
WriteLiteral(":</dt>\r\n");



WriteLiteral("                                <dd>");


            
            #line 113 "..\..\Pages\JobDetailsPage.cshtml"
                               Write(item.Value);

            
            #line default
            #line hidden
WriteLiteral("</dd>\r\n");


            
            #line 114 "..\..\Pages\JobDetailsPage.cshtml"
                            }

            
            #line default
            #line hidden
WriteLiteral("                        </dl>\r\n                    </div>\r\n");


            
            #line 117 "..\..\Pages\JobDetailsPage.cshtml"
                }

            
            #line default
            #line hidden
WriteLiteral("            </div>\r\n");


            
            #line 119 "..\..\Pages\JobDetailsPage.cshtml"

                index++;
        }
    }
}
            
            #line default
            #line hidden

        }
    }
}
#pragma warning restore 1591
