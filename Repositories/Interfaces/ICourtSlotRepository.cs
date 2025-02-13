﻿using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
    public interface ICourtSlotRepository
    {
        List<CourtSlot> GetCourtSlots();

        CourtSlot? GetCourtSlotById(int id);

        bool CreateCourtSlot(CourtSlot courtSlot);

        bool UpdateCourtSlot(CourtSlot courtSlot);
    }
}
