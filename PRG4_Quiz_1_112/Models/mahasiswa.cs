using System.ComponentModel.DataAnnotations;

namespace PRG4_Quiz_1_112.Models
{
    public class mahasiswa
    {
        [Required(ErrorMessage = "Id wajib diisi")]
        public int id { get; set; }

        [Required(ErrorMessage = "Nama wajib diisi")]
        [MaxLength(30, ErrorMessage = "Nama Maksimal 30 Karakter")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Nama Hanya Boleh Berupa Huruf")]
        public string nama { get; set; }

        [Required(ErrorMessage = "Program Studi wajib diisi")]
        [MaxLength(30, ErrorMessage = "Program Studi Maksimal 30 Karakter")]
        [RegularExpression("^[a-zA-Z ]*$", ErrorMessage = "Program Studi Hanya Boleh Berupa Huruf")]
        public string program_studi { get; set; }


        [Required(ErrorMessage = "Angkatan Wajib Diisi")]
        public int angkatan { get; set; }
    }
}
