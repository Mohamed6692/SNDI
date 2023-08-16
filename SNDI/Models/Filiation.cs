using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SNDI.Models
{
    public class Filiation
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string? id { get; set; }
        public string? NomPere { get; set; }
        public string? PrenomPere { get; set; }
        public DateTime? DateDenaissancePere { get; set; }
        public string? LieuxNaissancePere { get; set; }
        public string? NomMere { get; set; }
        public string? PrenomMere { get; set; }
        public DateTime? DateDenaissanceMere { get; set; }
        public string? LieuxNaissanceMere { get; set; }

        // Clé étrangère pour le Document
        public string? DocumentId { get; set; }

        [ForeignKey("DocumentId")]
        public Document? Document { get; set; }
    }
}
