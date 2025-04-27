using Microsoft.AspNetCore.Mvc;
using tpmodul10_103022300104.Models;
using System.Collections.Generic;
using tpmodul10_103022300104;

namespace tpmodul10_103022300104.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        private static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa { Nama = "Riza Muhammad Putra", Nim = "103022300104" },
            new Mahasiswa { Nama = "Tubagus Aulia Aariz Hibatullah Haykel ", Nim = "103022300141" },
            new Mahasiswa { Nama = "Irfan Rangga Miftahurrizqi", Nim = "103022300100" },
            new Mahasiswa { Nama = "Gamaliel Pradana Pangestu", Nim = "103022300015" },
            new Mahasiswa { Nama = "Muhammad Razky Abdie Pratama", Nim = "103022300047" },
            new Mahasiswa { Nama = "Christofer Abel Maximus Ruri", Nim = "103022300039" }
        };

        [HttpGet]
        public ActionResult<IEnumerable<Mahasiswa>> Get()
        {
            return ListMahasiswa;
        }

        [HttpGet("{index}")]
        public ActionResult<Mahasiswa> Get(int index)
        {
            if (index < 0 || index >= ListMahasiswa.Count)
                return NotFound();
            return ListMahasiswa[index];
        }

        [HttpPost]
        public ActionResult Post([FromBody] Mahasiswa mhs)
        {
            ListMahasiswa.Add(mhs);
            return Ok();
        }

        [HttpDelete("{index}")]
        public ActionResult Delete(int index)
        {
            if (index < 0 || index >= ListMahasiswa.Count)
                return NotFound();
            ListMahasiswa.RemoveAt(index);
            return Ok();
        }
    }
}