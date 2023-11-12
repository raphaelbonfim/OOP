﻿using DotCourse.SharedContext;

namespace DotCourse.SubscriptionContext
{
    public class Plan : Base
    {
        public string Title { get; set; }

        public decimal Price { get; set; } 
    }
}
