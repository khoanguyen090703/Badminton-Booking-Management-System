using BusinessObjects;
using Repositories.Interfaces;
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
        private readonly ICourtSlotRepository courtSlotRepository;

        public CourtSlotService(ICourtSlotRepository courtSlotRepository)
        {
            this.courtSlotRepository = courtSlotRepository;
        }
        public bool CreateCourtSlot(CourtSlot courtSlot)
        {
            return courtSlotRepository.CreateCourtSlot(courtSlot);
        }

        public CourtSlot? GetCourtSlotById(int id)
        {
            return courtSlotRepository.GetCourtSlotById(id);
        }

        public List<CourtSlot> GetCourtSlots()
        {
            return courtSlotRepository.GetCourtSlots();
        }

        public bool UpdateCourtSlot(CourtSlot courtSlot)
        {
            return courtSlotRepository.UpdateCourtSlot(courtSlot);
        }
    }
}
