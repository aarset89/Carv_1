using DataClass;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ModelsClass.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace carv_1.Controllers.Api
{
    [Route("api/documents")]
    [ApiController]
    public class DocumentsController : ControllerBase
    {
        [Route("getDocumentTypes")]
        [HttpGet]
        public ActionResult GetDocuments()
        {

            Documents_Data documents_Business = new Documents_Data();
            var output = documents_Business.GetDocuments();
            switch (output.Result)
            {
                case (Result.error):
                    return StatusCode(500, output);
                default:
                    return Ok(output);
            }

        }
    }
}
