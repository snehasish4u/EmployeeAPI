using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeFinance.Migrations
{
    public partial class spPROC_DesignationMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Attendance_Master",
                columns: table => new
                {
                    Attendance_Id = table.Column<int>(type: "int", nullable: false),
                    Attendance_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Attendance_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Attendance_Salary_Type = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Attendance_OT_Type = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Salary_Calendar_Type = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    Attendance_Reg_Type = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: false),
                    Is_Morethan_WorkDay = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendance_Master", x => x.Attendance_Id);
                });

            migrationBuilder.CreateTable(
                name: "Bank_Master",
                columns: table => new
                {
                    Bank_Id = table.Column<int>(type: "int", nullable: false),
                    Bank_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Bank_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Bank_Sht_Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    BankAccNo = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Address = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Branch_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IFSC_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Pin_No = table.Column<int>(type: "int", nullable: true),
                    Phone_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bank_Master", x => new { x.Bank_Id, x.Bank_Code });
                });

            migrationBuilder.CreateTable(
                name: "CountryMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryCode = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryMaster", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Department_Mst",
                columns: table => new
                {
                    Department_Id = table.Column<int>(type: "int", nullable: false),
                    Department_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Department_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Department_Mst", x => x.Department_Id);
                });

            migrationBuilder.CreateTable(
                name: "Designation_Mst",
                columns: table => new
                {
                    Desig_Id = table.Column<int>(type: "int", nullable: false),
                    Desig_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Desig_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Desig_Sht_Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designation_Mst_1", x => new { x.Desig_Id, x.Desig_Code });
                });

            migrationBuilder.CreateTable(
                name: "Division_Master",
                columns: table => new
                {
                    Division_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Division_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Division_Short_Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Division_Master", x => x.Division_Id);
                });

            migrationBuilder.CreateTable(
                name: "Employee_Details",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Employee_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Employee_Title = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Employee_Name = table.Column<string>(type: "varchar(85)", unicode: false, maxLength: 85, nullable: true),
                    FathersName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    MothersName = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NomineeName = table.Column<string>(type: "varchar(47)", unicode: false, maxLength: 47, nullable: true),
                    Gender = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Occupation = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Division = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Grade = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Emp_Attendance = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BloodGroup = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime", nullable: true),
                    Present_Res_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Present_Res_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Present_Road = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Present_Area = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Present_City = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Present_State = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Present_Pincode = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    Permanent_Res_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Permanent_Res_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Permanent_Road = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Permanent_Area = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Permanent_City = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Permanent_State = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Permanent_Pincode = table.Column<string>(type: "varchar(6)", unicode: false, maxLength: 6, nullable: true),
                    Marital_Status = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Ward_Circle = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    BankAcNo = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Bank_Name = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Branch_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Email_ID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Is_Default_EmailId = table.Column<bool>(type: "bit", nullable: true),
                    Alt_Email_ID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Is_Default_Alt_EmailId = table.Column<bool>(type: "bit", nullable: true),
                    CC_Email_ID = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    STD_Code = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PhoneNo = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    Mobile = table.Column<string>(type: "varchar(15)", unicode: false, maxLength: 15, nullable: true),
                    PANno = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AAdhar_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    UAN_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    VoterId = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PassportNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Marriage_Date = table.Column<DateTime>(type: "date", nullable: true),
                    Department_Id = table.Column<int>(type: "int", nullable: true),
                    Desig_Id = table.Column<int>(type: "int", nullable: true),
                    Emp_Cate_Id = table.Column<int>(type: "int", nullable: true),
                    Employee_Image = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date_of_Join = table.Column<DateTime>(type: "date", nullable: true),
                    Salary_Calc_From = table.Column<DateTime>(type: "date", nullable: true),
                    Is_Leaving = table.Column<bool>(type: "bit", nullable: true),
                    Date_of_Leave = table.Column<DateTime>(type: "date", nullable: true),
                    Reason_Of_Leave = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Past_Service_inDay = table.Column<int>(type: "int", nullable: true),
                    IsESI = table.Column<bool>(type: "bit", nullable: true),
                    ESI_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    ESI_Dispensary = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    IsPF = table.Column<bool>(type: "bit", nullable: true),
                    PF_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    PF_Dept_File = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Is_Restrict_PF = table.Column<bool>(type: "bit", nullable: true),
                    Is_Zero_Pension = table.Column<bool>(type: "bit", nullable: true),
                    Is_Zero_PT = table.Column<bool>(type: "bit", nullable: true),
                    IsGRI = table.Column<bool>(type: "bit", nullable: true),
                    GRI_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    IsInsurance = table.Column<bool>(type: "bit", nullable: true),
                    Insurance_No = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    IsDisabled = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    IsInternationalworker = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    IsHigherEPF = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    IsHigherEPS = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Salary_Structure_id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Details", x => new { x.EmployeeId, x.Employee_Code });
                });

            migrationBuilder.CreateTable(
                name: "Employee_Disciplinary_DTL",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Employee_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Employee_Dis_Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Memo = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Issue_By = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Issue_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Comments = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Dis_Id", x => new { x.EmployeeId, x.Employee_Code, x.Employee_Dis_Id });
                });

            migrationBuilder.CreateTable(
                name: "Employee_Education_DTL",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Employee_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Employee_Edu_Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Qualfication = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    University = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Year_Passed = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Percentage = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Edu_Id", x => new { x.EmployeeId, x.Employee_Code, x.Employee_Edu_Id });
                });

            migrationBuilder.CreateTable(
                name: "Employee_EXTRA_CURRICULAR_DTL",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Employee_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Employee_Curr_Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Activity_Name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Event_Name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    From_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    To_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Award = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Curr_Id", x => new { x.EmployeeId, x.Employee_Code, x.Employee_Curr_Id });
                });

            migrationBuilder.CreateTable(
                name: "Employee_Family_Details",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Employee_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Employee_fam_Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Relative_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Relation = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Date_Of_Birth = table.Column<DateTime>(type: "datetime", nullable: true),
                    Gender = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_fam_Id", x => new { x.EmployeeId, x.Employee_Code, x.Employee_fam_Id });
                });

            migrationBuilder.CreateTable(
                name: "Employee_Salary_Structure",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Sal_Str_Id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Effective_From = table.Column<DateTime>(type: "date", nullable: true),
                    Employee_Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Payhead_Id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Salary_Structure", x => new { x.RowId, x.Emp_Sal_Str_Id });
                });

            migrationBuilder.CreateTable(
                name: "Employee_Training_DTL",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    Employee_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Employee_Tra_Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Training_Name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    From_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    To_Date = table.Column<DateTime>(type: "datetime", nullable: true),
                    Comments = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Remarks = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee_Tra_Id", x => new { x.EmployeeId, x.Employee_Code, x.Employee_Tra_Id });
                });

            migrationBuilder.CreateTable(
                name: "ESIGroup_Mst",
                columns: table => new
                {
                    ESIGroup_Id = table.Column<int>(type: "int", nullable: false),
                    ESIGroup_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ESIGroup_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ESI_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    ESI_Local_Office = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Is_Limit_ESI_Gross = table.Column<bool>(type: "bit", nullable: true),
                    Is_Individual_Calc = table.Column<bool>(type: "bit", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ESIgrp_Mst", x => new { x.ESIGroup_Id, x.ESIGroup_Code });
                });

            migrationBuilder.CreateTable(
                name: "Grade_Master",
                columns: table => new
                {
                    Grade_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Grade_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Grade_Master", x => x.Grade_Id);
                });

            migrationBuilder.CreateTable(
                name: "HoliDay_Master",
                columns: table => new
                {
                    Holiday_Id = table.Column<int>(type: "int", nullable: false),
                    Holiday_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Is_National_Holiday = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Is_Branch_Wise = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoliDay_Master", x => new { x.Holiday_Id, x.Holiday_Code });
                });

            migrationBuilder.CreateTable(
                name: "Leave_Master",
                columns: table => new
                {
                    Leave_Id = table.Column<int>(type: "int", nullable: false),
                    Leave_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Leave_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Leave_Short_Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Is_Affect_salary = table.Column<bool>(type: "bit", nullable: true),
                    Is_Alloted = table.Column<bool>(type: "bit", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Leave_Master", x => new { x.Leave_Id, x.Leave_Code });
                });

            migrationBuilder.CreateTable(
                name: "Lumsum_Editor_Mst",
                columns: table => new
                {
                    Lumsum_Editor_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Lumsum_Editor_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Lumsum_Editor_Type = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Lumsum_Editor_Grade = table.Column<int>(type: "int", nullable: true),
                    Lumsum_Editor_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lum_Mst", x => x.Lumsum_Editor_Id);
                });

            migrationBuilder.CreateTable(
                name: "Occupation_Master",
                columns: table => new
                {
                    Occupation_Id = table.Column<int>(type: "int", nullable: false),
                    Occupation_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Occupation_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Occupation_Short_Name = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_occupation_Master", x => x.Occupation_Id);
                });

            migrationBuilder.CreateTable(
                name: "PayHead_Map_Master",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payhead_Map_Id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Effective_From = table.Column<DateTime>(type: "date", nullable: true),
                    Salary_Stru_Id = table.Column<int>(type: "int", nullable: true),
                    Payhead_Id = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true),
                    Paymap_Calc_Basic = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Paymap_Calc_Type = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Paymap_Calc_Rate = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Formula_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Formula_Value = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Cutoff_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Round_Off = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayHead_Map_Master", x => new { x.RowId, x.Payhead_Map_Id });
                });

            migrationBuilder.CreateTable(
                name: "Payhead_Map_Slab",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Payhead_Map_Slab_Id = table.Column<int>(type: "int", nullable: false),
                    Salary_Str_Id = table.Column<int>(type: "int", nullable: true),
                    Payhead_Id = table.Column<int>(type: "int", nullable: true),
                    Paymap_Min_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Paymap_Max_Amount = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Paymap_Type = table.Column<string>(type: "varchar(5)", unicode: false, maxLength: 5, nullable: true),
                    Paymap_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true),
                    Payhead_Map_Id = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payhead_Map_Slab", x => new { x.RowId, x.Payhead_Map_Slab_Id });
                });

            migrationBuilder.CreateTable(
                name: "PayHead_Mst",
                columns: table => new
                {
                    PayHead_Id = table.Column<int>(type: "int", nullable: false),
                    PayHead_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PayHead_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    PayHead_Inslip = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PayHead_Type = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    PayHead_Category = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Use_For_Gratuity = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Use_For_NetPay = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Contribute_by = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: false),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payhead_Mst", x => new { x.PayHead_Id, x.PayHead_Code });
                });

            migrationBuilder.CreateTable(
                name: "PF_ESI_Rate_Setting",
                columns: table => new
                {
                    PF_ESI_Rate_Id = table.Column<int>(type: "int", nullable: false),
                    PF_ESI_Rate_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Effective_From = table.Column<DateTime>(type: "date", nullable: true),
                    PF_Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PF_Cut_Off = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Is_Aply_Spec_CutOff = table.Column<bool>(type: "bit", nullable: true),
                    PF_Spec_Cut_Off = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PF_Employer_Pension = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EMPR_PF_Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PF_Round_Off = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    PF_Is_Rest_EMPR_Share = table.Column<bool>(type: "bit", nullable: true),
                    PF_Is_Rest_EMPL_TO_EMPR = table.Column<bool>(type: "bit", nullable: true),
                    ESI_EMPL_Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ESI_EMPR_Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ESI_Cut_Off = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ESI_Min_Wage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ESI_Round_Off = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    Acc_02 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Acc_21 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Acc_22 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PF_ESI_Rate_Setting", x => new { x.PF_ESI_Rate_Id, x.PF_ESI_Rate_Code });
                });

            migrationBuilder.CreateTable(
                name: "PFGroup_Mst",
                columns: table => new
                {
                    PFGroup_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PF_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    DBA_File_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    File_Extension = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PFGroup_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFgrp_Mst", x => x.PFGroup_Id);
                });

            migrationBuilder.CreateTable(
                name: "PFSetting_Mst",
                columns: table => new
                {
                    PFSett_Id = table.Column<int>(type: "int", nullable: false),
                    PFSett_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Effective_From = table.Column<DateTime>(type: "date", nullable: true),
                    PFSett_Age = table.Column<int>(type: "int", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PFSetting_Mst", x => new { x.PFSett_Id, x.PFSett_Code });
                });

            migrationBuilder.CreateTable(
                name: "PTGroup_Mst",
                columns: table => new
                {
                    PTGroup_Id = table.Column<int>(type: "int", nullable: false),
                    PTGroup_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    PTGroup_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    State_Id = table.Column<int>(type: "int", nullable: true),
                    Certificate_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PTO_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    PT_Address = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Return_Period = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTGRP_Mst", x => x.PTGroup_Id);
                });

            migrationBuilder.CreateTable(
                name: "PTRate_Mst",
                columns: table => new
                {
                    PTRate_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PTGroup_Id = table.Column<int>(type: "int", nullable: false),
                    Effective_From = table.Column<DateTime>(type: "date", nullable: true),
                    Minimum_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Maximum_Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PT_Rate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))"),
                    PTRate_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PTrate_Mst", x => x.PTRate_Id);
                });

            migrationBuilder.CreateTable(
                name: "Qualfication_Master",
                columns: table => new
                {
                    Qualification_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Qualification_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_quali_Master", x => x.Qualification_Id);
                });

            migrationBuilder.CreateTable(
                name: "RetirementSett_Mst",
                columns: table => new
                {
                    RetSett_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Effective_From = table.Column<DateTime>(type: "date", nullable: true),
                    RetSett_Age = table.Column<int>(type: "int", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Retirement_Mst", x => x.RetSett_Id);
                });

            migrationBuilder.CreateTable(
                name: "Salary_Calendar_Master",
                columns: table => new
                {
                    Salary_Calendar_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "varchar(max)", unicode: false, nullable: false),
                    Short_Name = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary_Calendar_Master", x => x.Salary_Calendar_Id);
                });

            migrationBuilder.CreateTable(
                name: "Salary_Struct_Mst",
                columns: table => new
                {
                    Salary_Str_Id = table.Column<int>(type: "int", nullable: false),
                    Salary_Str_Code = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Salary_Str_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Salary_Str_Reamrk = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: true),
                    Is_On_Gross = table.Column<bool>(type: "bit", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary_Struct_Mst", x => new { x.Salary_Str_Id, x.Salary_Str_Code });
                });

            migrationBuilder.CreateTable(
                name: "Site_Master",
                columns: table => new
                {
                    Site_Id = table.Column<int>(type: "int", nullable: false),
                    Site_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site_Master", x => x.Site_Id);
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Company",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Id = table.Column<int>(type: "int", nullable: false),
                    Company_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Company_Person_Name = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Company_Address = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Company_Address2 = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Company_PhoneNo = table.Column<int>(type: "int", nullable: true),
                    Company_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Company_Website = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Company_CINNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Company_GSTNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Comapny_IsPF = table.Column<bool>(type: "bit", nullable: true),
                    Company_PFNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Company_DBAFile_Code = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Company_PF_Extn = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Comapny_IsPFVol = table.Column<bool>(type: "bit", nullable: true),
                    Comapny_IsPFMultigrp = table.Column<bool>(type: "bit", nullable: true),
                    Comapny_IsESI = table.Column<bool>(type: "bit", nullable: true),
                    Company_ESI_No = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Company_ESI_LocalOfc = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Indv_Calculate_Emp_ESI = table.Column<bool>(type: "bit", nullable: true),
                    Limit_ESI_Gross = table.Column<bool>(type: "bit", nullable: true),
                    Is_ESI_Multiple_Group = table.Column<bool>(type: "bit", nullable: true),
                    Comapny_IsTDS = table.Column<bool>(type: "bit", nullable: true),
                    Comapny_TanNo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Company_Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Comapny_IsBonus = table.Column<bool>(type: "bit", nullable: true),
                    Comapny_IsITR = table.Column<bool>(type: "bit", nullable: true),
                    Comapny_IsPT = table.Column<bool>(type: "bit", nullable: true),
                    Comapny_IsSupSalary = table.Column<bool>(type: "bit", nullable: true),
                    Comapny_IsGratuity = table.Column<bool>(type: "bit", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Modified_By = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Company_Id", x => new { x.RowId, x.Company_Id });
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Company_Branch",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Id = table.Column<int>(type: "int", nullable: false),
                    Branch_Id = table.Column<int>(type: "int", nullable: false),
                    Branch_Name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Branch_Address = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Branch_Address2 = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    Branch_PhoneNo = table.Column<int>(type: "int", nullable: true),
                    Branch_Person_Name = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Branch_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Branch_PF_Group = table.Column<int>(type: "int", nullable: true),
                    Branch_PT_Group = table.Column<int>(type: "int", nullable: true),
                    Branch_ESI_Group = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Tbl_Company_Documents",
                columns: table => new
                {
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Company_Id = table.Column<int>(type: "int", nullable: false),
                    Company_File_Name = table.Column<string>(type: "varchar(150)", unicode: false, maxLength: 150, nullable: true),
                    File_Data = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WorkOrder_Master",
                columns: table => new
                {
                    Work_Order_Id = table.Column<int>(type: "int", nullable: false),
                    RowId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Work_Order_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Created_By = table.Column<int>(type: "int", nullable: true),
                    Created_On = table.Column<DateTime>(type: "datetime", nullable: true, defaultValueSql: "(getdate())"),
                    Modified_By = table.Column<int>(type: "int", nullable: true),
                    Modified_On = table.Column<DateTime>(type: "datetime", nullable: true),
                    Is_Deleted = table.Column<bool>(type: "bit", nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_workorder_Master", x => x.Work_Order_Id);
                });

            migrationBuilder.CreateTable(
                name: "StateMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    CountryID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateMaster", x => x.ID);
                    table.ForeignKey(
                        name: "FK_StateMaster_CountryMaster",
                        column: x => x.CountryID,
                        principalTable: "CountryMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CityMaster",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    StateID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMaster", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CityMaster_StateMaster",
                        column: x => x.StateID,
                        principalTable: "StateMaster",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityMaster_StateID",
                table: "CityMaster",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_StateMaster_CountryID",
                table: "StateMaster",
                column: "CountryID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendance_Master");

            migrationBuilder.DropTable(
                name: "Bank_Master");

            migrationBuilder.DropTable(
                name: "CityMaster");

            migrationBuilder.DropTable(
                name: "Department_Mst");

            migrationBuilder.DropTable(
                name: "Designation_Mst");

            migrationBuilder.DropTable(
                name: "Division_Master");

            migrationBuilder.DropTable(
                name: "Employee_Details");

            migrationBuilder.DropTable(
                name: "Employee_Disciplinary_DTL");

            migrationBuilder.DropTable(
                name: "Employee_Education_DTL");

            migrationBuilder.DropTable(
                name: "Employee_EXTRA_CURRICULAR_DTL");

            migrationBuilder.DropTable(
                name: "Employee_Family_Details");

            migrationBuilder.DropTable(
                name: "Employee_Salary_Structure");

            migrationBuilder.DropTable(
                name: "Employee_Training_DTL");

            migrationBuilder.DropTable(
                name: "ESIGroup_Mst");

            migrationBuilder.DropTable(
                name: "Grade_Master");

            migrationBuilder.DropTable(
                name: "HoliDay_Master");

            migrationBuilder.DropTable(
                name: "Leave_Master");

            migrationBuilder.DropTable(
                name: "Lumsum_Editor_Mst");

            migrationBuilder.DropTable(
                name: "Occupation_Master");

            migrationBuilder.DropTable(
                name: "PayHead_Map_Master");

            migrationBuilder.DropTable(
                name: "Payhead_Map_Slab");

            migrationBuilder.DropTable(
                name: "PayHead_Mst");

            migrationBuilder.DropTable(
                name: "PF_ESI_Rate_Setting");

            migrationBuilder.DropTable(
                name: "PFGroup_Mst");

            migrationBuilder.DropTable(
                name: "PFSetting_Mst");

            migrationBuilder.DropTable(
                name: "PTGroup_Mst");

            migrationBuilder.DropTable(
                name: "PTRate_Mst");

            migrationBuilder.DropTable(
                name: "Qualfication_Master");

            migrationBuilder.DropTable(
                name: "RetirementSett_Mst");

            migrationBuilder.DropTable(
                name: "Salary_Calendar_Master");

            migrationBuilder.DropTable(
                name: "Salary_Struct_Mst");

            migrationBuilder.DropTable(
                name: "Site_Master");

            migrationBuilder.DropTable(
                name: "Tbl_Company");

            migrationBuilder.DropTable(
                name: "Tbl_Company_Branch");

            migrationBuilder.DropTable(
                name: "Tbl_Company_Documents");

            migrationBuilder.DropTable(
                name: "WorkOrder_Master");

            migrationBuilder.DropTable(
                name: "StateMaster");

            migrationBuilder.DropTable(
                name: "CountryMaster");
        }
    }
}
