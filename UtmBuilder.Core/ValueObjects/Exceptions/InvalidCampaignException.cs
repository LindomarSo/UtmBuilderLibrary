namespace UtmBuilder.Core.ValueObjects.Exceptions
{
    public class InvalidCampaignException : Exception
    {
        private const string DefaultErroMessage = "Invalid UTM parameters";
        public InvalidCampaignException(string message = DefaultErroMessage) : base(message)
        {

        }

        public static void ThrowIfNull(string item, string message = DefaultErroMessage)
        {
            if (string.IsNullOrEmpty(item))
                throw new InvalidCampaignException(message);
        }
    }
}
