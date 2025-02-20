using System;
using System.Collections.Generic;
using System.Linq;
using Navtrack.Api.Model.Reports;
using Navtrack.Api.Model.Trips;
using Navtrack.DataAccess.Model.Common;

namespace Navtrack.Api.Services.Mappers.Reports;

public static class DistanceReportListModelMapper
{
    public static DistanceReportListModel Map(IEnumerable<TripModel> source, UnitsType unitsType)
    {
        DistanceReportListModel model = new DistanceReportListModel
        {
            Items = source.GroupBy(x => new
                    { x.StartPosition.DateTime.Day, x.StartPosition.DateTime.Month, x.StartPosition.DateTime.Year })
                .Select(x => new DistanceReportItemModel
                {
                    Day = new DateTime(x.Key.Year, x.Key.Month, x.Key.Day),
                    Trips = x.Count(),
                    Distance = x.Sum(y => y.Distance),
                    Duration = x.Sum(y => y.Duration)
                })
        };

        return model;
    }
}