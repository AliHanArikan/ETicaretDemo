using ETicaret.Order.Application.Features.CQRS.Commands.AddressCommands;
using ETicaret.Order.Application.Interfaces;
using ETicaret.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Order.Application.Features.CQRS.Handlers.AdsressHandlers
{
    public class CreateAddressCommandHandler
    {
        private readonly IRepository<Address> _addressRepository;

        public CreateAddressCommandHandler(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task Handle(CreateAdsressCommand createAdsressCommand)
        {
            await _addressRepository.CreateAsync(new Address
            {
                City = createAdsressCommand.City,
                Detail = createAdsressCommand.Detail,
                District = createAdsressCommand.District,
                UserId = createAdsressCommand.UserId,
            });
        }
    }
}
