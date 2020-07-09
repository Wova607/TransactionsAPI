using System;
using System.Collections.Generic;
using System.Text;

namespace Task.BLL.DTO
{
    public class TransactionDTO
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public double Amount { get; set; }
        public string TransactionStatus { get; set; }
        public int StatusId { get; set; }
        public string TransactionType { get; set; }
        public int TypeId { get; set; }
    }
}
