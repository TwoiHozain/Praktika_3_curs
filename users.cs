//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EducationalSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class users
    {
        public int id { get; set; }
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public Nullable<int> UserRole { get; set; }
    
        public virtual roles roles { get; set; }
    }
}
