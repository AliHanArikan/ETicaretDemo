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
    public class UpdateAddressCommandHandler
    {
        private readonly IRepository<Address> _addressRepository;

        public UpdateAddressCommandHandler(IRepository<Address> addressRepository)
        {
            _addressRepository = addressRepository;
        }

        public async Task Handle(UpdateAddressCommand updateAddressCommand)
        {
            var values = await _addressRepository.GetByIdAsync(updateAddressCommand.AddressId);
            values.Detail = updateAddressCommand.Detail;
            values.District = updateAddressCommand.District;
            values.City = updateAddressCommand.City;
            values.UserId = updateAddressCommand.UserId;
            await _addressRepository.UpdateAsync(values);   
        }
    }

}
