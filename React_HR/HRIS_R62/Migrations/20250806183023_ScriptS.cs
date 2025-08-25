using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS_R62.Migrations
{
    /// <inheritdoc />
    public partial class ScriptS : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AttendanceConfigurations",
                columns: table => new
                {
                    AttendanceConfigurationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GraceTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    LunchBreakStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    LunchBreakEndTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EveningSnacksBreakStartTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    EveningSnacksBreakEndTime = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceConfigurations", x => x.AttendanceConfigurationID);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceStatuss",
                columns: table => new
                {
                    AttendanceStatusID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StatusShortName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceStatuss", x => x.AttendanceStatusID);
                });

            migrationBuilder.CreateTable(
                name: "DateWiseOfficeTimes",
                columns: table => new
                {
                    DateWiseOfficeTimeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShiftStartDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ShiftEndDateTime = table.Column<DateTime>(type: "datetime", nullable: false),
                    ConsideredLunchHour = table.Column<TimeOnly>(type: "time", nullable: false),
                    BreakDuration = table.Column<TimeOnly>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DateWiseOfficeTimes", x => x.DateWiseOfficeTimeID);
                });

            migrationBuilder.CreateTable(
                name: "Designations",
                columns: table => new
                {
                    DesignationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DesignationName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DesignationShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designations", x => x.DesignationID);
                });

            migrationBuilder.CreateTable(
                name: "Divisions",
                columns: table => new
                {
                    DivisionID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DivisionName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DivisionShortName = table.Column<string>(type: "nvarchar(3)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Divisions", x => x.DivisionID);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentTypes",
                columns: table => new
                {
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmploymentTypeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentTypes", x => x.EmploymentTypeID);
                });

            migrationBuilder.CreateTable(
                name: "Grades",
                columns: table => new
                {
                    GradeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeShortID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GradeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromGrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ToGrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gross = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Medical = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grades", x => x.GradeID);
                });

            migrationBuilder.CreateTable(
                name: "LeaveTypes",
                columns: table => new
                {
                    LeaveTypeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveTypeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveTypes", x => x.LeaveTypeID);
                });

            migrationBuilder.CreateTable(
                name: "WeekDay",
                columns: table => new
                {
                    WeekDayID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    WeekDayName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WeekDayShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsWeekend = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeekDay", x => x.WeekDayID);
                });

            migrationBuilder.CreateTable(
                name: "ShiftEmployees",
                columns: table => new
                {
                    ShiftEmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateWiseOfficeTimeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftEmployees", x => x.ShiftEmployeeID);
                    table.ForeignKey(
                        name: "FK_ShiftEmployees_DateWiseOfficeTimes_DateWiseOfficeTimeID",
                        column: x => x.DateWiseOfficeTimeID,
                        principalTable: "DateWiseOfficeTimes",
                        principalColumn: "DateWiseOfficeTimeID");
                });

            migrationBuilder.CreateTable(
                name: "TiffinAllowanceRates",
                columns: table => new
                {
                    TiffinAllowanceRateID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RateInTaka = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DesignationID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiffinAllowanceRates", x => x.TiffinAllowanceRateID);
                    table.ForeignKey(
                        name: "FK_TiffinAllowanceRates_Designations_DesignationID",
                        column: x => x.DesignationID,
                        principalTable: "Designations",
                        principalColumn: "DesignationID");
                });

            migrationBuilder.CreateTable(
                name: "NightAllowances",
                columns: table => new
                {
                    NightAllowanceID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalaryMinimum = table.Column<decimal>(type: "money", nullable: false),
                    SalaryMaximum = table.Column<decimal>(type: "money", nullable: false),
                    NightAllowanceRate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NightAllowances", x => x.NightAllowanceID);
                    table.ForeignKey(
                        name: "FK_NightAllowances_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "EmploymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NightAllowanceTimes",
                columns: table => new
                {
                    NightAllowanceTimeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowanceType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    NightHours = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NightMinutes = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NightAllowanceTimes", x => x.NightAllowanceTimeID);
                    table.ForeignKey(
                        name: "FK_NightAllowanceTimes_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "EmploymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TiffinAllowanceTimes",
                columns: table => new
                {
                    TiffinAllowanceID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AllowanceDate = table.Column<DateOnly>(type: "date", nullable: false),
                    AllowanceType = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Time = table.Column<TimeOnly>(type: "time", nullable: false),
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TiffinAllowanceTimes", x => x.TiffinAllowanceID);
                    table.ForeignKey(
                        name: "FK_TiffinAllowanceTimes_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "EmploymentTypeID");
                });

            migrationBuilder.CreateTable(
                name: "SalaryGrades",
                columns: table => new
                {
                    SalaryGradeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GradeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryGrades", x => x.SalaryGradeID);
                    table.ForeignKey(
                        name: "FK_SalaryGrades_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalarySteps",
                columns: table => new
                {
                    SalaryStepID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GradeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    StepNumber = table.Column<int>(type: "int", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    ConveyanceAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StepStatus = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalarySteps", x => x.SalaryStepID);
                    table.ForeignKey(
                        name: "FK_SalarySteps_Grades_GradeID",
                        column: x => x.GradeID,
                        principalTable: "Grades",
                        principalColumn: "GradeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceBonus",
                columns: table => new
                {
                    AttendanceBonusID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BonusAmount = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    BonusCategory = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceBonus", x => x.AttendanceBonusID);
                });

            migrationBuilder.CreateTable(
                name: "AttendanceRecords",
                columns: table => new
                {
                    AttendanceRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "date", nullable: false),
                    InTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    OutTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    OTStart = table.Column<TimeOnly>(type: "time", nullable: false),
                    OTEnd = table.Column<TimeOnly>(type: "time", nullable: false),
                    TotalRegularHours = table.Column<TimeSpan>(type: "time", nullable: false),
                    TotalOvertimeHours = table.Column<TimeSpan>(type: "time", nullable: false),
                    DayType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AttendanceConfigurationID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    AttendanceStatusID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AttendanceRecords", x => x.AttendanceRecordID);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_AttendanceConfigurations_AttendanceConfigurationID",
                        column: x => x.AttendanceConfigurationID,
                        principalTable: "AttendanceConfigurations",
                        principalColumn: "AttendanceConfigurationID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AttendanceRecords_AttendanceStatuss_AttendanceStatusID",
                        column: x => x.AttendanceStatusID,
                        principalTable: "AttendanceStatuss",
                        principalColumn: "AttendanceStatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BonusRecord",
                columns: table => new
                {
                    BonusRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BonusDate = table.Column<DateOnly>(type: "date", nullable: false),
                    JoiningDate = table.Column<DateOnly>(type: "date", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OtherAllowance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BonusPercent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BonusAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FestivalName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RevenueStampAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPayableAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BonusRecord", x => x.BonusRecordID);
                });

            migrationBuilder.CreateTable(
                name: "Buildings",
                columns: table => new
                {
                    BuildingID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Floor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoomNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeInformationEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Buildings", x => x.BuildingID);
                });

            migrationBuilder.CreateTable(
                name: "CareerHistory",
                columns: table => new
                {
                    EntryNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EntryType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CareerHistory", x => x.EntryNumber);
                });

            migrationBuilder.CreateTable(
                name: "ChildrenInformation",
                columns: table => new
                {
                    ChildID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChildrenName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChildrenInformation", x => x.ChildID);
                });

            migrationBuilder.CreateTable(
                name: "Companies",
                columns: table => new
                {
                    CompanyID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyNameLocal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeInformationEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Companies", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    DepartmentID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentShortName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DepartmentNameLocal = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.DepartmentID);
                    table.ForeignKey(
                        name: "FK_Departments_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                columns: table => new
                {
                    UnitID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UnitName = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    CompanyID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitID);
                    table.ForeignKey(
                        name: "FK_Units_Companies_CompanyID",
                        column: x => x.CompanyID,
                        principalTable: "Companies",
                        principalColumn: "CompanyID");
                });

            migrationBuilder.CreateTable(
                name: "ContactPersonInformation",
                columns: table => new
                {
                    ContactID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Relation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactPersonInformation", x => x.ContactID);
                });

            migrationBuilder.CreateTable(
                name: "DepartmentEmployeeInformation",
                columns: table => new
                {
                    DepartmentsDepartmentID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeeInformationEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DepartmentEmployeeInformation", x => new { x.DepartmentsDepartmentID, x.EmployeeInformationEmployeeID });
                    table.ForeignKey(
                        name: "FK_DepartmentEmployeeInformation_Departments_DepartmentsDepartmentID",
                        column: x => x.DepartmentsDepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DisciplinaryAction",
                columns: table => new
                {
                    ActionID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ActionType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActionStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DisciplinaryAction", x => x.ActionID);
                });

            migrationBuilder.CreateTable(
                name: "EarlyLeaveInformation",
                columns: table => new
                {
                    EarlyLeaveInformationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EarlyLeaveInformation", x => x.EarlyLeaveInformationID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeBenefits",
                columns: table => new
                {
                    BenefitID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BenefitDate = table.Column<DateTime>(type: "date", nullable: true),
                    BenefitAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BenefitType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BenefitActivationDate = table.Column<DateTime>(type: "date", nullable: true),
                    PreviousNetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NewNetSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryStepID = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    GrossSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CashIncentive = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ApprovalDate = table.Column<DateTime>(type: "date", nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeInformationEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeBenefits", x => x.BenefitID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeComplaint",
                columns: table => new
                {
                    ComplaintID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ComplaintDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ComplaintType = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeComplaint", x => x.ComplaintID);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeInformations",
                columns: table => new
                {
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsLineSelected = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LineID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeeName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmployeeNameLocal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DesignationID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    ShiftID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    ProximityNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsOTAllowed = table.Column<bool>(type: "bit", nullable: false),
                    GenderID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IDentificationMark = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmploymentTypeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PresentAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PermanentAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MobileNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NationalIDNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    IsMobileBanking = table.Column<bool>(type: "bit", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    FatherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherNameLocal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FatherOccupation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    MotherName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MotherNameLocal = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MotherOccupation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    PlaceOfBirth = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DistrictOfBirth = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Nationality = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReligionID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BloodGroup = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    MaritalStatus = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DateOfMarriage = table.Column<DateTime>(type: "date", nullable: true),
                    JoiningDate = table.Column<DateTime>(type: "date", nullable: true),
                    PostingDate = table.Column<DateTime>(type: "date", nullable: true),
                    ConfirmationDate = table.Column<DateTime>(type: "date", nullable: true),
                    RetirementDate = table.Column<DateTime>(type: "date", nullable: true),
                    ServiceLength = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    SpouseName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SpouseOccupation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    SpouseDateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    SpouseBloodGroup = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    CurrentSalary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryAtJoining = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryGradeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    PassportNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    PassportIssueDate = table.Column<DateTime>(type: "date", nullable: true),
                    PassportExpiryDate = table.Column<DateTime>(type: "date", nullable: true),
                    PassportIssuePlace = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    PassportIssueAuthority = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReferenceName1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReferenceAddress1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReferencePhone1 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ReferenceOccupation1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReferenceRelation1 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReferenceName2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ReferenceAddress2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ReferencePhone2 = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    ReferenceOccupation2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ReferenceRelation2 = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmployeePhoto = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmployeeSignature = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OldEmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PreviousEmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalaryStepID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeInformations", x => x.EmployeeID);
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_Designations_DesignationID",
                        column: x => x.DesignationID,
                        principalTable: "Designations",
                        principalColumn: "DesignationID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_EmploymentTypes_EmploymentTypeID",
                        column: x => x.EmploymentTypeID,
                        principalTable: "EmploymentTypes",
                        principalColumn: "EmploymentTypeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_SalaryGrades_SalaryGradeID",
                        column: x => x.SalaryGradeID,
                        principalTable: "SalaryGrades",
                        principalColumn: "SalaryGradeID");
                    table.ForeignKey(
                        name: "FK_EmployeeInformations_SalarySteps_SalaryStepID",
                        column: x => x.SalaryStepID,
                        principalTable: "SalarySteps",
                        principalColumn: "SalaryStepID");
                });

            migrationBuilder.CreateTable(
                name: "EmployeeSkill",
                columns: table => new
                {
                    SkillID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SkillName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SkillLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CertificationDetails = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CertificationDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeSkill", x => x.SkillID);
                    table.ForeignKey(
                        name: "FK_EmployeeSkill_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EmployeeTax",
                columns: table => new
                {
                    EmployeeTaxID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalaryDate = table.Column<DateTime>(type: "date", nullable: false),
                    TaxMonth = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TaxYear = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    MonthlyGross = table.Column<double>(type: "float", nullable: true),
                    CalculatedTax = table.Column<double>(type: "float", nullable: true),
                    ProposedTax = table.Column<double>(type: "float", nullable: true),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmployeeTax", x => x.EmployeeTaxID);
                    table.ForeignKey(
                        name: "FK_EmployeeTax_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FestivalBonus",
                columns: table => new
                {
                    FestivalBonusID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FestivalName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PercentageBelowOneYear = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    PercentageAfterOneYear = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    BonusEligibilityCheck = table.Column<int>(type: "int", nullable: false),
                    FestivalBonusDate = table.Column<DateTime>(type: "date", nullable: false),
                    EffectiveFrom = table.Column<DateTime>(type: "date", nullable: false),
                    EffectiveTo = table.Column<DateTime>(type: "date", nullable: false),
                    LastUpdated = table.Column<DateTime>(type: "date", nullable: false),
                    UpdatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FestivalBonus", x => x.FestivalBonusID);
                    table.ForeignKey(
                        name: "FK_FestivalBonus_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FoodCharge",
                columns: table => new
                {
                    FoodChargeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ChargeDate = table.Column<DateTime>(type: "date", nullable: false),
                    ChargeAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ChargeType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCharge", x => x.FoodChargeID);
                    table.ForeignKey(
                        name: "FK_FoodCharge_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    GenderID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GenderName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.GenderID);
                    table.ForeignKey(
                        name: "FK_Genders_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "HoliDayBillRate",
                columns: table => new
                {
                    HoliDayBillRateID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SerialNumber = table.Column<int>(type: "int", nullable: false),
                    SalaryMinimum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryMaximum = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HoliDayBillRateValue = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoliDayBillRate", x => x.HoliDayBillRateID);
                    table.ForeignKey(
                        name: "FK_HoliDayBillRate_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoliDayEntitledEmployee",
                columns: table => new
                {
                    HoliDayEntitledEmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AttendanceStatus = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoliDayEntitledEmployee", x => x.HoliDayEntitledEmployeeID);
                    table.ForeignKey(
                        name: "FK_HoliDayEntitledEmployee_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HoliDayInformation",
                columns: table => new
                {
                    HoliDayInformationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EventName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoliDayInformation", x => x.HoliDayInformationID);
                    table.ForeignKey(
                        name: "FK_HoliDayInformation_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JobLeft",
                columns: table => new
                {
                    JobLeftID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JobLeftDate = table.Column<DateTime>(type: "date", nullable: true),
                    JobLeftType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: true),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobLeft", x => x.JobLeftID);
                    table.ForeignKey(
                        name: "FK_JobLeft_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LateApprovals",
                columns: table => new
                {
                    LateApprovalID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LateDate = table.Column<DateTime>(type: "date", nullable: false),
                    LateReason = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LateApprovals", x => x.LateApprovalID);
                    table.ForeignKey(
                        name: "FK_LateApprovals_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveApprovals",
                columns: table => new
                {
                    LeaveApprovalID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveTypeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    LeaveFromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LeaveToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LeaveEnjoyed = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    TotalLeave = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ProvidedLeave = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveApprovals", x => x.LeaveApprovalID);
                    table.ForeignKey(
                        name: "FK_LeaveApprovals_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_LeaveApprovals_LeaveTypes_LeaveTypeID",
                        column: x => x.LeaveTypeID,
                        principalTable: "LeaveTypes",
                        principalColumn: "LeaveTypeID");
                });

            migrationBuilder.CreateTable(
                name: "LeaveEncashment",
                columns: table => new
                {
                    LeaveEncashmentID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EncashMonth = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    EncashYear = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    BasicSalary = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    ActualDays = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ComputedDays = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveEncashAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    OtherDeductions = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    ActualEncashAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    ComputedEncashAmount = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: false),
                    LastMonthWorkingDays = table.Column<int>(type: "int", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveEncashment", x => x.LeaveEncashmentID);
                    table.ForeignKey(
                        name: "FK_LeaveEncashment_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManualAttendances",
                columns: table => new
                {
                    ManualAttendanceID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    AttendanceDate = table.Column<DateTime>(type: "date", nullable: false),
                    AttendanceTime = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OutTime = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ManualAttendances", x => x.ManualAttendanceID);
                    table.ForeignKey(
                        name: "FK_ManualAttendances_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaternityConfiguration",
                columns: table => new
                {
                    MaternityConfigurationID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "date", nullable: true),
                    IsEligible = table.Column<bool>(type: "bit", nullable: false),
                    LastWithdrawalDate = table.Column<DateTime>(type: "date", nullable: true),
                    InstallmentType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    NextWithdrawableTime = table.Column<int>(type: "int", nullable: true),
                    CurrentWithdrawalDate = table.Column<DateTime>(type: "date", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaternityConfiguration", x => x.MaternityConfigurationID);
                    table.ForeignKey(
                        name: "FK_MaternityConfiguration_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NomineeInformation",
                columns: table => new
                {
                    NomineeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Relation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Age = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Percentage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Flag = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NomineeInformation", x => x.NomineeID);
                    table.ForeignKey(
                        name: "FK_NomineeInformation_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "OverTimes",
                columns: table => new
                {
                    OverTimeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    OTDate = table.Column<DateTime>(type: "date", nullable: false),
                    OTHours = table.Column<float>(type: "real", nullable: true),
                    OTStartTime = table.Column<DateTime>(type: "date", nullable: true),
                    OTEndTime = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OverTimes", x => x.OverTimeID);
                    table.ForeignKey(
                        name: "FK_OverTimes_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProximityRecords",
                columns: table => new
                {
                    ProximityRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProximityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecordDate = table.Column<DateOnly>(type: "Date", nullable: false),
                    InTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    OutTime = table.Column<TimeOnly>(type: "time", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VerifiedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProximityRecords", x => x.ProximityRecordID);
                    table.ForeignKey(
                        name: "FK_ProximityRecords_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    ReligionID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ReligionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.ReligionID);
                    table.ForeignKey(
                        name: "FK_Religions_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "SalaryDeduction",
                columns: table => new
                {
                    SalaryDeductionID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DeductionDate = table.Column<DateTime>(type: "date", nullable: false),
                    ActivationDate = table.Column<DateTime>(type: "date", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryDeduction", x => x.SalaryDeductionID);
                    table.ForeignKey(
                        name: "FK_SalaryDeduction_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaryEntry",
                columns: table => new
                {
                    SalaryEntryID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApplyDate = table.Column<DateTime>(type: "date", nullable: false),
                    SalaryHeadName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryEntry", x => x.SalaryEntryID);
                    table.ForeignKey(
                        name: "FK_SalaryEntry_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalaryRecords",
                columns: table => new
                {
                    SalaryRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SalaryStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalaryEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalaryStepID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MonthDays = table.Column<int>(type: "int", nullable: false),
                    PunchDays = table.Column<int>(type: "int", nullable: false),
                    TotalHoliDay = table.Column<int>(type: "int", nullable: false),
                    TotalLeave = table.Column<int>(type: "int", nullable: false),
                    WorkingDays = table.Column<int>(type: "int", nullable: false),
                    Absenteeism = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Gross = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ActualGross = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Basic = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MedicalAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MobileAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherAllowances = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LunchAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Tax = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OtherDeduction = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OTHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OTAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ByBankAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ByCashAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NetPayable = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConveyanceAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    AttendanceBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SpecialAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryAdvance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FoodCharge = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OTRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TiffinAllowance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Arrear = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SpecialBonus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LeaveStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HoliDayBillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NightBillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SalaryID = table.Column<int>(type: "int", nullable: false),
                    LunchBillAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MobileBanking = table.Column<bool>(type: "bit", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProcessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    DepartmentID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryRecords", x => x.SalaryRecordID);
                    table.ForeignKey(
                        name: "FK_SalaryRecords_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID");
                    table.ForeignKey(
                        name: "FK_SalaryRecords_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalaryRecords_SalarySteps_SalaryStepID",
                        column: x => x.SalaryStepID,
                        principalTable: "SalarySteps",
                        principalColumn: "SalaryStepID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    SectionsID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SectionName = table.Column<string>(type: "nvarchar(30)", nullable: false),
                    SectionShortName = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    SectionNameNative = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DepartmentID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeeInformationEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.SectionsID);
                    table.ForeignKey(
                        name: "FK_Sections_Departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Sections_EmployeeInformations_EmployeeInformationEmployeeID",
                        column: x => x.EmployeeInformationEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "ShiftTimes",
                columns: table => new
                {
                    ShiftID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ShiftName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    ShiftStart = table.Column<TimeOnly>(type: "time", nullable: false),
                    ShiftEnd = table.Column<TimeOnly>(type: "time", nullable: false),
                    StartDate = table.Column<DateOnly>(type: "date", nullable: false),
                    EndDate = table.Column<DateOnly>(type: "date", nullable: false),
                    ConsideredLunchHour = table.Column<int>(type: "int", nullable: true),
                    BreakDuration = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WeekDayID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeeInformationEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShiftTimes", x => x.ShiftID);
                    table.ForeignKey(
                        name: "FK_ShiftTimes_EmployeeInformations_EmployeeInformationEmployeeID",
                        column: x => x.EmployeeInformationEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_ShiftTimes_WeekDay_WeekDayID",
                        column: x => x.WeekDayID,
                        principalTable: "WeekDay",
                        principalColumn: "WeekDayID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SpecialEmployees",
                columns: table => new
                {
                    SpecialEmployeeID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    ToDate = table.Column<DateTime>(type: "date", nullable: true),
                    AttendanceType = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialEmployees", x => x.SpecialEmployeeID);
                    table.ForeignKey(
                        name: "FK_SpecialEmployees_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "SpouseInformation",
                columns: table => new
                {
                    SpouseID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SpouseName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: true),
                    BloodGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpouseInformation", x => x.SpouseID);
                    table.ForeignKey(
                        name: "FK_SpouseInformation_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "Suspend",
                columns: table => new
                {
                    SuspendID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SuspendDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Release = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suspend", x => x.SuspendID);
                    table.ForeignKey(
                        name: "FK_Suspend_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "TaxAmount",
                columns: table => new
                {
                    TaxAmountID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TaxYear = table.Column<int>(type: "int", nullable: false),
                    TaxAmountValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxType = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxAmount", x => x.TaxAmountID);
                    table.ForeignKey(
                        name: "FK_TaxAmount_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "TaxExempted",
                columns: table => new
                {
                    TaxExemptedID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TaxYear = table.Column<int>(type: "int", nullable: false),
                    HouseRent = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Medical = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Conveyance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearlyExemptedTaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    YearlySpecialExemptedTaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ApprovalStatus = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    ApprovedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeInformationsEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxExempted", x => x.TaxExemptedID);
                    table.ForeignKey(
                        name: "FK_TaxExempted_EmployeeInformations_EmployeeInformationsEmployeeID",
                        column: x => x.EmployeeInformationsEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                });

            migrationBuilder.CreateTable(
                name: "LeaveEncashmentRate",
                columns: table => new
                {
                    LeaveEncashmentRateID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ToGrossSalary = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    RateInPercent = table.Column<decimal>(type: "numeric(18,0)", nullable: false),
                    LeaveEncashmentID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeeInformationEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveEncashmentRate", x => x.LeaveEncashmentRateID);
                    table.ForeignKey(
                        name: "FK_LeaveEncashmentRate_EmployeeInformations_EmployeeInformationEmployeeID",
                        column: x => x.EmployeeInformationEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_LeaveEncashmentRate_LeaveEncashment_LeaveEncashmentID",
                        column: x => x.LeaveEncashmentID,
                        principalTable: "LeaveEncashment",
                        principalColumn: "LeaveEncashmentID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaternityBill",
                columns: table => new
                {
                    MaternityBillID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MaternityConfigurationID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    CurrentMonth = table.Column<DateTime>(type: "date", nullable: true),
                    FromMonth = table.Column<DateTime>(type: "date", nullable: true),
                    ToMonth = table.Column<DateTime>(type: "date", nullable: true),
                    NumberOfMonths = table.Column<int>(type: "int", nullable: true),
                    BasicSalary = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    WorkingDays = table.Column<int>(type: "int", nullable: true),
                    ActualCurrentSalary = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    EarnedLeaveDays = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    EarnedLeaveAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Computed3MonthNetPayable = table.Column<decimal>(type: "decimal(10,4)", nullable: true),
                    Computed3MonthWorkingDays = table.Column<int>(type: "int", nullable: true),
                    ActualPay = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ComputedPay = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ActualNetPayable = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    ComputedNetPayable = table.Column<decimal>(type: "decimal(10,4)", nullable: false),
                    LocalAreaClerance = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LocalAreaRemarks = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaternityBill", x => x.MaternityBillID);
                    table.ForeignKey(
                        name: "FK_MaternityBill_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_MaternityBill_MaternityConfiguration_MaternityConfigurationID",
                        column: x => x.MaternityConfigurationID,
                        principalTable: "MaternityConfiguration",
                        principalColumn: "MaternityConfigurationID");
                });

            migrationBuilder.CreateTable(
                name: "SalaryProcess",
                columns: table => new
                {
                    ProcessID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MonthNo = table.Column<int>(type: "int", nullable: false),
                    YearNo = table.Column<int>(type: "int", nullable: false),
                    FromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SalaryHeadName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    ProcessDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    SalaryEntryID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalaryProcess", x => x.ProcessID);
                    table.ForeignKey(
                        name: "FK_SalaryProcess_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalaryProcess_SalaryEntry_SalaryEntryID",
                        column: x => x.SalaryEntryID,
                        principalTable: "SalaryEntry",
                        principalColumn: "SalaryEntryID");
                });

            migrationBuilder.CreateTable(
                name: "LineInformations",
                columns: table => new
                {
                    LineID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    BuildingID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    SectionsID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LineInformations", x => x.LineID);
                    table.ForeignKey(
                        name: "FK_LineInformations_Buildings_BuildingID",
                        column: x => x.BuildingID,
                        principalTable: "Buildings",
                        principalColumn: "BuildingID");
                    table.ForeignKey(
                        name: "FK_LineInformations_Sections_SectionsID",
                        column: x => x.SectionsID,
                        principalTable: "Sections",
                        principalColumn: "SectionsID");
                });

            migrationBuilder.CreateTable(
                name: "TaxRule",
                columns: table => new
                {
                    TaxRuleID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RuleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MinAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TaxPercentage = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    MinSpecialAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxSpecialAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EffectiveFrom = table.Column<DateTime>(type: "date", nullable: false),
                    EffectiveTo = table.Column<DateTime>(type: "date", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "date", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TaxExemptedID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EmployeeInformationEmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaxRule", x => x.TaxRuleID);
                    table.ForeignKey(
                        name: "FK_TaxRule_EmployeeInformations_EmployeeInformationEmployeeID",
                        column: x => x.EmployeeInformationEmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID");
                    table.ForeignKey(
                        name: "FK_TaxRule_TaxExempted_TaxExemptedID",
                        column: x => x.TaxExemptedID,
                        principalTable: "TaxExempted",
                        principalColumn: "TaxExemptedID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LeaveRecords",
                columns: table => new
                {
                    LeaveRecordID = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LeaveDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    LeaveTypeID = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    TotalLeave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LeaveEnjoyed = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    ApprovedDate = table.Column<DateTime>(type: "date", nullable: false),
                    EmployeeID = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    EntryUser = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MaternityBillID = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LeaveRecords", x => x.LeaveRecordID);
                    table.ForeignKey(
                        name: "FK_LeaveRecords_EmployeeInformations_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "EmployeeInformations",
                        principalColumn: "EmployeeID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LeaveRecords_LeaveTypes_LeaveTypeID",
                        column: x => x.LeaveTypeID,
                        principalTable: "LeaveTypes",
                        principalColumn: "LeaveTypeID");
                    table.ForeignKey(
                        name: "FK_LeaveRecords_MaternityBill_MaternityBillID",
                        column: x => x.MaternityBillID,
                        principalTable: "MaternityBill",
                        principalColumn: "MaternityBillID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceBonus_EmployeeID",
                table: "AttendanceBonus",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_AttendanceConfigurationID",
                table: "AttendanceRecords",
                column: "AttendanceConfigurationID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_AttendanceStatusID",
                table: "AttendanceRecords",
                column: "AttendanceStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_AttendanceRecords_EmployeeID",
                table: "AttendanceRecords",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_BonusRecord_EmployeeID",
                table: "BonusRecord",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Buildings_EmployeeInformationEmployeeID",
                table: "Buildings",
                column: "EmployeeInformationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_CareerHistory_EmployeeID",
                table: "CareerHistory",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ChildrenInformation_EmployeeID",
                table: "ChildrenInformation",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Companies_EmployeeInformationEmployeeID",
                table: "Companies",
                column: "EmployeeInformationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ContactPersonInformation_EmployeeID",
                table: "ContactPersonInformation",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentEmployeeInformation_EmployeeInformationEmployeeID",
                table: "DepartmentEmployeeInformation",
                column: "EmployeeInformationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_CompanyID",
                table: "Departments",
                column: "CompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_DisciplinaryAction_EmployeeID",
                table: "DisciplinaryAction",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EarlyLeaveInformation_EmployeeID",
                table: "EarlyLeaveInformation",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeBenefits_EmployeeInformationEmployeeID",
                table: "EmployeeBenefits",
                column: "EmployeeInformationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeComplaint_EmployeeID",
                table: "EmployeeComplaint",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_DesignationID",
                table: "EmployeeInformations",
                column: "DesignationID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_EmploymentTypeID",
                table: "EmployeeInformations",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_LineID",
                table: "EmployeeInformations",
                column: "LineID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_SalaryGradeID",
                table: "EmployeeInformations",
                column: "SalaryGradeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_SalaryStepID",
                table: "EmployeeInformations",
                column: "SalaryStepID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeInformations_ShiftID",
                table: "EmployeeInformations",
                column: "ShiftID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeSkill_EmployeeID",
                table: "EmployeeSkill",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_EmployeeTax_EmployeeID",
                table: "EmployeeTax",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_FestivalBonus_EmployeeID",
                table: "FestivalBonus",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCharge_EmployeeID",
                table: "FoodCharge",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_EmployeeInformationsEmployeeID",
                table: "Genders",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_HoliDayBillRate_EmployeeID",
                table: "HoliDayBillRate",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_HoliDayEntitledEmployee_EmployeeID",
                table: "HoliDayEntitledEmployee",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_HoliDayInformation_EmployeeID",
                table: "HoliDayInformation",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_JobLeft_EmployeeID",
                table: "JobLeft",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LateApprovals_EmployeeID",
                table: "LateApprovals",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApprovals_EmployeeInformationsEmployeeID",
                table: "LeaveApprovals",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveApprovals_LeaveTypeID",
                table: "LeaveApprovals",
                column: "LeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveEncashment_EmployeeID",
                table: "LeaveEncashment",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveEncashmentRate_EmployeeInformationEmployeeID",
                table: "LeaveEncashmentRate",
                column: "EmployeeInformationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveEncashmentRate_LeaveEncashmentID",
                table: "LeaveEncashmentRate",
                column: "LeaveEncashmentID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRecords_EmployeeID",
                table: "LeaveRecords",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRecords_LeaveTypeID",
                table: "LeaveRecords",
                column: "LeaveTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_LeaveRecords_MaternityBillID",
                table: "LeaveRecords",
                column: "MaternityBillID");

            migrationBuilder.CreateIndex(
                name: "IX_LineInformations_BuildingID",
                table: "LineInformations",
                column: "BuildingID");

            migrationBuilder.CreateIndex(
                name: "IX_LineInformations_SectionsID",
                table: "LineInformations",
                column: "SectionsID");

            migrationBuilder.CreateIndex(
                name: "IX_ManualAttendances_EmployeeID",
                table: "ManualAttendances",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_MaternityBill_EmployeeID",
                table: "MaternityBill",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_MaternityBill_MaternityConfigurationID",
                table: "MaternityBill",
                column: "MaternityConfigurationID");

            migrationBuilder.CreateIndex(
                name: "IX_MaternityConfiguration_EmployeeID",
                table: "MaternityConfiguration",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_NightAllowances_EmploymentTypeID",
                table: "NightAllowances",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_NightAllowanceTimes_EmploymentTypeID",
                table: "NightAllowanceTimes",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_NomineeInformation_EmployeeInformationsEmployeeID",
                table: "NomineeInformation",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_OverTimes_EmployeeID",
                table: "OverTimes",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ProximityRecords_EmployeeID",
                table: "ProximityRecords",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Religions_EmployeeInformationsEmployeeID",
                table: "Religions",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryDeduction_EmployeeID",
                table: "SalaryDeduction",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryEntry_EmployeeID",
                table: "SalaryEntry",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryGrades_GradeID",
                table: "SalaryGrades",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryProcess_EmployeeID",
                table: "SalaryProcess",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryProcess_SalaryEntryID",
                table: "SalaryProcess",
                column: "SalaryEntryID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryRecords_DepartmentID",
                table: "SalaryRecords",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryRecords_EmployeeID",
                table: "SalaryRecords",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SalaryRecords_SalaryStepID",
                table: "SalaryRecords",
                column: "SalaryStepID");

            migrationBuilder.CreateIndex(
                name: "IX_SalarySteps_GradeID",
                table: "SalarySteps",
                column: "GradeID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_DepartmentID",
                table: "Sections",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_EmployeeInformationEmployeeID",
                table: "Sections",
                column: "EmployeeInformationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftEmployees_DateWiseOfficeTimeID",
                table: "ShiftEmployees",
                column: "DateWiseOfficeTimeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftTimes_EmployeeInformationEmployeeID",
                table: "ShiftTimes",
                column: "EmployeeInformationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_ShiftTimes_WeekDayID",
                table: "ShiftTimes",
                column: "WeekDayID");

            migrationBuilder.CreateIndex(
                name: "IX_SpecialEmployees_EmployeeInformationsEmployeeID",
                table: "SpecialEmployees",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_SpouseInformation_EmployeeInformationsEmployeeID",
                table: "SpouseInformation",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Suspend_EmployeeInformationsEmployeeID",
                table: "Suspend",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxAmount_EmployeeInformationsEmployeeID",
                table: "TaxAmount",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxExempted_EmployeeInformationsEmployeeID",
                table: "TaxExempted",
                column: "EmployeeInformationsEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRule_EmployeeInformationEmployeeID",
                table: "TaxRule",
                column: "EmployeeInformationEmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_TaxRule_TaxExemptedID",
                table: "TaxRule",
                column: "TaxExemptedID");

            migrationBuilder.CreateIndex(
                name: "IX_TiffinAllowanceRates_DesignationID",
                table: "TiffinAllowanceRates",
                column: "DesignationID");

            migrationBuilder.CreateIndex(
                name: "IX_TiffinAllowanceTimes_EmploymentTypeID",
                table: "TiffinAllowanceTimes",
                column: "EmploymentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Units_CompanyID",
                table: "Units",
                column: "CompanyID");

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceBonus_EmployeeInformations_EmployeeID",
                table: "AttendanceBonus",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AttendanceRecords_EmployeeInformations_EmployeeID",
                table: "AttendanceRecords",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BonusRecord_EmployeeInformations_EmployeeID",
                table: "BonusRecord",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Buildings_EmployeeInformations_EmployeeInformationEmployeeID",
                table: "Buildings",
                column: "EmployeeInformationEmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_CareerHistory_EmployeeInformations_EmployeeID",
                table: "CareerHistory",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ChildrenInformation_EmployeeInformations_EmployeeID",
                table: "ChildrenInformation",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Companies_EmployeeInformations_EmployeeInformationEmployeeID",
                table: "Companies",
                column: "EmployeeInformationEmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_ContactPersonInformation_EmployeeInformations_EmployeeID",
                table: "ContactPersonInformation",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DepartmentEmployeeInformation_EmployeeInformations_EmployeeInformationEmployeeID",
                table: "DepartmentEmployeeInformation",
                column: "EmployeeInformationEmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DisciplinaryAction_EmployeeInformations_EmployeeID",
                table: "DisciplinaryAction",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EarlyLeaveInformation_EmployeeInformations_EmployeeID",
                table: "EarlyLeaveInformation",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeBenefits_EmployeeInformations_EmployeeInformationEmployeeID",
                table: "EmployeeBenefits",
                column: "EmployeeInformationEmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeComplaint_EmployeeInformations_EmployeeID",
                table: "EmployeeComplaint",
                column: "EmployeeID",
                principalTable: "EmployeeInformations",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_LineInformations_LineID",
                table: "EmployeeInformations",
                column: "LineID",
                principalTable: "LineInformations",
                principalColumn: "LineID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EmployeeInformations_ShiftTimes_ShiftID",
                table: "EmployeeInformations",
                column: "ShiftID",
                principalTable: "ShiftTimes",
                principalColumn: "ShiftID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Buildings_EmployeeInformations_EmployeeInformationEmployeeID",
                table: "Buildings");

            migrationBuilder.DropForeignKey(
                name: "FK_Companies_EmployeeInformations_EmployeeInformationEmployeeID",
                table: "Companies");

            migrationBuilder.DropForeignKey(
                name: "FK_Sections_EmployeeInformations_EmployeeInformationEmployeeID",
                table: "Sections");

            migrationBuilder.DropForeignKey(
                name: "FK_ShiftTimes_EmployeeInformations_EmployeeInformationEmployeeID",
                table: "ShiftTimes");

            migrationBuilder.DropTable(
                name: "AttendanceBonus");

            migrationBuilder.DropTable(
                name: "AttendanceRecords");

            migrationBuilder.DropTable(
                name: "BonusRecord");

            migrationBuilder.DropTable(
                name: "CareerHistory");

            migrationBuilder.DropTable(
                name: "ChildrenInformation");

            migrationBuilder.DropTable(
                name: "ContactPersonInformation");

            migrationBuilder.DropTable(
                name: "DepartmentEmployeeInformation");

            migrationBuilder.DropTable(
                name: "DisciplinaryAction");

            migrationBuilder.DropTable(
                name: "Divisions");

            migrationBuilder.DropTable(
                name: "EarlyLeaveInformation");

            migrationBuilder.DropTable(
                name: "EmployeeBenefits");

            migrationBuilder.DropTable(
                name: "EmployeeComplaint");

            migrationBuilder.DropTable(
                name: "EmployeeSkill");

            migrationBuilder.DropTable(
                name: "EmployeeTax");

            migrationBuilder.DropTable(
                name: "FestivalBonus");

            migrationBuilder.DropTable(
                name: "FoodCharge");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "HoliDayBillRate");

            migrationBuilder.DropTable(
                name: "HoliDayEntitledEmployee");

            migrationBuilder.DropTable(
                name: "HoliDayInformation");

            migrationBuilder.DropTable(
                name: "JobLeft");

            migrationBuilder.DropTable(
                name: "LateApprovals");

            migrationBuilder.DropTable(
                name: "LeaveApprovals");

            migrationBuilder.DropTable(
                name: "LeaveEncashmentRate");

            migrationBuilder.DropTable(
                name: "LeaveRecords");

            migrationBuilder.DropTable(
                name: "ManualAttendances");

            migrationBuilder.DropTable(
                name: "NightAllowances");

            migrationBuilder.DropTable(
                name: "NightAllowanceTimes");

            migrationBuilder.DropTable(
                name: "NomineeInformation");

            migrationBuilder.DropTable(
                name: "OverTimes");

            migrationBuilder.DropTable(
                name: "ProximityRecords");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "SalaryDeduction");

            migrationBuilder.DropTable(
                name: "SalaryProcess");

            migrationBuilder.DropTable(
                name: "SalaryRecords");

            migrationBuilder.DropTable(
                name: "ShiftEmployees");

            migrationBuilder.DropTable(
                name: "SpecialEmployees");

            migrationBuilder.DropTable(
                name: "SpouseInformation");

            migrationBuilder.DropTable(
                name: "Suspend");

            migrationBuilder.DropTable(
                name: "TaxAmount");

            migrationBuilder.DropTable(
                name: "TaxRule");

            migrationBuilder.DropTable(
                name: "TiffinAllowanceRates");

            migrationBuilder.DropTable(
                name: "TiffinAllowanceTimes");

            migrationBuilder.DropTable(
                name: "Units");

            migrationBuilder.DropTable(
                name: "AttendanceConfigurations");

            migrationBuilder.DropTable(
                name: "AttendanceStatuss");

            migrationBuilder.DropTable(
                name: "LeaveEncashment");

            migrationBuilder.DropTable(
                name: "LeaveTypes");

            migrationBuilder.DropTable(
                name: "MaternityBill");

            migrationBuilder.DropTable(
                name: "SalaryEntry");

            migrationBuilder.DropTable(
                name: "DateWiseOfficeTimes");

            migrationBuilder.DropTable(
                name: "TaxExempted");

            migrationBuilder.DropTable(
                name: "MaternityConfiguration");

            migrationBuilder.DropTable(
                name: "EmployeeInformations");

            migrationBuilder.DropTable(
                name: "Designations");

            migrationBuilder.DropTable(
                name: "EmploymentTypes");

            migrationBuilder.DropTable(
                name: "LineInformations");

            migrationBuilder.DropTable(
                name: "SalaryGrades");

            migrationBuilder.DropTable(
                name: "SalarySteps");

            migrationBuilder.DropTable(
                name: "ShiftTimes");

            migrationBuilder.DropTable(
                name: "Buildings");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Grades");

            migrationBuilder.DropTable(
                name: "WeekDay");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Companies");
        }
    }
}
