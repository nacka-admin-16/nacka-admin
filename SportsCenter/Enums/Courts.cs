using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SportsCenter.Enums
{
    public enum Courts
    {
        [Display(Name="Tennis")]
        Tennis,
        Squash,
        Badminton
    }
}
