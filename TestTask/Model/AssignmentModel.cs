using System;
using System.ComponentModel.DataAnnotations;
using TestTask.Enums;

namespace TestTask.Model
{
    public class AssignmentModel
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public uint? Weight { get; set; }
        public DateTime? Deadline { get; set; }
        public DateTime? FinishDate { get; set; }
        public AssignmentStatus Status { get; set; }
    }
}
