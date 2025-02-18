﻿using Maple2Storage.Tools;
using MapleServer2.Packets;
using MapleServer2.Types;

namespace MapleServer2.Triggers
{
    public partial class TriggerContext
    {
        public void SetActor(int actorId, bool isVisible, string stateName, bool arg4, bool arg5)
        {
            Field.State.TriggerActors[actorId].IsVisible = isVisible;
            Field.State.TriggerActors[actorId].StateName = stateName;
            Field.BroadcastPacket(TriggerPacket.UpdateTrigger(Field.State.TriggerActors[actorId]));
        }

        public void SetAgent(int[] arg1, bool arg2)
        {
        }

        public void SetCube(int[] triggerIds, bool isVisible, byte randomCount)
        {
            foreach (int triggerId in triggerIds)
            {
                Field.State.TriggerCubes[triggerId].IsVisible = isVisible;
                Field.BroadcastPacket(TriggerPacket.UpdateTrigger(Field.State.TriggerCubes[triggerId]));
            }
        }

        public void SetEffect(int[] triggerIds, bool isVisible, int arg3, byte arg4)
        {
            foreach (int triggerId in triggerIds)
            {
                Field.State.TriggerEffects[triggerId].IsVisible = isVisible;
                Field.BroadcastPacket(TriggerPacket.UpdateTrigger(Field.State.TriggerEffects[triggerId]));
            }
        }

        public void SetInteractObject(int[] interactObjectIds, byte state, bool arg4, bool arg3)
        {
            //This should be correct, but the current way of parsing interactObjects does not comply with triggerScripts. Needs changing.
            foreach (int interactObjectId in interactObjectIds)
            {
                //Field.State.InteractObjects[interactObjectId].Id = state
                Field.BroadcastPacket(InteractObjectPacket.ActivateInteractObject(interactObjectId));
            }
        }

        public void SetLadder(int ladderId, bool isVisible, bool animationEffect, byte animationDelay)
        {
            Field.State.TriggerLadders[ladderId].IsVisible = isVisible;
            Field.State.TriggerLadders[ladderId].AnimationEffect = animationEffect;
            Field.State.TriggerLadders[ladderId].AnimationDelay = animationDelay;
            Field.BroadcastPacket(TriggerPacket.UpdateTrigger(Field.State.TriggerLadders[ladderId]));
        }

        public void SetMesh(int[] meshIds, bool isVisible, int arg3, int arg4, float arg5)
        {
            foreach (int triggerMeshId in meshIds)
            {
                Field.State.TriggerMeshes[triggerMeshId].IsVisible = isVisible;
                Field.BroadcastPacket(TriggerPacket.UpdateTrigger(Field.State.TriggerMeshes[triggerMeshId]));
            }
        }

        public void SetMeshAnimation(int[] arg1, bool arg2, byte arg3, byte arg4)
        {
        }

        public void SetBreakable(int[] arg1, bool arg2)
        {
        }

        public void SetPortal(int portalId, bool visible, bool enabled, bool minimapVisible, bool arg5)
        {
            if (Field.State.Portals.IsEmpty)
            {
                return;
            }

            IFieldObject<Portal> portal = Field.State.Portals.Values.First(p => p.Value.Id == portalId);
            if (portal == null)
            {
                return;
            }
            portal.Value.Update(visible, enabled, minimapVisible);
            Field.BroadcastPacket(FieldPacket.UpdatePortal(portal));
        }

        public void SetRandomMesh(int[] meshIds, bool isVisible, byte meshCount, int arg4, int delayTime)
        {
            Random random = RandomProvider.Get();
            int[] pickedMeshIds = meshIds.OrderBy(x => random.Next()).Take(meshCount).ToArray();
            Task.Run(async () =>
            {
                foreach (int triggerMeshId in pickedMeshIds)
                {
                    Field.State.TriggerMeshes[triggerMeshId].IsVisible = isVisible;
                    Field.BroadcastPacket(TriggerPacket.UpdateTrigger(Field.State.TriggerMeshes[triggerMeshId]));
                    await Task.Delay(delayTime);
                }
            });
        }

        public void SetRope(int ropeId, bool isVisible, bool animationEffect, byte animationDelay)
        {
            Field.State.TriggerRopes[ropeId].IsVisible = isVisible;
            Field.State.TriggerRopes[ropeId].AnimationEffect = animationEffect;
            Field.State.TriggerRopes[ropeId].AnimationDelay = animationDelay;
            Field.BroadcastPacket(TriggerPacket.UpdateTrigger(Field.State.TriggerLadders[ropeId]));
        }

        public void SetSkill(int[] arg1, bool arg2)
        {
        }

        public void SetSound(int soundId, bool isEnabled)
        {
            Field.State.TriggerSounds[soundId].IsEnabled = isEnabled;
            Field.BroadcastPacket(TriggerPacket.UpdateTrigger(Field.State.TriggerSounds[soundId]));
        }

        public void SetVisibleBreakableObject(int[] arg1, bool arg2)
        {
        }

        public void CreateItem(int[] arg1, int arg2, int arg3, int arg5)
        {
        }

        public void SpawnItemRange(int[] rangeId, byte randomPickCount)
        {
        }
    }
}
