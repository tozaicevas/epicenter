﻿using System.Collections.Generic;

namespace Epicenter.Domain.Services.DTO.Face.Responses
{
    public struct IdentifyResponse
    {
        public string FaceId { get; set; }
        public List<Candidate> Candidates { get; set; }
    }

    public struct Candidate
    {
        public string PersonId { get; set; }
        public double Confidence { get; set; }
    }
}
