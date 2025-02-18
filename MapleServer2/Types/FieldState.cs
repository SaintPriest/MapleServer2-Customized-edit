﻿using System.Collections.Concurrent;

namespace MapleServer2.Types
{
    // All operations on this class should be thread safe
    public class FieldState
    {
        public readonly ConcurrentDictionary<int, IFieldObject<Item>> Items;
        public readonly ConcurrentDictionary<int, IFieldObject<Player>> Players;
        public readonly ConcurrentDictionary<int, IFieldObject<Npc>> Npcs;
        public readonly ConcurrentDictionary<int, IFieldObject<Portal>> Portals;
        public readonly ConcurrentDictionary<int, IFieldObject<MobSpawn>> MobSpawns;
        public readonly ConcurrentDictionary<int, IFieldObject<Mob>> Mobs;
        public readonly ConcurrentDictionary<string, IFieldObject<InteractObject>> InteractObjects;
        public readonly ConcurrentDictionary<int, IFieldObject<GuideObject>> Guide;
        public readonly ConcurrentDictionary<int, IFieldObject<Cube>> Cubes;
        public readonly ConcurrentDictionary<int, IFieldObject<HealingSpot>> HealingSpots;
        public readonly ConcurrentDictionary<int, IFieldObject<Instrument>> Instruments;
        public readonly ConcurrentDictionary<int, TriggerMesh> TriggerMeshes;
        public readonly ConcurrentDictionary<int, TriggerEffect> TriggerEffects;
        public readonly ConcurrentDictionary<int, TriggerCamera> TriggerCameras;
        public readonly ConcurrentDictionary<int, TriggerActor> TriggerActors;
        public readonly ConcurrentDictionary<int, TriggerCube> TriggerCubes;
        public readonly ConcurrentDictionary<int, TriggerLadder> TriggerLadders;
        public readonly ConcurrentDictionary<int, TriggerRope> TriggerRopes;
        public readonly ConcurrentDictionary<int, TriggerSound> TriggerSounds;
        public readonly ConcurrentDictionary<string, BreakableActorObject> BreakableActors;
        public readonly ConcurrentDictionary<string, BreakableNifObject> BreakableNifs;

        public FieldState()
        {
            Items = new ConcurrentDictionary<int, IFieldObject<Item>>();
            Players = new ConcurrentDictionary<int, IFieldObject<Player>>();
            Npcs = new ConcurrentDictionary<int, IFieldObject<Npc>>();
            Portals = new ConcurrentDictionary<int, IFieldObject<Portal>>();
            MobSpawns = new ConcurrentDictionary<int, IFieldObject<MobSpawn>>();
            Mobs = new ConcurrentDictionary<int, IFieldObject<Mob>>();
            InteractObjects = new ConcurrentDictionary<string, IFieldObject<InteractObject>>();
            Guide = new ConcurrentDictionary<int, IFieldObject<GuideObject>>();
            Cubes = new ConcurrentDictionary<int, IFieldObject<Cube>>();
            HealingSpots = new ConcurrentDictionary<int, IFieldObject<HealingSpot>>();
            Instruments = new ConcurrentDictionary<int, IFieldObject<Instrument>>();
            TriggerMeshes = new ConcurrentDictionary<int, TriggerMesh>();
            TriggerEffects = new ConcurrentDictionary<int, TriggerEffect>();
            TriggerCameras = new ConcurrentDictionary<int, TriggerCamera>();
            TriggerActors = new ConcurrentDictionary<int, TriggerActor>();
            TriggerCubes = new ConcurrentDictionary<int, TriggerCube>();
            TriggerLadders = new ConcurrentDictionary<int, TriggerLadder>();
            TriggerRopes = new ConcurrentDictionary<int, TriggerRope>();
            TriggerSounds = new ConcurrentDictionary<int, TriggerSound>();
            BreakableActors = new ConcurrentDictionary<string, BreakableActorObject>();
            BreakableNifs = new ConcurrentDictionary<string, BreakableNifObject>();
        }

        public bool TryGetItem(int objectId, out IFieldObject<Item> item)
        {
            return Items.TryGetValue(objectId, out item);
        }

