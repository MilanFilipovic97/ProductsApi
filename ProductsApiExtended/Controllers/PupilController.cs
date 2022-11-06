using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductsApiExtended.Models;

namespace ProductsApiExtended.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PupilController : ControllerBase
    {

        private readonly IMapper _mapper;   
        
        public PupilController(IMapper mapper)
        {
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        //[HttpPost]
        //public async Task<ActionResult<Pupil>> CreatePupil()
        //{


        //}
    }
}
