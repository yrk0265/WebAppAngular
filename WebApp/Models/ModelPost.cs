using System;

namespace WebApp
{
    public class ModelPost
    {
        public DateTime CreatedDateTime { get; set; }
        public DateTime ModifiedDateTime { get; set; }
        public bool IsDeleted { get; set; }
        public string HeadLine { get; set; }
        public string Content { get; set; }
    }
}
