﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Models.Request
{
    public class SendFeedbackModel
    {
        public string? Title { get; set; }
        public string? Message { get; set; }
        public int? CourseId { get; set; }
    }
}
