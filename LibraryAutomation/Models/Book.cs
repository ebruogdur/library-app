//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryAutomation.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Book()
        {
            this.Book_Student = new HashSet<Book_Student>();
            this.Book_BookType = new HashSet<Book_BookType>();
        }
    
        public int Id { get; set; }
        public string Name { get; set; }
        public int Page { get; set; }
        public string Author { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public Nullable<System.DateTime> DeletedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> UserID { get; set; }
        public string ImagePath { get; set; }
        public string ISBN { get; set; }
        public int Count { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_Student> Book_Student { get; set; }
        public virtual User User { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Book_BookType> Book_BookType { get; set; }
    }
}