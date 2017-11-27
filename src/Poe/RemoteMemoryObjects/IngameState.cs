using PoeHUD.Models.Enums;
using System;
using PoeHUD.Controllers;
using PoeHUD.Models;

namespace PoeHUD.Poe.RemoteMemoryObjects
{
    public class IngameState : RemoteMemoryObject
    {
        public Camera Camera => GameController.Instance.Cache.Enable ? GameController.Instance.Cache.Camera : CameraReal;

        public Camera CameraReal => GetObject<Camera>(Address + 0x1704 + Offsets.IgsOffsetDelta);

        public IngameData Data => GameController.Instance.Cache.Enable ? GameController.Instance.Cache.Data : DataReal;
        public IngameData DataReal => ReadObject<IngameData>(Address + 0x170 + Offsets.IgsOffset);

        public bool InGame => ServerDataReal.IsInGame;
        public ServerData ServerData => GameController.Instance.Cache.Enable ? GameController.Instance.Cache.ServerData : ServerDataReal;

        public ServerData ServerDataReal => ReadObjectAt<ServerData>(0x178 + Offsets.IgsOffset);
        public IngameUIElements IngameUi => GameController.Instance.Cache.Enable ? GameController.Instance.Cache.IngameUi : IngameUiReal;

        public IngameUIElements IngameUiReal => ReadObjectAt<IngameUIElements>(0x5D0 + Offsets.IgsOffset);
        public Element UIRoot => GameController.Instance.Cache.Enable ? GameController.Instance.Cache.UIRoot : UIRootReal;

        public Element UIRootReal => ReadObjectAt<Element>(0xC80 + Offsets.IgsOffset);
        public Element UIHover => ReadObjectAt<Element>(0xCA8 + Offsets.IgsOffset);

        public float CurentUIElementPosX => M.ReadFloat(Address + 0xCB0 + Offsets.IgsOffset);
        public float CurentUIElementPosY => M.ReadFloat(Address + 0xCB4 + Offsets.IgsOffset);

        public long EntityLabelMap => M.ReadLong(Address + 0x98, 0xA70);
        public DiagnosticInfoType DiagnosticInfoType => (DiagnosticInfoType)M.ReadInt(Address + 0xD38 + Offsets.IgsOffset);
        public DiagnosticElement LatencyRectangle => GameController.Instance.Cache.Enable ? GameController.Instance.Cache.LatencyRectangle : LatencyRectangleReal;

        public DiagnosticElement LatencyRectangleReal => GetObjectAt<DiagnosticElement>(0xF68 + Offsets.IgsOffset);
        public DiagnosticElement FrameTimeRectangle => GetObjectAt<DiagnosticElement>(0x13F8 + Offsets.IgsOffset);
        public DiagnosticElement FPSRectangle => GameController.Instance.Cache.Enable ? GameController.Instance.Cache.FPSRectangle : FPSRectangleReal;

        public DiagnosticElement FPSRectangleReal => GetObjectAt<DiagnosticElement>(0x1640 + Offsets.IgsOffset);
        public float CurLatency => LatencyRectangle.CurrValue;
        public float CurFrameTime => FrameTimeRectangle.CurrValue;
        public float CurFps => FPSRectangle.CurrValue;
        public TimeSpan TimeInGame => TimeSpan.FromSeconds(M.ReadFloat(Address + 0xD1C + Offsets.IgsOffset));
        public float TimeInGameF => M.ReadFloat(Address + 0xD20 + Offsets.IgsOffset);
    }
}