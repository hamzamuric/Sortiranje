//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sortiranje
{
    using System;
    using System.Collections.Generic;
    
    public partial class Vremena
    {
        public string username { get; set; }
        public long time { get; set; }
        public Nullable<int> bubble { get; set; }
        public Nullable<int> quick { get; set; }
        public Nullable<int> bst { get; set; }
    
        public virtual User User { get; set; }
    }
}
