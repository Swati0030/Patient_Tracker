using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Patient_Tracker_BAL.Services.AuthenticationLogin;
using Patient_Tracker_BAL.Services.Clerk;
using Patient_Tracker_BAL.Services.ClerkDetails;
using Patient_Tracker_BAL.Services.Doctor;
using Patient_Tracker_BAL.Services.Patients;
using Patient_Tracker_DAL.Contracts;
using Patient_Tracker_DAL.Repositories;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(Options =>
{
    Options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))


    };



});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddScoped<IRegisterDoctorDetails, RegisterDoctorDetails>();
builder.Services.AddScoped<IServiceClerkDoctorRegistration, ServiceClerkDoctorRegistration>();
builder.Services.AddScoped<IPatientRegisterDetail, RegisterPatientDetails>();
builder.Services.AddScoped<IServiceClerkPatientRegistration, ServiceClerkPatientRegistration>();
builder.Services.AddScoped<IPatientAddFeedback, PatientAddFeedback>();
builder.Services.AddScoped<IServicePatientAddFeedback, ServicePatientAddFeedback>();
builder.Services.AddScoped<IDoctorAddPrescription, DoctorAddPrescriptionDetails>();
builder.Services.AddScoped<IServiceDoctorAddPrescription, ServiceDoctorAddPrescription>();
builder.Services.AddScoped<IClerkGenerateMedicineBills, ClerkGenerateMedicineBills>();
builder.Services.AddScoped<IServiceGenerateMedicineBills, ServiceClerkGenerateMedicineBills>();
builder.Services.AddScoped<IClerkMedicineDetails, ClerkMedicineDetails>();
builder.Services.AddScoped<IServiceClerkMedicineDetails, ServiceAddMedicineDetails>();

builder.Services.AddScoped<ILogin, LoginRepository>();
builder.Services.AddScoped<IServiceLogin, ServiceLogin>();

builder.Services.AddScoped<IAddClerkDetails, SaveClerkDetails>();
builder.Services.AddScoped<IServiceClerkDetails, ServiceClerkDetails>();





var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.UseAuthentication();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
