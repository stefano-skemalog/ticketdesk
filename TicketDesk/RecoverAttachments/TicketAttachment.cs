namespace RecoverAttachments
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TicketAttachment
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TicketId { get; set; }

        [Key]
        [Column(Order = 1)]
        public int FileId { get; set; }

        [Required]
        [StringLength(255)]
        public string FileName { get; set; }

        public int FileSize { get; set; }

        [Required]
        [StringLength(100)]
        public string FileType { get; set; }

        [Required]
        [StringLength(100)]
        public string UploadedBy { get; set; }

        public DateTime UploadedDate { get; set; }

        [Required]
        public byte[] FileContents { get; set; }
    }
}
