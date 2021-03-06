namespace HSSystem.DAL.Entites
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ShoppingCartOnlineCustomer")]
    public partial class ShoppingCartOnlineCustomer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShoppingCartOnlineCustomer()
        {
            ShoppingCarts = new HashSet<ShoppingCart>();
        }

        public int ShoppingCartOnlineCustomerID { get; set; }

        [StringLength(10)]
        public string CustomerID { get; set; }

        public int? LoginID { get; set; }

        public Guid TrackingCookie { get; set; }

        public DateTime CreatedOn { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShoppingCart> ShoppingCarts { get; set; }
    }
}
