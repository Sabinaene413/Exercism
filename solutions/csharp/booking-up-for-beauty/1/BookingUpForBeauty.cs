static class Appointment
{
    public static DateTime Schedule(string appointmentDateDescription)
    {
       return DateTime.Parse(appointmentDateDescription);
    }

    public static bool HasPassed(DateTime appointmentDate) => appointmentDate < DateTime.Now;


    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
        int hour = appointmentDate.Hour;

        return hour >= 12 && hour < 18;
    }

    public static string Description(DateTime appointmentDate) => $"You have an appointment on {appointmentDate}.";


    public static DateTime AnniversaryDate() => new DateTime(DateTime.Now.Year, 9, 15);

}
