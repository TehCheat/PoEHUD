using PoeHUD.Framework;
using PoeHUD.Models;


namespace PoeHUD.Poe
{

    public class Offsets
    {
        public static Offsets Regular = new Offsets { IgsOffset = 0, IgsDelta = 0, ExeName = "PathOfExile_x64" };
        public static Offsets Steam = new Offsets { IgsOffset = 0x28, IgsDelta = 0, ExeName = "PathOfExile_x64Steam" };

        /*
        00007FF7C584CDB0 | 40 53                                    | push rbx                                   |
        00007FF7C584CDB2 | 48 83 EC 30                              | sub rsp,30                                 |
        00007FF7C584CDB6 | 48 C7 44 24 20 FE FF FF FF               | mov qword ptr ss:[rsp+20],FFFFFFFFFFFFFFFE |
        00007FF7C584CDBF | 48 8B 05 12 5D 02 01                     | mov rax,qword ptr ds:[7FF7C6872AD8]        |
        00007FF7C584CDC6 | 48 85 C0                                 | test rax,rax                               |
        */

        //    40 53 48 83 EC ?? 48 C7 44 24 20 FE FF FF FF 48 8B 05 ?? ?? ?? ?? 48 85 C0

        private static readonly Pattern basePtrPattern = new Pattern(new byte[]
        {
            0x40, 0x53,
            0x48, 0x83, 0xEC, 0x00,
            0x48, 0xC7, 0x44, 0x24, 0x20, 0xFE, 0xFF, 0xFF, 0xFF,
            0x48, 0x8B, 0x05, 0x00, 0x00, 0x00, 0x00,
            0x48, 0x85, 0xC0
        }, "xxxxx?xxxxxxxxxxxx????xxx");

        /* FileRoot Pointer
            PathOfExile_x64.exe+3B3180 - 48 8B C4              - mov rax,rsp
            PathOfExile_x64.exe+3B3183 - 48 89 48 08           - mov [rax+08],rcx
            PathOfExile_x64.exe+3B3187 - 55                    - push rbp
            PathOfExile_x64.exe+3B3188 - 41 56                 - push r14
            PathOfExile_x64.exe+3B318A - 41 57                 - push r15
            PathOfExile_x64.exe+3B318C - 48 8D A8 48FFFFFF     - lea rbp,[rax-000000B8]
            PathOfExile_x64.exe+3B3193 - 48 81 EC A0010000     - sub rsp,000001A0 { 416 }
            PathOfExile_x64.exe+3B319A - 48 C7 44 24 40 FEFFFFFF - mov [rsp+40],FFFFFFFE { -2 }
            PathOfExile_x64.exe+3B31A3 - 48 89 58 10           - mov [rax+10],rbx
            PathOfExile_x64.exe+3B31A7 - 48 89 70 18           - mov [rax+18],rsi
            PathOfExile_x64.exe+3B31AB - 48 89 78 20           - mov [rax+20],rdi
            PathOfExile_x64.exe+3B31AF - 33 D2                 - xor edx,edx
            PathOfExile_x64.exe+3B31B1 - 48 8D 0D C864DE00     - lea rcx,[PathOfExile_x64.exe+1199680] { [1.00] }
            PathOfExile_x64.exe+3B31B8 - E8 63060000           - call PathOfExile_x64.exe+3B3820
            PathOfExile_x64.exe+3B31BD - 90                    - nop
            PathOfExile_x64.exe+3B31BE - 48 8B 35 C364DE00     - mov rsi,[PathOfExile_x64.exe+1199688] { [241FA6992E0] }
            PathOfExile_x64.exe+3B31C5 - 48 8B 1E              - mov rbx,[rsi]
            PathOfExile_x64.exe+3B31C8 - 45 33 F6              - xor r14d,r14d
            PathOfExile_x64.exe+3B31CB - 4C 8D 3D 3EF08A00     - lea r15,[PathOfExile_x64.exe+C62210] { [7FF62940A460] }
            PathOfExile_x64.exe+3B31D2 - 48 89 9D C0000000     - mov [rbp+000000C0],rbx
            PathOfExile_x64.exe+3B31D9 - 48 3B DE              - cmp rbx,rsi
        */

