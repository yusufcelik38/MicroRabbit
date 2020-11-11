using MicroRabbit.MVC.Models.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Services
{
    public interface ITransferService
    {
        Task Tranfer(TransferDto transferDto);
    }
}
