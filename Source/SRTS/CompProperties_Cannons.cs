﻿using System.Collections.Generic;
using Verse;

namespace SRTS
{
    public class CompProperties_Cannons : CompProperties
    {
        public CompProperties_Cannons()
        {
            this.compClass = typeof(CompCannons);
        }

        public List<CannonHandler> cannons = new List<CannonHandler>();
    }
}
