//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace trainer
{
    using System;
    using System.Collections.Generic;
    
    public partial class CONSIGNMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CONSIGNMENT()
        {
            this.MANUFACTURER = new HashSet<MANUFACTURER>();
        }
    
        public int IDCONSIGMENT { get; set; }
        public int BATCHSIZE { get; set; }
        public int PRICE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MANUFACTURER> MANUFACTURER { get; set; }
    }
}
