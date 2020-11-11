using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using FilesWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FilesWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UpldoadController : ControllerBase
    {
/*        [HttpPost("/api/Upload/Upload"), DisableRequestSizeLimit]
        public IActionResult Upload()
        {
            try
            {
                Console.WriteLine("Tut1");
                var file = Request.Form.Files[0];
                Console.WriteLine("Tut2");
                var folderName = Path.Combine("Resources", "Images");
                Console.WriteLine("Tut3");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName);
                Console.WriteLine("Tut4");
                if (file.Length > 0)
                {
                    Console.WriteLine("Tut5");
                    var fileName = ContentDispositionHeaderValue.Parse(file.ContentDisposition).FileName.Trim('"');
                    var fullPath = Path.Combine(pathToSave, fileName);
                    var dbPath = Path.Combine(folderName, fileName);
                    using (var stream = new FileStream(fullPath, FileMode.Create))
                    {
                        file.CopyTo(stream);
                    }
                    return Ok(new { dbPath });
                }
                else
                {
                    return BadRequest();
                }
            }catch(Exception ex)
            {
                return StatusCode(500, $"Server error: {ex}");
            }
        }*/
        [HttpPost("/api/Upload/Upload")]
        [DisableRequestSizeLimit]
        public IActionResult Upload([FromForm] FileModel file)
        {
            try
            {
                var folderName = Path.Combine("Resources", "Images");
                var pathToSave = Path.Combine(Directory.GetCurrentDirectory(), folderName, file.FileName);
                using (var stream = new FileStream(pathToSave, FileMode.Create))
                {
                    file.FormFile.CopyTo(stream);
                }
                var dbPath = folderName + file.FileName;
                return Ok(new { dbPath });
            }
            catch(Exception ex)
            {
                return StatusCode(500, "zhopa");
            }
        }
    }
}
