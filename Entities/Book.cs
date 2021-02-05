using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1.Database.Contracts;

namespace TP1.Entities
{
    [Table(BookContract.BOOK_TABLE)]
    public class Book
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column(BookContract.BOOK_COLUMN_ID)]
        private long id;

        [Column(BookContract.BOOK_COLUMN_NAME)]
        [Required]
        private string name;
        
        [Column(BookContract.BOOK_COLUMN_NB_PAGE)]
        [Required]
        private int nb_page;

        public long Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Nb_page { get => nb_page; set => nb_page = value; }
    }
}
