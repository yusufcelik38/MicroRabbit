using MicroRabbit.Domain.Core.Bus;
using MicroRabbit.Transfer.Domain.Events;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Transfer.Domain.EventHandlers
{
    public class TransferEventHandler : IEventHanler<TransferCreatedEvent>
    {
        private readonly ITransferLogRepository _transferLogRepository;
        public TransferEventHandler(ITransferLogRepository transferLogRepository)
        {
            _transferLogRepository = transferLogRepository;
        }
        public Task Handle(TransferCreatedEvent @event)
        {
            _transferLogRepository.Add(new TransferLog()
            {
                FromAccount = @event.From,
                ToAccount = @event.To,
                TransferAmount = @event.Amount,
            });
            return Task.CompletedTask;
        }
    }
}
