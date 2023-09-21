using Microsoft.AspNetCore.Mvc.Formatters;
using Microsoft.Net.Http.Headers;

using System.Text;
using System.Text.RegularExpressions;
using System;

namespace APIRestLab01
{
    public class CsvOutputFormatter : TextOutputFormatter
    {
        public CsvOutputFormatter()
        {
            SupportedMediaTypes.Add(MediaTypeHeaderValue.Parse("text/csv"));
            SupportedEncodings.Add(Encoding.UTF8);
            SupportedEncodings.Add(Encoding.Unicode);
        }
        
        public override async Task WriteResponseBodyAsync(OutputFormatterWriteContext context, Encoding selectedEncoding)
        {
        }
        
    }
}