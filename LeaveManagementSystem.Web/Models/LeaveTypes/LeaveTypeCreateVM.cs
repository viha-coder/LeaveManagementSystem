using System.ComponentModel.DataAnnotations;

namespace LeaveManagementSystem.Web.Models.LeaveTypes
{
    public class LeaveTypeCreateVM
    {
        [Required]
        [Length(3, 150, ErrorMessage = "Not Enough characters, minimum 3 and maximum 150")]
        public string Name { get; set; } = string.Empty;
        [Required]
        [Range(1, 90, ErrorMessage = "Choose an valid number of days between 1 and 90")]
        [Display(Name = "Number Of Days")]
        public int NumberOfDays { get; set; }
    }
}
