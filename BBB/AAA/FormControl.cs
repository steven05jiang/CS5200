//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AAA
{
    using System;
    using System.Collections.Generic;
    
    public partial class FormControl
    {
        public FormControl()
        {
            this.FormControlOptions = new HashSet<FormControlOption>();
        }
    
        public int Id { get; set; }
        public string defaultValue { get; set; }
        public string dataType { get; set; }
        public string type { get; set; }
        public Nullable<int> formId { get; set; }
    
        public virtual Form Form { get; set; }
        public virtual ICollection<FormControlOption> FormControlOptions { get; set; }
    }
}
