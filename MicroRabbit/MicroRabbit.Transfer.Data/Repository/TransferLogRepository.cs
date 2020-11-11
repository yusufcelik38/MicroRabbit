using MicroRabbit.Transfer.Data.Context;
using MicroRabbit.Transfer.Domain.Interfaces;
using MicroRabbit.Transfer.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MicroRabbit.Transfer.Data.Repository
{
    public class TransferLogRepository : ITransferLogRepository
    {
        private TransferDbContext _dbContext;

        public TransferLogRepository(TransferDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Add(TransferLog transfer)
        {
            _dbContext.Add(transfer);
            _dbContext.SaveChanges();
        }

        public IEnumerable<TransferLog> GetTransferLogs()
        {
            return _dbContext.TransferLogs;
        }
    }
}
