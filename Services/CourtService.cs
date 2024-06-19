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
    public class CourtService : ICourtService
    {
        private readonly ICourtRepository courtRepository;

        public CourtService(ICourtRepository courtRepository)
        {
            this.courtRepository = courtRepository;
        }
        public bool CreateCourt(Court court)
        {
            return courtRepository.CreateCourt(court);
        }

        public Court? GetCourtById(int id)
        {
            return courtRepository.GetCourtById(id);
        }

        public List<Court> GetCourts()
        {
            return courtRepository.GetCourts();
        }

        public bool UpdateCourt(Court court)
        {
            return courtRepository.UpdateCourt(court);
        }
    }
}
