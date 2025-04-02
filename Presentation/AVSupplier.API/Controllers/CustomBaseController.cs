﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AVSupplier.API.CustomAttributes;

namespace AVSupplier.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [CustomAuthorize]
    public class CustomBaseController : ControllerBase
    {
        //private readonly ICommonRepository _ICommonRepository;

        //public CommonController(ICommonRepository iCommonRepository)
        //{
        //    _ICommonRepository = iCommonRepository;
        //}

        //[HttpPost("CheckAPI")]
        //public async Task<IActionResult> CheckAPIPost(Common request)
        //{
        //    return Ok(await _ICommonRepository.CheckName(request));
        //}

        //[HttpGet("CheckAPI")]
        //public async Task<IActionResult> CheckAPIGet()
        //{
        //    return Ok(await _ICommonRepository.CheckList());
        //}
    }
}
