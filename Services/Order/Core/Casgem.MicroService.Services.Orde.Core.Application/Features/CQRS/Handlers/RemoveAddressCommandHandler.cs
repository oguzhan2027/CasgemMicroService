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
    public class RemoveAddressCommandHandler : IRequestHandler<RemoveAddressCommandRequest>
    {
        private readonly IRepository<Address> _repository;

        public RemoveAddressCommandHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAddressCommandRequest request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteGetAsync(values);
            //var value = await _repository.GetByIdAsync(request.Id);
            //if(value != null) 
            //{
            //    await _repository.DeleteGetAsync(value);
            //}
            //return value;
        }
    }
    
}
