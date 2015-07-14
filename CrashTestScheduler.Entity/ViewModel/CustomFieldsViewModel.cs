using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrashTestScheduler.Entity.ViewModel
{
    public class CustomFieldsViewModel{
        public int Id { get; set; }
        public string FieldName { get; set; }
        public bool Selected { get; set; }
    }

    public class TestPlanTemplateFieldSelectorVM
    {
        public int TestPlanTemplateId { get; set; }
        public CustomFieldSelectionViewModel CustomFieldSelection { get; set; }
    }


    public class CustomFieldSelectionViewModel
    {
        private Dictionary<string, CustomFieldsViewModel> _customSelection = new Dictionary<string,CustomFieldsViewModel>();

        private void populateCustomFields(List<CustomFieldsViewModel> customFields)
        {
            customFields.ForEach(a => _customSelection.Add(a.FieldName, a));
        }

        public CustomFieldSelectionViewModel()
        {

        }

        public CustomFieldSelectionViewModel(List<CustomFieldsViewModel> customFields)
        {
            populateCustomFields(customFields);
        }

        public bool GetValueByKey(string key){
            return GetValue(key);
        }

        private bool GetValue(string fieldNameKey)
        {
            if( !_customSelection.Keys.Contains(fieldNameKey))
            {
                _customSelection.Add(fieldNameKey, new CustomFieldsViewModel { FieldName = fieldNameKey, Selected = false });
                return false;
            }
            CustomFieldsViewModel returnval;
            if( _customSelection.TryGetValue(fieldNameKey, out returnval))
            {
                return returnval.Selected;
            }
            return false;
        }

        private void SetValue(string fieldNameKey, bool selected)
        {
            if (!_customSelection.Keys.Contains(fieldNameKey))
            {
                _customSelection.Add(fieldNameKey, new CustomFieldsViewModel { FieldName = fieldNameKey, Selected = selected });
                return;
            }
            _customSelection[fieldNameKey].Selected = selected;

        }

        #region propterties
        public bool ImpactSide {
            get 
            {
                return GetValue("ImpactSide");
            }
            set {
                SetValue("ImpactSide", value);
            }
        }

        public bool ImpactLocation {
            get { return GetValue("ImpactLocation"); }
            set { SetValue("ImpactLocation", value); } 
        }
        public bool ImpactPoint {
            get { return GetValue("ImpactPoint"); }
            set { SetValue("ImpactPoint", value); } 
        }
        public bool ImpactBarrier { 
            get { return GetValue("ImpactBarrier"); } 
            set { SetValue("ImpactBarrier", value); } 
        }
        public bool ImpactSpeed { 
            get { return GetValue("ImpactSpeed"); } 
            set { SetValue("ImpactSpeed", value); } 
        }
        public bool PreferredImpactSpeed { 
            get { return GetValue("PreferredImpactSpeed"); } 
            set { SetValue("PreferredImpactSpeed", value); } 
        }
        public bool LowLimit { 
            get { return GetValue("LowLimit"); } 
            set { SetValue("LowLimit", value); } 
        }
        public bool HighLimit { 
            get { return GetValue("HighLimit"); } 
            set { SetValue("HighLimit", value); } 
        }
        public bool StickerNomenclature { 
            get { return GetValue("StickerNomenclature"); } 
            set { SetValue("StickerNomenclature", value); } 
        }
        public bool RollOver { 
            get { return GetValue("RollOver"); } 
            set { SetValue("RollOver", value); } 
        }
        public bool FuelPercent { 
            get { return GetValue("FuelPercent"); } 
            set { SetValue("FuelPercent", value); } 
        }
        public bool FuelCapacity { 
            get { return GetValue("FuelCapacity"); } 
            set { SetValue("FuelCapacity", value); } 
        }
        public bool TestFuelAmount { 
            get { return GetValue("TestFuelAmount"); } 
            set { SetValue("TestFuelAmount",value); } 
        }
        public bool FuelTankContents { 
            get { return GetValue("FuelTankContents"); } 
            set { SetValue("FuelTankContents",value); } 
        }
        public bool TestWeightMethod { 
            get { return GetValue("TestWeightMethod"); } 
            set { SetValue("TestWeightMethod",value); } 
        }
        public bool FrontCurbWt { 
            get { return GetValue("FrontCurbWt"); }
            set { SetValue("FrontCurbWt",value); } 
        }
        public bool RearCurbWt { 
            get { return GetValue("RearCurbWt"); } 
            set { SetValue("RearCurbWt",value); } 
        }
        public bool TotalCurbWt { 
            get { return GetValue("TotalCurbWt"); } 
            set { SetValue("TotalCurbWt",value); } 
        }
        public bool FrontTestWt { 
            get { return GetValue("FrontTestWt"); } 
            set { SetValue("FrontTestWt",value); } 
        }
        public bool RearTestWt { 
            get { return GetValue("RearTestWt"); } 
            set { SetValue("RearTestWt",value); } 
        }
        public bool TotalTestWt { 
            get { return GetValue("TotalTestWt"); } 
            set { SetValue("TotalTestWt",value); } 
        }
        public bool FrontTirePressure { 
            get { return GetValue("FrontTirePressure"); } 
            set { SetValue("FrontTirePressure",value); } 
        }
        public bool RearTirePressure { 
            get { return GetValue("RearTirePressure"); } 
            set { SetValue("RearTirePressure",value); } 
        }
        public bool SpareTirePressure { 
            get { return GetValue("SpareTirePressure"); } 
            set { SetValue("SpareTirePressure",value); } 
        }
        public bool SRSStatus { 
            get { return GetValue("SRSStatus"); } 
            set { SetValue("SRSStatus",value); } 
        }
        public bool AirbagFireSystem
        {
            get { return GetValue("AirbagFireSystem"); }
            set { SetValue("AirbagFireSystem", value); }
        }
        public bool PostTestLocation { 
            get { return GetValue("PostTestLocation"); } 
            set { SetValue("PostTestLocation",value); } 
        }
        public bool VehicleReqAddtlTest { 
            get { return GetValue("VehicleReqAddtlTest"); } 
            set { SetValue("VehicleReqAddtlTest",value); }
        }
        public bool ProCam { 
            get { return GetValue("ProCam"); } 
            set { SetValue("ProCam",value); } 
        }
        public bool FMVSS_212_WindshieldRetention { 
            get { return GetValue("FMVSS_212_WindshieldRetention"); } 
            set { SetValue("FMVSS_212_WindshieldRetention",value); } 
        }
        public bool FARO_ArmReqForDummy { 
            get { return GetValue("FARO_ArmReqForDummy"); } 
            set { SetValue("FARO_ArmReqForDummy",value); } 
        }
        public bool FMVSS_219_PartialWindshield { 
            get { return GetValue("FMVSS_219_PartialWindshield"); } 
            set { SetValue("FMVSS_219_PartialWindshield",value); } 
        }
        public bool FMVSS_219_FullWindshield { 
            get { return GetValue("FMVSS_219_FullWindshield"); } 
            set { SetValue("FMVSS_219_FullWindshield",value); } 
        }
        public bool Fmvss305
        {
            get { return GetValue("Fmvss305"); }
            set { SetValue("Fmvss305", value); }
        }
        public bool Paint { 
            get { return GetValue("Paint"); } 
            set { SetValue("Paint",value); } 
        }
        public bool PaintInstruction { 
            get { return GetValue("PaintInstruction"); } 
            set { SetValue("PaintInstruction",value); } 
        }
        public bool MoonRoofOpen { 
            get { return GetValue("MoonRoofOpen"); } 
            set { SetValue("MoonRoofOpen",value); } 
        }
        public bool WindowsOpen {
            get { return GetValue("WindowsOpen"); } 
            set { SetValue("WindowsOpen",value); } 
        }
        public bool FrontPit { 
            get { return GetValue("FrontPit"); } 
            set { SetValue("FrontPit",value); } 
        }
        public bool RearPit { 
            get { return GetValue("RearPit"); } 
            set { SetValue("RearPit",value); }
        }
        public bool VehicleWeightFront
        {
            get { return GetValue("VehicleWeightFront"); }
            set { SetValue("VehicleWeightFront", value); }
        }
        public bool VehicleWeightRear
        {
            get { return GetValue("VehicleWeightRear"); }
            set { SetValue("VehicleWeightRear", value); }
        }
        public bool PendulumWeight
        {
            get { return GetValue("PendulumWeight"); }
            set { SetValue("PendulumWeight", value); }
        }
        public bool Hits
        {
            get { return GetValue("Hits"); }
            set { SetValue("Hits", value); }
        }
        #endregion

    } //end public class declartion
}
