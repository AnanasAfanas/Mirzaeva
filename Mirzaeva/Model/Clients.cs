//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mirzaeva.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Clients
    {
        public Clients()
        {
            this.Records = new HashSet<Records>();
        }
    
        public int client_id { get; set; }
        public string client_name { get; set; }
        public string client_phone { get; set; }
        public byte[] client_photo { get; set; }
    
        public virtual ICollection<Records> Records { get; set; }
    }
}
