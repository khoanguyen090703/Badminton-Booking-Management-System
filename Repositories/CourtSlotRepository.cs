using BusinessObjects;
using DataAccessLayer;
using Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CourtSlotRepository : ICourtSlotRepository
    {
        public bool CreateCourtSlot(CourtSlot courtSlot)
            => CourtSlotDAO.CreateCourtSlot(courtSlot);

        public CourtSlot? GetCourtSlotById(int id)
            => CourtSlotDAO.GetCourtById(id);

        public List<CourtSlot> GetCourtSlots()
            => CourtSlotDAO.GetCourtSlots();

        public bool UpdateCourtSlot(CourtSlot courtSlot)
            => CourtSlotDAO.UpdateCourtSlot(courtSlot);
    }
}
