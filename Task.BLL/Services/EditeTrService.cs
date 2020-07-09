using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Task.BLL.DTO;
using Task.DAL;
using Task.DAL.Entities;

namespace Task.BLL.Services
{
    public class EditeTrService
    {
        private readonly TaskContext db = new TaskContext();
        public void Execute(TransactionDTO transactionDTO)
        {

            try
            {
                DAL.Entities.Type type = db.Types.Find(transactionDTO.TypeId);
            Status status = db.Statuses.Find(transactionDTO.StatusId);
            Taransactions trEntity = new Taransactions()
            {
                Id = transactionDTO.Id,
                ClientName = transactionDTO.ClientName,
                Amount = transactionDTO.Amount,
                TransactionStatus = status,
                StatusId = transactionDTO.StatusId,
                TransactionType = type,
                TypeId = transactionDTO.TypeId

            };


           

                db.Entry(trEntity).State = EntityState.Modified;
                db.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
       
    }
}
