using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Queries.DestinationQueries;
using TraversalCoreProje.CQRS.Results.DestinationResults;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandler
    {
        private readonly Context _context;
        public GetDestinationByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
				Price = values.Price,
				DayNight = values.DayNight,
                Status = values.Status,
                GuideID = values.GuideID,
                Date = values.Date,
                Capacity = values.Capacity,
                Description = values.Description,
                Details1 = values.Details1,
                Details2 = values.Details2,
                Image = values.Image,
                Image2 = values.Image2,
                CoverImage = values.CoverImage,
            };
        }
    }
}
