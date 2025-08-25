using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRIS_R62.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        // <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AttendanceStatuss",
                columns: new[] { "AttendanceStatusID", "StatusName", "StatusShortName" },
                values: new object[,]
                {
                    { "P", "Present", "P" },
                    { "A", "Absent", "A" },
                    { "OL", "On Leave", "On L" },
                    { "WFH", "Work From Home", "WFH" },
                    { "L", "Late", "L" }
                });

            //migrationBuilder.InsertData(
            //    table: "AttendanceConfigurations",
            //    columns: new[] { "AttendanceConfigurationID", "GraceTime", "LunchBreakStartTime", "LunchBreakEndTime", "EveningSnacksBreakStartTime", "EveningSnacksBreakEndTime" },
            //    values: new object[,]
            //   {
            //    { "Config1", "15 min", TimeOnly.Parse("12:30:00"), TimeOnly.Parse("13:30:00"), TimeOnly.Parse("16:00:00"), TimeOnly.Parse("16:15:00") },
            //    { "Config2", "30 min", TimeOnly.Parse("13:00:00"), TimeOnly.Parse("14:00:00"), TimeOnly.Parse("15:30:00"), TimeOnly.Parse("15:45:00") },
            //    { "Config3", "10 min", TimeOnly.Parse("12:45:00"), TimeOnly.Parse("13:15:00"), TimeOnly.Parse("16:15:00"), TimeOnly.Parse("16:30:00") },
            //    { "Config4", "20 min", TimeOnly.Parse("12:00:00"), TimeOnly.Parse("13:00:00"), TimeOnly.Parse("15:45:00"), TimeOnly.Parse("16:00:00") },
            //    { "Config5", "25 min", TimeOnly.Parse("13:15:00"), TimeOnly.Parse("14:15:00"), TimeOnly.Parse("16:30:00"), TimeOnly.Parse("16:45:00") }
            //   });

            migrationBuilder.InsertData(
                table: "AttendanceConfigurations",
                columns: new[] { "AttendanceConfigurationID", "GraceTime", "LunchBreakStartTime", "LunchBreakEndTime", "EveningSnacksBreakStartTime", "EveningSnacksBreakEndTime" },
                values: new object[,]
    {
        { "Config1", TimeSpan.Parse("00:15:00"), TimeSpan.Parse("12:30:00"), TimeSpan.Parse("13:30:00"), TimeSpan.Parse("16:00:00"), TimeSpan.Parse("16:15:00") },
        { "Config2", TimeSpan.Parse("00:30:00"), TimeSpan.Parse("13:00:00"), TimeSpan.Parse("14:00:00"), TimeSpan.Parse("15:30:00"), TimeSpan.Parse("15:45:00") },
        { "Config3", TimeSpan.Parse("00:10:00"), TimeSpan.Parse("12:45:00"), TimeSpan.Parse("13:15:00"), TimeSpan.Parse("16:15:00"), TimeSpan.Parse("16:30:00") },
        { "Config4", TimeSpan.Parse("00:20:00"), TimeSpan.Parse("12:00:00"), TimeSpan.Parse("13:00:00"), TimeSpan.Parse("15:45:00"), TimeSpan.Parse("16:00:00") },
        { "Config5", TimeSpan.Parse("00:25:00"), TimeSpan.Parse("13:15:00"), TimeSpan.Parse("14:15:00"), TimeSpan.Parse("16:30:00"), TimeSpan.Parse("16:45:00") }
    });




            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyID", "CompanyName", "CompanyShortName", "CompanyNameLocal", "CompanyAddress", "PhoneNumber", "FaxNumber", "Email" },
                values: new object[,]
               {
                { "C001", "Tech Solutions Ltd.", "TSL", "Tech", "12 Gulshan Avenue, Dhaka", "01711112222", "880-2-8822333", "info@techsl.com" },
                { "C002", "Delta Garments", "DG", "Delta", "House 45, Uttara, Dhaka", "01822223333", "880-2-8822444", "contact@deltagarm.com" },
                { "C003", "Green Life Pharma", "GLP", "Green", "45 Green Road, Dhaka", "01933334444", "880-2-8822555", "support@glpharma.com" },
                { "C004", "Blue Ocean Textiles", "BOT", "Blue", "Plot 22, CEPZ, Chittagong", "01755556666", "880-31-772200", "hr@blueoceantx.com" },
                { "C005", "Star Logistics", "SL", "Star", "Airport Road, Dhaka", "01677778888", "880-2-8822666", "logistics@starltd.com" }
               });

            migrationBuilder.InsertData(
           table: "Departments",
           columns: new[] { "DepartmentID", "DepartmentName", "DepartmentShortName", "DepartmentNameLocal", "CompanyID" },
           values: new object[,]
           {
                { "D001", "Human Resources", "HR", "Human", "C001" },
                { "D002", "Finance", "FIN", "Finance", "C001" },
                { "D003", "Production", "PROD", "Production", "C002" },
                { "D004", "IT Department", "IT", "IT", "C003" },
                { "D005", "Sales & Marketing", "S&M", "Sales", "C002" }
           });

            migrationBuilder.InsertData(
                table: "Buildings",
                columns: new[] { "BuildingID", "Floor", "RoomNumber", "Name", },
                values: new object[,]
            {
                { "B001", "1st Floor", "101", "Main Office"},
                { "B002", "2nd Floor", "201", "HR Department" },
                { "B003", "3rd Floor", "301", "IT Department"},
                { "B004", "Ground Floor", "G01", "Reception"},
                { "B005", "1st Floor", "102", "Conference Room" }
            });

            migrationBuilder.InsertData(
            table: "Sections",
            columns: new[] { "SectionsID", "SectionName", "SectionShortName", "SectionNameNative", "DepartmentID" },
            values: new object[,]
            {
                { "S001", "Production", "PRD", "Production", "D001" },
                { "S002", "Quality", "QTY", "Quality", "D002" },
                { "S003", "Maintenance", "MNT", "Maintenance", "D003" },
                { "S004", "HR", "HR", "HR", "D004" },
                { "S005", "Logistics", "LOG", "Logistics", "D005" }
            });


            migrationBuilder.InsertData(
            table: "Units",
            columns: new[] { "UnitID", "UnitName", "CompanyID" },
            values: new object[,]
            {
                { "U001", "Unit A", "C001" },
                { "U002", "Unit B", "C001" },
                { "U003", "Unit C", "C001" },
                { "U004", "Unit D", "C001" },
                { "U005", "Unit E", "C001" }
            });




            migrationBuilder.InsertData(
            table: "Divisions",
            columns: new[] { "DivisionID", "DivisionName", "DivisionShortName" },
            values: new object[,]
            {
                { "D001", "Manufacturing", "MFG" },
                { "D002", "Sales", "SLS"},
                { "D003", "Finance", "FIN"},
                { "D004", "Research", "R&D"},
                { "D005", "Customer Service", "CS",}
            });

            migrationBuilder.InsertData(
            table: "LineInformations",
            columns: new[] { "LineID", "LineName", "EntryDate", "BuildingID", "SectionsID" },
            values: new object[,]
            {
                { "L001", "Line A", DateTime.Parse("2025-05-27"), "B001", "S001"},
                { "L002", "Line B", DateTime.Parse("2025-05-27"), "B002", "S002"},
                { "L003", "Line C", DateTime.Parse("2025-05-27"), "B003", "S003"},
                { "L004", "Line D", DateTime.Parse("2025-05-27"), "B004", "S004"},
                { "L005", "Line E", DateTime.Parse("2025-05-27"), "B005", "S005"}
            });



            migrationBuilder.InsertData(
            table: "Designations",
            columns: new[] { "DesignationID", "DesignationName", "DesignationShortName" },
            values: new object[,]
            {
                { "DSG001", "Manager", "Manager" },
                { "DSG002", "Assistant Manager", "Assistant" },
                { "DSG003", "Executive", "Executive" },
                { "DSG004", "Technician", "Technician" },
                { "DSG005", "Operator", "Operator" }
            });

            migrationBuilder.InsertData(
            table: "Grades",
            columns: new[]
{
                "GradeID", "GradeShortID", "GradeName", "FromGrossSalary", "ToGrossSalary",
                "Gross", "Basic", "HouseRent", "Medical", "ConveyanceAllowance", "LunchAllowance"
            },
            values: new object[,]
            {
                { "GRD001", "G1", "Grade A", 30000m, 39999m, 35000m, 17500m, 10500m, 1500m, 2000m, 1500m },
                { "GRD002", "G2", "Grade B", 20000m, 29999m, 25000m, 12500m, 7500m, 1200m, 1800m, 1000m },
                { "GRD003", "G3", "Grade C", 15000m, 19999m, 17000m, 8500m, 5100m, 1000m, 1600m, 800m },
                { "GRD004", "G4", "Grade D", 10000m, 14999m, 12000m, 6000m, 3600m, 800m, 1400m, 700m },
                { "GRD005", "G5", "Grade E", 5000m, 9999m, 8000m, 4000m, 2400m, 500m, 1200m, 600m }
            });





            migrationBuilder.InsertData(
            table: "EmploymentTypes",
            columns: new[] { "EmploymentTypeID", "EmploymentTypeName" },
            values: new object[,]
            {
                { "EMP_TYPE_001", "Permanent" },
                { "EMP_TYPE_002", "Contractual" },
                { "EMP_TYPE_003", "Temporary" },
                { "EMP_TYPE_004", "Part-Time" },
                { "EMP_TYPE_005", "Intern" }
            });

            migrationBuilder.InsertData(
            table: "SalaryGrades",
            columns: new[] { "SalaryGradeID", "GradeName", "GradeStatus", "RuleName", "EffectiveDate", "GradeID" },
            values: new object[,]
            {
                { "SG001", "Junior Officer Grade", "Active", "Rule2020", DateTime.Parse("2023-01-01"), "GRD001" },
                { "SG002", "Officer Grade", "Active", "Rule2021", DateTime.Parse("2023-06-01"), "GRD002" },
                { "SG003", "Senior Officer Grade", "Active", "Rule2022", DateTime.Parse("2023-11-15"), "GRD003" },
                { "SG004", "Assistant Manager Grade", "Active", "Rule2023", DateTime.Parse("2024-02-10"), "GRD004" },
                { "SG005", "Manager Grade", "Active", "Rule2024", DateTime.Parse("2024-05-25"), "GRD005" }
            });


            migrationBuilder.InsertData(
            table: "SalarySteps",

            columns: new[]
            { "SalaryStepID", "GradeID", "StepNumber", "BasicSalary", "HouseAllowance", "MedicalAllowance", "ConveyanceAllowance", "LunchAllowance", "GrossSalary", "StepStatus" },

        values: new object[,]
        {
                { "SS001", "GRD001", 1, 30000.00m, 5000.00m, 2000.00m, 1000.00m, 1500.00m, 39500.00m, "Active" },
                { "SS002", "GRD002", 2, 32000.00m, 5200.00m, 2100.00m, 1100.00m, 1600.00m, 42000.00m, "Active" },
                { "SS003", "GRD003", 3, 34000.00m, 5400.00m, 2200.00m, 1200.00m, 1700.00m, 44500.00m, "Active" },
                { "SS004", "GRD004", 4, 36000.00m, 5600.00m, 2300.00m, 1300.00m, 1800.00m, 47000.00m, "Active" },
                { "SS005", "GRD005", 5, 38000.00m, 5800.00m, 2400.00m, 1400.00m, 1900.00m, 49500.00m, "Active" }
        });

            migrationBuilder.InsertData(
            table: "ShiftEmployees",
            columns: new[] { "ShiftEmployeeID", "FromDate", "ToDate" },
            values: new object[,]
            {
                { "SE001", DateTime.Parse("2025-01-01"), DateTime.Parse("2025-06-30") },
                { "SE002", DateTime.Parse("2025-02-01"), null },
                { "SE003", DateTime.Parse("2025-03-01"), DateTime.Parse("2025-09-30")},
                { "SE004", DateTime.Parse("2025-04-01"), null },
                { "SE005", DateTime.Parse("2025-05-01"), DateTime.Parse("2025-12-31") }
        });

            migrationBuilder.InsertData(
              table: "WeekDay",
              columns: new[]
              {"WeekDayID", "WeekDayName", "WeekDayShortName", "IsWeekend"},

              values: new object[,]
           {
                {"WD001", "Sunday", "SD", false},
                {"WD002", "Monday", "MD", false},
                {"WD003", "Tuesday", "TD", false},
                {"WD004", "Wednesday", "WD", false},
                {"WD005", "Thursday", "ThD", false},
                {"WD006", "Friday", "FD", true},
                {"WD007", "Saturday", "StD", true}
           });


            migrationBuilder.InsertData(
                table: "ShiftTimes",
                columns: new[]
                {"ShiftID", "ShiftName", "ShiftStart", "ShiftEnd", "StartDate", "EndDate", "ConsideredLunchHour", "BreakDuration", "WeekDayID"},

                values: new object[,]
             {
                {"SFT001", "Morning Shift", new TimeOnly(8, 00, 00), new TimeOnly(17, 00, 00), DateOnly.Parse("2025-06-01"), DateOnly.Parse("2025-12-31"), 1, 0.5m, "WD001"},
                {"SFT002", "Evening Shift", new TimeOnly(17, 00, 00), new TimeOnly(1, 00, 00), DateOnly.Parse("2025-06-01"), DateOnly.Parse("2025-12-31"), 1, 0.75m,"WD002"},
                { "SFT003", "Night Shift", new TimeOnly(1, 00, 00), new TimeOnly(8, 00, 00), DateOnly.Parse("2025-06-01"), DateOnly.Parse("2025-12-31"), null, 1.0m, "WD003"}
             });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[]
                {"GenderID", "GenderName", "EmployeeID"},

                values: new object[,]
            {
                {"G001", "Male", "E001"},
                {"G002", "Female", "E002"},
                {"G003", "Others", "E003"}
            });

            migrationBuilder.InsertData(
            table: "EmployeeInformations",
            columns: new[]
            {
                "EmployeeID", "IsLineSelected","GenderID", "ReligionID", "LineID", "EmployeeName", "EmployeeNameLocal",
                "DesignationID" ,"ShiftID","ProximityNumber", "IsOTAllowed",
                "IDentificationMark", "EmploymentTypeID", "PresentAddress", "PermanentAddress", "Telephone", "MobileNumber",
                "Email", "NationalIDNumber", "IsMobileBanking", "AccountNumber", "BankName", "FatherName", "FatherNameLocal",
                "FatherOccupation", "MotherName", "MotherNameLocal", "MotherOccupation", "DateOfBirth", "PlaceOfBirth",
                "DistrictOfBirth", "Nationality", "BloodGroup", "Age", "MaritalStatus", "DateOfMarriage",
                 "JoiningDate", "PostingDate", "ConfirmationDate", "RetirementDate", "ServiceLength",
                "SpouseName", "SpouseOccupation", "SpouseDateOfBirth", "SpouseBloodGroup", "CurrentSalary",
                "SalaryAtJoining","SalaryGradeID", "PassportNumber", "PassportIssueDate", "PassportExpiryDate",
                "PassportIssuePlace", "PassportIssueAuthority", "ReferenceName1", "ReferenceAddress1", "ReferencePhone1", "ReferenceOccupation1",
                "ReferenceRelation1", "ReferenceName2", "ReferenceAddress2", "ReferencePhone2", "ReferenceOccupation2",
                "ReferenceRelation2", "LocalAreaClerance", "LocalAreaRemarks", "EmployeePhoto", "EmployeeSignature",
                "OldEmployeeID", "PreviousEmployeeID", "ApprovedDate", "EmployeeStatus"
            },
            values: new object[,]
            {
            {
                "E001", "Yes","G001","R001", "L001", "John Doe", "John",
                  "DSG001","SFT001", "PN123456", true,
                "Scar on left cheek", "EMP_TYPE_001", "123 Main St", "456 Elm St", "0123456789", "01712345678",
                "john.doe@example.com", "NID123456789", true, "1234567890", "ABC Bank", "Robert Doe", "Robert",
                "Engineer", "Mary Doe", "Mary", "Teacher", new DateTime(1985, 4, 15), "Dhaka", "Dhaka", "Bangladeshi",
                "A+", 40, "Married", new DateTime(2010, 6, 10), new DateTime(2010, 6, 1),
                new DateTime(2010, 6, 15), new DateTime(2011, 6, 15), new DateTime(2045, 6, 1), "15 years", "Jane Doe",
                "Housewife", new DateTime(1987, 8, 22), "O+", 50000m, 30000m,"SG001",
                "P1234567", new DateTime(2015, 1, 1), new DateTime(2025, 1, 1), "Dhaka", "Dhaka Authority",

                "Ref One", "123 Reference St", "0123456789", "Engineer", "Friend",
                "Ref Two", "456 Reference Ave", "0987654321", "Doctor", "Relative",
                "Clear", "Remarks here", "photo.jpg", "signature.jpg", "OLD001", "PREV001", new DateTime(2020, 1, 1), "Active"
            },
            {
                "E002", "No", "G002","R002","L002", "Alice Smith", "Alice", "DSG002","SFT002",
                 "PN123456", false, "Mole on neck", "EMP_TYPE_002", "789 Pine St", "321 Oak St", "0987654321",
                "01898765432", "alice.smith@example.com", "NID987654321", false, "0987654321", "XYZ Bank", "Michael Smith", "Michael", "Manager",
                "Sarah Smith", "Sarah", "Nurse", new DateTime(1990, 7, 20), "Chittagong", "Chittagong", "Bangladeshi", "B+", 35,
                "Single", null,  new DateTime(2015, 9, 15), new DateTime(2015, 10, 1), new DateTime(2016, 10, 1), null, "5 years", "N/A",
                "N/A", null, null,45000m, 35000m,"SG001",
                "P7654321", new DateTime(2016, 3, 1), new DateTime(2026, 3, 1), "Chittagong", "Chittagong Authority",
                "Ref A", "789 Reference St", "0234567891", "Teacher", "Colleague", "Ref B", "654 Reference Blvd", "1098765432",
                "Engineer", "Friend", "Clear", "No remarks", "photo2.jpg", "signature2.jpg", "OLD002", "PREV002", new DateTime(2019, 5, 5), "Inactive"
            },
                {
                "E003", "Yes","G002","R002", "L003", "Bob Johnson", "Bob", "DSG003","SFT003",
                  "PN123456",true, "Tattoo on arm", "EMP_TYPE_003", "135 Maple St", "246 Birch St", "0112233445",
                "01911223344", "bob.johnson@example.com", "NID112233445", true, "1122334455", "DEF Bank", "William Johnson", "William", "Clerk",
                "Emma Johnson", "Emma", "Artist", new DateTime(1982, 11, 5), "Khulna", "Khulna", "Bangladeshi", "AB-", 43,
                "Married", new DateTime(2008, 3, 20),  new DateTime(2008, 3, 10), new DateTime(2008, 3, 25), new DateTime(2009, 3, 25), new DateTime(2043, 3, 1), "17 years", "Anna Johnson",
                "Teacher", new DateTime(1985, 9, 15), "B+", 55000m, 32000m,"SG003",
                "P1122334", new DateTime(2014, 5, 1), new DateTime(2024, 5, 1), "Khulna", "Khulna Authority",
                "Ref X", "135 Reference St", "0147852369", "Driver", "Neighbor", "Ref Y", "246 Reference Ave", "0198745632",
                "Engineer", "Friend", "Clear", "Some remarks", "photo3.jpg", "signature3.jpg", "OLD003", "PREV003",  new DateTime(2018, 3, 3), "Active"
            },
                    {
                "E004", "No", "G002","R001", "L004", "Carol White", "Carol", "DSG004","SFT001",
                  "PN123456",false, "Scar on right hand", "EMP_TYPE_004", "246 Cedar St", "135 Spruce St", "0223344556",
                "01644556677", "carol.white@example.com", "NID223344556", false, "2233445566", "GHI Bank", "David White", "David", "Supervisor",
                "Nancy White", "Nancy", "Doctor", new DateTime(1988, 12, 10), "Rajshahi", "Rajshahi", "Bangladeshi", "O-", 37,
                "Married", new DateTime(2012, 11, 25), new DateTime(2012, 11, 20), new DateTime(2012, 12, 5), new DateTime(2013, 12, 5), new DateTime(2047, 11, 20), "13 years", "Mark White",
                "Engineer", new DateTime(1990, 6, 30), "A+", 48000m, 33000m,"SG004",
                "P2233445", new DateTime(2017, 2, 1), new DateTime(2027, 2, 1), "Rajshahi", "Rajshahi Authority",
                "Ref M", "246 Reference Rd", "0176543210", "Engineer", "Friend", "Ref N", "135 Reference Ln", "0198765430",
                "Teacher", "Colleague", "Clear", "No remarks", "photo4.jpg", "signature4.jpg", "OLD004", "PREV004", new DateTime(2021, 6, 1), "Active"
            },    {
                "E005", "Yes","G002","R002", "L005", "David Brown", "David", "DSG005","SFT002",
                  "PN123456",true, "Birthmark on neck", "EMP_TYPE_005", "357 Willow St", "468 Aspen St", "0334455667",
                "01555667788", "david.brown@example.com", "NID334455667", true, "3344556677", "JKL Bank", "George Brown", "George", "Technician",
                "Lisa Brown", "Lisa", "Nurse", new DateTime(1992, 5, 17), "Sylhet", "Sylhet", "Bangladeshi", "B-", 32,
                "Single", null, new DateTime(2018, 7, 10), new DateTime(2018, 7, 25), new DateTime(2019, 7, 25), null, "4 years", "N/A",
                "N/A", null, null, 47000m, 31000m,"SG005",
                "P3344556", new DateTime(2019, 1, 1), new DateTime(2029, 1, 1), "Sylhet", "Sylhet Authority",
                "Ref Z", "357 Reference St", "0151234567", "Accountant", "Colleague", "Ref W", "468 Reference Ave", "0167654321",
                "Engineer", "Friend", "Clear", "Remarks here", "photo5.jpg", "signature5.jpg", "OLD005", "PREV005", new DateTime(2022, 8, 15), "Active"
        }
        });


            migrationBuilder.InsertData(
            table: "AttendanceBonus",
            columns: new[]

                { "AttendanceBonusID", "BonusAmount", "BonusCategory", "EmployeeID" },

            values: new object[,]
            {
                { "AB001", 1000m, "Monthly", "E001"},
                { "AB002", 1200m, "Quarterly", "E002"},
                { "AB003", 1500m, "Monthly","E003"}
            });


            migrationBuilder.InsertData(
            table: "DateWiseOfficeTimes",
            columns: new[] { "DateWiseOfficeTimeID", "ShiftStartDateTime", "ShiftEndDateTime", "ConsideredLunchHour", "BreakDuration" },
            values: new object[,]
            {
                { "DOT001", DateTime.Parse("2025-05-01 08:00:00"), DateTime.Parse("2025-05-01 17:00:00"), TimeOnly.Parse("01:00:00"), TimeOnly.Parse("00:30:00") },
                { "DOT002", DateTime.Parse("2025-05-01 09:00:00"), DateTime.Parse("2025-05-01 18:00:00"), TimeOnly.Parse("01:00:00"), TimeOnly.Parse("00:45:00") },
                { "DOT003", DateTime.Parse("2025-05-02 07:30:00"), DateTime.Parse("2025-05-02 16:30:00"), TimeOnly.Parse("00:45:00"), TimeOnly.Parse("00:30:00")},
                { "DOT004", DateTime.Parse("2025-05-03 08:30:00"), DateTime.Parse("2025-05-03 17:30:00"), TimeOnly.Parse("01:00:00"), TimeOnly.Parse("00:15:00")},
                { "DOT005", DateTime.Parse("2025-05-04 09:00:00"), DateTime.Parse("2025-05-04 18:00:00"), TimeOnly.Parse("01:00:00"), TimeOnly.Parse("00:30:00") }
});

            migrationBuilder.InsertData(
            table: "SalaryRecords",
            columns: new[]
            {
                "SalaryRecordID", "SalaryStartDate", "SalaryEndDate", "SalaryStepID", "JoiningDate", "MonthDays", "PunchDays",
                "TotalHoliDay", "TotalLeave", "WorkingDays", "Absenteeism", "Gross", "ActualGross", "Basic",
                "HouseRent", "MedicalAllowance", "MobileAllowance", "OtherAllowances", "LunchAllowance",
                "Tax", "OtherDeduction", "OTHours", "OTAmount", "ByBankAmount", "ByCashAmount", "NetPayable",
                "ConveyanceAllowance", "AttendanceBonus", "SpecialAllowance", "SalaryAdvance", "FoodCharge",
                "OTRate", "TiffinAllowance", "Arrear", "SpecialBonus", "LeaveStatus", "HoliDayBillAmount",
                "NightBillAmount", "SalaryID", "LunchBillAmount", "MobileBanking", "AccountNumber", "BankName",
                "ProcessDate", "EmployeeID"
            },
            values: new object[,]
            {
                {
                    "SR001", DateTime.Parse("2025-05-01"), DateTime.Parse("2025-05-31"), "SS001" ,DateTime.Parse("2025-01-10"), 31, 30,
                    2, 1, 28, 0.0, 50000.00, 50000.00, 20000.00, 10000.00, 5000.00, 1000.00, 2000.00, 1500.00,
                    5000.00, 500.00, 10.0, 1000.00, 25000.00, 25000.00, 45000.00, 2000.00, 1000.00, 1500.00,
                    2000.00, 500.00, 50.00, 100.00, 200.00, 300.00, "Active", 1000.00, 2000.00, 1, 500.00, true,
                    "ACC123456", "Bank ABC", DateTime.Parse("2025-05-27"), "E001"
                },
                {
                    "SR002", DateTime.Parse("2025-05-01"), DateTime.Parse("2025-05-31"), "SS002", DateTime.Parse("2024-11-15"), 31, 29,
                    2, 2, 27, 1.0, 48000.00, 47000.00, 19000.00, 9500.00, 4800.00, 800.00, 1000.00, 1200.00,
                    4500.00, 300.00, 15.0, 1500.00, 23500.00, 23000.00, 44000.00, 1800.00, 900.00, 1200.00,
                    1800.00, 400.00, 60.00, 90.00, 150.00, 250.00, "Active", 900.00, 1500.00, 2, 400.00, false,
                    "ACC654321", "Bank XYZ", DateTime.Parse("2025-05-27"), "E002"
                },
                {
                    "SR003", DateTime.Parse("2025-05-01"), DateTime.Parse("2025-05-31"),"SS003", DateTime.Parse("2023-03-01"), 31, 31,
                    0, 0, 31, 0.0, 60000.00, 60000.00, 25000.00, 12000.00, 6000.00, 1100.00, 1300.00, 1700.00,
                    6000.00, 400.00, 12.0, 1200.00, 28000.00, 28000.00, 51000.00, 2200.00, 1100.00, 1600.00,
                    2300.00, 600.00, 55.00, 110.00, 220.00, 330.00, "Active", 1100.00, 2000.00, 3, 600.00, true,
                    "ACC999999", "Bank DEF", DateTime.Parse("2025-05-27"), "E003"
                },
                {
                    "SR004", DateTime.Parse("2025-05-01"), DateTime.Parse("2025-05-31"),"SS004", DateTime.Parse("2022-06-05"), 31, 28,
                    3, 1, 27, 0.0, 40000.00, 39500.00, 16000.00, 8000.00, 4000.00, 900.00, 1000.00, 1300.00,
                    4000.00, 350.00, 8.0, 800.00, 20000.00, 19000.00, 39000.00, 1700.00, 850.00, 1400.00,
                    1800.00, 450.00, 45.00, 80.00, 190.00, 260.00, "Active", 950.00, 1700.00, 4, 450.00, false,
                    "ACC121212", "Bank GHI", DateTime.Parse("2025-05-27"), "E004"
                },
                {
                    "SR005", DateTime.Parse("2025-05-01"), DateTime.Parse("2025-05-31"),"SS005", DateTime.Parse("2021-08-20"), 31, 27,
                    4, 1, 26, 1.5, 52000.00, 51000.00, 21000.00, 10500.00, 5200.00, 1000.00, 2200.00, 1600.00,
                    5200.00, 450.00, 11.0, 1100.00, 25500.00, 25500.00, 46500.00, 1900.00, 950.00, 1550.00,
                    2100.00, 550.00, 52.00, 95.00, 210.00, 310.00, "Active", 1050.00, 1900.00, 5, 550.00, true,
                    "ACC333333", "Bank JKL", DateTime.Parse("2025-05-27"),"E005"
                }
            });

            migrationBuilder.InsertData(
            table: "AttendanceRecords",
            columns: new[]
            {
                    "AttendanceRecordID", "AttendanceDate", "InTime", "OutTime", "OTStart", "OTEnd", "TotalRegularHours", "TotalOvertimeHours", "DayType", "AttendanceStatusID","EmployeeID","AttendanceConfigurationID","Status"
            },
            values: new object[,]
            {
                    { "AR001", new DateTime(2025, 5, 27), TimeOnly.Parse("08:00:00"), TimeOnly.Parse("17:00:00"), TimeOnly.Parse("17:30:00"), TimeOnly.Parse("19:00:00"), TimeSpan.Parse("09:00:00"), TimeSpan.Parse("01:30:00"), "Weekday", "P","E001","Config1","Good" },
                    {"AR002", new DateTime(2025, 5, 26), TimeOnly.Parse("08:15:00"), TimeOnly.Parse("17:05:00"), TimeOnly.Parse("17:30:00"), TimeOnly.Parse("18:30:00"), TimeSpan.Parse("08:50:00"), TimeSpan.Parse("01:00:00"), "Weekday", "A", "E002", "Config2", "Good"},
                    {"AR003", new DateTime(2025, 5, 25), TimeOnly.Parse("08:00:00"), TimeOnly.Parse("17:00:00"), TimeOnly.Parse("00:00:00"), TimeOnly.Parse("00:00:00"), TimeSpan.Parse("09:00:00"), TimeSpan.Parse("00:00:00"), "Weekend", "OL", "E003", "Config3", "Good"},
                    {"AR004", new DateTime(2025, 5, 24), TimeOnly.Parse("08:45:00"), TimeOnly.Parse("17:00:00"), TimeOnly.Parse("17:10:00"), TimeOnly.Parse("18:00:00"), TimeSpan.Parse("08:15:00"), TimeSpan.Parse("00:50:00"), "Weekday", "WFH", "E004", "Config4", "Good"},
                    {"AR005", new DateTime(2025, 5, 23), TimeOnly.Parse("08:00:00"), TimeOnly.Parse("16:00:00"), TimeOnly.Parse("00:00:00"), TimeOnly.Parse("00:00:00"), TimeSpan.Parse("08:00:00"), TimeSpan.Parse("00:00:00"), "Weekday", "L", "E005", "Config5", "Good"}
            });

            migrationBuilder.InsertData(
            table: "LeaveTypes",
            columns: new[]
            {
                "LeaveTypeID", "LeaveTypeName", "EntryUser", "EntryDate"
            },
            values: new object[,]
            {
                { "LT001", "Sick Leave", "admin", new DateTime(2025, 1, 1) },
                { "LT002", "Casual Leave", "admin", new DateTime(2025, 1, 1) },
                { "LT003", "Emergency Leave", "admin", new DateTime(2025, 1, 1) },
                { "LT004", "Earned Leave", "admin", new DateTime(2025, 1, 1) },
                { "LT005", "Paternity Leave", "admin", new DateTime(2025, 1, 1) }
            });

            migrationBuilder.InsertData(
                table: "LeaveApprovals",
                columns: new[]
                {
                "LeaveApprovalID", "LeaveTypeID", "LeaveFromDate", "LeaveToDate", "Remarks", "ApprovedDate", "LeaveEnjoyed", "TotalLeave", "ProvidedLeave", "EmployeeID", "EntryUser", "EntryDate"
                },
                values: new object[,]
                {
            { "LA001", "LT001", new DateTime(2025, 1, 10), new DateTime(2025, 1, 12), "Approved due to health issue", new DateTime(2025, 1, 9), "2", "12", "10", "E001", "admin", new DateTime(2025, 1, 10) },
            { "LA002", "LT002", new DateTime(2025, 2, 15), new DateTime(2025, 2, 15), "For personal work", new DateTime(2025, 2, 14), "1", "10", "10", "E002", "manager01", new DateTime(2025, 2, 15) },
            { "LA003", "LT003", new DateTime(2025, 3, 5), new DateTime(2025, 3, 10), "Long family vacation", new DateTime(2025, 3, 4), "5", "15", "12", "E003", "hruser", new DateTime(2025, 3, 5) },
            { "LA004", "LT004", new DateTime(2025, 4, 20), new DateTime(2025, 4, 21), "Urgent home visit", new DateTime(2025, 4, 19), "2", "8", "8", "E004", "admin", new DateTime(2025, 4, 20) },
            { "LA005", "LT005", new DateTime(2025, 5, 1), new DateTime(2025, 5, 7), "New baby arrival", new DateTime(2025, 4, 30), "7", "7", "7", "E005", "admin", new DateTime(2025, 5, 1) }
                });


            migrationBuilder.InsertData(
            table: "LeaveRecords",
            columns: new[]

            { "LeaveRecordID", "LeaveDate", "Remarks", "LeaveTypeID", "TotalLeave", "LeaveEnjoyed", "ApprovedDate", "EmployeeID", "EntryUser", "EntryDate"},

    values: new object[,]
            {
            { "LR001", new DateTime(2025, 1, 15), "Medical checkup", "LT001", "12", "1", new DateTime(2025, 1, 13), "E001", "admin", new DateTime(2025, 1, 10) },
            { "LR002", new DateTime(2025, 2, 20), "Personal work", "LT002", "10", "2", new DateTime(2025, 2, 19), "E002", "manager01", new DateTime(2025, 2, 18) },
            { "LR003", new DateTime(2025, 3, 5), "Family emergency", "LT003", "8", "1", new DateTime(2025, 3, 4), "E003", "hrteam", new DateTime(2025, 3, 2) },
            { "LR004", new DateTime(2025, 4, 10), "Travel plan", "LT004", "15", "3", new DateTime(2025, 4, 9), "E004", "admin", new DateTime(2025, 4, 8) },
            { "LR005", new DateTime(2025, 5, 25), "Function at home", "LT002", "10", "4", new DateTime(2025, 5, 24), "E005", "admin", new DateTime(2025, 5, 22) }
            });




            migrationBuilder.InsertData(
            table: "EarlyLeaveInformation",
            columns: new[]

            {"EarlyLeaveInformationID", "LeaveDate", "LeaveTime","Remarks","EmployeeID"},

            values: new object[,]
            {
                {"EL001", DateTime.Parse("2025-05-10"), TimeOnly.Parse("14:30"),"Medical checkup" ,"E001"},
                {"EL002", DateTime.Parse("2025-05-12"), TimeOnly.Parse("15:00"),"Personal work" , "E002"},
                {"EL003", DateTime.Parse("2025-05-15"), TimeOnly.Parse("13:15"),"Family emergency" , "E003"},
                {"EL004", DateTime.Parse("2025-05-18"), TimeOnly.Parse("12:45"),"Travel plan" , "E004"},
                {"EL005", DateTime.Parse("2025-05-20"), TimeOnly.Parse("16:00"),"Function at home" , "E005"}
            });





            migrationBuilder.InsertData(
            table: "LateApprovals",
            columns: new[] { "LateApprovalID", "LateDate", "LateReason", "EntryUser", "EmployeeID", "ApprovedDate", "LocalAreaRemarks", "LocalAreaClerance" },
            values: new object[,]
        {
            { "LA001", DateTime.Parse("2025-06-20"), "Traffic congestion", "admin", "E001",DateTime.Parse("2025-06-20"),"Okay","Alright"},
            {"LA002", DateTime.Parse("2025-06-21"), "Medical emergency", "admin", "E002", DateTime.Parse("2025-06-21"), "Okay", "Alright"},
            {"LA003", DateTime.Parse("2025-06-22"), "Family issue", "admin", "E003", DateTime.Parse("2025-06-22"), "Okay", "Alright"}
        });

            migrationBuilder.InsertData(
            table: "ManualAttendances",
            columns: new[]

            { "ManualAttendanceID", "AttendanceDate", "AttendanceTime", "EntryDate", "Reason", "EntryUser", "OutTime","Remarks", "EmployeeID"},

            values: new object[,]{

                {"MA001", DateTime.Parse("2025-06-20"), "08:45", DateTime.Parse("2025-06-20"), "Forgot to punch in", "admin", "17:00", "Manually approved", "E001"},
            {"MA002", DateTime.Parse("2025-06-21"), "09:05", DateTime.Parse("2025-06-21"), "Late due to traffic", "admin", "18:00", "Traffic was unusually heavy", "E002" },
            {"MA003", DateTime.Parse("2025-06-22"), "08:50", DateTime.Parse("2025-06-22"), "System error", "admin", "17:15", "System didn’t record punch", "E003"}
            });


            migrationBuilder.InsertData(
            table: "NightAllowances",
            columns: new[]

            {"NightAllowanceID","SalaryMinimum","SalaryMaximum","NightAllowanceRate","EmploymentTypeID"},

            values: new object[,]
            {
                {"NA001",15000.00m,25000.00m,"5%","EMP_TYPE_001"},
                {"NA002",25001.00m,40000.00m,"7%","EMP_TYPE_002"},
                {"NA003",40001.00m,60000.00m,"10%","EMP_TYPE_003"}
            });

            migrationBuilder.InsertData(
            table: "NightAllowanceTimes",
            columns: new[]
            {"NightAllowanceTimeID","StartDate","EndDate","AllowanceType","NightHours","NightMinutes","EmploymentTypeID"},
            values: new object[,]
            {
                {"NAT001",DateTime.Parse("2025-06-01"),DateTime.Parse("2025-06-30"),"Fixed","08","30","EMP_TYPE_001" },
                {"NAT002",DateTime.Parse("2025-07-01"),DateTime.Parse("2025-07-31"),"Variable","07","45","EMP_TYPE_002"},
                {"NAT003",DateTime.Parse("2025-08-01"),DateTime.Parse("2025-08-31"),"Fixed","09","00","EMP_TYPE_003"}
            });

            migrationBuilder.InsertData(
                table: "OverTimes",
                columns: new[]
                {"OverTimeID","OTDate","OTHours","OTStartTime","OTEndTime","EmployeeID"},
                values: new object[,]
                {
                    {"OT001",DateTime.Parse("2025-06-20"),1f, DateTime.Parse("2025-06-20"),DateTime.Parse("2025-06-20"), "E001"},
                    {"OT002",DateTime.Parse("2025-06-21"),2f, DateTime.Parse("2025-06-21"),DateTime.Parse("2025-06-20"),"E002"},
                    {"OT003",DateTime.Parse("2025-06-22"), 1f, DateTime.Parse("2025-06-21"), DateTime.Parse("2025-06-21"),"E003"}
                });


            migrationBuilder.InsertData(
                table: "ProximityRecords",
                columns: new[]
                {"ProximityRecordID","ProximityNumber","RecordDate","InTime","OutTime","Status","VerifiedBy","EmployeeID"},

                values: new object[,]
             {
                {"PR001","PX1001", DateTime.Parse("2025-06-20"), new TimeOnly(8, 45, 0), new TimeOnly(17, 0, 0),"Valid", "System", "E001"},
                {"PR002", "PX1002", DateTime.Parse("2025-06-21"), new TimeOnly(9, 0, 0), new TimeOnly(18, 0, 0), "Valid", "Admin", "E002"},
                {"PR003", "PX1003", DateTime.Parse("2025-06-22"), new TimeOnly(8, 30, 15), new TimeOnly(17, 15, 15), "Valid", "Admin", "E003"}
             });






            migrationBuilder.InsertData(
                table: "TiffinAllowanceRates",
                columns: new[]
                {"TiffinAllowanceRateID", "RateInTaka", "DesignationID"},

                values: new object[,]
            {
                {"TAR001", 50.00m, "DSG001"},
                {"TAR002", 75.00m, "DSG002"},
                {"TAR003", 100.00m, null }
            });



            migrationBuilder.InsertData(
                table: "TiffinAllowanceTimes",
                columns: new[]
                {"TiffinAllowanceID", "AllowanceDate", "AllowanceType","Time","EmploymentTypeID"},

                values: new object[,]

            {
                {"TA001", DateTime.Parse("2025-06-20"),"Fixed", new TimeOnly(20, 0, 0), "EMP_TYPE_001"},
                {"TA002", DateTime.Parse("2025-06-21"), "Variable", new TimeOnly(19, 30, 0),"EMP_TYPE_002"},
                {"TA003",DateTime.Parse("2025-06-22"),"Fixed",new TimeOnly(21, 0, 0),null}
            });





            migrationBuilder.InsertData(
                table: "Religions",
                columns: new[]
                {"ReligionID", "ReligionName", "EmployeeID"},

                values: new object[,]
            {
                {"R001", "Islam", "E001"},
                {"R002", "Hindu", "E002"},
                {"R003", "Others", "E003"}
            });


        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {




            //migrationBuilder.DeleteData(
            //    table: "SalaryGrades",
            //    keyColumn: "SalaryGradeID",
            //    keyValue: "SG001");

            //migrationBuilder.DeleteData(
            //    table: "SalaryGrades",
            //    keyColumn: "SalaryGradeID",
            //    keyValue: "SG002");

            //migrationBuilder.DeleteData(
            //    table: "SalaryGrades",
            //    keyColumn: "SalaryGradeID",
            //    keyValue: "SG003");

            //migrationBuilder.DeleteData(
            //    table: "SalaryGrades",
            //    keyColumn: "SalaryGradeID",
            //    keyValue: "SG004");

            //migrationBuilder.DeleteData(
            //    table: "SalaryGrades",
            //    keyColumn: "SalaryGradeID",
            //    keyValue: "SG005");

            //migrationBuilder.DeleteData(
            //    table: "Grades",
            //    keyColumn: "GradeID",
            //    keyValue: "G001");

            //migrationBuilder.DeleteData(
            //    table: "Grades",
            //    keyColumn: "GradeID",
            //    keyValue: "G002");

            //migrationBuilder.DeleteData(
            //    table: "Grades",
            //    keyColumn: "GradeID",
            //    keyValue: "G003");

            //migrationBuilder.DeleteData(
            //    table: "Grades",
            //    keyColumn: "GradeID",
            //    keyValue: "G004");

            //migrationBuilder.DeleteData(
            //    table: "Grades",
            //    keyColumn: "GradeID",
            //    keyValue: "G005");




            migrationBuilder.DeleteData(
               table: "LateApprovals",
               keyColumn: "LateApprovalID",
               keyValues: new object[] { "LA001", "LA002", "LA003" });

            migrationBuilder.DeleteData(
                table: "ManualAttendances",
                keyColumn: "ManualAttendanceID",
                keyValues: new object[] { "MA001", "MA002", "MA003" });

            migrationBuilder.DeleteData(
                table: "NightAllowances",
                keyColumn: "NightAllowanceID",
                keyValues: new object[] { "NA001", "NA002", "NA003" });

            migrationBuilder.DeleteData(
                table: "NightAllowanceTimes",
                keyColumn: "NightAllowanceTimeID",
                keyValues: new object[] { "NAT001", "NAT002", "NAT003" });

            migrationBuilder.DeleteData(
                table: "OverTimes",
                keyColumn: "EmployeeOverTimeID",
                keyValues: new object[] { "OT001", "OT002", "OT003" });

            migrationBuilder.DeleteData(
                table: "ProximityRecords",
                keyColumn: "ProximityRecordID",
                keyValues: new object[] { "PR001", "PR002", "PR003" });

            migrationBuilder.DeleteData(
                table: "ShiftTimes",
                keyColumn: "ShiftID",
                keyValues: new object[] { "SFT001", "SFT002", "SFT003" });

            migrationBuilder.DeleteData(
                table: "TiffinAllowanceRates",
                keyColumn: "TiffinAllowanceRateID",
                keyValues: new object[] { "TAR001", "TAR002", "TAR003" });

            migrationBuilder.DeleteData(
                table: "AttendanceBonus",
                keyColumn: "AttendanceBonusID",
                keyValues: new object[] { "AB001", "AB002", "AB003" });
        }
    }
}
