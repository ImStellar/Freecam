﻿using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using VRC;
using VRC.Core;
using VRC.SDKBase;

namespace FreeCamMain
{
    internal static class PlayerExtensions
    {
        // These extensions were made by Love, Day, me, and probably a few other coders credits to them
        public static VRCPlayer LocalVRCPlayer => VRCPlayer.field_Internal_Static_VRCPlayer_0;

        public static Player LocalPlayer => Player.prop_Player_0;

        public static void FreezeLocalPlayer(bool enabled)
        {
            if (_localPlayerCollider == null) _localPlayerCollider = LocalVRCPlayer.GetComponent<Collider>();
            _localPlayerCollider.enabled = !enabled;
        }
        
        public static bool IsInWorld() => RoomManager.field_Internal_Static_ApiWorld_0 != null;

        private static Collider _localPlayerCollider;
    }
}