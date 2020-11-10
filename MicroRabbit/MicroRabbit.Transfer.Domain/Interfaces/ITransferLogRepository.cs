﻿using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Domain.Interfaces
{
    public interface ITransferLogRepository
    {
        IEnumerable<TransferLog> GetTransferLogs();
    }
}
