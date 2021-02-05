using TP1.Database.Contracts;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1.Entities
{
    [Table(AuthorContract.AUTHOR_TABLE)]
    public class Author
    {
        private long id;
        private string firstname;
        private string lastname;
        private Author authorInst;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(AuthorContract.AUTHOR_COLUMN_ID)]
        public long Id { get => id; set => id = value; }
        
        [Column(AuthorContract.AUTHOR_COLUMN_FIRSTNAME)]
        [Required]
        public string Firstname { get => firstname; set => firstname = value; }
        
        [Column(AuthorContract.AUTHOR_COLUMN_LASTNAME)]
        [Required]
        public string Lastname { get => lastname; set => lastname = value; }
        
        public Author AuthorInst { get => authorInst; set => authorInst = value; }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}