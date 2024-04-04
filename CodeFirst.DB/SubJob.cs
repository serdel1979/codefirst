using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.DB
{
    public class SubJob
    {
        public int Id { get; set; }
        public string Detail { get; set; }
        public int JobId { get; set; }
        public Job Job { get; set; }
    }
}
