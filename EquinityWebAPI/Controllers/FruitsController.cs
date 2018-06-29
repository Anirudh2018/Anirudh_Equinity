#region History
///----------------------History------------------------------------------------------------------------------------------------------------------------------
///      Date       |    ModifidBy     |         TaskID           |   Changes
/// ----------------------------------------------------------------------------------------------------------------------------------------------------------
///   29-08-2018      Anirudh Jaiswal    System Test(200 ok)        Created GetAllFruits(),GetFruitsById(),PostNewFruit(),PutExistingFruit(),DeleteFruitById()
#endregion

#region Namespace
using System.Collections.Generic;
using System.Web.Http;
#endregion

namespace EquinityWebAPI.Controllers
{
    
    public class FruitsController : ApiController
    {

        #region Created fruits collection
        static List<string> fruits = new List<string>
        {
            "Mango","Banana","Apple","Orange"
        };
        #endregion

        #region Get all the fruits available
        // GET api/fruits
        // Sample URI : http://localhost:52395/api/Fruits
        public IEnumerable<string> GetAllFruits()
        {
            return fruits;
        }
        #endregion

        #region Get fruit by its unique id
        // GET api/values/5
        public string GetFruitsById(int id)
        {
            return fruits[id];
        }
        #endregion

        #region Add new fruit by to the fruits collection
        // POST api/values
        public void PostNewFruit([FromBody]string newFruit)
        {
            fruits.Add(newFruit);
        }
        #endregion

        #region Edit existing fruit by its id
        // PUT api/values/5
        public void PutExistingFruit(int id, [FromBody]string editFruitName)
        {
            fruits[id] = editFruitName;
        }
        #endregion

        #region Delete fruit from the fruits collection by its id
        // DELETE api/values/5
        public void DeleteFruitById(int id)
        {
            fruits.RemoveAt(id);
        }
        #endregion
    }
}
