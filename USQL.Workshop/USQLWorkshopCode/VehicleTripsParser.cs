using System.Linq;
using Microsoft.Analytics.Types.Sql;

namespace USQLWorkshopCode
{
    public class VehicleTripsParser
    {
        public static SqlArray<int> SplitAndParseAsInt(string trips, char delimeter)
        {
            var tripIds = trips.Split(delimeter).Select(int.Parse);
            return new SqlArray<int>(tripIds);
        }
    }
}