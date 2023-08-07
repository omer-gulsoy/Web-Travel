using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TraversalCoreProje.CQRS.Commands.DestinationCommands;

namespace TraversalCoreProje.CQRS.Handlers.DestinationHandlers
{
    public class CreateDestinationCommandHandler
    {
        private readonly Context _context;
        public CreateDestinationCommandHandler(Context context)
        {
            _context = context;
        }
        public void Handle(CreateDestinationCommand command)
        {
            _context.Destinations.Add(new Destination
            {
                City = command.City,
                Price = command.Price,
                DayNight = command.DayNight,
                Status = true,
                GuideID = command.GuideID,
                Date = command.Date,
                Capacity = 25,
                Description = "Tek Kişilik Oda",
                Details1 = command.Details1,
                Details2 = command.Details2,
                Image= command.Image,
                Image2 = command.Image2,
                CoverImage= command.CoverImage,

            });
            _context.SaveChanges();
        }
    }
}
