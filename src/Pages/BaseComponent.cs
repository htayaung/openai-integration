using Microsoft.AspNetCore.Components;

namespace OpenAIIntegration.Pages;

public abstract class BaseComponent : ComponentBase
{
    [Inject]
    protected IConfiguration Configuration { get; set; }

    protected OpenAI_API.OpenAIAPI API;

    protected override Task OnInitializedAsync()
    {
        API = new OpenAI_API.OpenAIAPI(Configuration["OpenAI_API_KEY"]);

        return base.OnInitializedAsync();
    }
}
