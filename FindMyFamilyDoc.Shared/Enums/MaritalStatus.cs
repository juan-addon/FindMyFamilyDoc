using System.ComponentModel;

namespace FindMyFamilyDoc.Shared.Enums
{
    public enum MaritalStatus
    {
        [Description("Single")]
        Single,

        [Description("Married")]
        Married,

        [Description("Divorced")]
        Divorced,

        [Description("Widowed")]
        Widowed
    }
}