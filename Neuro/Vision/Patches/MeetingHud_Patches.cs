﻿using HarmonyLib;

namespace Neuro.Vision.Patches;

[HarmonyPatch(typeof(MeetingHud), nameof(MeetingHud.Start))]
public static class MeetingHud_Start
{
    [HarmonyPostfix]
    public static void Postfix()
    {
        NeuroPlugin.Instance.Vision.ReportFindings();
    }
}
