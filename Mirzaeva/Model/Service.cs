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
    
    public partial class Service
    {
        public Service()
        {
            this.Records = new HashSet<Records>();
        }
    
        public int service_id { get; set; }
        public string service_name { get; set; }
        public string service_price { get; set; }
        public byte[] service_photo { get; set; }
    
        public virtual ICollection<Records> Records { get; set; }
    }
}
