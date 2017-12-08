using PoeHUD.Poe;
using PoeHUD.Poe.Components;

namespace PoeHUD.Models.CacheComponent
{
    public class PlayerCache
    {
        public Entity Player { get; private set; }
        private  Positioned _positioned;
        private  Actor _actor;


        public Positioned Positioned => _positioned ?? (_positioned = Player.GetComponent<Positioned>());
        public Actor Actor => _actor ?? (_actor = Player.GetComponent<Actor>());

        public PlayerCache(Entity Player)
        {
            this.Player = Player;
        }

        public void UpdateCache(Entity player)
        {
            Player = player;
            _positioned = Player.GetComponent<Positioned>();
            _actor = Player.GetComponent<Actor>();
        }
    }
}