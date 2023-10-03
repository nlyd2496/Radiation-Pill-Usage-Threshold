using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;
using Klei.AI;
using PeterHan.PLib.Core;
using PeterHan.PLib.Options;
using Newtonsoft.Json;

namespace 辐射药丸使用阈值Radiation_Pill_Usage_Threshold
{
    public class MM202310031613GG1
    {
        [HarmonyPatch(typeof(MedicinalPillWorkable), "CanBeTakenBy")]
        public static class mm202310031613gg1
        {
            public static void Postfix(ref bool __result, ref MedicinalPill ___pill, GameObject consumer)
            {
                if (___pill.info.id == "BasicRadPill")
                {
                    if (consumer.GetAmounts().Get(Db.Get().Amounts.RadiationBalance.Id).value < SingletonOptions<TestModSettings>.Instance.a1)
                    {
                        __result = false;
                    }
                }
            }
        }
    }
}
