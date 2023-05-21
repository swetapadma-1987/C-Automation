using System;
using NUnit.Framework;
using NUnit.Framework.Api;
using Services.BoredAPI;
using System.Threading.Tasks;

namespace Apitest2.BoredApi
{

    public class BoredAPiTest
    {
        [Test]
        [Category("Tests")]
        
        public async Task API_Test() 
        {

            Services.BoredAPI.BoredApi test = new Services.BoredAPI.BoredApi();
            var response = await test.Get_200Ok();
            Assert.IsNotNull(response);
            
                  }




    }






}
