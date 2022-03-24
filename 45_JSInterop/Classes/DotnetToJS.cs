using Microsoft.JSInterop;
using System.Threading.Tasks;

namespace JavaScriptInterop.Classes
{
    public class DotnetToJS : IDotnetToJS
    {
        private readonly IJSRuntime _jS;

        public DotnetToJS(IJSRuntime jS)
        {
            _jS = jS;
        }

        public async Task PrintAsync(int counter)
        {
            await _jS.InvokeVoidAsync("logUser", counter);
        }
    }
}
