using BusinessObjects;
using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CourtSlotService : ICourtSlotService
    {
        private readonly ICourtSlotService courtSlotService;

        public CourtSlotService(ICourtSlotService courtSlotService)
        {
            this.courtSlotService = courtSlotService;
        }
        public bool CreateCourtSlot(CourtSlot courtSlot)
        {
            return courtSlotService.CreateCourtSlot(courtSlot);
        }

        public CourtSlot? GetCourtSlotById(int id)
        {
            return courtSlotService.GetCourtSlotById(id);
        }

        public List<CourtSlot> GetCourtSlots()
        {
            return courtSlotService.GetCourtSlots();
        }

        public bool UpdateCourtSlot(CourtSlot courtSlot)
        {
            return courtSlotService.UpdateCourtSlot(courtSlot);
        }
    }
}
