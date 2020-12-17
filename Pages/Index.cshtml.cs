using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using CsvHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using InterviewAssignment.Models;
using System.Collections;

namespace InterviewAssignment.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        // Private Instance of List of DistinctQuarterCodes.
        // See class at Models/DistinctQuarterCode 
        private List<DistinctQuarterCode> _distinctQuarterCodes = new List<DistinctQuarterCode>();

        public List<Classes> _classes { get; set; }

        // Get Accessor for _distinctQuarterCodes
        public List<DistinctQuarterCode> DistinctQuarterCodes
        {
            get { return SplitQuarterCode(); }

        }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            string path = Path.Combine(Environment.CurrentDirectory, "ClassData.csv");

            using (var reader = new StreamReader(path))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                _classes = csv.GetRecords<Classes>().ToList();

            }
        }

        private List<DistinctQuarterCode> SplitQuarterCode()
        {
            // Create Three Instances of DistinctQuarterCode for Distinct Quarter Code
            DistinctQuarterCode _distcode_11 = new DistinctQuarterCode("C011");
            DistinctQuarterCode _distcode_12 = new DistinctQuarterCode("C012");
            DistinctQuarterCode _distcode_13 = new DistinctQuarterCode("C013");

            // _distinctQuarterCodes = new List<DistinctQuarterCode>();

            foreach (var items in _classes)
            {
                // Starting Index
                int begin_index = items.ClassID.Length - 4;

                // Substring 
                string code_substring = items.ClassID.Substring(begin_index);

                switch (code_substring)
                {
                    case "C011":
                        _distcode_11.Insert(items);
                        break;
                    case "C012":
                        _distcode_12.Insert(items);
                        break;
                    default:
                        _distcode_13.Insert(items);
                        break;
                }
            }

            _distinctQuarterCodes.Add(_distcode_11);
            _distinctQuarterCodes.Add(_distcode_12);
            _distinctQuarterCodes.Add(_distcode_13);


            return _distinctQuarterCodes.OrderByDescending(l => l.label).ToList();

            //return _distinctQuarterCodes.OrderByDescending(l => l.label).ThenBy(sp => sp.Classes.OrderBy(sps => sps.CourseID)).ToList();

        }

    }
}
