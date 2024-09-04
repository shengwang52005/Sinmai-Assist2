﻿using HarmonyLib;
using Process.Entry.State;

namespace Fix
{
    public class SkipVersionCheck
    {
        [HarmonyPrefix]
        [HarmonyPatch(typeof(ConfirmPlay), "IsValidVersion")]
        public static bool IsValidVersion(ref bool __result)
        {
            __result = true;
            return false;
        }
    }
}