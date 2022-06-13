using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject3.Services;

namespace TestProject3.Tests
{
    public class TestPet
    {
        [Test]
        [Category("APITests")]
        public static void API_tests()
        {
            Pet client = new Pet();

            client.Get_Response();
            client.Post_Response();
            client.Put_Response();
            client.Delete_Response();
        }
    }
}
