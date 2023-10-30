using Microsoft.JSInterop;

namespace MaSchoeller.NoteBox.WebClient.Layout;

public partial class MainLayout
{
    private readonly IJSObjectReference? _jsModule;
    private bool _isDark = true;
}
