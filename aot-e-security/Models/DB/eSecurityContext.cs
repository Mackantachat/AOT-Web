using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace aot_e_security.Models.DB
{
    public partial class eSecurityContext : DbContext
    {
        public eSecurityContext()
        {
        }

        public eSecurityContext(DbContextOptions<eSecurityContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<Cardexchange> Cardexchange { get; set; }
        public virtual DbSet<DefectiveWorkHistory> DefectiveWorkHistory { get; set; }
        public virtual DbSet<DepositWeapon> DepositWeapon { get; set; }
        public virtual DbSet<DepositWeaponDetail> DepositWeaponDetail { get; set; }
        public virtual DbSet<Eod> Eod { get; set; }
        public virtual DbSet<EodDetail> EodDetail { get; set; }
        public virtual DbSet<EpositWeaponStaff> EpositWeaponStaff { get; set; }
        public virtual DbSet<Esprtrig> Esprtrig { get; set; }
        public virtual DbSet<Exprtrig> Exprtrig { get; set; }
        public virtual DbSet<GuardAircraft> GuardAircraft { get; set; }
        public virtual DbSet<GuardAircraftStaff> GuardAircraftStaff { get; set; }
        public virtual DbSet<InspectFireExtinguisher> InspectFireExtinguisher { get; set; }
        public virtual DbSet<InspectVehicle> InspectVehicle { get; set; }
        public virtual DbSet<MActuation> MActuation { get; set; }
        public virtual DbSet<MAirport> MAirport { get; set; }
        public virtual DbSet<MCardType> MCardType { get; set; }
        public virtual DbSet<MCheckinCounter> MCheckinCounter { get; set; }
        public virtual DbSet<MCompany> MCompany { get; set; }
        public virtual DbSet<MContactAtta> MContactAtta { get; set; }
        public virtual DbSet<MContactCompany> MContactCompany { get; set; }
        public virtual DbSet<MContactGovernment> MContactGovernment { get; set; }
        public virtual DbSet<MContactHotel> MContactHotel { get; set; }
        public virtual DbSet<MCountry> MCountry { get; set; }
        public virtual DbSet<MCuscomp> MCuscomp { get; set; }
        public virtual DbSet<MDivision> MDivision { get; set; }
        public virtual DbSet<MDocType> MDocType { get; set; }
        public virtual DbSet<MDocumentType> MDocumentType { get; set; }
        public virtual DbSet<MDriverLicenseType> MDriverLicenseType { get; set; }
        public virtual DbSet<MDuration> MDuration { get; set; }
        public virtual DbSet<MEodType> MEodType { get; set; }
        public virtual DbSet<MEyeColor> MEyeColor { get; set; }
        public virtual DbSet<MFunction> MFunction { get; set; }
        public virtual DbSet<MGender> MGender { get; set; }
        public virtual DbSet<MGl> MGl { get; set; }
        public virtual DbSet<MGuardRate> MGuardRate { get; set; }
        public virtual DbSet<MHairColor> MHairColor { get; set; }
        public virtual DbSet<MMaritalStatus> MMaritalStatus { get; set; }
        public virtual DbSet<MMenuList> MMenuList { get; set; }
        public virtual DbSet<MNationality> MNationality { get; set; }
        public virtual DbSet<MOccupation> MOccupation { get; set; }
        public virtual DbSet<MOnetime> MOnetime { get; set; }
        public virtual DbSet<MOperationUnit> MOperationUnit { get; set; }
        public virtual DbSet<MPassDuration> MPassDuration { get; set; }
        public virtual DbSet<MPassIssueLocation> MPassIssueLocation { get; set; }
        public virtual DbSet<MPassPersonReason> MPassPersonReason { get; set; }
        public virtual DbSet<MPassPersonTempReason> MPassPersonTempReason { get; set; }
        public virtual DbSet<MPassPersonType> MPassPersonType { get; set; }
        public virtual DbSet<MPassVehicleReason> MPassVehicleReason { get; set; }
        public virtual DbSet<MPassVehicleType> MPassVehicleType { get; set; }
        public virtual DbSet<MPenalty> MPenalty { get; set; }
        public virtual DbSet<MPenaltyPeriod> MPenaltyPeriod { get; set; }
        public virtual DbSet<MPersonPassRate> MPersonPassRate { get; set; }
        public virtual DbSet<MPersonType> MPersonType { get; set; }
        public virtual DbSet<MPostingKey> MPostingKey { get; set; }
        public virtual DbSet<MProvince> MProvince { get; set; }
        public virtual DbSet<MRace> MRace { get; set; }
        public virtual DbSet<MReligion> MReligion { get; set; }
        public virtual DbSet<MResolveMethod> MResolveMethod { get; set; }
        public virtual DbSet<MRestrictArea> MRestrictArea { get; set; }
        public virtual DbSet<MRole> MRole { get; set; }
        public virtual DbSet<MScreeningObject> MScreeningObject { get; set; }
        public virtual DbSet<MScreeningObjectGroup> MScreeningObjectGroup { get; set; }
        public virtual DbSet<MScreeningPier> MScreeningPier { get; set; }
        public virtual DbSet<MScreeningPoint> MScreeningPoint { get; set; }
        public virtual DbSet<MScreeningRow> MScreeningRow { get; set; }
        public virtual DbSet<MScreeningTool> MScreeningTool { get; set; }
        public virtual DbSet<MSubcontract> MSubcontract { get; set; }
        public virtual DbSet<MTaxCode> MTaxCode { get; set; }
        public virtual DbSet<MTaxiInformType> MTaxiInformType { get; set; }
        public virtual DbSet<MTitle> MTitle { get; set; }
        public virtual DbSet<MTrainingChannel> MTrainingChannel { get; set; }
        public virtual DbSet<MTrainingChapter> MTrainingChapter { get; set; }
        public virtual DbSet<MTrainingCompany> MTrainingCompany { get; set; }
        public virtual DbSet<MTrainingContent> MTrainingContent { get; set; }
        public virtual DbSet<MTrainingCurriculum> MTrainingCurriculum { get; set; }
        public virtual DbSet<MTrainingCurriculumMedia> MTrainingCurriculumMedia { get; set; }
        public virtual DbSet<MTrainingDayoff> MTrainingDayoff { get; set; }
        public virtual DbSet<MTrainingDocument> MTrainingDocument { get; set; }
        public virtual DbSet<MTrainingMedia> MTrainingMedia { get; set; }
        public virtual DbSet<MTrainingPunishment> MTrainingPunishment { get; set; }
        public virtual DbSet<MTrainingStatus> MTrainingStatus { get; set; }
        public virtual DbSet<MUnit> MUnit { get; set; }
        public virtual DbSet<MVehicleBrand> MVehicleBrand { get; set; }
        public virtual DbSet<MVehicleColor> MVehicleColor { get; set; }
        public virtual DbSet<MVehicleFunction> MVehicleFunction { get; set; }
        public virtual DbSet<MVehiclePassRate> MVehiclePassRate { get; set; }
        public virtual DbSet<MVehicleType> MVehicleType { get; set; }
        public virtual DbSet<MViolationGuilt> MViolationGuilt { get; set; }
        public virtual DbSet<MViolationPlace> MViolationPlace { get; set; }
        public virtual DbSet<MWtCode> MWtCode { get; set; }
        public virtual DbSet<MWtType> MWtType { get; set; }
        public virtual DbSet<MZone> MZone { get; set; }
        public virtual DbSet<Operation> Operation { get; set; }
        public virtual DbSet<OperationAnalyze> OperationAnalyze { get; set; }
        public virtual DbSet<OperationAui> OperationAui { get; set; }
        public virtual DbSet<OperationDaily> OperationDaily { get; set; }
        public virtual DbSet<OperationEmergency> OperationEmergency { get; set; }
        public virtual DbSet<OperationEoc> OperationEoc { get; set; }
        public virtual DbSet<OperationPhone> OperationPhone { get; set; }
        public virtual DbSet<OperationRapid> OperationRapid { get; set; }
        public virtual DbSet<OperationVerbal> OperationVerbal { get; set; }
        public virtual DbSet<PassPerson> PassPerson { get; set; }
        public virtual DbSet<PassPersonCancel> PassPersonCancel { get; set; }
        public virtual DbSet<PassPersonChange> PassPersonChange { get; set; }
        public virtual DbSet<PassPersonCopy> PassPersonCopy { get; set; }
        public virtual DbSet<PassPersonReturn> PassPersonReturn { get; set; }
        public virtual DbSet<PassPersonTemp> PassPersonTemp { get; set; }
        public virtual DbSet<PassVehicle> PassVehicle { get; set; }
        public virtual DbSet<PassVehicleCancel> PassVehicleCancel { get; set; }
        public virtual DbSet<PassVehicleChange> PassVehicleChange { get; set; }
        public virtual DbSet<PassVehicleReturn> PassVehicleReturn { get; set; }
        public virtual DbSet<PassVehicleTemp> PassVehicleTemp { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<PersonAttachment> PersonAttachment { get; set; }
        public virtual DbSet<PersonCertificate> PersonCertificate { get; set; }
        public virtual DbSet<PersonRtp> PersonRtp { get; set; }
        public virtual DbSet<PersonTraining> PersonTraining { get; set; }
        public virtual DbSet<PersonViolation> PersonViolation { get; set; }
        public virtual DbSet<PrintCard> PrintCard { get; set; }
        public virtual DbSet<ReqPassVehicle> ReqPassVehicle { get; set; }
        public virtual DbSet<ScreeningBag> ScreeningBag { get; set; }
        public virtual DbSet<ScreeningBagDetail> ScreeningBagDetail { get; set; }
        public virtual DbSet<ScreeningPassenger> ScreeningPassenger { get; set; }
        public virtual DbSet<ScreeningPassengerDetail> ScreeningPassengerDetail { get; set; }
        public virtual DbSet<SqlResults> SqlResults { get; set; }
        public virtual DbSet<TaxiInform> TaxiInform { get; set; }
        public virtual DbSet<TaxiInformDetail> TaxiInformDetail { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<TrainingCalendar> TrainingCalendar { get; set; }
        public virtual DbSet<TrainingCoaching> TrainingCoaching { get; set; }
        public virtual DbSet<TrainingPunishmentTrainee> TrainingPunishmentTrainee { get; set; }
        public virtual DbSet<TrainingRegister> TrainingRegister { get; set; }
        public virtual DbSet<TrainingTrainee> TrainingTrainee { get; set; }
        public virtual DbSet<TrainingTrainer> TrainingTrainer { get; set; }
        public virtual DbSet<Vehicle> Vehicle { get; set; }
        public virtual DbSet<VehicleViolation> VehicleViolation { get; set; }
        public virtual DbSet<ViolationPerson> ViolationPerson { get; set; }
        public virtual DbSet<ViolationPersonCaptor> ViolationPersonCaptor { get; set; }
        public virtual DbSet<ViolationPersonGuilt> ViolationPersonGuilt { get; set; }
        public virtual DbSet<ViolationPersonOffender> ViolationPersonOffender { get; set; }
        public virtual DbSet<ViolationVihicle> ViolationVihicle { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.0.1.94;Database=eSecurity;User Id=sa;Password=p@ssw0rd;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("audit_log");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.DataNew)
                    .HasColumnName("data_new")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.DataOld)
                    .HasColumnName("data_old")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FieldName)
                    .HasColumnName("field_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.IdTblActive).HasColumnName("id_tbl_active");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Cardexchange>(entity =>
            {
                entity.ToTable("cardexchange");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_cardexchange_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApproveCode)
                    .HasColumnName("approve_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDatationDate)
                    .HasColumnName("end_datation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Expiry)
                    .HasColumnName("expiry")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionName)
                    .HasColumnName("function_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityNumber)
                    .HasColumnName("nationality_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OldCompanyCode)
                    .HasColumnName("old_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PAirport)
                    .HasColumnName("p_airport")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PAirportCode)
                    .HasColumnName("p_airport_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PAirportEng)
                    .HasColumnName("p_airport_eng")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PassDurationCode)
                    .HasColumnName("pass_duration_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassIssueLocationCode)
                    .HasColumnName("pass_issue_location_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonTempTypeCode)
                    .HasColumnName("pass_person_temp_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PasspersCode)
                    .HasColumnName("passpers_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCompany)
                    .HasColumnName("present_company")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictArea)
                    .HasColumnName("restrict_area")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictAreaCode)
                    .HasColumnName("restrict_area_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDurationDate)
                    .HasColumnName("start_duration_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Subcontract)
                    .HasColumnName("subcontract")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerPrint).HasColumnName("trigger_print");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DefectiveWorkHistory>(entity =>
            {
                entity.ToTable("defective_work_history");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_defective_work_history")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AnOperation)
                    .HasColumnName("an_operation")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfOperation)
                    .HasColumnName("date_of_operation")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefectiveWorkCode)
                    .HasColumnName("defective_work_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DetailsDefectiveWork)
                    .HasColumnName("details_defective_work")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.DwhGroupCode)
                    .HasColumnName("dwh_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DwhRecAirCode)
                    .HasColumnName("dwh_rec_air_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PathFile)
                    .HasColumnName("path_file")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PsCode)
                    .HasColumnName("ps_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ResultsOfOperations)
                    .HasColumnName("results_of_operations")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningPassengerCode)
                    .HasColumnName("screening_passenger_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCurriculumCode)
                    .IsRequired()
                    .HasColumnName("training_curriculum_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingStaff).HasColumnName("training_staff");

                entity.Property(e => e.TrainingStatus).HasColumnName("training_status");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkPlace)
                    .HasColumnName("work_place")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepositWeapon>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deposit_weapon");

                entity.Property(e => e.Airline)
                    .HasColumnName("airline")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.BuildingType)
                    .HasColumnName("building_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CheckinCounterCode)
                    .HasColumnName("checkin_counter_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNumber)
                    .HasColumnName("flight_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.OccupationCode)
                    .HasColumnName("occupation_code")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ProvinceCode)
                    .HasColumnName("province_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveCompany)
                    .HasColumnName("receive_company")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveStaff)
                    .HasColumnName("receive_staff")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningDate)
                    .HasColumnName("screening_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Seat)
                    .HasColumnName("seat")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SenderCompany)
                    .HasColumnName("sender_company")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SenderStaff)
                    .HasColumnName("sender_staff")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasColumnName("zone_code")
                    .HasMaxLength(120)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepositWeaponDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("deposit_weapon_detail");

                entity.Property(e => e.DepositWeaponId).HasColumnName("deposit_weapon_id");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.ScreeningObjectCode)
                    .HasColumnName("screening_object_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningObjectGroupCode)
                    .HasColumnName("screening_object_group_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCode)
                    .HasColumnName("unit_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Eod>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("eod");

                entity.Property(e => e.EodDescription)
                    .HasColumnName("eod_description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.EodTypeCode)
                    .HasColumnName("eod_type_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FounderAddress)
                    .HasColumnName("founder_address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.FounderCompanyCode)
                    .HasColumnName("founder_company_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FounderName)
                    .HasColumnName("founder_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FounderPosition)
                    .HasColumnName("founder_position")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FounderSurname)
                    .HasColumnName("founder_surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FounderTitleCode)
                    .HasColumnName("founder_title_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformAddress)
                    .HasColumnName("inform_address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InformCompanyCode)
                    .HasColumnName("inform_company_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InformDate)
                    .HasColumnName("inform_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InformName)
                    .HasColumnName("inform_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InformPosition)
                    .HasColumnName("inform_position")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InformSurname)
                    .HasColumnName("inform_surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InformTitleCode)
                    .HasColumnName("inform_title_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.InformantName)
                    .HasColumnName("informant_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperationStaff1)
                    .HasColumnName("operation_staff1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.OperationStaff2)
                    .HasColumnName("operation_staff2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceDescription)
                    .HasColumnName("place_description")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientAddress)
                    .HasColumnName("recipient_address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientCompanyCode)
                    .HasColumnName("recipient_company_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientName)
                    .HasColumnName("recipient_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientPosition)
                    .HasColumnName("recipient_position")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientSurname)
                    .HasColumnName("recipient_surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RecipientTitleCode)
                    .HasColumnName("recipient_title_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Result)
                    .HasColumnName("result")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SendDate)
                    .HasColumnName("send_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendName)
                    .HasColumnName("send_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationPlaceCode)
                    .HasColumnName("violation_place_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EodDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("eod_detail");

                entity.Property(e => e.EodId).HasColumnName("eod_id");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.ObjectDescription)
                    .HasColumnName("object_description")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Qty)
                    .HasColumnName("qty")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCode)
                    .HasColumnName("unit_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EpositWeaponStaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("eposit_weapon_staff");

                entity.Property(e => e.DepositWeaponId).HasColumnName("deposit_weapon_id");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryNumber)
                    .HasColumnName("salary_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Esprtrig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("esprtrig");

                entity.Property(e => e.Prtrig)
                    .HasColumnName("prtrig")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prtrigid).HasColumnName("prtrigid");
            });

            modelBuilder.Entity<Exprtrig>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("exprtrig");

                entity.Property(e => e.Prtrig)
                    .HasColumnName("prtrig")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Prtrigid).HasColumnName("prtrigid");
            });

            modelBuilder.Entity<GuardAircraft>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("guard_aircraft");

                entity.Property(e => e.Agent)
                    .HasColumnName("agent")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BuildingType)
                    .HasColumnName("building_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndSupervisor)
                    .HasColumnName("end_supervisor")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Flight)
                    .HasColumnName("flight")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.GuardAircraftNumber)
                    .HasColumnName("guard_aircraft_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuardAmount).HasColumnName("guard_amount");

                entity.Property(e => e.GuardDay).HasColumnName("guard_day");

                entity.Property(e => e.GuardHour).HasColumnName("guard_hour");

                entity.Property(e => e.GuardMinute).HasColumnName("guard_minute");

                entity.Property(e => e.GuardSupervisor)
                    .HasColumnName("guard_supervisor")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.RegistrationMark)
                    .HasColumnName("registration_mark")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StaffAmount).HasColumnName("staff_amount");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartSupervisor)
                    .HasColumnName("start_supervisor")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GuardAircraftStaff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("guard_aircraft_staff");

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuardAircraftId).HasColumnName("guard_aircraft_id");

                entity.Property(e => e.GuardAircraftNumber)
                    .HasColumnName("guard_aircraft_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryNumber)
                    .HasColumnName("salary_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StaftDate)
                    .HasColumnName("staft_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InspectFireExtinguisher>(entity =>
            {
                entity.ToTable("inspect_fire_extinguisher");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReqPassVehicleId).HasColumnName("req_pass_vehicle_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<InspectVehicle>(entity =>
            {
                entity.ToTable("inspect_vehicle");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReqPassVehicleId).HasColumnName("req_pass_vehicle_id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MActuation>(entity =>
            {
                entity.ToTable("m_actuation");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_actuation_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Fine)
                    .HasColumnName("fine")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MAirport>(entity =>
            {
                entity.ToTable("m_airport");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_airport_code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AbbreEh)
                    .HasColumnName("abbre_eh")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AbbreTh)
                    .HasColumnName("abbre_th")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenaralData)
                    .HasColumnName("genaral_data")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NameEn)
                    .HasColumnName("name_en")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NameTh)
                    .HasColumnName("name_th")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitCenter)
                    .HasColumnName("profit_center")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCardType>(entity =>
            {
                entity.ToTable("m_card_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_cardtype_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCheckinCounter>(entity =>
            {
                entity.ToTable("m_checkin_counter");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_chkcounter_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCompany>(entity =>
            {
                entity.ToTable("m_company");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_comp_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AddressCode)
                    .HasColumnName("address_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ArNumber)
                    .HasColumnName("ar_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description1)
                    .HasColumnName("description1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description2)
                    .HasColumnName("description2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Description3)
                    .HasColumnName("description3")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlagGroup)
                    .IsRequired()
                    .HasColumnName("flag_group")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('YES')");

                entity.Property(e => e.GroupCode)
                    .HasColumnName("group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentFine)
                    .HasColumnName("payment_fine")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentPass)
                    .HasColumnName("payment_pass")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentPerson)
                    .HasColumnName("payment_person")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentPersonFine)
                    .HasColumnName("payment_person_fine")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentPersonTemp)
                    .HasColumnName("payment_person_temp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentPersonTempFine)
                    .HasColumnName("payment_person_temp_fine")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentVehicleTemp)
                    .HasColumnName("payment_vehicle_temp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentVehicleTempFine)
                    .HasColumnName("payment_vehicle_temp_fine")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MContactAtta>(entity =>
            {
                entity.ToTable("m_contact_atta");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_contactatta_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("date");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenderCode)
                    .HasColumnName("gender_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusCode)
                    .HasColumnName("marital_status_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("nationality_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RaceCode)
                    .HasColumnName("race_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionCode)
                    .HasColumnName("religion_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MContactCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("m_contact_company");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Building)
                    .HasColumnName("building")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyType)
                    .HasColumnName("company_type")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ContactTel)
                    .HasColumnName("contact_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlagLocation)
                    .HasColumnName("flag_location")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.HomeTel)
                    .HasColumnName("home_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Position)
                    .HasColumnName("position")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MContactGovernment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("m_contact_government");

                entity.Property(e => e.Building)
                    .HasColumnName("building")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Contact1Address)
                    .HasColumnName("contact1_address")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Contact1HomeTel)
                    .HasColumnName("contact1_home_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact1Name)
                    .HasColumnName("contact1_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact1OfficeTel)
                    .HasColumnName("contact1_office_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact1Position)
                    .HasColumnName("contact1_position")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact1Surname)
                    .HasColumnName("contact1_surname")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact1TitleCode)
                    .HasColumnName("contact1_title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Contact2Address)
                    .HasColumnName("contact2_address")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Contact2HomeTel)
                    .HasColumnName("contact2_home_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact2Name)
                    .HasColumnName("contact2_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact2OfficeTel)
                    .HasColumnName("contact2_office_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact2Position)
                    .HasColumnName("contact2_position")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact2Surname)
                    .HasColumnName("contact2_surname")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact2TitleCode)
                    .HasColumnName("contact2_title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Contact3Address)
                    .HasColumnName("contact3_address")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Contact3HomeTel)
                    .HasColumnName("contact3_home_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact3Name)
                    .HasColumnName("contact3_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact3OfficeTel)
                    .HasColumnName("contact3_office_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Contact3Position)
                    .HasColumnName("contact3_position")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact3Surname)
                    .HasColumnName("contact3_surname")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Contact3TitleCode)
                    .HasColumnName("contact3_title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlagLocation)
                    .HasColumnName("flag_location")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MContactHotel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("m_contact_hotel");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("date");

                entity.Property(e => e.Fax)
                    .HasColumnName("fax")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenderCode)
                    .HasColumnName("gender_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MaritalStatusCode)
                    .HasColumnName("marital_status_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("nationality_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RaceCode)
                    .HasColumnName("race_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionCode)
                    .HasColumnName("religion_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCountry>(entity =>
            {
                entity.ToTable("m_country");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MCuscomp>(entity =>
            {
                entity.ToTable("m_cuscomp");

                entity.HasIndex(e => e.PartnerCode)
                    .HasName("uq_cuscomp")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Address3)
                    .HasColumnName("address3")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Address4)
                    .HasColumnName("address4")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BranchNum)
                    .HasColumnName("branch_num")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CompName1)
                    .IsRequired()
                    .HasColumnName("comp_name1")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CompName2)
                    .HasColumnName("comp_name2")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CompName3)
                    .HasColumnName("comp_name3")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.CompName4)
                    .HasColumnName("comp_name4")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .IsRequired()
                    .HasColumnName("country")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.District)
                    .HasColumnName("district")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PartnerCode)
                    .IsRequired()
                    .HasColumnName("partner_code")
                    .HasMaxLength(8)
                    .IsUnicode(false);

                entity.Property(e => e.PostalCode)
                    .HasColumnName("postal_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasColumnName("street")
                    .HasMaxLength(35)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxNum)
                    .HasColumnName("tax_num")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MDivision>(entity =>
            {
                entity.ToTable("m_division");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_division_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MDocType>(entity =>
            {
                entity.ToTable("m_doc_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_doctype")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DocType)
                    .IsRequired()
                    .HasColumnName("doc_type")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MDocumentType>(entity =>
            {
                entity.ToTable("m_document_type");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MDriverLicenseType>(entity =>
            {
                entity.ToTable("m_driver_license_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_m_driver_license_type_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MDuration>(entity =>
            {
                entity.ToTable("m_duration");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_duration_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DurationType)
                    .HasColumnName("duration_type")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MEodType>(entity =>
            {
                entity.ToTable("m_eod_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_eodtype_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MEyeColor>(entity =>
            {
                entity.ToTable("m_eye_color");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_eyecolor_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MFunction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("m_function");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FuncName)
                    .HasColumnName("func_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MGender>(entity =>
            {
                entity.ToTable("m_gender");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_gender_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MGl>(entity =>
            {
                entity.ToTable("m_gl");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_gl")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GlName)
                    .IsRequired()
                    .HasColumnName("gl_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TxtName)
                    .IsRequired()
                    .HasColumnName("txt_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MGuardRate>(entity =>
            {
                entity.ToTable("m_guard_rate");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_guardrate_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GuardHour).HasColumnName("guard_hour");

                entity.Property(e => e.GuardRate).HasColumnName("guard_rate");

                entity.Property(e => e.OrverRate).HasColumnName("orver_rate");

                entity.Property(e => e.OvertimeRate).HasColumnName("overtime_rate");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MHairColor>(entity =>
            {
                entity.ToTable("m_hair_color");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_haircolor_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MMaritalStatus>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("m_marital_status");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MMenuList>(entity =>
            {
                entity.ToTable("m_menu_list");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.MIcon)
                    .HasColumnName("m_icon")
                    .HasMaxLength(50)
                    .HasComment("ไอคอนตระกูล fa ex. fa fa-list");

                entity.Property(e => e.MLevel)
                    .HasColumnName("m_level")
                    .HasDefaultValueSql("((1))")
                    .HasComment("menu level");

                entity.Property(e => e.MLinks)
                    .HasColumnName("m_links")
                    .HasMaxLength(200);

                entity.Property(e => e.MName)
                    .IsRequired()
                    .HasColumnName("m_name")
                    .HasMaxLength(150);

                entity.Property(e => e.MRefId)
                    .HasColumnName("m_ref_id")
                    .HasComment("เชื่อมกับ id table ตัวเอง หากเป็น submenu");

                entity.Property(e => e.MSort).HasColumnName("m_sort");
            });

            modelBuilder.Entity<MNationality>(entity =>
            {
                entity.ToTable("m_nationality");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_nation_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MOccupation>(entity =>
            {
                entity.ToTable("m_occupation");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_occupation_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MOnetime>(entity =>
            {
                entity.ToTable("m_onetime");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_onetime")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MOperationUnit>(entity =>
            {
                entity.ToTable("m_operation_unit");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_operunit_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPassDuration>(entity =>
            {
                entity.ToTable("m_pass_duration");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_passduration_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPassIssueLocation>(entity =>
            {
                entity.ToTable("m_pass_issue_location");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_passissloc_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPassPersonReason>(entity =>
            {
                entity.ToTable("m_pass_person_reason");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_passpsnreason_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPassPersonTempReason>(entity =>
            {
                entity.ToTable("m_pass_person_temp_reason");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_passpsntmpreason_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPassPersonType>(entity =>
            {
                entity.ToTable("m_pass_person_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_passpsntype_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPassVehicleReason>(entity =>
            {
                entity.ToTable("m_pass_vehicle_reason");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_passvehreason_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPassVehicleType>(entity =>
            {
                entity.ToTable("m_pass_vehicle_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_passvehtype_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPenalty>(entity =>
            {
                entity.ToTable("m_penalty");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_penalty_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPenaltyPeriod>(entity =>
            {
                entity.ToTable("m_penalty_period");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_penaltyperiod_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPersonPassRate>(entity =>
            {
                entity.ToTable("m_person_pass_rate");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_perpassrate_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AirportCode)
                    .HasColumnName("airport_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardPrice)
                    .HasColumnName("card_price")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Duration)
                    .HasColumnName("duration")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonReasonCode)
                    .HasColumnName("pass_person_reason_code")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonTypeCode)
                    .HasColumnName("pass_person_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPersonType>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("m_person_type");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.NameType)
                    .HasColumnName("name_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MPostingKey>(entity =>
            {
                entity.ToTable("m_posting_key");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_posting_key")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MProvince>(entity =>
            {
                entity.ToTable("m_province");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_province_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ZoneCode)
                    .HasColumnName("zone_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MRace>(entity =>
            {
                entity.ToTable("m_race");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_race_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MReligion>(entity =>
            {
                entity.ToTable("m_religion");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_religion_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MResolveMethod>(entity =>
            {
                entity.ToTable("m_resolve_method");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_resolvemethod_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MRestrictArea>(entity =>
            {
                entity.ToTable("m_restrict_area");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_restrictarea_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MRole>(entity =>
            {
                entity.ToTable("m_role");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RoleType)
                    .IsRequired()
                    .HasColumnName("role_type")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ESEC')");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MScreeningObject>(entity =>
            {
                entity.ToTable("m_screening_object");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GroupCode)
                    .HasColumnName("group_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MScreeningObjectGroup>(entity =>
            {
                entity.ToTable("m_screening_object_group");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_scnobjgroup_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MScreeningPier>(entity =>
            {
                entity.ToTable("m_screening_pier");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_scnpier_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MScreeningPoint>(entity =>
            {
                entity.ToTable("m_screening_point");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_scnpoint_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MScreeningRow>(entity =>
            {
                entity.ToTable("m_screening_row");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_scnrow_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MScreeningTool>(entity =>
            {
                entity.ToTable("m_screening_tool");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_scntool_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MSubcontract>(entity =>
            {
                entity.ToTable("m_subcontract");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_subcontract_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasColumnName("company_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SubcontractName)
                    .HasColumnName("subcontract_name")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTaxCode>(entity =>
            {
                entity.ToTable("m_tax_code");

                entity.HasIndex(e => e.TaxCode)
                    .HasName("uq_taxcode")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Gl)
                    .HasColumnName("gl")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TaxCode)
                    .IsRequired()
                    .HasColumnName("tax_code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTaxiInformType>(entity =>
            {
                entity.ToTable("m_taxi_inform_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_taxiinftype_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTitle>(entity =>
            {
                entity.ToTable("m_title");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_title_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingChannel>(entity =>
            {
                entity.ToTable("m_training_channel");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_trainchannel_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CurriculumCode)
                    .IsRequired()
                    .HasColumnName("curriculum_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingChapter>(entity =>
            {
                entity.ToTable("m_training_chapter");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_trainchapter_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NameEng)
                    .HasColumnName("name_eng")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingCompany>(entity =>
            {
                entity.ToTable("m_training_company");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_trainingcomp_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingContent>(entity =>
            {
                entity.ToTable("m_training_content");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_traincontent_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContentBody)
                    .HasColumnName("content_body")
                    .IsUnicode(false);

                entity.Property(e => e.ContentBodyEng)
                    .HasColumnName("content_body_eng")
                    .IsUnicode(false);

                entity.Property(e => e.ContentHeader)
                    .HasColumnName("content_header")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ContentHeaderEng)
                    .HasColumnName("content_header_eng")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingCurriculum>(entity =>
            {
                entity.ToTable("m_training_curriculum");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_traincurriculum_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.NameEng)
                    .HasColumnName("name_eng")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TcAirportCode)
                    .IsRequired()
                    .HasColumnName("tc_airport_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingCurriculumMedia>(entity =>
            {
                entity.ToTable("m_training_curriculum_media");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_traincurrmedia_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCode)
                    .IsRequired()
                    .HasColumnName("division_code")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber).HasColumnName("order_number");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TcmAirportCode)
                    .IsRequired()
                    .HasColumnName("tcm_airport_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingChapterCode)
                    .IsRequired()
                    .HasColumnName("training_chapter_code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCurriculumCode)
                    .IsRequired()
                    .HasColumnName("training_curriculum_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingMediaCode)
                    .IsRequired()
                    .HasColumnName("training_media_code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingDayoff>(entity =>
            {
                entity.ToTable("m_training_dayoff");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_trainingdayoff_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DateOffday)
                    .HasColumnName("date_offday")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingDocument>(entity =>
            {
                entity.ToTable("m_training_document");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_traindocument_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeCode)
                    .IsRequired()
                    .HasColumnName("document_type_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TdAirportCode)
                    .IsRequired()
                    .HasColumnName("td_airport_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCurriculumCode)
                    .IsRequired()
                    .HasColumnName("training_curriculum_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingMedia>(entity =>
            {
                entity.ToTable("m_training_media");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_trainmedia_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MediaName)
                    .HasColumnName("media_name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MediaNameEng)
                    .HasColumnName("media_name_eng")
                    .IsUnicode(false);

                entity.Property(e => e.MediaPath)
                    .HasColumnName("media_path")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MediaPathEng)
                    .HasColumnName("media_path_eng")
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingPunishment>(entity =>
            {
                entity.ToTable("m_training_punishment");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_trainpunishment_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BlockDay).HasColumnName("block_day");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TpAirportCode)
                    .IsRequired()
                    .HasColumnName("tp_airport_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCurriculumCode)
                    .IsRequired()
                    .HasColumnName("training_curriculum_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MTrainingStatus>(entity =>
            {
                entity.ToTable("m_training_status");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_trainingst_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MUnit>(entity =>
            {
                entity.ToTable("m_unit");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_unit_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MVehicleBrand>(entity =>
            {
                entity.ToTable("m_vehicle_brand");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_vehbrand_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MVehicleColor>(entity =>
            {
                entity.ToTable("m_vehicle_color");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_vehcolor_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MVehicleFunction>(entity =>
            {
                entity.ToTable("m_vehicle_function");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_vehicle_function_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VFuncName)
                    .HasColumnName("v_func_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MVehiclePassRate>(entity =>
            {
                entity.ToTable("m_vehicle_pass_rate");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("date");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MaxWeight)
                    .HasColumnName("max_weight")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.MinWeight)
                    .HasColumnName("min_weight")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("date");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MVehicleType>(entity =>
            {
                entity.ToTable("m_vehicle_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_vehtype_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MViolationGuilt>(entity =>
            {
                entity.ToTable("m_violation_guilt");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_vioguilt_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MViolationPlace>(entity =>
            {
                entity.ToTable("m_violation_place");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_vioplace_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MWtCode>(entity =>
            {
                entity.ToTable("m_wt_code");

                entity.HasIndex(e => e.WtCode)
                    .HasName("uq_vat_wt_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VatRate)
                    .HasColumnName("vat_rate")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.WtCode)
                    .IsRequired()
                    .HasColumnName("wt_code")
                    .HasMaxLength(3)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MWtType>(entity =>
            {
                entity.ToTable("m_wt_type");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_wttype")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WtType)
                    .IsRequired()
                    .HasColumnName("wt_type")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MZone>(entity =>
            {
                entity.ToTable("m_zone");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_zone_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.ToTable("operation");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_oper")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ApCode)
                    .IsRequired()
                    .HasColumnName("ap_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .IsRequired()
                    .HasColumnName("company_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCode)
                    .IsRequired()
                    .HasColumnName("division_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate)
                    .HasColumnName("event_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EventDescription)
                    .HasColumnName("event_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.FlagAnalyze)
                    .HasColumnName("flag_analyze")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.FlagAui)
                    .HasColumnName("flag_aui")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.FlagBomb)
                    .HasColumnName("flag_bomb")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.FlagDaily)
                    .HasColumnName("flag_daily")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.FlagEmergency)
                    .HasColumnName("flag_emergency")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.FlagEoc)
                    .HasColumnName("flag_eoc")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.FlagPhone)
                    .HasColumnName("flag_phone")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.FlagRapid)
                    .HasColumnName("flag_rapid")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.FlagVerbal)
                    .HasColumnName("flag_verbal")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('NO')");

                entity.Property(e => e.Notifications)
                    .HasColumnName("notifications")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.NotificationsTime)
                    .HasColumnName("notifications_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TmcCode)
                    .IsRequired()
                    .HasColumnName("tmc_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TypeEmergencyCode)
                    .IsRequired()
                    .HasColumnName("type_emergency_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationAnalyze>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operation_analyze");

                entity.Property(e => e.BackgroundAircraft)
                    .HasColumnName("background_aircraft")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundAnimal)
                    .HasColumnName("background_animal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundChild)
                    .HasColumnName("background_child")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundFactory)
                    .HasColumnName("background_factory")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundHouse)
                    .HasColumnName("background_house")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundKitchen)
                    .HasColumnName("background_kitchen")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundMusic)
                    .HasColumnName("background_music")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundNone)
                    .HasColumnName("background_none")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundOffice)
                    .HasColumnName("background_office")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundOther)
                    .HasColumnName("background_other")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundParty)
                    .HasColumnName("background_party")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundPeople)
                    .HasColumnName("background_people")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundShip)
                    .HasColumnName("background_ship")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundTraffic)
                    .HasColumnName("background_traffic")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BackgroundTrain)
                    .HasColumnName("background_train")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LangaugeBadAccent)
                    .HasColumnName("langauge_bad_accent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LangaugeGoodAccent)
                    .HasColumnName("langauge_good_accent")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LangaugeNoReason)
                    .HasColumnName("langauge_no_reason")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageEducated)
                    .HasColumnName("language_educated")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageEnglish)
                    .HasColumnName("language_english")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageLocal)
                    .HasColumnName("language_local")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageOther)
                    .HasColumnName("language_other")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageReading)
                    .HasColumnName("language_reading")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageRecording)
                    .HasColumnName("language_recording")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageThai)
                    .HasColumnName("language_thai")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageUnclearVoice)
                    .HasColumnName("language_unclear_voice")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LanguageUneducated)
                    .HasColumnName("language_uneducated")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.OtherFamiliar)
                    .HasColumnName("other_familiar")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneBox)
                    .HasColumnName("phone_box")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneFar)
                    .HasColumnName("phone_far")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneGlobal)
                    .HasColumnName("phone_global")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneInternal)
                    .HasColumnName("phone_internal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("phone_number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhonePublic)
                    .HasColumnName("phone_public")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneUrban)
                    .HasColumnName("phone_urban")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterAdult)
                    .HasColumnName("reporter_adult")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterChild)
                    .HasColumnName("reporter_child")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterFemale)
                    .HasColumnName("reporter_female")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterForeigner)
                    .HasColumnName("reporter_foreigner")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterMale)
                    .HasColumnName("reporter_male")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterOther)
                    .HasColumnName("reporter_other")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterThai)
                    .HasColumnName("reporter_thai")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechAngry)
                    .HasColumnName("speech_angry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechCalm)
                    .HasColumnName("speech_calm")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechCry)
                    .HasColumnName("speech_cry")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechDrunk)
                    .HasColumnName("speech_drunk")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechEmotion)
                    .HasColumnName("speech_emotion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechExcited)
                    .HasColumnName("speech_excited")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechHappy)
                    .HasColumnName("speech_happy")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechIntend)
                    .HasColumnName("speech_intend")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechLaugh)
                    .HasColumnName("speech_laugh")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechNoReason)
                    .HasColumnName("speech_no_reason")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechReason)
                    .HasColumnName("speech_reason")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpeechSerious)
                    .HasColumnName("speech_serious")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceBass)
                    .HasColumnName("voice_bass")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceBending)
                    .HasColumnName("voice_bending")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceCaseFamiliar)
                    .HasColumnName("voice_case_familiar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceClear)
                    .HasColumnName("voice_clear")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceCoerce)
                    .HasColumnName("voice_coerce")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceCough)
                    .HasColumnName("voice_cough")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceFamiliar)
                    .HasColumnName("voice_familiar")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceFamiliarPerson)
                    .HasColumnName("voice_familiar_person")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceHeavilyBreathe)
                    .HasColumnName("voice_heavily_breathe")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceHighKey)
                    .HasColumnName("voice_high_key")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceHoarse)
                    .HasColumnName("voice_hoarse")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceLoud)
                    .HasColumnName("voice_loud")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceLowKey)
                    .HasColumnName("voice_low_key")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceNasal)
                    .HasColumnName("voice_nasal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceNormal)
                    .HasColumnName("voice_normal")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceProlong)
                    .HasColumnName("voice_prolong")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceQuiet)
                    .HasColumnName("voice_quiet")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceRattle)
                    .HasColumnName("voice_rattle")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceShout)
                    .HasColumnName("voice_shout")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceSlow)
                    .HasColumnName("voice_slow")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceSpeed)
                    .HasColumnName("voice_speed")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceStutter)
                    .HasColumnName("voice_stutter")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceUnclear)
                    .HasColumnName("voice_unclear")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VoiceWhisper)
                    .HasColumnName("voice_whisper")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationAui>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operation_aui");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationDaily>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operation_daily");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.ReceipentName)
                    .HasColumnName("receipent_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceipentSurname)
                    .HasColumnName("receipent_surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceipentTitleCode)
                    .HasColumnName("receipent_title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.ReceipentTurnNumber).HasColumnName("receipent_turn_number");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SendDate)
                    .HasColumnName("send_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SenderName)
                    .HasColumnName("sender_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderSurname)
                    .HasColumnName("sender_surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SenderTitleCode)
                    .HasColumnName("sender_title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.SenderTurnNumber).HasColumnName("sender_turn_number");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Tool)
                    .HasColumnName("tool")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TurnNumber).HasColumnName("turn_number");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WorkHour).HasColumnName("work_hour");
            });

            modelBuilder.Entity<OperationEmergency>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operation_emergency");

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("division_code")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformDate)
                    .HasColumnName("inform_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.RecepientName)
                    .HasColumnName("recepient_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SenderName)
                    .HasColumnName("sender_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationEoc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operation_eoc");

                entity.Property(e => e.Behavior1)
                    .HasColumnName("behavior1")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Behavior2)
                    .HasColumnName("behavior2")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.CrewChild).HasColumnName("crew_child");

                entity.Property(e => e.CrewPassengerFemale).HasColumnName("crew_passenger_female");

                entity.Property(e => e.CrewPassengerMale).HasColumnName("crew_passenger_male");

                entity.Property(e => e.CrewPatient).HasColumnName("crew_patient");

                entity.Property(e => e.CrewStaffFemale).HasColumnName("crew_staff_female");

                entity.Property(e => e.CrewStaffMale).HasColumnName("crew_staff_male");

                entity.Property(e => e.CrewTotal).HasColumnName("crew_total");

                entity.Property(e => e.CrewVip).HasColumnName("crew_vip");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlightArrivalDate)
                    .HasColumnName("flight_arrival_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightCompany)
                    .HasColumnName("flight_company")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightDepartureDate)
                    .HasColumnName("flight_departure_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlightDestination)
                    .HasColumnName("flight_destination")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightFuelHour)
                    .HasColumnName("flight_fuel_hour")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FlightFuelMinute)
                    .HasColumnName("flight_fuel_minute")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FlightModel)
                    .HasColumnName("flight_model")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlightNickname)
                    .HasColumnName("flight_nickname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FlightOrigin)
                    .HasColumnName("flight_origin")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.FlightType)
                    .HasColumnName("flight_type")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HijackerFemale)
                    .HasColumnName("hijacker_female")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HijackerFemaleAge)
                    .HasColumnName("hijacker_female_age")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HijackerFemaleNationality)
                    .HasColumnName("hijacker_female_nationality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.HijackerMale).HasColumnName("hijacker_male");

                entity.Property(e => e.HijackerMaleAge)
                    .HasColumnName("hijacker_male_age")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HijackerMaleNationality)
                    .HasColumnName("hijacker_male_nationality")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.RecepientCompany)
                    .HasColumnName("recepient_company")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.RecepientDate)
                    .HasColumnName("recepient_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RecepientName)
                    .HasColumnName("recepient_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RecepientTel)
                    .HasColumnName("recepient_tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterCompany)
                    .HasColumnName("reporter_company")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterDate)
                    .HasColumnName("reporter_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReporterName)
                    .HasColumnName("reporter_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterTel)
                    .HasColumnName("reporter_tel")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Request)
                    .HasColumnName("request")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.WeaponAirgun).HasColumnName("weapon_airgun");

                entity.Property(e => e.WeaponBomb).HasColumnName("weapon_bomb");

                entity.Property(e => e.WeaponCarbine).HasColumnName("weapon_carbine");

                entity.Property(e => e.WeaponMachineGun).HasColumnName("weapon_machine_gun");

                entity.Property(e => e.WeaponOt)
                    .HasColumnName("weapon_ot")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.WeaponOther).HasColumnName("weapon_other");

                entity.Property(e => e.WeaponRifle).HasColumnName("weapon_rifle");

                entity.Property(e => e.WeaponShotgun).HasColumnName("weapon_shotgun");

                entity.Property(e => e.WeaponType)
                    .HasColumnName("weapon_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationPhone>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operation_phone");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformDate)
                    .HasColumnName("inform_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InformFrom)
                    .HasColumnName("inform_from")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.InformName)
                    .HasColumnName("inform_name")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.InformTo)
                    .HasColumnName("inform_to")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.Recipient)
                    .HasColumnName("recipient")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .HasColumnName("source")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationRapid>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operation_rapid");

                entity.Property(e => e.Cause)
                    .HasColumnName("cause")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Damage)
                    .HasColumnName("damage")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformDate)
                    .HasColumnName("inform_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InformTo)
                    .HasColumnName("inform_to")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NextOperation)
                    .HasColumnName("next_operation")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.Place)
                    .HasColumnName("place")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RelatedPerson)
                    .HasColumnName("related_person")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterName)
                    .HasColumnName("reporter_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterPosition)
                    .HasColumnName("reporter_position")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OperationVerbal>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("operation_verbal");

                entity.Property(e => e.Damage)
                    .HasColumnName("damage")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformDate)
                    .HasColumnName("inform_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InformTo)
                    .HasColumnName("inform_to")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.NextOperation)
                    .HasColumnName("next_operation")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.OperationId).HasColumnName("operation_id");

                entity.Property(e => e.Place)
                    .HasColumnName("place")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterName)
                    .HasColumnName("reporter_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ReporterPosition)
                    .HasColumnName("reporter_position")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassPerson>(entity =>
            {
                entity.ToTable("pass_person");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AgentCompanyCode)
                    .HasColumnName("agent_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentFunctionality)
                    .HasColumnName("agent_functionality")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName)
                    .HasColumnName("agent_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentSurname)
                    .HasColumnName("agent_surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentTitleCode)
                    .HasColumnName("agent_title_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Bid)
                    .HasColumnName("bid")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BidDate)
                    .HasColumnName("bid_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDurationDate)
                    .HasColumnName("end_duration_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipmentAmount)
                    .HasColumnName("equipment_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("date");

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Init)
                    .HasColumnName("init")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasColumnType("date");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NameEng)
                    .HasColumnName("name_eng")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityNumber)
                    .HasColumnName("nationality_number")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OldCompanyCode)
                    .HasColumnName("old_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OldPassPersonTempId).HasColumnName("old_pass_person_temp_id");

                entity.Property(e => e.OldUrno)
                    .HasColumnName("old_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassDurationCode)
                    .HasColumnName("pass_duration_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassIssueLocationCode)
                    .HasColumnName("pass_issue_location_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonTempReasonCode)
                    .HasColumnName("pass_person_temp_reason_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonTempTypeCode)
                    .HasColumnName("pass_person_temp_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PasspersCode)
                    .HasColumnName("passpers_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PpAirCode)
                    .HasColumnName("pp_air_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PpFormNumber)
                    .HasColumnName("pp_form_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictAreaCode)
                    .HasColumnName("restrict_area_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StaffGroupCode)
                    .HasColumnName("staff_group_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StartDurationDate)
                    .HasColumnName("start_duration_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subcontract)
                    .HasColumnName("subcontract")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SurnameEng)
                    .HasColumnName("surname_eng")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TiteCode)
                    .HasColumnName("tite_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassPersonCancel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_person_cancel");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkPassPersonId).HasColumnName("link_pass_person_id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCancel)
                    .HasColumnName("reason_cancel")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassPersonChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_person_change");

                entity.Property(e => e.Bid)
                    .HasColumnName("bid")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.BidDate)
                    .HasColumnName("bid_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EquipmentAmount)
                    .HasColumnName("equipment_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("date");

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID PK");

                entity.Property(e => e.Init)
                    .HasColumnName("init")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NameEng)
                    .HasColumnName("name_eng")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityNumber)
                    .HasColumnName("nationality_number")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NewPassPersonId).HasColumnName("new_pass_person_id");

                entity.Property(e => e.NewUrno)
                    .HasColumnName("new_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.OldCompanyCode)
                    .HasColumnName("old_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonReasonCode)
                    .HasColumnName("pass_person_reason_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonTypeCode)
                    .HasColumnName("pass_person_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictAreaCode)
                    .HasColumnName("restrict_area_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SurnameEng)
                    .HasColumnName("surname_eng")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("ผู้บันทึก");

                entity.Property(e => e.TiteCode)
                    .HasColumnName("tite_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่่แก้ไขล่าสุด");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ผู้แก้ไขล่าสุด");
            });

            modelBuilder.Entity<PassPersonCopy>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_person_copy");

                entity.Property(e => e.Bid)
                    .HasColumnName("bid")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("BID");

                entity.Property(e => e.BidDate)
                    .HasColumnName("bid_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก BID");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("เลขที่บัตรประจำตัว");

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("ประเภทบัตรประจำตัว");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("เลขที่ธุรการ");

                entity.Property(e => e.EquipmentAmount)
                    .HasColumnName("equipment_amount")
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("คำอุปกรณ์");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ETL Field Name");

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ETL System");

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ETL Table");

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ETL Value");

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("date")
                    .HasComment("วันหมดอายุ");

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("ค่าธรรมเนียม");

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("ค่าปรับ");

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("รหัส หน้าที่");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID PK");

                entity.Property(e => e.Init)
                    .HasColumnName("init")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("INIT");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasColumnType("date")
                    .HasComment("วันที่แจ้งหนี้");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("ชือ");

                entity.Property(e => e.NameEng)
                    .HasColumnName("name_eng")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ชื่อ (ภาษาอังกฤษ)");

                entity.Property(e => e.NationalityNumber)
                    .HasColumnName("nationality_number")
                    .HasMaxLength(13)
                    .IsUnicode(false)
                    .HasComment("หมายเลขบัตรประชาชน");

                entity.Property(e => e.OldCompanyCode)
                    .HasColumnName("old_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("สังกัดเดิม");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("หมายเลขสั่งซื้อ");

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("เลขที่บัตร");

                entity.Property(e => e.PassPersonReasonCode)
                    .HasColumnName("pass_person_reason_code")
                    .HasMaxLength(60)
                    .IsUnicode(false)
                    .HasComment("เหตุผลการทำบัตร");

                entity.Property(e => e.PassPersonTypeCode)
                    .HasColumnName("pass_person_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("ประเภทบัตร");

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("รหัสบุคคล");

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("สังกัดปัจจุบัน");

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่รับบัตร");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasComment("หมายเหตุ");

                entity.Property(e => e.RestrictAreaCode)
                    .HasColumnName("restrict_area_code")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("พื้นที่หวงห้าม");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("สถานะข้อมูล \"N\" = ปกติ, \"C\" = ยกเลิก, \"D\" = ลบ");

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("นามสกุล");

                entity.Property(e => e.SurnameEng)
                    .HasColumnName("surname_eng")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("นามสกุล (ภาษาอังกฤษ)");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("ผู้บันทึก");

                entity.Property(e => e.TiteCode)
                    .HasColumnName("tite_code")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("คำนำหน้าชื่อ");

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasColumnType("decimal(10, 2)")
                    .HasComment("รวมค่าธรรมเนียม");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไขล่าสุด");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ผู้แก้ไขล่าสุด");
            });

            modelBuilder.Entity<PassPersonReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_person_return");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FlagReturnCard)
                    .HasColumnName("flag_return_card")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassPersonTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_person_temp");

                entity.Property(e => e.AgentCompanyCode)
                    .HasColumnName("agent_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentFunctionality)
                    .HasColumnName("agent_functionality")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName)
                    .HasColumnName("agent_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentSurname)
                    .HasColumnName("agent_surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentTitleCode)
                    .HasColumnName("agent_title_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CreateCardDate)
                    .HasColumnName("create_card_date")
                    .HasColumnType("date");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDatationDate)
                    .HasColumnName("end_datation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EquipmentAmount)
                    .HasColumnName("equipment_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasColumnType("date");

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityNumber)
                    .HasColumnName("nationality_number")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OldPassPersonTempId).HasColumnName("old_pass_person_temp_id");

                entity.Property(e => e.OldUrno)
                    .HasColumnName("old_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PassDurationCode)
                    .HasColumnName("pass_duration_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassIssueLocationCode)
                    .HasColumnName("pass_issue_location_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonTempReasonCode)
                    .HasColumnName("pass_person_temp_reason_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonTempTypeCode)
                    .HasColumnName("pass_person_temp_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictAreaCode)
                    .HasColumnName("restrict_area_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StartDurationDate)
                    .HasColumnName("start_duration_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subcontract)
                    .HasColumnName("subcontract")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TiteCode)
                    .HasColumnName("tite_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_vehicle");

                entity.Property(e => e.ApproveDate)
                    .HasColumnName("approve_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveStaff)
                    .HasColumnName("approve_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FeeType)
                    .HasColumnName("fee_type")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FeeWeight)
                    .HasColumnName("fee_weight")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LetterNumber)
                    .HasColumnName("letter_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassVehicleReasonCode)
                    .HasColumnName("pass_vehicle_reason_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewDate)
                    .HasColumnName("review_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleBrandCode)
                    .HasColumnName("vehicle_brand_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleCode)
                    .HasColumnName("vehicle_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleColorCode)
                    .HasColumnName("vehicle_color_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleFunctionCode)
                    .HasColumnName("vehicle_function_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLicense)
                    .HasColumnName("vehicle_license")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNumber)
                    .HasColumnName("vehicle_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("vehicle_type_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WeightDlt)
                    .HasColumnName("weight_dlt")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WheelNumber)
                    .HasColumnName("wheel_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassVehicleCancel>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_vehicle_cancel");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkPassVehicleId).HasColumnName("link_pass_vehicle_id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonCancel)
                    .HasColumnName("reason_cancel")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassVehicleChange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_vehicle_change");

                entity.Property(e => e.ApproveDate)
                    .HasColumnName("approve_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ApproveStaff)
                    .HasColumnName("approve_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FeeType)
                    .HasColumnName("fee_type")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FeeWeight)
                    .HasColumnName("fee_weight")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LetterNumber)
                    .HasColumnName("letter_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassVehicleReasonCode)
                    .HasColumnName("pass_vehicle_reason_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.ReviewDate)
                    .HasColumnName("review_date")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleBrandCode)
                    .HasColumnName("vehicle_brand_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleCode)
                    .HasColumnName("vehicle_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleColorCode)
                    .HasColumnName("vehicle_color_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleFunctionCode)
                    .HasColumnName("vehicle_function_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLicense)
                    .HasColumnName("vehicle_license")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNumber)
                    .HasColumnName("vehicle_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("vehicle_type_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WeightDlt)
                    .HasColumnName("weight_dlt")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WheelNumber)
                    .HasColumnName("wheel_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassVehicleReturn>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_vehicle_return");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FlagReturnCard)
                    .HasColumnName("flag_return_card")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PassVehicleTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("pass_vehicle_temp");

                entity.Property(e => e.AgentCompanyCode)
                    .HasColumnName("agent_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentName)
                    .HasColumnName("agent_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.AgentSubcompany)
                    .HasColumnName("agent_subcompany")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.EndDatationDate)
                    .HasColumnName("end_datation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FeeType)
                    .HasColumnName("fee_type")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.FeeWeight)
                    .HasColumnName("fee_weight")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PassDurationCode)
                    .HasColumnName("pass_duration_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassIssueLocationCode)
                    .HasColumnName("pass_issue_location_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.StartDurationDate)
                    .HasColumnName("start_duration_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleBrandCode)
                    .HasColumnName("vehicle_brand_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleCode)
                    .HasColumnName("vehicle_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleColorCode)
                    .HasColumnName("vehicle_color_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleFunctionCode)
                    .HasColumnName("vehicle_function_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLicense)
                    .HasColumnName("vehicle_license")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleNumber)
                    .HasColumnName("vehicle_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("vehicle_type_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.WeightDlt)
                    .HasColumnName("weight_dlt")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<Person>(entity =>
            {
                entity.ToTable("person");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_person_code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CertificateCode)
                    .HasColumnName("certificate_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ChangeCode)
                    .HasColumnName("change_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CountryCode)
                    .HasColumnName("country_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DefectiveWorkCode)
                    .HasColumnName("defective_work_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EyeColorCode)
                    .HasColumnName("eye_color_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasColumnName("father_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FlagBlacklist).HasColumnName("flag_blacklist");

                entity.Property(e => e.FlagNoneCard).HasColumnName("flag_none_card");

                entity.Property(e => e.FlagViolation)
                    .HasColumnName("flag_violation")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.GenderCode)
                    .HasColumnName("gender_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HairColorCode)
                    .HasColumnName("hair_color_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusCode)
                    .HasColumnName("marital_status_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasColumnName("mother_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("nationality_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityNumber)
                    .HasColumnName("nationality_number")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasColumnName("nick_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OldCompanyCode)
                    .HasColumnName("old_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PAirCode)
                    .HasColumnName("p_air_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PProvince)
                    .IsRequired()
                    .HasColumnName("p_province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PasspersCode)
                    .HasColumnName("passpers_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PassportNumber)
                    .HasColumnName("passport_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PathPic)
                    .HasColumnName("path_pic")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PathPicSign)
                    .HasColumnName("path_pic_sign")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.PersonTypeCode)
                    .HasColumnName("person_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RaceCode)
                    .HasColumnName("race_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.RetireDate)
                    .HasColumnName("retire_date")
                    .HasColumnType("date");

                entity.Property(e => e.RtpCode)
                    .HasColumnName("rtp_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RtpSendCode)
                    .HasColumnName("rtp_send_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SalaryCode)
                    .HasColumnName("salary_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Scar)
                    .HasColumnName("scar")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SubDivisionCode)
                    .HasColumnName("sub_division_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SubcontractCode)
                    .HasColumnName("subcontract_code")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tel)
                    .HasColumnName("tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCode)
                    .HasColumnName("training_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationCode)
                    .HasColumnName("violation_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonAttachment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("person_attachment");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentTypeCode)
                    .HasColumnName("document_type_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentUrl)
                    .HasColumnName("document_url")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.DriverLicenseTypeId)
                    .HasColumnName("driver_license_type_id")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ExpiredDate)
                    .HasColumnName("expired_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileExtension)
                    .HasColumnName("file_extension")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IssueDate)
                    .HasColumnName("issue_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreviewUrl)
                    .HasColumnName("preview_url")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RefLocation)
                    .HasColumnName("ref_location")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RefNumber)
                    .HasColumnName("ref_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonCertificate>(entity =>
            {
                entity.ToTable("person_certificate");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_percert_code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CerAirCode)
                    .HasColumnName("cer_air_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CerDescription)
                    .HasColumnName("cer_description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.CerExpireDate)
                    .HasColumnName("cer_expire_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CerReceiveDate)
                    .HasColumnName("cer_receive_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CertificateDate)
                    .HasColumnName("certificate_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CertificateNumber)
                    .HasColumnName("certificate_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.StaffGroupCode)
                    .HasColumnName("staff_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PersonRtp>(entity =>
            {
                entity.ToTable("person_rtp");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID PK");

                entity.Property(e => e.CheckingStatus)
                    .HasColumnName("checking_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("document_date")
                    .HasColumnType("date")
                    .HasComment("วันที่บันทึก งคร.");

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("เลขที่ งคร.");

                entity.Property(e => e.DocumentReceiveDate)
                    .HasColumnName("document_receive_date")
                    .HasColumnType("date")
                    .HasComment("วันที่รับเอกสาร งคร.");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ETL Field Name");

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ETL System");

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ETL Table");

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ETL Xalue");

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasComment("Path file และชื่อไฟล์เอกสารแนบ");

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("รหัสบุคคล");

                entity.Property(e => e.RtpAirCode)
                    .HasColumnName("rtp_air_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RtpCode)
                    .HasColumnName("rtp_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RtpDate)
                    .HasColumnName("rtp_date")
                    .HasColumnType("date")
                    .HasComment("วันที่บันทึกที่เอกสารกรมตำรวจ");

                entity.Property(e => e.RtpDurationCode)
                    .HasColumnName("rtp_duration_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RtpExpireDate)
                    .HasColumnName("rtp_expire_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RtpNumber)
                    .HasColumnName("rtp_number")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("เลขที่เอกสารกรมตำรวจ");

                entity.Property(e => e.RtpReceiveDate)
                    .HasColumnName("rtp_receive_date")
                    .HasColumnType("date")
                    .HasComment("วันที่รับเอกสารกรมตำรวจ");

                entity.Property(e => e.RtpResult)
                    .HasColumnName("rtp_result")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.RtpStaffGroupCode)
                    .HasColumnName("rtp_staff_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("สถานะใช้งาน Active or Inactive");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ผู้บันทึก");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไขล่าสุด");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ผู้แก้ไขล่าสุด");
            });

            modelBuilder.Entity<PersonTraining>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("person_training");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ETL Field Name");

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ETL System");

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ETL Table");

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ETL Value");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID PK");

                entity.Property(e => e.PassDate)
                    .HasColumnName("pass_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("รหัสบุคคล");

                entity.Property(e => e.PtGroupCode)
                    .HasColumnName("pt_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PtRecAirCode)
                    .HasColumnName("pt_rec_air_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PtStaffRec)
                    .HasColumnName("pt_staff_rec")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("ผู้บันทึก");

                entity.Property(e => e.TrainCode)
                    .HasColumnName(@"train_code
")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrainDate)
                    .HasColumnName("train_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrainName)
                    .HasColumnName("train_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainResult)
                    .HasColumnName("train_result")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไขล่าสุด");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ผู้แก้ไขล่าสุด");
            });

            modelBuilder.Entity<PersonViolation>(entity =>
            {
                entity.ToTable("person_violation");

                entity.HasIndex(e => e.ViolationCode)
                    .HasName("uq_pervio")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasComment("ID PK");

                entity.Property(e => e.ActuationCode)
                    .HasColumnName("actuation_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("การดำเนินการ");

                entity.Property(e => e.ActuationResult)
                    .HasColumnName("actuation_result")
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasComment("ผลการดำเนินการ");

                entity.Property(e => e.ArrestDate)
                    .HasColumnName("arrest_date")
                    .HasColumnType("datetime")
                    .HasComment("วันเวลาที่จับกุม");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasComment("รายละเอียดความผิด");

                entity.Property(e => e.EndViolationDate)
                    .HasColumnName("end_violation_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่สิ้นสุดความผิด");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ETL Field Name");

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasComment("ETL System");

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ETL Table");

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ETL Value");

                entity.Property(e => e.FilePath)
                    .HasColumnName("file_path")
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasComment("Path file และชื่อไฟล์เอกสารแนบ");

                entity.Property(e => e.PassStatus)
                    .HasColumnName("pass_status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("สถานะการใช้บัตร \"ACTIVE\" = ปกติ, \"INACTIVE\" = ยกเลิก");

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("รหัสบุคคล");

                entity.Property(e => e.PvAirCode)
                    .HasColumnName("pv_air_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("ท่าอากาศยานที่บันทึก");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false)
                    .HasComment("หมายเหตุ");

                entity.Property(e => e.ResolveMethodCode)
                    .HasColumnName("resolve_method_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("วิธีการแก้ไข");

                entity.Property(e => e.StaffGroupCode)
                    .HasColumnName("staff_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("สังกัดผู้บันทึก");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("สถานะ \"ACTIVE\" = ปกติ, \"INACTIVE\" = ยกเลิก, \"DELETE\" = ลบ");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่บันทึก");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasComment("ผู้บันทึก");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่แก้ไขล่าสุด");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasComment("ผู้แก้ไขล่าสุด");

                entity.Property(e => e.ViolationCode)
                    .HasColumnName("violation_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("รหัสความผิดบุคคล");

                entity.Property(e => e.ViolationDate)
                    .HasColumnName("violation_date")
                    .HasColumnType("datetime")
                    .HasComment("วันที่กระทำความผิด");

                entity.Property(e => e.ViolationGuilt)
                    .HasColumnName("violation_guilt")
                    .HasMaxLength(120)
                    .IsUnicode(false)
                    .HasComment("ประเภทความผิด");

                entity.Property(e => e.ViolationPlaceCode)
                    .HasColumnName("violation_place_code")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasComment("สถานที่การทำความผิด");
            });

            modelBuilder.Entity<PrintCard>(entity =>
            {
                entity.ToTable("print_card");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_print_code")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.ApproveCode)
                    .HasColumnName("approve_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EndDatationDate)
                    .HasColumnName("end_datation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("middle_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityNumber)
                    .HasColumnName("nationality_number")
                    .HasMaxLength(13)
                    .IsUnicode(false);

                entity.Property(e => e.OldCompanyCode)
                    .HasColumnName("old_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassDurationCode)
                    .HasColumnName("pass_duration_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassIssueLocationCode)
                    .HasColumnName("pass_issue_location_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonTempTypeCode)
                    .HasColumnName("pass_person_temp_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PasspersCode)
                    .HasColumnName("passpers_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.RestrictAreaCode)
                    .HasColumnName("restrict_area_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SerialNumber)
                    .HasColumnName("serial_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDurationDate)
                    .HasColumnName("start_duration_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Subcontract)
                    .HasColumnName("subcontract")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Trigger).HasColumnName("trigger");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReqPassVehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("req_pass_vehicle");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScreeningBag>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("screening_bag");

                entity.Property(e => e.BagCheckPosition)
                    .HasColumnName("bag_check_position")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BagCheckStaff)
                    .HasColumnName("bag_check_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureAirline)
                    .HasColumnName("departure_airline")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepartureFlight)
                    .HasColumnName("departure_flight")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureFrom)
                    .HasColumnName("departure_from")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAirline)
                    .HasColumnName("destination_airline")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DestinationFlight)
                    .HasColumnName("destination_flight")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationTo)
                    .HasColumnName("destination_to")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeadOfficer)
                    .HasColumnName("head_officer")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformAirline)
                    .HasColumnName("inform_airline")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InformAirlineDetail)
                    .HasColumnName("inform_airline_detail")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InformOperation)
                    .HasColumnName("inform_operation")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InformOther)
                    .HasColumnName("inform_other")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InformOtherDetail)
                    .HasColumnName("inform_other_detail")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InformSecurity)
                    .HasColumnName("inform_security")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.InformSecurityDetail)
                    .HasColumnName("inform_security_detail")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("nationality_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Occupaton)
                    .HasColumnName("occupaton")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Part)
                    .HasColumnName("part")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PassengerType)
                    .HasColumnName("passenger_type")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasColumnName("property_type")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RaceCode)
                    .HasColumnName("race_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution1)
                    .HasColumnName("resolution1")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution2)
                    .HasColumnName("resolution2")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution3)
                    .HasColumnName("resolution3")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution3Detail)
                    .HasColumnName("resolution3_detail")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResolveDescription)
                    .HasColumnName("resolve_description")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningDate)
                    .HasColumnName("screening_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScreeningPierCode)
                    .HasColumnName("screening_pier_code")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningPosition)
                    .HasColumnName("screening_position")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningRowCode)
                    .HasColumnName("screening_row_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningStaff)
                    .HasColumnName("screening_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningToolCode)
                    .HasColumnName("screening_tool_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftNumber)
                    .HasColumnName("shift_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Suggestion)
                    .HasColumnName("suggestion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TurnNumber).HasColumnName("turn_number");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScreeningBagDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("screening_bag_detail");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.ScreeningBagId).HasColumnName("screening_bag_id");

                entity.Property(e => e.ScreeningObjectCode)
                    .HasColumnName("screening_object_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningObjectGroupCode)
                    .HasColumnName("screening_object_group_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCode)
                    .HasColumnName("unit_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<ScreeningPassenger>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("screening_passenger");

                entity.Property(e => e.BagCheckPosition)
                    .HasColumnName("bag_check_position")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.BagCheckStaff)
                    .HasColumnName("bag_check_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureAirline)
                    .HasColumnName("departure_airline")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DepartureFlight)
                    .HasColumnName("departure_flight")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DepartureFrom)
                    .HasColumnName("departure_from")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationAirline)
                    .HasColumnName("destination_airline")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DestinationFlight)
                    .HasColumnName("destination_flight")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationTo)
                    .HasColumnName("destination_to")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.EndViolationDate)
                    .HasColumnName("end_violation_date")
                    .HasColumnType("date");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HeadOfficer)
                    .HasColumnName("head_officer")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformAirline)
                    .HasColumnName("inform_airline")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InformAirlineDetail)
                    .HasColumnName("inform_airline_detail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InformOperation)
                    .HasColumnName("inform_operation")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InformOther)
                    .HasColumnName("inform_other")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InformOtherDetail)
                    .HasColumnName("inform_other_detail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InformSecurity)
                    .HasColumnName("inform_security")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.InformSecurityDetail)
                    .HasColumnName("inform_security_detail")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("nationality_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Occupaton)
                    .HasColumnName("occupaton")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Part)
                    .HasColumnName("part")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PassengerType)
                    .HasColumnName("passenger_type")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PropertyType)
                    .HasColumnName("property_type")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.RaceCode)
                    .HasColumnName("race_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution1)
                    .HasColumnName("resolution1")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution2)
                    .HasColumnName("resolution2")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution3)
                    .HasColumnName("resolution3")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution3Detail)
                    .HasColumnName("resolution3_detail")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResolveDescription)
                    .HasColumnName("resolve_description")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningDate)
                    .HasColumnName("screening_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScreeningPierCode)
                    .HasColumnName("screening_pier_code")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningPosition)
                    .HasColumnName("screening_position")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningRowCode)
                    .HasColumnName("screening_row_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningStaff)
                    .HasColumnName("screening_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningTime)
                    .HasColumnName("screening_time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ScreeningToolCode)
                    .HasColumnName("screening_tool_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ShiftNumber)
                    .HasColumnName("shift_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.StartViolationDate)
                    .HasColumnName("start_violation_date")
                    .HasColumnType("date");

                entity.Property(e => e.Suggestion)
                    .HasColumnName("suggestion")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TurnNumber)
                    .HasColumnName("turn_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ScreeningPassengerDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("screening_passenger_detail");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Qty).HasColumnName("qty");

                entity.Property(e => e.ScreeningObjectCode)
                    .HasColumnName("screening_object_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningObjectGroupCode)
                    .HasColumnName("screening_object_group_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.ScreeningPassengerId).HasColumnName("screening_passenger_id");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UnitCode)
                    .HasColumnName("unit_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VolPerUnit)
                    .HasColumnName("vol_per_unit")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Weight)
                    .HasColumnName("weight")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SqlResults>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__SQL Resu__3213E83E1E9CC556")
                    .IsClustered(false);

                entity.ToTable("SQL Results");

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .HasMaxLength(255);

                entity.Property(e => e.AgentCompanyCode)
                    .HasColumnName("agent_company_code")
                    .HasMaxLength(255);

                entity.Property(e => e.AgentFunctionality)
                    .HasColumnName("agent_functionality")
                    .HasMaxLength(255);

                entity.Property(e => e.AgentName)
                    .HasColumnName("agent_name")
                    .HasMaxLength(255);

                entity.Property(e => e.AgentSurname)
                    .HasColumnName("agent_surname")
                    .HasMaxLength(255);

                entity.Property(e => e.AgentTitleCode)
                    .HasColumnName("agent_title_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Bid)
                    .HasColumnName("bid")
                    .HasMaxLength(255);

                entity.Property(e => e.BidDate)
                    .HasColumnName("bid_date")
                    .HasMaxLength(255);

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(255);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(255);

                entity.Property(e => e.DocumentNumber)
                    .HasColumnName("document_number")
                    .HasMaxLength(255);

                entity.Property(e => e.EndDurationDate)
                    .HasColumnName("end_duration_date")
                    .HasMaxLength(255);

                entity.Property(e => e.EquipmentAmount)
                    .HasColumnName("equipment_amount")
                    .HasMaxLength(255);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(255);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(255);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(255);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(255);

                entity.Property(e => e.ExpireDate)
                    .HasColumnName("expire_date")
                    .HasMaxLength(255);

                entity.Property(e => e.FeeAmount)
                    .HasColumnName("fee_amount")
                    .HasMaxLength(255);

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasMaxLength(255);

                entity.Property(e => e.Frequency)
                    .HasColumnName("frequency")
                    .HasMaxLength(255);

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(255);

                entity.Property(e => e.Init)
                    .HasColumnName("init")
                    .HasMaxLength(255);

                entity.Property(e => e.InvoiceDate)
                    .HasColumnName("invoice_date")
                    .HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(255);

                entity.Property(e => e.NameEng)
                    .HasColumnName("name_eng")
                    .HasMaxLength(255);

                entity.Property(e => e.NationalityNumber)
                    .HasColumnName("nationality_number")
                    .HasMaxLength(255);

                entity.Property(e => e.OldCompanyCode)
                    .HasColumnName("old_company_code")
                    .HasMaxLength(255);

                entity.Property(e => e.OldPassPersonTempId)
                    .HasColumnName("old_pass_person_temp_id")
                    .HasMaxLength(255);

                entity.Property(e => e.OldUrno)
                    .HasColumnName("old_urno")
                    .HasMaxLength(255);

                entity.Property(e => e.OrderNumber)
                    .HasColumnName("order_number")
                    .HasMaxLength(255);

                entity.Property(e => e.PassDurationCode)
                    .HasColumnName("pass_duration_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PassIssueLocationCode)
                    .HasColumnName("pass_issue_location_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PassNumber)
                    .HasColumnName("pass_number")
                    .HasMaxLength(255);

                entity.Property(e => e.PassPersonTempReasonCode)
                    .HasColumnName("pass_person_temp_reason_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PassPersonTempTypeCode)
                    .HasColumnName("pass_person_temp_type_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PasspersCode)
                    .HasColumnName("passpers_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PpAirCode)
                    .HasColumnName("pp_air_code")
                    .HasMaxLength(255);

                entity.Property(e => e.PpFromNumber)
                    .HasColumnName("pp_from_number")
                    .HasMaxLength(255);

                entity.Property(e => e.PresentCompanyCode)
                    .HasColumnName("present_company_code")
                    .HasMaxLength(255);

                entity.Property(e => e.ReceiveDate)
                    .HasColumnName("receive_date")
                    .HasMaxLength(255);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(255);

                entity.Property(e => e.RestrictAreaCode)
                    .HasColumnName("restrict_area_code")
                    .HasMaxLength(255);

                entity.Property(e => e.StaffGroupCode)
                    .HasColumnName("staff_group_code")
                    .HasMaxLength(255);

                entity.Property(e => e.StartDurationDate)
                    .HasColumnName("start_duration_date")
                    .HasMaxLength(255);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(255);

                entity.Property(e => e.Subcontract)
                    .HasColumnName("subcontract")
                    .HasMaxLength(255);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(255);

                entity.Property(e => e.SurnameEng)
                    .HasColumnName("surname_eng")
                    .HasMaxLength(255);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasMaxLength(255);

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(255);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalAmount)
                    .HasColumnName("total_amount")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<TaxiInform>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("taxi_inform");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverName)
                    .HasColumnName("driver_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverPersonCode)
                    .HasColumnName("driver_person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DriverSurname)
                    .HasColumnName("driver_surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverTitleCode)
                    .HasColumnName("driver_title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EventDate)
                    .HasColumnName("event_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformAddress)
                    .HasColumnName("inform_address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InformDate)
                    .HasColumnName("inform_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InformName)
                    .HasColumnName("inform_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InformSurname)
                    .HasColumnName("inform_surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InformTel)
                    .HasColumnName("inform_tel")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InformTitleCode)
                    .HasColumnName("inform_title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Origin)
                    .HasColumnName("origin")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TaxiInformTypeCode)
                    .HasColumnName("taxi_inform_type_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleBrand)
                    .HasColumnName("vehicle_brand")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleColor)
                    .HasColumnName("vehicle_color")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleLicense)
                    .HasColumnName("vehicle_license")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaxiInformDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("taxi_inform_detail");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.InformDate)
                    .HasColumnName("inform_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InformName)
                    .HasColumnName("inform_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InformSurname)
                    .HasColumnName("inform_surname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InformTitleCode)
                    .HasColumnName("inform_title_code")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Resolution)
                    .HasColumnName("resolution")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TaxiInformId).HasColumnName("taxi_inform_id");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.ToTable("training");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_training_code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CourseCode)
                    .HasColumnName("course_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CourseName)
                    .HasColumnName("course_name")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.DatePassedTest)
                    .HasColumnName("date_passed_test")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.Lecturer)
                    .HasColumnName("lecturer")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PsCode)
                    .HasColumnName("ps_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TnGroupCode)
                    .HasColumnName("tn_group_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TnRecAirCode)
                    .HasColumnName("tn_rec_air_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingDate)
                    .HasColumnName("training_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrainingDatePassed)
                    .HasColumnName("training_date_passed")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrainingLocation)
                    .HasColumnName("training_location")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingRegisterCode)
                    .HasColumnName("training_register_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingResults)
                    .HasColumnName("training_results")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingScore)
                    .HasColumnName("training_score")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingCalendar>(entity =>
            {
                entity.ToTable("training_calendar");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_training_calendar")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.BookSeat).HasColumnName("book_seat");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaxScore).HasColumnName("max_score");

                entity.Property(e => e.OffDay)
                    .HasColumnName("off_day")
                    .HasColumnType("datetime");

                entity.Property(e => e.OpenDay)
                    .HasColumnName("open_day")
                    .HasColumnType("datetime");

                entity.Property(e => e.PassScore).HasColumnName("pass_score");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TotalSeat).HasColumnName("total_seat");

                entity.Property(e => e.TrainingCurriculumCode)
                    .IsRequired()
                    .HasColumnName("training_curriculum_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingDayoffCode)
                    .IsRequired()
                    .HasColumnName("training_dayoff_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingTrainerCode)
                    .IsRequired()
                    .HasColumnName("training_trainer_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingCoaching>(entity =>
            {
                entity.ToTable("training_coaching");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_training_coaching")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .IsRequired()
                    .HasColumnName("person_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCalendarCode).HasColumnName("training_calendar_code");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingPunishmentTrainee>(entity =>
            {
                entity.ToTable("training_punishment_trainee");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_training_punishment_trainee")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .HasColumnName("end_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .HasColumnName("start_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingPunishmentId).HasColumnName("training_punishment_id");

                entity.Property(e => e.TrainingRegisterCode)
                    .IsRequired()
                    .HasColumnName("training_register_code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingRegister>(entity =>
            {
                entity.ToTable("training_register");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_training_register")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EvaluateDate)
                    .HasColumnName("evaluate_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EvaluateScore).HasColumnName("evaluate_score");

                entity.Property(e => e.EvaluateStatus)
                    .HasColumnName("evaluate_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MaxScore).HasColumnName("max_score");

                entity.Property(e => e.PassScore).HasColumnName("pass_score");

                entity.Property(e => e.PersonCode)
                    .IsRequired()
                    .HasColumnName("person_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RegisDate)
                    .HasColumnName("regis_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegistrationDate)
                    .HasColumnName("registration_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCalendarCode)
                    .IsRequired()
                    .HasColumnName("training_calendar_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingChannelCode)
                    .HasColumnName("training_channel_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCode)
                    .HasColumnName("training_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingExpirDate)
                    .HasColumnName("training_expir_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrainingPunishmentCode)
                    .HasColumnName("training_punishment_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingStatus)
                    .HasColumnName("training_status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingTrainee>(entity =>
            {
                entity.ToTable("training_trainee");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_trainingtrai_trainee")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FlagValidDriver)
                    .HasColumnName("flag_valid_driver")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlagValidMedical)
                    .HasColumnName("flag_valid_medical")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FlagValidNationality)
                    .HasColumnName("flag_valid_nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MessageValidDriver)
                    .HasColumnName("message_valid_driver")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MessageValidMedical)
                    .HasColumnName("message_valid_medical")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.MessageValidNationality)
                    .HasColumnName("message_valid_nationality")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .IsRequired()
                    .HasColumnName("person_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TraineeStatus)
                    .HasColumnName("trainee_status")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PASS')");

                entity.Property(e => e.TraineeStatusPerson)
                    .HasColumnName("trainee_status_person")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('PASS')");

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingTrainer>(entity =>
            {
                entity.ToTable("training_trainer");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_training_trainer")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasColumnName("code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .IsRequired()
                    .HasColumnName("person_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingCurriculumCode)
                    .IsRequired()
                    .HasColumnName("training_curriculum_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vehicle");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VehicleViolation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("vehicle_violation");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViolationPerson>(entity =>
            {
                entity.ToTable("violation_person");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_vioper_code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ActuationCode)
                    .HasColumnName("actuation_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ActuationResult)
                    .HasColumnName("actuation_result")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ArrestDate)
                    .HasColumnName("arrest_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Behavior)
                    .HasColumnName("behavior")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.EndViolationDate)
                    .HasColumnName("end_violation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FineAmount)
                    .HasColumnName("fine_amount")
                    .HasColumnType("decimal(10, 2)");

                entity.Property(e => e.FinePayer)
                    .HasColumnName("fine_payer")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FineReceiptNumber)
                    .HasColumnName("fine_receipt_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FlagReport)
                    .HasColumnName("flag_report")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.License)
                    .HasColumnName("license")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PenaltyCode)
                    .HasColumnName("penalty_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PenaltyDurationCode)
                    .HasColumnName("penalty_duration_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Place)
                    .HasColumnName("place")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Point)
                    .HasColumnName("point")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Property)
                    .HasColumnName("property")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Remark)
                    .HasColumnName("remark")
                    .HasMaxLength(220)
                    .IsUnicode(false);

                entity.Property(e => e.ResolveDetail)
                    .HasColumnName("resolve_detail")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.ResolveMethod)
                    .IsRequired()
                    .HasColumnName("resolve_method")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ResolveMethodCode)
                    .HasColumnName("resolve_method_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StartViolationDate)
                    .HasColumnName("start_violation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.Supervisor)
                    .HasColumnName("supervisor")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Unit)
                    .IsRequired()
                    .HasColumnName("unit")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleBrandCode)
                    .HasColumnName("vehicle_brand_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleColorCode)
                    .HasColumnName("vehicle_color_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleTypeCode)
                    .HasColumnName("vehicle_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationDate)
                    .HasColumnName("violation_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ViolationPlaceCode)
                    .HasColumnName("violation_place_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViolationPersonCaptor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("violation_person_captor");

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationPersonId).HasColumnName("violation_person_id");
            });

            modelBuilder.Entity<ViolationPersonGuilt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("violation_person_guilt");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationGuiltCode)
                    .HasColumnName("violation_guilt_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationPersonId).HasColumnName("violation_person_id");
            });

            modelBuilder.Entity<ViolationPersonOffender>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("violation_person_offender");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address1)
                    .HasColumnName("address1")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("address2")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Arm)
                    .HasColumnName("arm")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("birth_date")
                    .HasColumnType("date");

                entity.Property(e => e.CardExpireDate)
                    .HasColumnName("card_expire_date")
                    .HasColumnType("date");

                entity.Property(e => e.CardNumber)
                    .HasColumnName("card_number")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CardTypeCode)
                    .HasColumnName("card_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyCode)
                    .HasColumnName("company_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Ear)
                    .HasColumnName("ear")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EyeColor)
                    .HasColumnName("eye_color")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Eyebrow)
                    .HasColumnName("eyebrow")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasColumnName("father_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.FatherOccupation)
                    .HasColumnName("father_occupation")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Frequency).HasColumnName("frequency");

                entity.Property(e => e.FunctionCode)
                    .HasColumnName("function_code")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.Habit)
                    .HasColumnName("habit")
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HairColor)
                    .HasColumnName("hair_color")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Head)
                    .HasColumnName("head")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Leg)
                    .HasColumnName("leg")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LinkUrno)
                    .HasColumnName("link_urno")
                    .HasMaxLength(16)
                    .IsUnicode(false);

                entity.Property(e => e.MaritalStatusCode)
                    .HasColumnName("marital_status_code")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasColumnName("mother_name")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.MotherOccupation)
                    .HasColumnName("mother_occupation")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Mouth)
                    .HasColumnName("mouth")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Mustache)
                    .HasColumnName("mustache")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NationalityCode)
                    .HasColumnName("nationality_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nickname)
                    .HasColumnName("nickname")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nose)
                    .HasColumnName("nose")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Occupation)
                    .HasColumnName("occupation")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OccupationHistory1)
                    .HasColumnName("occupation_history1")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.OccupationHistory2)
                    .HasColumnName("occupation_history2")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PassPersonNumber)
                    .HasColumnName("pass_person_number")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.RaceCode)
                    .HasColumnName("race_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceCode)
                    .HasColumnName("reference_code")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.ReligionCode)
                    .HasColumnName("religion_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Scar)
                    .HasColumnName("scar")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Shape)
                    .HasColumnName("shape")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Skin)
                    .HasColumnName("skin")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseName)
                    .HasColumnName("spouse_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Surname)
                    .HasColumnName("surname")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(40)
                    .IsUnicode(false);

                entity.Property(e => e.Talent)
                    .HasColumnName("talent")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.TitleCode)
                    .HasColumnName("title_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ViolationPersonId).HasColumnName("violation_person_id");

                entity.Property(e => e.Walking)
                    .HasColumnName("walking")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ViolationVihicle>(entity =>
            {
                entity.ToTable("violation_vihicle");

                entity.HasIndex(e => e.Code)
                    .HasName("uq_vehvio_code")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Code)
                    .HasColumnName("code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EtlField)
                    .HasColumnName("etl_field")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlSystem)
                    .HasColumnName("etl_system")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.EtlTable)
                    .HasColumnName("etl_table")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EtlValue)
                    .HasColumnName("etl_value")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PersonCode)
                    .HasColumnName("person_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasColumnName("status")
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('ACTIVE')");

                entity.Property(e => e.SystemDate)
                    .HasColumnName("system_date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SystemStaff)
                    .HasColumnName("system_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDate)
                    .HasColumnName("update_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdateStaff)
                    .HasColumnName("update_staff")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.VehicleCode)
                    .HasColumnName("vehicle_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
