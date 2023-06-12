using System.ComponentModel;

namespace FindMyFamilyDoc.Shared.Enums
{
    public enum Gender
    {
        [Description("Male")]
        Male,

        [Description("Female")]
        Female,

        [Description("Other")]
        Other,

        [Description("Prefer not to say")]
        PreferNotToSay
    }
}