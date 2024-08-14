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
    public class RemoveAddressCommandHandler
    {
        private readonly IRepository<Address> _repository;

        public RemoveAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddressCommand removeAddressCommand)
        {
            var values = await _repository.GetByIdAsync(removeAddressCommand.Id);
            await _repository.DeleteAsync(values);
        }
    }
}
