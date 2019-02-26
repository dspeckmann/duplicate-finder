using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuplicateFinder
{
    public class DuplicateViewModel
    {
        public string FileName { get; set; }
        public IEnumerable<string> FilePaths { get; set; }
    }
}
