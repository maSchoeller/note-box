using MaSchoeller.NoteBox.ServerHost.Components;
using MaSchoeller.NoteBox.ServerHost.Services;
using Microsoft.Data.Sqlite;

var builder = WebApplication.CreateBuilder(args);

var sqliteBuilder = new SqliteConnectionStringBuilder()
{
    DataSource = @".\noteBox.db",
};
builder.Services.AddSqlite<BoxNoteDbContext>(sqliteBuilder.ToString());

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveWebAssemblyComponents();

var app = builder.Build();

await using (var scope = app.Services.CreateAsyncScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<BoxNoteDbContext>();
    var created = await dbContext.Database.EnsureCreatedAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    _ = app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveWebAssemblyRenderMode()
    .AddAdditionalAssemblies(typeof(MaSchoeller.NoteBox.WebClient._Imports).Assembly);

app.Run();
