﻿using Application.Common.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.TeamMembers.Queries
{
    public class GetAllTeamMembersQuery : IRequest<List<TeamMemberDto>>
    {
    }

    public class GetAllTeamMembersQueryHandler : IRequestHandler<GetAllTeamMembersQuery, List<TeamMemberDto>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllTeamMembersQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<TeamMemberDto>> Handle(GetAllTeamMembersQuery request, CancellationToken cancellationToken)
        {
            var teamMembers = await _context.TeamMembers.ToListAsync(cancellationToken);

            return teamMembers.Select(member => new TeamMemberDto
            {
                Id = member.id,
                Name = member.Name,
                Position = member.Designation,
                ImageUrl = member.ImageUrl,
                FacebookLink = member.FacebookLink,
                TwitterLink = member.TwitterLink,
                InstagramLink = member.InstagramLink
            }).ToList();
        }
    }
}
