using System;
using HarmonyLib;
using KMod;
using UnityEngine.Diagnostics;
using PeterHan.PLib.Options;

namespace 辐射药丸使用阈值Radiation_Pill_Usage_Threshold
{
	public class ModLoad : UserMod2
	{
        public static string Namespace { get; private set; }
        public override void OnLoad(Harmony harmony)
		{
            //--------------------------
            base.OnLoad(harmony);
            ModLoad.Namespace = base.GetType().Namespace;
            //--------------------------
            //参数控制器组件
            //LocString.CreateLocStringKeys(typeof(UII), "STRINGS.");
            //--------------------------
            //配置项组件
            new POptions().RegisterOptions(this, typeof(TestModSettings));
            //--------------------------
            Namespace = base.GetType().Namespace;
            //--------------------------
        }
        //------------------------------------------------------------------------------------------------
    }
}