using DapperTicketEaseWebAPI.Models.BURepo;
using DapperTicketEaseWebAPI.Models.Data;
using DapperTicketEaseWebAPI.Models.DepartmentRepository;
using DapperTicketEaseWebAPI.Models.Repo;
using DapperTicketEaseWebAPI.Models.TicketRepository;
using DapperTicketEaseWebAPI.Models.TicketCommentsRepository;
using DapperTicketEaseWebAPI.Models.RequestRepository;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

/////////////////////////////////////////////////////////////////
var config = builder.Configuration;

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidIssuer = config["JWTSettings:Issuer"],
        ValidAudience = config["JWTSettings:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(config["JWTSettings:Key"])),
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ClockSkew = TimeSpan.Zero
    };

    options.Events = new JwtBearerEvents
    {
        OnTokenValidated = context =>
        {
            // Renew expiration time on each request
            var newExpiration = DateTime.UtcNow.AddSeconds(30); // Set your desired expiration time
            context.Properties.Items[".Token.Expires"] = newExpiration.ToString();

            return Task.CompletedTask;
        }
    };
});

builder.Services.AddAuthorization();

//builder.Services.AddAuthorization(options =>
//{
//    options.AddPolicy(IdentityData.AdminUserPolicyName, p =>
//    p.RequireClaim(IdentityData.AdminUserClaimName, "true"));
//});
/////////////////////////////////////////////////////////////////

//////////////////////////////////////////////////////////////////////////
var MyAllowSpecificOrigins = "corspolicy";

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: MyAllowSpecificOrigins,
                      policy =>
                      {
                          policy.WithOrigins("*").AllowAnyMethod().AllowAnyHeader();
                      });
});

//////////////////////////////////////////////////////////////////////////


builder.Services.AddControllers();

/////////////////////////////////////////////////////////////////////////////////////
builder.Services.AddTransient<DapperDBContext>();
builder.Services.AddTransient<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddTransient<IRequestRepo, RequestRepo>();
builder.Services.AddTransient<IBURepo, BURepo>();
builder.Services.AddTransient<IDepartmentRepo, DepartmentRepo>();
builder.Services.AddTransient<ITicketCommentsRepo,TicketCommentsRepo>();
builder.Services.AddTransient<ITicketRepo, TicketRepo>();
////////////////////////////////////////////////////////////////////////////////////

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

///////////////////////////////////////
app.UseCors(MyAllowSpecificOrigins);
///////////////////////////////////////
///
app.UseHttpsRedirection();

//////////////////
app.UseAuthentication();
///////////////////


app.UseAuthorization();

app.MapControllers();

app.Run();