        private static readonly Pattern fileRootPattern = new Pattern(new byte[]
        {
            0x48, 0x8D, 0x0D, 0x00, 0x00, 0x00, 0x00,
            0xE8, 0x00, 0x00, 0x00, 0x00,
            0x90,
            0x48, 0x8B, 0x35, 0x00, 0x00, 0x00, 0x00,
            0x48, 0x8B, 0x1E
        }, "xxx????x????xxxx????xxx");

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

        private static readonly Pattern areaChangePattern = new Pattern(new byte[]
        {
             0x48, 0x83, 0xEC, 0x58,
             0x4C, 0x8B, 0xC1,
             0x41, 0xB9, 0x01, 0x00, 0x00, 0x00,
             0x48, 0x8B, 0x49, 0x10
        }, "xxxxxxxxxxxxxxxxx");

        /*
        PathOfExile_x64.exe+853E28 - 48 89 05 E9ABC400     - mov [PathOfExile_x64.exe+149EA18],rax { [00000000] }
        PathOfExile_x64.exe+853E2F - 48 8B 44 24 40        - mov rax,[rsp+40]
        PathOfExile_x64.exe+853E34 - 48 89 06              - mov [rsi],rax
        PathOfExile_x64.exe+853E37 - 48 8B C6              - mov rax,rsi
        PathOfExile_x64.exe+853E3A - 48 83 C4 20           - add rsp,20 { 32 }
        PathOfExile_x64.exe+853E3E - 5E                    - pop rsi
        PathOfExile_x64.exe+853E3F - C3                    - ret 
        */

        private static readonly Pattern isLoadingScreenPattern = new Pattern(new byte[]
        {
            0x48, 0x89, 0x05, 0x00, 0x00, 0x00, 0x00,
            0x48, 0x8B, 0x00, 0x00, 0x00,
            0x48, 0x89, 0x00,
            0x48, 0x8B, 0xC6
        }, "xxx????xx???xx?xxx");

        public long AreaChangeCount { get; private set; }
        public long Base { get; private set; }
        public string ExeName { get; private set; }
        public long FileRoot { get; private set; }
        public int IgsDelta { get; private set; }
        public int IgsOffset { get; private set; }
        public int IgsOffsetDelta => IgsOffset + IgsDelta;
        public long isLoadingScreenOffset { get; private set; }

        public void DoPatternScans(Memory m)
        {
            long[] array = m.FindPatterns(basePtrPattern, fileRootPattern, areaChangePattern, isLoadingScreenPattern);
            Base = m.ReadInt(m.AddressOfProcess + array[0] + 0x12) + array[0] + 0x16;
            System.Console.WriteLine("Base Address: " + (Base + m.AddressOfProcess).ToString("x8"));

            FileRoot = m.ReadInt(m.AddressOfProcess + array[1] + 0x3) + array[1] + 0x7;
            System.Console.WriteLine("FileRoot Pointer: " + (FileRoot + m.AddressOfProcess).ToString("x8"));

            AreaChangeCount = m.ReadInt(m.AddressOfProcess + array[2] + 0x25) + array[2] + 0x29;
            System.Console.WriteLine("AreaChangeCount Pointer: " + (AreaChangeCount + m.AddressOfProcess).ToString("x8"));

            isLoadingScreenOffset = m.ReadInt(m.AddressOfProcess + array[3] + 0x03) + array[3] + 0x07;
            System.Console.WriteLine("Is Loading Screen Offset:" + (isLoadingScreenOffset + m.AddressOfProcess).ToString("x8"));
        }
    }
}
