﻿using System;

namespace Epicenter.Domain.Services.DTO.Face.Responses
{
    public struct TrainingStatusResponse
    {
        public string Status { get; set; }
        public string CreatedDateTime { get; set; }
        public string LastActionDateTime { get; set; }
        public string Message { get; set; }

        public DateTime GetCreatedDateTime()
        {
            DateTime.TryParse(CreatedDateTime, out DateTime dateTime);
            return dateTime;
        }

        public DateTime GetLastActionDateTime()
        {
            DateTime.TryParse(LastActionDateTime, out DateTime dateTime);
            return dateTime;
        }

        public PersonGroupTrainingStatus GetPersonGroupTrainingStatus()
        {
            Enum.TryParse(Status, true, out PersonGroupTrainingStatus status);
            return status;
        }
    }

    public enum PersonGroupTrainingStatus
    {
        notstarted,
        running,
        succeeded,
        failed
    }
}
