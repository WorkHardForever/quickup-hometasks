namespace LoggerAndFilters.Models.GenericResultTime
{
    public class ResultTimeHelper
    {
        public static ResultTimeContext _database;

        public ResultTimeHelper(ResultTimeContext database)
        {
            _database = database;
        }

        public static void SaveResultTimeInDb(ResultTime<object> resultTime)
        {
            _database.Add(resultTime);
            _database.SaveChanges();
        }
    }
}
