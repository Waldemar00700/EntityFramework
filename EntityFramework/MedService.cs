//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedService
    {
        public int Id { get; set; }
        public int ChildId { get; set; }
        public System.DateTime Day { get; set; }
        public double Weight { get; set; }
        public double Height { get; set; }
    
        public virtual Child Child { get; set; }
    }
}
