using PoeHUD.Framework;
using PoeHUD.Models;


namespace PoeHUD.Poe
{

    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile_x64" };
        public static Offsets Steam = new Offsets { IgsOffset = 0x28, IgsDelta = 0, ExeName = "PathOfExile_x64Steam" };

        /*
        00007FF7006C7891  | 90                                 | nop                                        |
        00007FF7006C7892  | 48 8B 1D EF 93 06 01               | mov rbx,qword ptr ds:[7FF701730C88]        |
        00007FF7006C7899  | 48 89 05 E8 93 06 01               | mov qword ptr ds:[7FF701730C88],rax        |
        00007FF7006C78A0  | 48 85 DB                           | test rbx,rbx                               |
        00007FF7006C78A3  | 74 15                              | je pathofexile_x64.7FF7006C78BA            |
        00007FF7006C78A5  | 48 8B CB                           | mov rcx,rbx                                |
        00007FF7006C78A8  | E8 53 D7 00 00                     | call pathofexile_x64.7FF7006D5000          |
        */
        //    90 48 03 D8 48 8B 03 48 85 c0 75 ?? 48 8b 1d ?? ?? ?? ?? 48 8b 05 ?? ?? ?? ?? 48 85 c0 74 ?? 66 90

        private static readonly Pattern basePtrPattern = new Pattern(new byte[]
        {
			0x90,
			0x48, 0x03, 0xD8,
			0x48, 0x8B, 0x03,
			0x48, 0x85, 0xC0,
			0x75, 0x00,
			0x48, 0x8B, 0x1D, 0x00, 0x00, 0x00, 0x00,
			0x48, 0x8B, 0x05, 0x00, 0x00, 0x00, 0x00,
			0x48, 0x85, 0xC0,
			0X74, 0x00,
			0x66, 0x90
		}, "xxxxxxxxxxx?xxx????xxx????xxxx?xx");

		/* FileRoot Pointer
		00007FF6C47EED01  | 48 8D 0D A8 23 7F 00               | lea rcx,qword ptr ds:[7FF6C4FE10B0]        | <--FileRootPtr
		00007FF6C47EED08  | E8 E3 5C 56 FF                     | call pathofexile_x64.7FF6C3D549F0          |
		00007FF6C47EED0D  | 48 8B 3D A4 23 7F 00               | mov rdi,qword ptr ds:[7FF6C4FE10B8]        |
		00007FF6C47EED14  | 48 8B 1F                           | mov rbx,qword ptr ds:[rdi]                 |
		00007FF6C47EED17  | 48 3B DF                           | cmp rbx,rdi                                |
		00007FF6C47EED1A  | 0F 84 26 01 00 00                  | je pathofexile_x64.7FF6C47EEE46            |
        */
		// 3.3.x
		//    48 8D 0D ?? ?? ?? ?? E8 ?? ?? ?? ?? 48 8B 3D ?? ?? ?? ?? 48 8B 1F

		private static readonly Pattern fileRootPattern = new Pattern(new byte[]
		{
			0x48, 0x8D, 0x0D, 0x00, 0x00, 0x00, 0x00,
			0xE8, 0x00, 0x00, 0x00, 0x00,
			0x48, 0x8B, 0x3D, 0x00, 0x00, 0x00, 0x00,
			0x48, 0x8B, 0x1F,
			0x48, 0x3B, 0xDF
		}, "xxx????x????xxx????xxxxxx");

		/* Area Change
        00007FF63317CE40 | 48 83 EC 58                    | sub rsp,58                                      |
        00007FF63317CE44 | 4C 8B C1                       | mov r8,rcx                                      |
        00007FF63317CE47 | 41 B9 01 00 00 00              | mov r9d,1                                       |
        00007FF63317CE4D | 48 8B 49 10                    | mov rcx,qword ptr ds:[rcx+10]                   |
        00007FF63317CE51 | 48 89 4C 24 30                 | mov qword ptr ss:[rsp+30],rcx                   |
        00007FF63317CE56 | 48 85 C9                       | test rcx,rcx                                    |
        00007FF63317CE59 | 74 11                          | je pathofexile_x64 - alpha 2.5.7FF63317CE6C     |
        00007FF63317CE5B | 41 8B C1                       | mov eax,r9d                                     |
        00007FF63317CE5E | F0 0F C1 41 54                 | lock xadd dword ptr ds:[rcx+54],eax             |
        00007FF63317CE63 | 8B 05 7B 09 F0 00              | mov eax,dword ptr ds:[<AreaChangeCount>]        |
        00007FF63317CE69 | 89 41 50                       | mov dword ptr ds:[rcx+50],eax                   |
        00007FF63317CE6C | 49 8B 08                       | mov rcx,qword ptr ds:[r8]                       |
        00007FF63317CE6F | 49 8B 40 18                    | mov rax,qword ptr ds:[r8+18]                    |
        */
		// 3.0.3b
		//     48 83 EC 58 4C 8B C1 41 B9 01 00 00 00 48 8B 49 10
		// 3.5.0: this pattern matched 4 results but they all are pointing towards same pointer i.e. counter.

		private static readonly Pattern areaChangePattern = new Pattern(new byte[]
		{
			0x41, 0x8B, 0xC2, 0xF0, 0x41, 0x0F, 0xC1, 0x40, 0x54, 0x8B, 0x05
		}, "xxxxxxxxxxx");

		private static readonly Pattern GameStatePattern = new Pattern(new byte[]
{
			0x48, 0x39, 0x2D, 0x3F, 0xA2, 0x52, 0x01,
			0x0F, 0x85, 0x02, 0x01, 0x00, 0x00,
			0xB9, 0x80, 0x00, 0x00, 0x00,
			0xE8
		}, "xxx????xxxxxxxxxxxx");

        /*
        PathOfExile_x64.exe+118FD9 - 4C 8B 35 48255B01     - mov r14,[PathOfExile_x64.exe+16CB528] { [C6151734A0] }<<here
        PathOfExile_x64.exe+118FE0 - 4D 85 F6              - test r14,r14
        PathOfExile_x64.exe+118FE3 - 0F94 C0               - sete al
        PathOfExile_x64.exe+118FE6 - 84 C0                 - test al,al
        */

        public long AreaChangeCount { get; private set; }
        public long Base { get; private set; }
        public string ExeName { get; private set; }
        public long FileRoot { get; private set; }
        public int IgsDelta { get; private set; }
        public int IgsOffset { get; private set; }
        public int IgsOffsetDelta => IgsOffset + IgsDelta;
        public long GameStateOffset { get; private set; }

        public void DoPatternScans(Memory m)
        {
            long[] array = m.FindPatterns(fileRootPattern, areaChangePattern, GameStatePattern);

            FileRoot = m.ReadInt(m.AddressOfProcess + array[0] + 0x3) + array[0] + 0x7;
            System.Console.WriteLine("FileRoot Pointer: " + (FileRoot + m.AddressOfProcess).ToString("x8"));

			AreaChangeCount = m.ReadInt(m.AddressOfProcess + array[1] + 0xB) + array[1] + 0xF;
			System.Console.WriteLine("AreaChangeCount: " + m.ReadInt(AreaChangeCount + m.AddressOfProcess).ToString());

            GameStateOffset = m.ReadInt(m.AddressOfProcess + array[2] + 0x03) + array[2] + 0x07;
            System.Console.WriteLine("Game State Offset:" + (GameStateOffset + m.AddressOfProcess).ToString("x8"));
        }
    }
}
