using Microsoft.AspNetCore.Components;

namespace Client.Layout;

public partial class NavMenu
{
    [Parameter]
    public bool IsDrawerOpen { get; set; } = true;
}
