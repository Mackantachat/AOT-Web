﻿using System;
using System.Collections.Generic;

namespace aot_e_security.Models.DB
{
    public partial class OperationAnalyze
    {
        public long Id { get; set; }
        public DateTime SystemDate { get; set; }
        public string SystemStaff { get; set; }
        public DateTime? UpdateDate { get; set; }
        public string UpdateStaff { get; set; }
        public string EtlSystem { get; set; }
        public string EtlTable { get; set; }
        public string EtlField { get; set; }
        public string EtlValue { get; set; }
        public long OperationId { get; set; }
        public string ReporterMale { get; set; }
        public string ReporterFemale { get; set; }
        public string ReporterAdult { get; set; }
        public string ReporterChild { get; set; }
        public string ReporterThai { get; set; }
        public string ReporterForeigner { get; set; }
        public string ReporterOther { get; set; }
        public string LanguageThai { get; set; }
        public string LanguageLocal { get; set; }
        public string LanguageEnglish { get; set; }
        public string LanguageEducated { get; set; }
        public string LanguageUneducated { get; set; }
        public string LangaugeGoodAccent { get; set; }
        public string LangaugeBadAccent { get; set; }
        public string LangaugeNoReason { get; set; }
        public string LanguageUnclearVoice { get; set; }
        public string LanguageReading { get; set; }
        public string LanguageRecording { get; set; }
        public string LanguageOther { get; set; }
        public string VoiceNormal { get; set; }
        public string VoiceLoud { get; set; }
        public string VoiceQuiet { get; set; }
        public string VoiceWhisper { get; set; }
        public string VoiceSlow { get; set; }
        public string VoiceSpeed { get; set; }
        public string VoiceHighKey { get; set; }
        public string VoiceLowKey { get; set; }
        public string VoiceBass { get; set; }
        public string VoiceHoarse { get; set; }
        public string VoiceClear { get; set; }
        public string VoiceProlong { get; set; }
        public string VoiceNasal { get; set; }
        public string VoiceStutter { get; set; }
        public string VoiceUnclear { get; set; }
        public string VoiceRattle { get; set; }
        public string VoiceShout { get; set; }
        public string VoiceCoerce { get; set; }
        public string VoiceBending { get; set; }
        public string VoiceFamiliar { get; set; }
        public string VoiceCough { get; set; }
        public string VoiceHeavilyBreathe { get; set; }
        public string VoiceCaseFamiliar { get; set; }
        public string VoiceFamiliarPerson { get; set; }
        public string SpeechCalm { get; set; }
        public string SpeechExcited { get; set; }
        public string SpeechAngry { get; set; }
        public string SpeechHappy { get; set; }
        public string SpeechLaugh { get; set; }
        public string SpeechCry { get; set; }
        public string SpeechSerious { get; set; }
        public string SpeechNoReason { get; set; }
        public string SpeechIntend { get; set; }
        public string SpeechReason { get; set; }
        public string SpeechEmotion { get; set; }
        public string SpeechDrunk { get; set; }
        public string BackgroundNone { get; set; }
        public string BackgroundPeople { get; set; }
        public string BackgroundMusic { get; set; }
        public string BackgroundTraffic { get; set; }
        public string BackgroundAircraft { get; set; }
        public string BackgroundShip { get; set; }
        public string BackgroundTrain { get; set; }
        public string BackgroundAnimal { get; set; }
        public string BackgroundKitchen { get; set; }
        public string BackgroundOffice { get; set; }
        public string BackgroundFactory { get; set; }
        public string BackgroundHouse { get; set; }
        public string BackgroundParty { get; set; }
        public string BackgroundChild { get; set; }
        public string BackgroundOther { get; set; }
        public string PhoneUrban { get; set; }
        public string PhoneFar { get; set; }
        public string PhoneBox { get; set; }
        public string PhonePublic { get; set; }
        public string PhoneInternal { get; set; }
        public string PhoneGlobal { get; set; }
        public string PhoneNumber { get; set; }
        public string OtherFamiliar { get; set; }
        public string Description { get; set; }
        public string Remark { get; set; }
        public string LinkUrno { get; set; }
    }
}
