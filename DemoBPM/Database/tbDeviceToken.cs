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
    using System.Collections.Generic;
    
    public partial class tbDeviceToken : DemoBPM.Common.APISupport.SEObject
    {
        public int ID { get; set; }
        public Nullable<int> UserID { get; set; }
        public string DeviceToken { get; set; }
        public Nullable<bool> IsLogin { get; set; }
    
        public virtual tbUser tbUser { get; set; }
    }
}
