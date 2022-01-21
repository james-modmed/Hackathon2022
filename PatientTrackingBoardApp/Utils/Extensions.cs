using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PatientTrackingBoardApp.Utils.Extensions
{
    public static partial class IJSRuntimeExtensions
    {
        public static async Task<bool> FullScreen(this IJSRuntime jsRuntime)
        {
            return await jsRuntime.InvokeAsync<bool>("requestFullScreen");
        }

        public static async Task<bool> CloseFullScreen(this IJSRuntime jsRuntime)
        {
            return await jsRuntime.InvokeAsync<bool>("closeFullScreen");
        }
    }
}
