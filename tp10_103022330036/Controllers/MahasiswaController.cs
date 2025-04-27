using tp10_103022330036.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using tp10_103022330036.Models;

namespace MahasiswaAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        // Static list untuk menyimpan data Mahasiswa
        private static List<Mahasiswa> mahasiswas = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "LeBron James", Nim = "1302000001" },
            new Mahasiswa { Nama = "Stephen Curry", Nim = "1302000002" },
            new Mahasiswa { Nama = "John Doe", Nim = "1302000003" }
        };

        // GET: api/mahasiswa
        [HttpGet]
        public ActionResult<List<Mahasiswa>> GetAll()
        {
            return mahasiswas;
        }

        // GET: api/mahasiswa/{index}
        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> GetByIndex(int index)
        {
            if (index < 0 || index >= mahasiswas.Count)
            {
                return NotFound();
            }
            return mahasiswas[index];
        }

        // POST: api/mahasiswa
        [HttpPost]
        public ActionResult<List<Mahasiswa>> AddMahasiswa([FromBody] Mahasiswa mahasiswa)
        {
            mahasiswas.Add(mahasiswa);
            return mahasiswas;
        }

        // DELETE: api/mahasiswa/{index}
        [HttpDelete("{index}")]
        public ActionResult<List<Mahasiswa>> DeleteMahasiswa(int index)
        {
            if (index < 0 || index >= mahasiswas.Count)
            {
                return NotFound();
            }
            mahasiswas.RemoveAt(index);
            return mahasiswas;
        }
    }
}
