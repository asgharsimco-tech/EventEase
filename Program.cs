using EventEase.Components;
using EventEase.Services;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
// Scoped services keep each interactive browser circuit isolated.
builder.Services.AddScoped<EventStore>();
builder.Services.AddScoped<UserSession>();
var app = builder.Build();
if (!app.Environment.IsDevelopment()) app.UseExceptionHandler("/error");
app.UseStaticFiles(); app.UseRouting(); app.UseRouting();
app.UseAntiforgery();
app.MapRazorComponents<App>().AddInteractiveServerRenderMode();
app.Run();
