using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Intellect.Models
{
    public class UserQuestion
    {
        public int TestTakerId { get; set; }
        public TestTaker TestTaker { get; set; }
        public int QuestionId { get; set; }
        public Question Question { get; set; }
    }
}
