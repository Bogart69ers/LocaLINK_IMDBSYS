//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LocaLINK
{
    using System;
    using System.Collections.Generic;
    
    public partial class User_Role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User_Role()
        {
            this.User_Account = new HashSet<User_Account>();
        }
    
        public int roleId { get; set; }
        public string rolename { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User_Account> User_Account { get; set; }
        public virtual User_Role User_Role1 { get; set; }
        public virtual User_Role User_Role2 { get; set; }
    }
}