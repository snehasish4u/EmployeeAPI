using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace EmployeeFinance.Models
{
    public partial class VYPAK_PAYROLLContext : DbContext
    {
        public VYPAK_PAYROLLContext()
        {
        }

        public VYPAK_PAYROLLContext(DbContextOptions<VYPAK_PAYROLLContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttendanceMaster> AttendanceMasters { get; set; }
        public virtual DbSet<BankMaster> BankMasters { get; set; }
        public virtual DbSet<CityMaster> CityMasters { get; set; }
        public virtual DbSet<CountryMaster> CountryMasters { get; set; }
        public virtual DbSet<DepartmentMst> DepartmentMsts { get; set; }
        public virtual DbSet<DesignationMst> DesignationMsts { get; set; }
        public virtual DbSet<DivisionMaster> DivisionMasters { get; set; }
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; }
        public virtual DbSet<EmployeeDisciplinaryDtl> EmployeeDisciplinaryDtls { get; set; }
        public virtual DbSet<EmployeeEducationDtl> EmployeeEducationDtls { get; set; }
        public virtual DbSet<EmployeeExtraCurricularDtl> EmployeeExtraCurricularDtls { get; set; }
        public virtual DbSet<EmployeeFamilyDetail> EmployeeFamilyDetails { get; set; }
        public virtual DbSet<EmployeeSalaryStructure> EmployeeSalaryStructures { get; set; }
        public virtual DbSet<EmployeeTrainingDtl> EmployeeTrainingDtls { get; set; }
        public virtual DbSet<EsigroupMst> EsigroupMsts { get; set; }
        public virtual DbSet<GradeMaster> GradeMasters { get; set; }
        public virtual DbSet<HoliDayMaster> HoliDayMasters { get; set; }
        public virtual DbSet<LeaveMaster> LeaveMasters { get; set; }
        public virtual DbSet<LumsumEditorMst> LumsumEditorMsts { get; set; }
        public virtual DbSet<OccupationMaster> OccupationMasters { get; set; }
        public virtual DbSet<PayHeadMapMaster> PayHeadMapMasters { get; set; }
        public virtual DbSet<PayHeadMst> PayHeadMsts { get; set; }
        public virtual DbSet<PayheadMapSlab> PayheadMapSlabs { get; set; }
        public virtual DbSet<PfEsiRateSetting> PfEsiRateSettings { get; set; }
        public virtual DbSet<PfgroupMst> PfgroupMsts { get; set; }
        public virtual DbSet<PfsettingMst> PfsettingMsts { get; set; }
        public virtual DbSet<PtgroupMst> PtgroupMsts { get; set; }
        public virtual DbSet<PtrateMst> PtrateMsts { get; set; }
        public virtual DbSet<QualficationMaster> QualficationMasters { get; set; }
        public virtual DbSet<RetirementSettMst> RetirementSettMsts { get; set; }
        public virtual DbSet<SalaryCalendarMaster> SalaryCalendarMasters { get; set; }
        public virtual DbSet<SalaryStructMst> SalaryStructMsts { get; set; }
        public virtual DbSet<SiteMaster> SiteMasters { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }
        public virtual DbSet<TblCompany> TblCompanies { get; set; }
        public virtual DbSet<TblCompanyBranch> TblCompanyBranches { get; set; }
        public virtual DbSet<TblCompanyDocument> TblCompanyDocuments { get; set; }
        public virtual DbSet<WorkOrderMaster> WorkOrderMasters { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=VYPAK_PAYROLL;User ID=admin;pwd=Aquarius@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<AttendanceMaster>(entity =>
            {
                entity.HasKey(e => e.AttendanceId);

                entity.ToTable("Attendance_Master");

                entity.Property(e => e.AttendanceId)
                    .ValueGeneratedNever()
                    .HasColumnName("Attendance_Id");

                entity.Property(e => e.AttendanceCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Attendance_Code");

                entity.Property(e => e.AttendanceName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Attendance_Name");

                entity.Property(e => e.AttendanceOtType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Attendance_OT_Type");

                entity.Property(e => e.AttendanceRegType)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Attendance_Reg_Type");

                entity.Property(e => e.AttendanceSalaryType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Attendance_Salary_Type");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsMorethanWorkDay)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Is_Morethan_WorkDay");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.SalaryCalendarType)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Salary_Calendar_Type");
            });

            modelBuilder.Entity<BankMaster>(entity =>
            {
                entity.HasKey(e => new { e.BankId, e.BankCode });

                entity.ToTable("Bank_Master");

                entity.Property(e => e.BankId).HasColumnName("Bank_Id");

                entity.Property(e => e.BankCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Code");

                entity.Property(e => e.Address).IsUnicode(false);

                entity.Property(e => e.BankAccNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Name");

                entity.Property(e => e.BankShtName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Sht_Name");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Branch_Name");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IfscCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("IFSC_Code");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Phone_No");

                entity.Property(e => e.PinNo).HasColumnName("Pin_No");
            });

            modelBuilder.Entity<CityMaster>(entity =>
            {
                entity.ToTable("CityMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.CityMasters)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK_CityMaster_StateMaster");
            });

            modelBuilder.Entity<CountryMaster>(entity =>
            {
                entity.ToTable("CountryMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryCode)
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DepartmentMst>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("Department_Mst");

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever()
                    .HasColumnName("Department_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartmentCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Department_Code");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Department_Name");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");
            });

            modelBuilder.Entity<DesignationMst>(entity =>
            {
                entity.HasKey(e => new { e.DesigId, e.DesigCode })
                    .HasName("PK_Designation_Mst_1");

                entity.ToTable("Designation_Mst");

                entity.Property(e => e.DesigId).HasColumnName("Desig_Id");

                entity.Property(e => e.DesigCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Desig_Code");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DesigName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Desig_Name");

                entity.Property(e => e.DesigShtName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Desig_Sht_Name");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");
            });

            modelBuilder.Entity<DivisionMaster>(entity =>
            {
                entity.HasKey(e => e.DivisionId);

                entity.ToTable("Division_Master");

                entity.Property(e => e.DivisionId)
                    .ValueGeneratedNever()
                    .HasColumnName("Division_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On");

                entity.Property(e => e.DivisionName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Division_Name");

                entity.Property(e => e.DivisionShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Division_Short_Name");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmployeeCode });

                entity.ToTable("Employee_Details");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Code");

                entity.Property(e => e.AadharNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AAdhar_No");

                entity.Property(e => e.AltEmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Alt_Email_ID");

                entity.Property(e => e.BankAcNo)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.BankName)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Bank_Name");

                entity.Property(e => e.BloodGroup)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Branch_Name");

                entity.Property(e => e.CcEmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("CC_Email_ID");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfJoin)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_Join");

                entity.Property(e => e.DateOfLeave)
                    .HasColumnType("date")
                    .HasColumnName("Date_of_Leave");

                entity.Property(e => e.DepartmentId).HasColumnName("Department_Id");

                entity.Property(e => e.DesigId).HasColumnName("Desig_Id");

                entity.Property(e => e.Division)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Email_ID");

                entity.Property(e => e.EmpAttendance)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Attendance");

                entity.Property(e => e.EmpCateId).HasColumnName("Emp_Cate_Id");

                entity.Property(e => e.EmployeeImage)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Image");

                entity.Property(e => e.EmployeeName)
                    .HasMaxLength(85)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Name");

                entity.Property(e => e.EmployeeTitle)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Title");

                entity.Property(e => e.EsiDispensary)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESI_Dispensary");

                entity.Property(e => e.EsiNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ESI_No");

                entity.Property(e => e.FathersName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Grade)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GriNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("GRI_No");

                entity.Property(e => e.InsuranceNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Insurance_No");

                entity.Property(e => e.IsDefaultAltEmailId).HasColumnName("Is_Default_Alt_EmailId");

                entity.Property(e => e.IsDefaultEmailId).HasColumnName("Is_Default_EmailId");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsDisabled)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsEsi).HasColumnName("IsESI");

                entity.Property(e => e.IsGri).HasColumnName("IsGRI");

                entity.Property(e => e.IsHigherEpf)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IsHigherEPF");

                entity.Property(e => e.IsHigherEps)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("IsHigherEPS");

                entity.Property(e => e.IsInternationalworker)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsLeaving).HasColumnName("Is_Leaving");

                entity.Property(e => e.IsPf).HasColumnName("IsPF");

                entity.Property(e => e.IsRestrictPf).HasColumnName("Is_Restrict_PF");

                entity.Property(e => e.IsZeroPension).HasColumnName("Is_Zero_Pension");

                entity.Property(e => e.IsZeroPt).HasColumnName("Is_Zero_PT");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Marital_Status");

                entity.Property(e => e.MarriageDate)
                    .HasColumnType("date")
                    .HasColumnName("Marriage_Date");

                entity.Property(e => e.Mobile)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.MothersName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NomineeName)
                    .HasMaxLength(47)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Panno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PANno");

                entity.Property(e => e.PassportNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PastServiceInDay).HasColumnName("Past_Service_inDay");

                entity.Property(e => e.PermanentArea)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Permanent_Area");

                entity.Property(e => e.PermanentCity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Permanent_City");

                entity.Property(e => e.PermanentPincode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Permanent_Pincode");

                entity.Property(e => e.PermanentResName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Permanent_Res_Name");

                entity.Property(e => e.PermanentResNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Permanent_Res_No");

                entity.Property(e => e.PermanentRoad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Permanent_Road");

                entity.Property(e => e.PermanentState)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Permanent_State");

                entity.Property(e => e.PfDeptFile)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_Dept_File");

                entity.Property(e => e.PfNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("PF_No");

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.PresentArea)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Present_Area");

                entity.Property(e => e.PresentCity)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Present_City");

                entity.Property(e => e.PresentPincode)
                    .HasMaxLength(6)
                    .IsUnicode(false)
                    .HasColumnName("Present_Pincode");

                entity.Property(e => e.PresentResName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Present_Res_Name");

                entity.Property(e => e.PresentResNo)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Present_Res_No");

                entity.Property(e => e.PresentRoad)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Present_Road");

                entity.Property(e => e.PresentState)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("Present_State");

                entity.Property(e => e.ReasonOfLeave)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Reason_Of_Leave");

                entity.Property(e => e.SalaryCalcFrom)
                    .HasColumnType("date")
                    .HasColumnName("Salary_Calc_From");

                entity.Property(e => e.SalaryStructureId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Salary_Structure_id");

                entity.Property(e => e.StdCode)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("STD_Code");

                entity.Property(e => e.UanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("UAN_No");

                entity.Property(e => e.VoterId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WardCircle)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Ward_Circle");
            });

            modelBuilder.Entity<EmployeeDisciplinaryDtl>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmployeeCode, e.EmployeeDisId })
                    .HasName("PK_Employee_Dis_Id");

                entity.ToTable("Employee_Disciplinary_DTL");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Code");

                entity.Property(e => e.EmployeeDisId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Dis_Id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IssueBy)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Issue_By");

                entity.Property(e => e.IssueDate)
                    .HasColumnType("datetime")
                    .HasColumnName("Issue_Date");

                entity.Property(e => e.Memo)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeEducationDtl>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmployeeCode, e.EmployeeEduId })
                    .HasName("PK_Employee_Edu_Id");

                entity.ToTable("Employee_Education_DTL");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Code");

                entity.Property(e => e.EmployeeEduId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Edu_Id");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Percentage).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Qualfication)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.University)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.YearPassed)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Year_Passed");
            });

            modelBuilder.Entity<EmployeeExtraCurricularDtl>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmployeeCode, e.EmployeeCurrId })
                    .HasName("PK_Employee_Curr_Id");

                entity.ToTable("Employee_EXTRA_CURRICULAR_DTL");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Code");

                entity.Property(e => e.EmployeeCurrId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Curr_Id");

                entity.Property(e => e.ActivityName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Activity_Name");

                entity.Property(e => e.Award)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EventName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Event_Name");

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("From_Date");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("To_Date");
            });

            modelBuilder.Entity<EmployeeFamilyDetail>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmployeeCode, e.EmployeeFamId })
                    .HasName("PK_Employee_fam_Id");

                entity.ToTable("Employee_Family_Details");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Code");

                entity.Property(e => e.EmployeeFamId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_fam_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On");

                entity.Property(e => e.DateOfBirth)
                    .HasColumnType("datetime")
                    .HasColumnName("Date_Of_Birth");

                entity.Property(e => e.Gender)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.Relation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RelativeName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Relative_Name");

                entity.Property(e => e.Remarks).IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeSalaryStructure>(entity =>
            {
                entity.HasKey(e => new { e.RowId, e.EmpSalStrId });

                entity.ToTable("Employee_Salary_Structure");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();

                entity.Property(e => e.EmpSalStrId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Sal_Str_Id");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On");

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("date")
                    .HasColumnName("Effective_From");

                entity.Property(e => e.EmployeeId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Id");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PayheadId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Payhead_Id");
            });

            modelBuilder.Entity<EmployeeTrainingDtl>(entity =>
            {
                entity.HasKey(e => new { e.EmployeeId, e.EmployeeCode, e.EmployeeTraId })
                    .HasName("PK_Employee_Tra_Id");

                entity.ToTable("Employee_Training_DTL");

                entity.Property(e => e.EmployeeCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Code");

                entity.Property(e => e.EmployeeTraId)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Employee_Tra_Id");

                entity.Property(e => e.Comments)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasColumnType("datetime")
                    .HasColumnName("From_Date");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Remarks).IsUnicode(false);

                entity.Property(e => e.ToDate)
                    .HasColumnType("datetime")
                    .HasColumnName("To_Date");

                entity.Property(e => e.TrainingName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Training_Name");
            });

            modelBuilder.Entity<EsigroupMst>(entity =>
            {
                entity.HasKey(e => new { e.EsigroupId, e.EsigroupCode })
                    .HasName("PK_ESIgrp_Mst");

                entity.ToTable("ESIGroup_Mst");

                entity.Property(e => e.EsigroupId).HasColumnName("ESIGroup_Id");

                entity.Property(e => e.EsigroupCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("ESIGroup_Code");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EsiLocalOffice)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESI_Local_Office");

                entity.Property(e => e.EsiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESI_No");

                entity.Property(e => e.EsigroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ESIGroup_Name");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsIndividualCalc).HasColumnName("Is_Individual_Calc");

                entity.Property(e => e.IsLimitEsiGross).HasColumnName("Is_Limit_ESI_Gross");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<GradeMaster>(entity =>
            {
                entity.HasKey(e => e.GradeId);

                entity.ToTable("Grade_Master");

                entity.Property(e => e.GradeId)
                    .ValueGeneratedNever()
                    .HasColumnName("Grade_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GradeName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Grade_Name");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<HoliDayMaster>(entity =>
            {
                entity.HasKey(e => new { e.HolidayId, e.HolidayCode });

                entity.ToTable("HoliDay_Master");

                entity.Property(e => e.HolidayId).HasColumnName("Holiday_Id");

                entity.Property(e => e.HolidayCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Holiday_Code");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.IsBranchWise)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Is_Branch_Wise");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsNationalHoliday)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Is_National_Holiday");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<LeaveMaster>(entity =>
            {
                entity.HasKey(e => new { e.LeaveId, e.LeaveCode });

                entity.ToTable("Leave_Master");

                entity.Property(e => e.LeaveId).HasColumnName("Leave_Id");

                entity.Property(e => e.LeaveCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Leave_Code");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsAffectSalary).HasColumnName("Is_Affect_salary");

                entity.Property(e => e.IsAlloted).HasColumnName("Is_Alloted");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeaveName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Leave_Name");

                entity.Property(e => e.LeaveShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Leave_Short_Name");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");
            });

            modelBuilder.Entity<LumsumEditorMst>(entity =>
            {
                entity.HasKey(e => e.LumsumEditorId)
                    .HasName("PK_Lum_Mst");

                entity.ToTable("Lumsum_Editor_Mst");

                entity.Property(e => e.LumsumEditorId)
                    .ValueGeneratedNever()
                    .HasColumnName("Lumsum_Editor_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LumsumEditorAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Lumsum_Editor_Amount");

                entity.Property(e => e.LumsumEditorGrade).HasColumnName("Lumsum_Editor_Grade");

                entity.Property(e => e.LumsumEditorName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Lumsum_Editor_Name");

                entity.Property(e => e.LumsumEditorType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Lumsum_Editor_Type");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<OccupationMaster>(entity =>
            {
                entity.HasKey(e => e.OccupationId)
                    .HasName("PK_occupation_Master");

                entity.ToTable("Occupation_Master");

                entity.Property(e => e.OccupationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Occupation_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.OccupationCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Occupation_Code");

                entity.Property(e => e.OccupationName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Occupation_Name");

                entity.Property(e => e.OccupationShortName)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Occupation_Short_Name");
            });

            modelBuilder.Entity<PayHeadMapMaster>(entity =>
            {
                entity.HasKey(e => new { e.RowId, e.PayheadMapId });

                entity.ToTable("PayHead_Map_Master");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();

                entity.Property(e => e.PayheadMapId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Payhead_Map_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CutoffAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Cutoff_Amount");

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("date")
                    .HasColumnName("Effective_From");

                entity.Property(e => e.FormulaName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Formula_Name");

                entity.Property(e => e.FormulaValue)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Formula_Value");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PayheadId)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Payhead_Id");

                entity.Property(e => e.PaymapCalcBasic)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Paymap_Calc_Basic");

                entity.Property(e => e.PaymapCalcRate)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("Paymap_Calc_Rate");

                entity.Property(e => e.PaymapCalcType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Paymap_Calc_Type");

                entity.Property(e => e.RoundOff)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Round_Off");

                entity.Property(e => e.SalaryStruId).HasColumnName("Salary_Stru_Id");
            });

            modelBuilder.Entity<PayHeadMst>(entity =>
            {
                entity.HasKey(e => new { e.PayHeadId, e.PayHeadCode })
                    .HasName("PK_payhead_Mst");

                entity.ToTable("PayHead_Mst");

                entity.Property(e => e.PayHeadId).HasColumnName("PayHead_Id");

                entity.Property(e => e.PayHeadCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PayHead_Code");

                entity.Property(e => e.ContributeBy)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Contribute_by");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PayHeadCategory)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PayHead_Category");

                entity.Property(e => e.PayHeadInslip)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PayHead_Inslip");

                entity.Property(e => e.PayHeadName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PayHead_Name");

                entity.Property(e => e.PayHeadType)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PayHead_Type");

                entity.Property(e => e.UseForGratuity)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Use_For_Gratuity");

                entity.Property(e => e.UseForNetPay)
                    .IsRequired()
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Use_For_NetPay");
            });

            modelBuilder.Entity<PayheadMapSlab>(entity =>
            {
                entity.HasKey(e => new { e.RowId, e.PayheadMapSlabId });

                entity.ToTable("Payhead_Map_Slab");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();

                entity.Property(e => e.PayheadMapSlabId).HasColumnName("Payhead_Map_Slab_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PayheadId).HasColumnName("Payhead_Id");

                entity.Property(e => e.PayheadMapId).HasColumnName("Payhead_Map_Id");

                entity.Property(e => e.PaymapAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Paymap_Amount");

                entity.Property(e => e.PaymapMaxAmount)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Paymap_Max_Amount");

                entity.Property(e => e.PaymapMinAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Paymap_Min_Amount");

                entity.Property(e => e.PaymapType)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("Paymap_Type");

                entity.Property(e => e.SalaryStrId).HasColumnName("Salary_Str_Id");
            });

            modelBuilder.Entity<PfEsiRateSetting>(entity =>
            {
                entity.HasKey(e => new { e.PfEsiRateId, e.PfEsiRateCode });

                entity.ToTable("PF_ESI_Rate_Setting");

                entity.Property(e => e.PfEsiRateId).HasColumnName("PF_ESI_Rate_Id");

                entity.Property(e => e.PfEsiRateCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PF_ESI_Rate_Code");

                entity.Property(e => e.Acc02)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Acc_02");

                entity.Property(e => e.Acc21)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Acc_21");

                entity.Property(e => e.Acc22)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Acc_22");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("date")
                    .HasColumnName("Effective_From");

                entity.Property(e => e.EmprPfRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("EMPR_PF_Rate");

                entity.Property(e => e.EsiCutOff)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ESI_Cut_Off");

                entity.Property(e => e.EsiEmplRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ESI_EMPL_Rate");

                entity.Property(e => e.EsiEmprRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ESI_EMPR_Rate");

                entity.Property(e => e.EsiMinWage)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ESI_Min_Wage");

                entity.Property(e => e.EsiRoundOff)
                    .HasMaxLength(2)
                    .HasColumnName("ESI_Round_Off");

                entity.Property(e => e.IsAplySpecCutOff).HasColumnName("Is_Aply_Spec_CutOff");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PfCutOff)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PF_Cut_Off");

                entity.Property(e => e.PfEmployerPension)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PF_Employer_Pension");

                entity.Property(e => e.PfIsRestEmplToEmpr).HasColumnName("PF_Is_Rest_EMPL_TO_EMPR");

                entity.Property(e => e.PfIsRestEmprShare).HasColumnName("PF_Is_Rest_EMPR_Share");

                entity.Property(e => e.PfRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PF_Rate");

                entity.Property(e => e.PfRoundOff)
                    .HasMaxLength(2)
                    .HasColumnName("PF_Round_Off");

                entity.Property(e => e.PfSpecCutOff)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PF_Spec_Cut_Off");
            });

            modelBuilder.Entity<PfgroupMst>(entity =>
            {
                entity.HasKey(e => e.PfgroupId)
                    .HasName("PK_PFgrp_Mst");

                entity.ToTable("PFGroup_Mst");

                entity.Property(e => e.PfgroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("PFGroup_Id");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DbaFileCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("DBA_File_Code");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("File_Extension");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PfNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PF_No");

                entity.Property(e => e.PfgroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PFGroup_Name");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<PfsettingMst>(entity =>
            {
                entity.HasKey(e => new { e.PfsettId, e.PfsettCode });

                entity.ToTable("PFSetting_Mst");

                entity.Property(e => e.PfsettId).HasColumnName("PFSett_Id");

                entity.Property(e => e.PfsettCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PFSett_Code");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("date")
                    .HasColumnName("Effective_From");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PfsettAge).HasColumnName("PFSett_Age");
            });

            modelBuilder.Entity<PtgroupMst>(entity =>
            {
                entity.HasKey(e => e.PtgroupId)
                    .HasName("PK_PTGRP_Mst");

                entity.ToTable("PTGroup_Mst");

                entity.Property(e => e.PtgroupId)
                    .ValueGeneratedNever()
                    .HasColumnName("PTGroup_Id");

                entity.Property(e => e.CertificateNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Certificate_No");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PtAddress)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("PT_Address");

                entity.Property(e => e.PtgroupCode)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("PTGroup_Code");

                entity.Property(e => e.PtgroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTGroup_Name");

                entity.Property(e => e.PtoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTO_No");

                entity.Property(e => e.ReturnPeriod)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Return_Period");

                entity.Property(e => e.StateId).HasColumnName("State_Id");
            });

            modelBuilder.Entity<PtrateMst>(entity =>
            {
                entity.HasKey(e => e.PtrateId)
                    .HasName("PK_PTrate_Mst");

                entity.ToTable("PTRate_Mst");

                entity.Property(e => e.PtrateId)
                    .ValueGeneratedNever()
                    .HasColumnName("PTRate_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("date")
                    .HasColumnName("Effective_From");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MaximumAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Maximum_Amount");

                entity.Property(e => e.MinimumAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Minimum_Amount");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.PtRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PT_Rate");

                entity.Property(e => e.PtgroupId).HasColumnName("PTGroup_Id");

                entity.Property(e => e.PtrateName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PTRate_Name");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<QualficationMaster>(entity =>
            {
                entity.HasKey(e => e.QualificationId)
                    .HasName("PK_quali_Master");

                entity.ToTable("Qualfication_Master");

                entity.Property(e => e.QualificationId)
                    .ValueGeneratedNever()
                    .HasColumnName("Qualification_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.QualificationName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Qualification_Name");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<RetirementSettMst>(entity =>
            {
                entity.HasKey(e => e.RetSettId)
                    .HasName("PK_Retirement_Mst");

                entity.ToTable("RetirementSett_Mst");

                entity.Property(e => e.RetSettId)
                    .ValueGeneratedNever()
                    .HasColumnName("RetSett_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.EffectiveFrom)
                    .HasColumnType("date")
                    .HasColumnName("Effective_From");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.RetSettAge).HasColumnName("RetSett_Age");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<SalaryCalendarMaster>(entity =>
            {
                entity.HasKey(e => e.SalaryCalendarId);

                entity.ToTable("Salary_Calendar_Master");

                entity.Property(e => e.SalaryCalendarId)
                    .ValueGeneratedNever()
                    .HasColumnName("Salary_Calendar_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On");

                entity.Property(e => e.IsDeleted).HasColumnName("Is_Deleted");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();

                entity.Property(e => e.ShortName)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("Short_Name");
            });

            modelBuilder.Entity<SalaryStructMst>(entity =>
            {
                entity.HasKey(e => new { e.SalaryStrId, e.SalaryStrCode });

                entity.ToTable("Salary_Struct_Mst");

                entity.Property(e => e.SalaryStrId).HasColumnName("Salary_Str_Id");

                entity.Property(e => e.SalaryStrCode)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("Salary_Str_Code");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IsOnGross).HasColumnName("Is_On_Gross");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.SalaryStrName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Salary_Str_Name");

                entity.Property(e => e.SalaryStrReamrk)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("Salary_Str_Reamrk");
            });

            modelBuilder.Entity<SiteMaster>(entity =>
            {
                entity.HasKey(e => e.SiteId);

                entity.ToTable("Site_Master");

                entity.Property(e => e.SiteId)
                    .ValueGeneratedNever()
                    .HasColumnName("Site_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.SiteName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Site_Name");
            });

            modelBuilder.Entity<StateMaster>(entity =>
            {
                entity.ToTable("StateMaster");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.StateMasters)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK_StateMaster_CountryMaster");
            });

            modelBuilder.Entity<TblCompany>(entity =>
            {
                entity.HasKey(e => new { e.RowId, e.CompanyId })
                    .HasName("PK_Company_Id");

                entity.ToTable("Tbl_Company");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();

                entity.Property(e => e.CompanyId).HasColumnName("Company_Id");

                entity.Property(e => e.ComapnyIsBonus).HasColumnName("Comapny_IsBonus");

                entity.Property(e => e.ComapnyIsEsi).HasColumnName("Comapny_IsESI");

                entity.Property(e => e.ComapnyIsGratuity).HasColumnName("Comapny_IsGratuity");

                entity.Property(e => e.ComapnyIsItr).HasColumnName("Comapny_IsITR");

                entity.Property(e => e.ComapnyIsPf).HasColumnName("Comapny_IsPF");

                entity.Property(e => e.ComapnyIsPfmultigrp).HasColumnName("Comapny_IsPFMultigrp");

                entity.Property(e => e.ComapnyIsPfvol).HasColumnName("Comapny_IsPFVol");

                entity.Property(e => e.ComapnyIsPt).HasColumnName("Comapny_IsPT");

                entity.Property(e => e.ComapnyIsSupSalary).HasColumnName("Comapny_IsSupSalary");

                entity.Property(e => e.ComapnyIsTds).HasColumnName("Comapny_IsTDS");

                entity.Property(e => e.ComapnyTanNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Comapny_TanNo");

                entity.Property(e => e.CompanyAddress)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Company_Address");

                entity.Property(e => e.CompanyAddress2)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Company_Address2");

                entity.Property(e => e.CompanyCinno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_CINNo");

                entity.Property(e => e.CompanyDbafileCode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_DBAFile_Code");

                entity.Property(e => e.CompanyEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_Email");

                entity.Property(e => e.CompanyEsiLocalOfc)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_ESI_LocalOfc");

                entity.Property(e => e.CompanyEsiNo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_ESI_No");

                entity.Property(e => e.CompanyGstno)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_GSTNo");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_Name");

                entity.Property(e => e.CompanyPersonName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("Company_Person_Name");

                entity.Property(e => e.CompanyPfExtn)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_PF_Extn");

                entity.Property(e => e.CompanyPfno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_PFNo");

                entity.Property(e => e.CompanyPhoneNo).HasColumnName("Company_PhoneNo");

                entity.Property(e => e.CompanyType)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_Type");

                entity.Property(e => e.CompanyWebsite)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Company_Website");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On");

                entity.Property(e => e.IndvCalculateEmpEsi).HasColumnName("Indv_Calculate_Emp_ESI");

                entity.Property(e => e.IsEsiMultipleGroup).HasColumnName("Is_ESI_Multiple_Group");

                entity.Property(e => e.LimitEsiGross).HasColumnName("Limit_ESI_Gross");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");
            });

            modelBuilder.Entity<TblCompanyBranch>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Company_Branch");

                entity.Property(e => e.BranchAddress)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Branch_Address");

                entity.Property(e => e.BranchAddress2)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Branch_Address2");

                entity.Property(e => e.BranchEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Branch_Email");

                entity.Property(e => e.BranchEsiGroup).HasColumnName("Branch_ESI_Group");

                entity.Property(e => e.BranchId).HasColumnName("Branch_Id");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Branch_Name");

                entity.Property(e => e.BranchPersonName)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .HasColumnName("Branch_Person_Name");

                entity.Property(e => e.BranchPfGroup).HasColumnName("Branch_PF_Group");

                entity.Property(e => e.BranchPhoneNo).HasColumnName("Branch_PhoneNo");

                entity.Property(e => e.BranchPtGroup).HasColumnName("Branch_PT_Group");

                entity.Property(e => e.CompanyId).HasColumnName("Company_Id");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<TblCompanyDocument>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Tbl_Company_Documents");

                entity.Property(e => e.CompanyFileName)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("Company_File_Name");

                entity.Property(e => e.CompanyId).HasColumnName("Company_Id");

                entity.Property(e => e.FileData).HasColumnName("File_Data");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<WorkOrderMaster>(entity =>
            {
                entity.HasKey(e => e.WorkOrderId)
                    .HasName("PK_workorder_Master");

                entity.ToTable("WorkOrder_Master");

                entity.Property(e => e.WorkOrderId)
                    .ValueGeneratedNever()
                    .HasColumnName("Work_Order_Id");

                entity.Property(e => e.CreatedBy).HasColumnName("Created_By");

                entity.Property(e => e.CreatedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Created_On")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsDeleted)
                    .HasColumnName("Is_Deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedBy).HasColumnName("Modified_By");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasColumnName("Modified_On");

                entity.Property(e => e.RowId).ValueGeneratedOnAdd();

                entity.Property(e => e.WorkOrderName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Work_Order_Name");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
