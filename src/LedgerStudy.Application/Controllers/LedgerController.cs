using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LedgerStudy.Cqrs.Request;
using MediatR;

namespace LedgerStudy.Application.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LedgerController : ControllerBase
    {
        private readonly IMediator _mediator;

        public LedgerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("create-batch")]
        public async Task<IActionResult> CreateBatch(CreateBatchRequest request)
        {
            var result = await _mediator.Send(request);
            return Created("Ledger", result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAccountBalance(GetAccountBalanceRequest request)
        {
            var result = await _mediator.Send(request);
            return Ok(request);
        }

    }
}
