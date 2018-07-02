﻿using M3D.Spooling.Core;

namespace M3D.Spooling.Printer_Profiles
{
  internal class MicroEEPROMConstants : EEPROMProfile
  {
    public MicroEEPROMConstants()
      : base("Micro", 98, (ushort) 767, (ushort) 512, 1)
    {
      AddEepromAddressInfo(new EepromAddressInfo("FirmwareVersion", (ushort) 0, 4, typeof (uint)));
      AddEepromAddressInfo(new EepromAddressInfo("FirmwareCRC", (ushort) 4, 4, typeof (uint)));
      AddEepromAddressInfo(new EepromAddressInfo("LastRecordedZValue", (ushort) 8, 4, typeof (int)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashX", (ushort) 12, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashY", (ushort) 16, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BedCompensationBackRight", (ushort) 20, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BedCompensationBackLeft", (ushort) 24, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BedCompensationFrontLeft", (ushort) 28, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BedCompensationFrontRight", (ushort) 32, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("FilamentColorID", (ushort) 36, 4, typeof (uint)));
      AddEepromAddressInfo(new EepromAddressInfo("FilamentTypeID", (ushort) 40, 1, typeof (byte)));
      AddEepromAddressInfo(new EepromAddressInfo("FilamentTemperature", (ushort) 41, 1, typeof (byte)));
      AddEepromAddressInfo(new EepromAddressInfo("FilamentAmount", (ushort) 42, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashExpansionXPlus", (ushort) 46, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashExpansionYLPlus", (ushort) 50, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashExpansionYRPlus", (ushort) 54, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashExpansionYRMinus", (ushort) 58, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashExpansionZ", (ushort) 62, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashExpansionE", (ushort) 66, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("ZCalibrationBLO", (ushort) 70, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("ZCalibrationBRO", (ushort) 74, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("ZCalibrationFRO", (ushort) 78, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("ZCalibrationFLO", (ushort) 82, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("ZCalibrationZO", (ushort) 86, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("ReservedForSpooler", (ushort) 90, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BacklashSpeed", (ushort) 94, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("BedCompensationVersion", (ushort) 98, 1, typeof (byte)));
      AddEepromAddressInfo(new EepromAddressInfo("SpeedLimitX", (ushort) 102, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("SpeedLimitY", (ushort) 106, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("SpeedLimitZ", (ushort) 110, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("SpeedLimitEp", (ushort) 114, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("SpeedLimitEn", (ushort) 118, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("FilamentSize", (ushort) 130, 1, typeof (byte)));
      AddEepromAddressInfo(new EepromAddressInfo("FilamentUID", (ushort) 131, 4, typeof (uint)));
      AddEepromAddressInfo(new EepromAddressInfo("G32FirstSample", (ushort) 262, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("FANTYPE", (ushort) 683, 1, typeof (byte)));
      AddEepromAddressInfo(new EepromAddressInfo("FANOFFSET", (ushort) 684, 1, typeof (byte)));
      AddEepromAddressInfo(new EepromAddressInfo("FANSCALE", (ushort) 685, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("HeaterCalibrationMode", (ushort) 689, 1, typeof (byte)));
      AddEepromAddressInfo(new EepromAddressInfo("XMotorCurrent", (ushort) 690, 2, typeof (ushort)));
      AddEepromAddressInfo(new EepromAddressInfo("YMotorCurrent", (ushort) 692, 2, typeof (ushort)));
      AddEepromAddressInfo(new EepromAddressInfo("ZMotorCurrent", (ushort) 694, 2, typeof (ushort)));
      AddEepromAddressInfo(new EepromAddressInfo("HardwareStatus", (ushort) 696, 2, typeof (ushort)));
      AddEepromAddressInfo(new EepromAddressInfo("HeaterTempMeasure_B", (ushort) 698, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("HoursCounterSpooler", (ushort) 704, 4, typeof (uint)));
      AddEepromAddressInfo(new EepromAddressInfo("XAxisStepsPerMM", (ushort) 726, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("YAxisStepsPerMM", (ushort) 730, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("ZAxisStepsPerMM", (ushort) 734, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("EAxisStepsPerMM", (ushort) 738, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("SavedZState", (ushort) 742, 2, typeof (ushort)));
      AddEepromAddressInfo(new EepromAddressInfo("ExtruderCurrent", (ushort) 744, 2, typeof (ushort)));
      AddEepromAddressInfo(new EepromAddressInfo("HeaterResistance_M", (ushort) 746, 4, typeof (float)));
      AddEepromAddressInfo(new EepromAddressInfo("SerialNumber", (ushort) 751, 4, typeof (uint)));
    }
  }
}
