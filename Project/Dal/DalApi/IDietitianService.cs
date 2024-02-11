﻿using Dal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal.DalApi
{
    public interface IDietitianService : Icrud<Dietitian>
    {
        public List<Meeting> GetMeetingsById(int id);
    }
}
