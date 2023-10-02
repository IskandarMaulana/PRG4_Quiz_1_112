using Microsoft.AspNetCore.Mvc;
using PRG4_Quiz_1_112.Models;

namespace PRG4_Quiz_1_112.Controllers
{
    public class mahasiswaController : Controller
    {
        private static List<mahasiswa> mhs = InitializeData();

        private static List<mahasiswa> InitializeData()
        {
            List<mahasiswa> InitialData = new List<mahasiswa>
            {
                new mahasiswa
                {
                    id = 1,
                    nama = "Maulana",
                    program_studi    = "MI",
                    angkatan = 2023
                },
                new mahasiswa
                {
                    id = 2,
                    nama = "Iskandar",
                    program_studi    = "MI",
                    angkatan = 2023
                }
            };
            return InitialData;
        }
        public IActionResult Index()
        {
            List<mahasiswa> mhsList = mhs.ToList();
            return View(mhsList);
        }

        public IActionResult form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult form(mahasiswa mhsiswa)
        {
            if (ModelState.IsValid)
            {
                int new_id = 1;
                while (mhs.Any(b => b.id == new_id))
                {
                    new_id++;
                }

                mhsiswa.id = new_id;

                mhs.Add(mhsiswa);

                TempData["SuccessMessage"] = "Data Berhasil Ditambahkan";

                return RedirectToAction("Index");
            }
            return View(mhsiswa);
        }
    }
}
