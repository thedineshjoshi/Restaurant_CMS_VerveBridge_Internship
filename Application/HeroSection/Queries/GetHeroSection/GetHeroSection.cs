﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.HeroSection.Queries.GetHeroSection
{
    public class GetHeroSectionQuery : IRequest<HeroSectionDto>
    {
    }
}
