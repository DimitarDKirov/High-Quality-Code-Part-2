//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeGenerator.Example
{
    using System;
    using System.Collections.Generic;
    
    public partial class ParticipantAnswer
    {
        public int ParticipantId { get; set; }
        public int ContestQuestionId { get; set; }
        public string Answer { get; set; }
    
        public virtual ContestQuestion ContestQuestion { get; set; }
        public virtual Participant Participant { get; set; }
    }
}