        public void AddItem(IFieldObject<Item> item)
        {
            Items[item.ObjectId] = item;
        }

        public bool RemoveItem(int objectId, out Item item)
        {
            bool result = Items.Remove(objectId, out IFieldObject<Item> fieldItem);
            item = fieldItem?.Value;

            return result;
        }

        public void AddPlayer(IFieldObject<Player> player)
        {
            Players[player.ObjectId] = player;
        }

        public bool RemovePlayer(int objectId)
        {
            return Players.Remove(objectId, out _);
        }

        public void AddNpc(IFieldObject<Npc> npc)
        {
            Npcs[npc.ObjectId] = npc;
        }

        public bool RemoveNpc(int objectId)
        {
            return Npcs.Remove(objectId, out _);
        }

        public void AddPortal(IFieldObject<Portal> portal)
        {
            Portals[portal.ObjectId] = portal;
        }

        public bool RemovePortal(int objectId)
        {
            return Portals.Remove(objectId, out _);
        }

        public void AddInteractObject(IFieldObject<InteractObject> interactObject)
        {
            InteractObjects[interactObject.Value.Uuid] = interactObject;
        }

        public void AddBalloon(IFieldObject<InteractObject> balloon)
        {
            InteractObjects[balloon.Value.Name] = balloon;
        }

        public bool RemoveBalloon(string name)
        {
            return InteractObjects.Remove(name, out _);
        }

        public void AddGuide(IFieldObject<GuideObject> guide)
        {
            Guide[guide.ObjectId] = guide;
        }

        public bool RemoveGuide(int objectId)
        {
            return Guide.Remove(objectId, out _);
        }

        public void AddCube(IFieldObject<Cube> ugcCube)
        {
            Cubes[ugcCube.ObjectId] = ugcCube;
        }

        public bool RemoveCube(int objectId)
        {
            return Cubes.Remove(objectId, out _);
        }

        public void AddInstrument(IFieldObject<Instrument> instrument)
        {
            Instruments[instrument.ObjectId] = instrument;
        }

        public bool RemoveInstrument(int objectId)
        {
            return Instruments.Remove(objectId, out _);
        }

        public void AddMobSpawn(IFieldObject<MobSpawn> spawn)
        {
            MobSpawns[spawn.ObjectId] = spawn;
        }

        public bool RemoveMobSpawn(int objectId)
        {
            return MobSpawns.Remove(objectId, out _);
        }

        public void AddMob(IFieldObject<Mob> mob)
        {
            Mobs[mob.ObjectId] = mob;
        }

        public bool RemoveMob(int objectId)
        {
            return Mobs.Remove(objectId, out _);
        }

        public void AddHealingSpot(IFieldObject<HealingSpot> healingSpot)
        {
            HealingSpots[healingSpot.ObjectId] = healingSpot;
        }

        public void AddTriggerObject(TriggerObject triggerObject)
        {
            switch (triggerObject)
            {
                case TriggerMesh triggerMesh:
                    TriggerMeshes[triggerMesh.Id] = triggerMesh;
                    break;
                case TriggerEffect triggerEffect:
                    TriggerEffects[triggerEffect.Id] = triggerEffect;
                    break;
                case TriggerCamera triggerCamera:
                    TriggerCameras[triggerCamera.Id] = triggerCamera;
                    break;
                case TriggerActor triggerActor:
                    TriggerActors[triggerActor.Id] = triggerActor;
                    break;
                case TriggerCube triggerCube:
                    TriggerCubes[triggerCube.Id] = triggerCube;
                    break;
                case TriggerLadder triggerLadder:
                    TriggerLadders[triggerLadder.Id] = triggerLadder;
                    break;
                case TriggerRope triggerRope:
                    TriggerRopes[triggerRope.Id] = triggerRope;
                    break;
                case TriggerSound triggerSound:
                    TriggerSounds[triggerSound.Id] = triggerSound;
                    break;
            }
        }

        public void AddBreakable(BreakableObject breakable)
        {
            switch (breakable)
            {
                case BreakableActorObject actor:
                    BreakableActors[actor.Id] = actor;
                    break;
                case BreakableNifObject nif:
                    BreakableNifs[nif.Id] = nif;
                    break;
            }
        }
    }
}
