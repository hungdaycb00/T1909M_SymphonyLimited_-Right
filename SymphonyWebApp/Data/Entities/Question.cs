using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SymphonyWebApp.Data.Entities
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string Title { get; set; }
        public string Answer { get; set; }
    }
}
