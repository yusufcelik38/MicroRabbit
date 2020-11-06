using MicroRabbit.Domain.Core.Events;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MicroRabbit.Domain.Core.Bus
{
    public interface IEventHanler<in TEvent> : IEventHanler
        where TEvent : Event
    {
        Task Handle(TEvent @event);
    }
    public interface IEventHanler
    {

    }
}
