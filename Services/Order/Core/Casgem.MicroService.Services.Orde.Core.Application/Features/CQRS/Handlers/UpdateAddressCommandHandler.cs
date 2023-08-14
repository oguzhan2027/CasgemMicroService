using Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Commands;
using Casgem.MicroService.Services.Orde.Core.Application.Interfaces;
using CasgemMicroService.Services.Order.Core.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casgem.MicroService.Services.Orde.Core.Application.Features.CQRS.Handlers
{
    public class UpdateAddressCommandHandler : IRequestHandler<UpdateAddresCommandRequest>
    {
        private readonly IRepository<Address> _repository;

        public UpdateAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAddresCommandRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.AddressID);
            values.City = request.City;
            values.District = request.District;
            values.UserID = request.UserID;
            values.Detail = request.Detail;
            await _repository.UpdateGetAsync(values);
        }
    }
}
