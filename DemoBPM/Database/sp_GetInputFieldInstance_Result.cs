//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DemoBPM.Database
{
    using System;
    
    public partial class sp_GetInputFieldInstance_Result
    {
        public int ID { get; set; }
        public Nullable<int> InputFieldID { get; set; }
        public Nullable<int> StepInstanceID { get; set; }
        public Nullable<int> RequestInstanceID { get; set; }
        public byte[] FileContent { get; set; }
        public string FileName { get; set; }
        public string TextAnswer { get; set; }
        public Nullable<int> InputFieldTypeID { get; set; }
        public string Title { get; set; }
    }
}
