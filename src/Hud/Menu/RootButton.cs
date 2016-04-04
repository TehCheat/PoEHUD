using PoeHUD.Framework.Helpers;
using PoeHUD.Hud.UI;
using SharpDX;
using SharpDX.Direct3D9;
using System.Linq;

namespace PoeHUD.Hud.Menu
{
    public sealed class RootButton : MenuItem
    {
        private MenuItem currentHover;
        private bool visible;

        public RootButton(Vector2 position)
        {
            Bounds = new RectangleF(position.X - 5, position.Y - 20, DesiredWidth, DesiredHeight);
        }

        public override int DesiredWidth => 80;
        public override int DesiredHeight => 25;

        public override void AddChild(MenuItem item)
        {
            base.AddChild(item);
            float x = item.Bounds.X - DesiredWidth;
            float y = item.Bounds.Y + DesiredHeight;
            item.Bounds = new RectangleF(x, y, item.Bounds.Width, item.Bounds.Height);
        }

        public bool OnMouseEvent(MouseEventID id, Vector2 pos)
        {
            if (currentHover != null && currentHover.TestHit(pos))
            {
                currentHover.OnEvent(id, pos);
                return id != MouseEventID.MouseMove;
            }

            if (id == MouseEventID.MouseMove)
            {
                MenuItem button = Children.FirstOrDefault(b => b.TestHit(pos));
                if (button != null)
                {
                    currentHover?.SetHovered(false);
                    currentHover = button;
                    button.SetHovered(true);
                }
                return false;
            }

            if (Bounds.Contains(pos) && id == MouseEventID.LeftButtonDown)
            {
                visible = !visible;
                currentHover = null;
                Children.ForEach(button => button.SetVisible(visible));
                return true;
            }

            return false;
        }

        public override void Render(Graphics graphics, MenuSettings settings)
        {
            graphics.DrawText(settings.TitleName, settings.TitleFontSize, Bounds.TopLeft.Translate(25, 12), settings.TitleFontColor, FontDrawFlags.VerticalCenter | FontDrawFlags.Center);
            graphics.DrawImage("menu-background.png", Bounds, settings.BackgroundColor);
            Children.ForEach(x => x.Render(graphics, settings));
        }

        protected override void HandleEvent(MouseEventID id, Vector2 pos)
        {
        }
    }
}