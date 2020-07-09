using System;
using System.Collections.Generic;
using System.Text;
using Task.BLL.DTO;
using Task.DAL;
using Task.DAL.Entities;

namespace Task.BLL.Services
{
   public class StatusService
    {
        private readonly TaskContext db = new TaskContext();

        public IEnumerable<StatusDTO> GetAllStatus()
        {
            List<StatusDTO> statusList = new List<StatusDTO>();
            
            foreach (Status s in db.Statuses)
            {
                statusList.Add(
                    new StatusDTO()
                    {
                        Id = s.Id,
                        Name = s.Name
                    });
            }

            return statusList;
        }
    }
}
