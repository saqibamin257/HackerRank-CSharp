using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HackerRank
{
    internal class Asynchoronous_ReadDataFromNetwork_Result
    {
        //This snippet downloads the HTML from the homepage at https://dotnetfoundation.org and counts the number of times the string ".NET" occurs
        //in the HTML. It uses ASP.NET to define a Web API controller method, which performs this task and returns the number.

        private readonly HttpClient _httpClient = new HttpClient();

        [HttpGet, Route("DotNetCount")]
        public async Task<int> GetDotNetCountAsync() 
        {            
            Task<string> getStringTask =_httpClient.GetStringAsync("https://dotnetfoundation.org");
            DoIndependentWork();
            string contents = await getStringTask;
            return Regex.Matches(contents, @"\.NET").Count();
        }

        ///If GetUrlContentLengthAsync doesn't have any work that it can do between calling GetStringAsync and awaiting its completion, 
        ///you can simplify your code by calling and awaiting in the following single statement.
        public async Task<int> GetDotNetCount1Async()
        {           
            string contents = await _httpClient.GetStringAsync("https://dotnetfoundation.org");
            return Regex.Matches(contents, @"\.NET").Count();
        }

        private static void DoIndependentWork()
        {           
         Console.WriteLine("Working.....");            
        }
    }
    

}
