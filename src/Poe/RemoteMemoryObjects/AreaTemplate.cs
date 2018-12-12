using System.Collections.Generic;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class AreaTemplate : RemoteMemoryObject
    {
        public string RawName => M.ReadStringU(M.ReadLong(Address));
        public string Name => M.ReadStringU(M.ReadLong(Address + 8));
        public int Act => M.ReadInt(Address + 0x10);
        public bool IsTown => M.ReadByte(Address + 0x14) == 1;
        public bool HasWaypoint => M.ReadByte(Address + 0x15) == 1;
        public int MonsterLevel => M.ReadInt(Address + 0x26);
        public int WorldAreaId => M.ReadInt(Address + 0x2A);

		/// <summary>
		/// Possible amount (varieties) of CorruptedAreas
		/// </summary>
        public int CorruptedAreasVariety => M.ReadInt(Address + 0xFB);
	    public List<WorldArea> PossibleCorruptedAreas => M.ReadClassesFromPointerArray<WorldArea>(Address + 0x103, CorruptedAreasVariety);
    }

    /*
    00000000 POE_Area struc ; (sizeof=0xEB)
    00000000 zoneCode dd ?                           ; offset
    00000004 zoneName dd ?                           ; offset
    00000008 act dd ?
    0000000C hasWp db ?
    0000000D isTown db ?
    0000000E cntLinkedZones dd ?
    00000012 lpLinkedZones dd ?                      ; offset
    00000016 Level dd ?                              ; base 10
    0000001A field_1A dd ?
    0000001E field_1E db ?
    0000001F hashCode dd ?                           ; base 10
    00000023 field_23 dd ?                           ; base 10
    00000027 field_27 dd ?
    0000002B lpLoadingScreen dd ?                    ; offset
    0000002F field_2F dd ?                           ; base 10
    00000033 field_33 dd ?
    00000037 lpCntXZ dd ?                            ; offset
    0000003B field_3B dd ?
    0000003F cnt_p1 dd ?
    00000043 lpTopologies dd ?                       ; offset (00000000)
    00000047 lpTownArea dd ?                         ; offset
    0000004B lpAllDificulties dd ?                   ; offset (00000000)
    0000004F lplpDifficulty dd ?                     ; offset
    00000053 field_53 dd ?                           ; base 10
    00000057 field_57 dd ?                           ; base 10
    0000005B field_5B dd ?                           ; base 10
    0000005F field_5F dd ?                           ; base 10
    00000063 field_63 dd ?                           ; base 10
    00000067 field_67 dd ?                           ; offset (00000000)
    0000006B field_6B dd ?
    0000006F area_achievements1 dd ?                 ; offset (00000000)
    00000073 field_73 dd ?
    00000077 field_77 dd ?
    0000007B area_achievements2 dd ?                 ; offset (00000000)
    0000007F field_7F dd ?
    00000083 area_achievements3 dd ?                 ; offset (00000000)
    00000087 field_87 db ?
    00000088 field_88 dd ?
    0000008C area_achievements4 dd ?                 ; offset (00000000)
    00000090 field_90 dd ?                           ; base 10
    00000094 field_94 dd ?                           ; base 10
    00000098 field_98 dd ?
    0000009C field_9C dd ?
    000000A0 field_A0 dd ?
    000000A4 possibleVaal dd ?                       ; offset (00000000)
    000000A8 possibleVaal2 dd ?                      ; offset (00000000)
    000000AC field_AC dd ?
    000000B0 field_B0 dd ?
    000000B4 field_B4 dd ?
    000000B8 lplpSideArea dd ?                       ; offset
    000000BC field_BC dd ?                           ; base 10
    000000C0 field_C0 dd ?                           ; base 10
    000000C4 field_C4 dd ?                           ; base 10
    000000C8 field_C8 dd ?                           ; base 10
    000000CC zoneShortStruct dd ?                    ; offset
    000000D0 field_D0 db ?
    000000D1 field_D1 dd ?                           ; base 10
    000000D5 field_D5 dd ?                           ; base 10
    000000D9 field_D9 dd ?
    000000DD field_DD dd ?                           ; offset
    000000E1 field_E1 dd ?                           ; base 10
    000000E5 field_E5 dd ?                           ; base 16
    000000E9 field_E9 dw ?
    000000EB POE_Area ends
         * */
}