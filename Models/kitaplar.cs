//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BookInfo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class kitaplar
    {
        public int ID { get; set; }
        public string kitap_adi { get; set; }
        public string kitap_yazari { get; set; }
        public Nullable<System.DateTime> yayin_tarihi { get; set; }
        public Nullable<int> kitap_turID { get; set; }
        public byte[] kitap_kapagi { get; set; }
        public string kitap_aciklama { get; set; }
        public Nullable<int> kitap_dilID { get; set; }
    
        public virtual kitap_diller kitap_diller { get; set; }
        public virtual kitap_turler kitap_turler { get; set; }
    }
}
