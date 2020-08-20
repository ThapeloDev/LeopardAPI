using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace LeopardAPI.Pages
{
    public class Index_Tests : LeopardAPIWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
