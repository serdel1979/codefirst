using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DB
{
    public class Job
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<SubJob> SubJobs { get; set; }

    }
}
