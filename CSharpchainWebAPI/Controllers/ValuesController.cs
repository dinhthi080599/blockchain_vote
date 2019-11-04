using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CSharpChainModel;
using CSharpChainNetwork;

namespace CSharpchainWebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id, int idd)
        {
            return "value";
        }

        [HttpGet]
        public int Length()
        {
             int a = Models.Program.blockchainServices.BlockchainLength();
            return a;
        }

        [HttpGet]
        public Block GetBlock(int Id)
        {
            var block = Models.Program.blockchainServices.get_block(Id);
            return block;
        }

        [HttpGet]
        public Blockchain GetBlockchain()
        {
            var blockChain = Models.Program.blockchainServices.Blockchain;
            var a = blockChain;
            return blockChain;
        }

        // POST api/valuesSystem.NullReferenceException: 'Object reference not set to an instance of an object.'
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
