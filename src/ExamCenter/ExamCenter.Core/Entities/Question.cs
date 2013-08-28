﻿using Abp.Entities;
using Abp.Entities.Core;

namespace ExamCenter.Entities
{
    /// <summary>
    /// An question that is used in an exam.
    /// </summary>
    public class Question : AuditedEntity, IHasTenant
    {
        /// <summary>
        /// The tenant account which this entity is belong to.
        /// </summary>
        public virtual Tenant Tenant { get; set; }

        /// <summary>
        /// Question text.
        /// </summary>
        public virtual string QuestionText { get; set; }

        /// <summary>
        /// Answering type.
        /// </summary>
        public virtual AnsweringType AnsweringType { get; set; }

        /// <summary>
        /// Estimated answering type.
        /// </summary>
        public virtual int? EstimatedAnsweringTime { get; set; }

        /// <summary>
        /// Experince degree to be able to answer this question.
        /// </summary>
        public virtual ExperienceDegree? ExperienceDegree { get; set; }

        /// <summary>
        /// If <see cref="AnsweringType"/> is FreeText, this can be used to enter the right answer
        /// </summary>
        public virtual string RightAnswerText { get; set; }
    }
}