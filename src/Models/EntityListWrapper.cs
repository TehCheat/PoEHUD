using PoeHUD.Controllers;
using PoeHUD.Poe;
using PoeHUD.Poe.Elements;
using System;
using System.Collections.Generic;

namespace PoeHUD.Models
{
    public sealed class EntityListWrapper
    {
        private readonly GameController gameController;
        private readonly HashSet<string> ignoredEntities;
        private Dictionary<uint, EntityWrapper> entityCache;

        public EntityListWrapper(GameController gameController)
        {
            this.gameController = gameController;
            entityCache = new Dictionary<uint, EntityWrapper>();
            ignoredEntities = new HashSet<string>();
            gameController.Area.OnAreaChange += OnAreaChanged;
        }

        public ICollection<EntityWrapper> Entities => entityCache.Values;

        private EntityWrapper player;
        public Dictionary<Enums.GameStat, int> PlayerStats { get; private set; } = new Dictionary<Enums.GameStat, int>();
        public EntityWrapper Player
        {
            get
            {
                if (player == null)
                    UpdatePlayer();
                return player;
            }
        }

        public event Action<EntityWrapper> EntityAdded;
        public event Action<EntityWrapper> EntityAddedAny = delegate { };

        public event Action<EntityWrapper> EntityRemoved;

        private void OnAreaChanged(AreaController area)
        {
            ignoredEntities.Clear();
            PlayerStats.Clear();
            RemoveOldEntitiesFromCache();
        }

        private void RemoveOldEntitiesFromCache()
        {
            foreach (var current in Entities)
            {
                EntityRemoved?.Invoke(current);
                current.IsInList = false;
            }
            entityCache.Clear();
        }

        public void RefreshState()
        {
            UpdatePlayer();
            if(player.IsAlive && player.IsValid && player.HasComponent<Poe.Components.Stats>())
                UpdatePlayerStats();

            if (gameController.Area.CurrentArea == null)
                return;

            Dictionary<uint, Entity> newEntities = gameController.Game.IngameState.Data.EntityList.EntitiesAsDictionary;
            var newCache = new Dictionary<uint, EntityWrapper>();
            foreach (var keyEntity in newEntities)
            {
                if (!keyEntity.Value.IsValid)
                    continue;

                var entityID = keyEntity.Key;
                string uniqueEntityName = keyEntity.Value.Path + entityID;

                if (ignoredEntities.Contains(uniqueEntityName))
                    continue;

                if (entityCache.ContainsKey(entityID) && entityCache[entityID].IsValid)
                {
                    newCache.Add(entityID, entityCache[entityID]);
                    entityCache[entityID].IsInList = true;
                    entityCache.Remove(entityID);
                    continue;
                }

                var entity = new EntityWrapper(gameController, keyEntity.Value);

                EntityAddedAny(entity);
                if (entity.Path.StartsWith("Metadata/Effects") || ((entityID & 0x80000000L) != 0L) ||
                    entity.Path.StartsWith("Metadata/Monsters/Daemon"))
                {
                    ignoredEntities.Add(uniqueEntityName);
                    continue;
                }

                EntityAdded?.Invoke(entity);
                newCache.Add(entityID, entity);
            }
            RemoveOldEntitiesFromCache();
            entityCache = newCache;
        }

        private void UpdatePlayer()
        {
            long address = gameController.Game.IngameState.Data.LocalPlayer.Address;
            if ((player == null) || (player.Address != address))
            {
                player = new EntityWrapper(gameController, address);
            }
        }
        private void UpdatePlayerStats()
        {
            var stats = player.GetComponent<Poe.Components.Stats>();
            PlayerStats = stats.StatDictionary;
        }
        public EntityWrapper GetEntityById(uint id)
        {
            EntityWrapper result;
            return entityCache.TryGetValue(id, out result) ? result : null;
        }

        public EntityLabel GetLabelForEntity(Entity entity)
        {
            var hashSet = new HashSet<long>();
            long entityLabelMap = gameController.Game.IngameState.EntityLabelMap;
            long num = entityLabelMap;
            
            while (true)
            {
                hashSet.Add(num);
                if (gameController.Memory.ReadLong(num + 0x10) == entity.Address)
                {
                    break;
                }
                num = gameController.Memory.ReadLong(num);
                if (hashSet.Contains(num) || num == 0 || num == -1)
                {
                    return null;
                }
            }
            return gameController.Game.ReadObject<EntityLabel>(num + 0x18);
        }
    }
}