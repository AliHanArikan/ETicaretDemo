using ETicaret.Order.Application.Features.CQRS.Queries.AddressQueries;
using ETicaret.Order.Application.Features.CQRS.Results.AddressResults;
using ETicaret.Order.Application.Interfaces;
using ETicaret.Order.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Order.Application.Features.CQRS.Handlers.AdsressHandlers
{
    public class GetAddressByIdQueryHandler
    {
            private readonly IRepository<Address> _repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery getAddressByIdQuery)
        {
            var values = await _repository.GetByIdAsync(getAddressByIdQuery.Id);
            return new GetAddressByIdQueryResult
            {
                AddressId = values.AddressId,
                City = values.City,
                 Detail = values.Detail,
                 District = values.District,
                 UserId = values.UserId,

            };
        }
    }
}
