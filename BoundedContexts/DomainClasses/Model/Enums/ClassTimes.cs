using System.ComponentModel;

namespace DomainClasses.Model.Enums
{
    public enum ClassTimes
    {
        [Description("From 10am to 12pm")]
        MorningClass,
        [Description("From 12pm to 3pm")]
        NoonClass,
        [Description("From 3pm to 6pm")]
        AfterNoonCalss,
        [Description("From 6pm to 9pm")]
        EveningClass,
        [Description("From 9pm to 12am")]
        NightClass
    }
}