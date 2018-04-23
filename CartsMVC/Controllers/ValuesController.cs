using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Swashbuckle.Swagger.Annotations;

namespace CartsMVC.Controllers
{
    /// <summary>
    /// 資料處理 API
    /// </summary>
    public class ValuesController : ApiController
    {

        static Dictionary<int, string> statusDictionary = new Dictionary<int, string>()
        {
            { 1, "Value1"},
            { 2, "Value2"},
            { 3, "Value3"},
        };

        // GET api/values
        /// <summary>
        /// 取得資料
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> Get()
        {
            //return new string[] { "value1", "value2" };
            return (from pair in statusDictionary
                select pair.Value).ToArray();
        }

        // GET api/values/5
        /// <summary>
        /// 取得特定資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ResponseType(typeof(string))]
        [SwaggerResponse(HttpStatusCode.NotFound, "找不到資料")]
        public IHttpActionResult Get(int id)
        {
            //return "value";
            return statusDictionary.ContainsKey(id) ? (IHttpActionResult) Ok(statusDictionary[id]) : NotFound();
        }

        // POST api/values
        /// <summary>
        /// 新增資料
        /// </summary>
        /// <param name="value"></param>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        /// <summary>
        /// 修改資料
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        /// <summary>
        /// 刪除資料
        /// </summary>
        /// <param name="id"></param>
        public void Delete(int id)
        {
        }
    }
}
