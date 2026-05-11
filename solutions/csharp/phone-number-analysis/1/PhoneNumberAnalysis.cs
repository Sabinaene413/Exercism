public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        bool isNY = phoneNumber.StartsWith("212");

        bool isFake = phoneNumber.Substring(4, 3) == "555";

        string localNumber = phoneNumber.Substring(8);

        return (isNY, isFake, localNumber);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo)
    {
        return phoneNumberInfo.IsFake;
    }
}
