using System;

namespace Vidly.Models
{
    public class Error
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Exception { get; set; }
        public string Stacktrace { get; set; }
        public DateTime Time { get; set; }
    }
}