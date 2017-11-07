using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Homework_04.Models
{
    public class Survey
    {
        public string SurveyId { get; set; }
        public string QuestionText { get; set; }
        public string StudyId { get; set; }
    }

    public class SurveyResponse
    {
        public string SurveyId { get; set; }
        public string UserId { get; set; }
        public string SurveyResponseId { get; set; }
        public string StudyId { get; set; }
        public string UserResponseText { get; set; }
    }

    public class StudyGroup
    {
        public string StudyGroupId { get; set; }
        public string StudyName { get; set; }
        public string StudyCoordinatorId { get; set; }
    }
}