using System;
using System.Collections.Generic;
using System.Text;
using Task.BLL.DTO;
using Task.DAL;

namespace Task.BLL.Services
{
    public class TypeService
    {
        private readonly TaskContext db = new TaskContext();

        public IEnumerable<TypeDTO> GetAllStatus()
        {
            List<TypeDTO> typeList = new List<TypeDTO>();

            foreach (DAL.Entities.Type s in db.Types)
            {
                typeList.Add(
                    new TypeDTO()
                    {
                        Id = s.Id,
                        Name = s.Name
                    });
            }

            return typeList;
        }
    }
}
