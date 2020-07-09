using System;
using System.Collections.Generic;
using System.Text;
using Task.BLL.DTO;
using Task.DAL;
using Task.DAL.Entities;

namespace Task.BLL.Services
{
     public  class DeleteTrService
    {
        private readonly TaskContext db = new TaskContext();
        public void DelTransactions(TransactionDTO delTransactionsDTO)
        {
           


            try
            {
                DAL.Entities.Type type = db.Types.Find(delTransactionsDTO.TypeId);
                Status status = db.Statuses.Find(delTransactionsDTO.StatusId);
                Taransactions delTransaction = new Taransactions()
                {
                    Id = delTransactionsDTO.Id,
                    ClientName= delTransactionsDTO.ClientName,
                    Amount= delTransactionsDTO.Amount,
                    TransactionStatus= status,
                    StatusId= delTransactionsDTO.StatusId,
                    TransactionType=type,
                    TypeId= delTransactionsDTO.TypeId

                };

                db.Taransactionses.Remove(delTransaction);
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
           
       
    }
}
