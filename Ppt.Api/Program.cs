using Ppt.Shared;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(corsOptions => corsOptions.AddDefaultPolicy(policy =>
    policy.WithOrigins("https://localhost:1111")
    .WithMethods("GET", "DELETE")
    .AllowAnyHeader()
));

var app = builder.Build();

app.UseCors();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

List<VybaveniVm> seznam = VybaveniVm.VratRandSeznam();

List<RevizeViewModel> reviz = new List<RevizeViewModel>();
List<RevizeViewModel> revizSelect;
for (int i = 0; i < 10; i++) {
    reviz.Add(RevizeViewModel.generateRand());
}

app.MapGet("/revize", (String name) =>
{
    revizSelect = null;
    foreach(RevizeViewModel v in reviz)
    {
        if (v.nazev.Contains(name))
            revizSelect.Add(v);
    }
	return reviz;
});

app.MapGet("/vybaveni", () =>
{
    return seznam;
});
app.MapGet("/vybaveni/specific", ()=>{
    
    return seznam[2]; 

});

app.MapGet("/vybaveni/{id}", (Guid id) =>
{
    VybaveniVm? en = seznam.SingleOrDefault(x => x.Id == id);
    if (en is null)
        return Results.NotFound("Item Not Found!");
    return Results.Ok(en);
});

app.UseHttpsRedirection();


app.MapPut("/vybaveni", (VybaveniVm editedModel) =>
{

    var vybaveniVm_Entity = seznam.SingleOrDefault(x => x.Id == editedModel.Id);
    if (vybaveniVm_Entity == null)
        return Results.NotFound("Item Not Found!");
    else
    {
        vybaveniVm_Entity.BoughtDateTime = editedModel.BoughtDateTime;
        vybaveniVm_Entity.LastRevisionDateTime = editedModel.LastRevisionDateTime;
        vybaveniVm_Entity.Name = editedModel.Name;

        return Results.Ok();
    }

});


app.MapDelete("/vybaveni/{id}", (Guid id) =>
{
    var item = seznam.SingleOrDefault(x => x.Id == id);
    if (item == null)
        return Results.NotFound("Item Not Found!");
    seznam.Remove(item);

    return Results.Ok();

});


app.Run();
