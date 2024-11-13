namespace Com.Cognizant.Truyum.Utility
{
    public class DateUtility
    {
        public DateTime ConvertToShortDateString (string inputDate)
        {
            DateTime shortDate = DateTime.Parse (inputDate);
            return shortDate;
        }
    }
}
