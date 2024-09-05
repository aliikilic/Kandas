using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kandas.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpireTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                });

            migrationBuilder.CreateTable(
                name: "DonationTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonationTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EducationStatus",
                columns: table => new
                {
                    EducationStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EducationStatus", x => x.EducationStatusId);
                });

            migrationBuilder.CreateTable(
                name: "MovementStatus",
                columns: table => new
                {
                    MovementStatusId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementStatus", x => x.MovementStatusId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictID = table.Column<int>(type: "int", nullable: false),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictID);
                    table.ForeignKey(
                        name: "FK_Districts_Cities_CityID",
                        column: x => x.CityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Recepients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlaceId = table.Column<int>(type: "int", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recepients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Recepients_Cities_BirthPlaceId",
                        column: x => x.BirthPlaceId,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Neighborhoods",
                columns: table => new
                {
                    NeighborhoodId = table.Column<int>(type: "int", nullable: false),
                    NeighborhoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Neighborhoods", x => x.NeighborhoodId);
                    table.ForeignKey(
                        name: "FK_Neighborhoods_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityID");
                    table.ForeignKey(
                        name: "FK_Neighborhoods_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictID");
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospitalName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressCityID = table.Column<int>(type: "int", nullable: false),
                    AddressDistrictID = table.Column<int>(type: "int", nullable: false),
                    AddressNeighbohoodID = table.Column<int>(type: "int", nullable: false),
                    AddressDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Hospitals_Cities_AddressCityID",
                        column: x => x.AddressCityID,
                        principalTable: "Cities",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Hospitals_Districts_AddressDistrictID",
                        column: x => x.AddressDistrictID,
                        principalTable: "Districts",
                        principalColumn: "DistrictID");
                    table.ForeignKey(
                        name: "FK_Hospitals_Neighborhoods_AddressNeighbohoodID",
                        column: x => x.AddressNeighbohoodID,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodId");
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformations",
                columns: table => new
                {
                    PersonalInformationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TcNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthPlaceId = table.Column<int>(type: "int", nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Marriage = table.Column<bool>(type: "bit", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: false),
                    PersonEducationStatusId = table.Column<int>(type: "int", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityId = table.Column<int>(type: "int", nullable: false),
                    ResidanceDistrictId = table.Column<int>(type: "int", nullable: false),
                    ResidanceNeighborhoodId = table.Column<int>(type: "int", nullable: false),
                    BloodType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonalInformations", x => x.PersonalInformationId);
                    table.ForeignKey(
                        name: "FK_PersonalInformations_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalInformations_Cities_BirthPlaceId",
                        column: x => x.BirthPlaceId,
                        principalTable: "Cities",
                        principalColumn: "CityID");
                    table.ForeignKey(
                        name: "FK_PersonalInformations_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityID");
                    table.ForeignKey(
                        name: "FK_PersonalInformations_Districts_ResidanceDistrictId",
                        column: x => x.ResidanceDistrictId,
                        principalTable: "Districts",
                        principalColumn: "DistrictID");
                    table.ForeignKey(
                        name: "FK_PersonalInformations_EducationStatus_PersonEducationStatusId",
                        column: x => x.PersonEducationStatusId,
                        principalTable: "EducationStatus",
                        principalColumn: "EducationStatusId");
                    table.ForeignKey(
                        name: "FK_PersonalInformations_Neighborhoods_ResidanceNeighborhoodId",
                        column: x => x.ResidanceNeighborhoodId,
                        principalTable: "Neighborhoods",
                        principalColumn: "NeighborhoodId");
                });

            migrationBuilder.CreateTable(
                name: "Donations",
                columns: table => new
                {
                    DonationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecepientId = table.Column<int>(type: "int", nullable: false),
                    HospitalId = table.Column<int>(type: "int", nullable: false),
                    DonationTypeId = table.Column<int>(type: "int", nullable: false),
                    NecessityAmount = table.Column<int>(type: "int", nullable: false),
                    NecessityStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donations", x => x.DonationId);
                    table.ForeignKey(
                        name: "FK_Donations_DonationTypes_DonationTypeId",
                        column: x => x.DonationTypeId,
                        principalTable: "DonationTypes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Donations_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "ID");
                    table.ForeignKey(
                        name: "FK_Donations_Recepients_RecepientId",
                        column: x => x.RecepientId,
                        principalTable: "Recepients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonInquiryForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastCheckDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DangerousWork = table.Column<bool>(type: "bit", nullable: false),
                    PreviouslyReject = table.Column<bool>(type: "bit", nullable: false),
                    Acne = table.Column<bool>(type: "bit", nullable: false),
                    PainKiller = table.Column<bool>(type: "bit", nullable: false),
                    Allergic = table.Column<bool>(type: "bit", nullable: false),
                    OtherMedicine = table.Column<bool>(type: "bit", nullable: false),
                    Diarrhea = table.Column<bool>(type: "bit", nullable: false),
                    Vaccine = table.Column<bool>(type: "bit", nullable: false),
                    Dental = table.Column<bool>(type: "bit", nullable: false),
                    ChronicIllness = table.Column<bool>(type: "bit", nullable: false),
                    MoneyDrug = table.Column<bool>(type: "bit", nullable: false),
                    Syphilis = table.Column<bool>(type: "bit", nullable: false),
                    AIDSSuspicion = table.Column<bool>(type: "bit", nullable: false),
                    AIDSRel = table.Column<bool>(type: "bit", nullable: false),
                    Dialysis = table.Column<bool>(type: "bit", nullable: false),
                    UsingDrugs = table.Column<bool>(type: "bit", nullable: false),
                    Insulin = table.Column<bool>(type: "bit", nullable: false),
                    Surgery = table.Column<bool>(type: "bit", nullable: false),
                    Cardiovascular = table.Column<bool>(type: "bit", nullable: false),
                    Epilepsy = table.Column<bool>(type: "bit", nullable: false),
                    Cancer = table.Column<bool>(type: "bit", nullable: false),
                    Diabetes = table.Column<bool>(type: "bit", nullable: false),
                    BloodDisease = table.Column<bool>(type: "bit", nullable: false),
                    Jaundice = table.Column<bool>(type: "bit", nullable: false),
                    JaundiceAtHome = table.Column<bool>(type: "bit", nullable: false),
                    Toxoplasma = table.Column<bool>(type: "bit", nullable: false),
                    Cameroon = table.Column<bool>(type: "bit", nullable: false),
                    Wales = table.Column<bool>(type: "bit", nullable: false),
                    OtherCountries = table.Column<bool>(type: "bit", nullable: false),
                    CreutzfeldtJakob = table.Column<bool>(type: "bit", nullable: false),
                    Cornea = table.Column<bool>(type: "bit", nullable: false),
                    OrganTransplant = table.Column<bool>(type: "bit", nullable: false),
                    BloodContact = table.Column<bool>(type: "bit", nullable: false),
                    Botox = table.Column<bool>(type: "bit", nullable: false),
                    TattooCupping = table.Column<bool>(type: "bit", nullable: false),
                    Rabies = table.Column<bool>(type: "bit", nullable: false),
                    Arrest = table.Column<bool>(type: "bit", nullable: false),
                    LastDonation = table.Column<bool>(type: "bit", nullable: false),
                    Miscarriage = table.Column<bool>(type: "bit", nullable: false),
                    PersonalInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonInquiryForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PersonInquiryForms_PersonalInformations_PersonalInformationId",
                        column: x => x.PersonalInformationId,
                        principalTable: "PersonalInformations",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DonationMovements",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonationId = table.Column<int>(type: "int", nullable: false),
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    DonationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DonationTypeId = table.Column<int>(type: "int", nullable: false),
                    DonationAmount = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MovementStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DonationMovements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DonationMovements_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "DonationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationMovements_DonationTypes_DonationTypeId",
                        column: x => x.DonationTypeId,
                        principalTable: "DonationTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationMovements_MovementStatus_MovementStatusId",
                        column: x => x.MovementStatusId,
                        principalTable: "MovementStatus",
                        principalColumn: "MovementStatusId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DonationMovements_PersonalInformations_PersonId",
                        column: x => x.PersonId,
                        principalTable: "PersonalInformations",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    NotificationId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DonationId = table.Column<int>(type: "int", nullable: false),
                    NotificationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                    table.ForeignKey(
                        name: "FK_Notifications_Donations_DonationId",
                        column: x => x.DonationId,
                        principalTable: "Donations",
                        principalColumn: "DonationId");
                });

            migrationBuilder.CreateTable(
                name: "NotificationPersonalInformation",
                columns: table => new
                {
                    NotificationsNotificationId = table.Column<int>(type: "int", nullable: false),
                    PersonIdPersonalInformationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NotificationPersonalInformation", x => new { x.NotificationsNotificationId, x.PersonIdPersonalInformationId });
                    table.ForeignKey(
                        name: "FK_NotificationPersonalInformation_Notifications_NotificationsNotificationId",
                        column: x => x.NotificationsNotificationId,
                        principalTable: "Notifications",
                        principalColumn: "NotificationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NotificationPersonalInformation_PersonalInformations_PersonIdPersonalInformationId",
                        column: x => x.PersonIdPersonalInformationId,
                        principalTable: "PersonalInformations",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PersonalInformationNotification",
                columns: table => new
                {
                    PersonalInformationId = table.Column<int>(type: "int", nullable: false),
                    NotificationId = table.Column<int>(type: "int", nullable: false),
                    InsertDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_PersonalInformationNotification_Notifications_NotificationId",
                        column: x => x.NotificationId,
                        principalTable: "Notifications",
                        principalColumn: "NotificationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonalInformationNotification_PersonalInformations_PersonalInformationId",
                        column: x => x.PersonalInformationId,
                        principalTable: "PersonalInformations",
                        principalColumn: "PersonalInformationId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "12e7b6ff-3906-4d4c-a218-3501ae33dcf7", "ac14dc92-c0f3-4df4-a5af-5510938ac540", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6971b3ff-02ef-4192-99c3-9ca05f59da62", "142df170-2089-4707-804b-25003d094701", "Admin", "ADMIN" });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_CityID",
                table: "Districts",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_DonationMovements_DonationId",
                table: "DonationMovements",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationMovements_DonationTypeId",
                table: "DonationMovements",
                column: "DonationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationMovements_MovementStatusId",
                table: "DonationMovements",
                column: "MovementStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_DonationMovements_PersonId",
                table: "DonationMovements",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_DonationTypeId",
                table: "Donations",
                column: "DonationTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_HospitalId",
                table: "Donations",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Donations_RecepientId",
                table: "Donations",
                column: "RecepientId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_AddressCityID",
                table: "Hospitals",
                column: "AddressCityID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_AddressDistrictID",
                table: "Hospitals",
                column: "AddressDistrictID");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_AddressNeighbohoodID",
                table: "Hospitals",
                column: "AddressNeighbohoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhoods_CityId",
                table: "Neighborhoods",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_Neighborhoods_DistrictId",
                table: "Neighborhoods",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_NotificationPersonalInformation_PersonIdPersonalInformationId",
                table: "NotificationPersonalInformation",
                column: "PersonIdPersonalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_Notifications_DonationId",
                table: "Notifications",
                column: "DonationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformationNotification_NotificationId",
                table: "PersonalInformationNotification",
                column: "NotificationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformationNotification_PersonalInformationId",
                table: "PersonalInformationNotification",
                column: "PersonalInformationId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_BirthPlaceId",
                table: "PersonalInformations",
                column: "BirthPlaceId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_CityId",
                table: "PersonalInformations",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_PersonEducationStatusId",
                table: "PersonalInformations",
                column: "PersonEducationStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_ResidanceDistrictId",
                table: "PersonalInformations",
                column: "ResidanceDistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_ResidanceNeighborhoodId",
                table: "PersonalInformations",
                column: "ResidanceNeighborhoodId");

            migrationBuilder.CreateIndex(
                name: "IX_PersonalInformations_UserId",
                table: "PersonalInformations",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonInquiryForms_PersonalInformationId",
                table: "PersonInquiryForms",
                column: "PersonalInformationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recepients_BirthPlaceId",
                table: "Recepients",
                column: "BirthPlaceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "DonationMovements");

            migrationBuilder.DropTable(
                name: "NotificationPersonalInformation");

            migrationBuilder.DropTable(
                name: "PersonalInformationNotification");

            migrationBuilder.DropTable(
                name: "PersonInquiryForms");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "MovementStatus");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "PersonalInformations");

            migrationBuilder.DropTable(
                name: "Donations");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "EducationStatus");

            migrationBuilder.DropTable(
                name: "DonationTypes");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "Recepients");

            migrationBuilder.DropTable(
                name: "Neighborhoods");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Cities");
        }
    }
}
