using System;
using System.Collections.Generic;
using System.Text;

namespace Task.DAL.Entities
{
    /// <summary>
    /// Model our Entity
    /// </summary>
    public class Taransactions
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public double Amount { get; set; }
        public Status TransactionStatus { get; set; }
        public int StatusId { get; set; }
        public Type TransactionType { get; set; }
        public int TypeId { get; set; }
    }
}
