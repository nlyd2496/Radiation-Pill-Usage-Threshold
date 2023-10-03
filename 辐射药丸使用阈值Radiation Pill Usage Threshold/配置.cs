using System;
using Newtonsoft.Json;
using PeterHan.PLib.Options;

namespace 辐射药丸使用阈值Radiation_Pill_Usage_Threshold
{
    [RestartRequired]
    [JsonObject(MemberSerialization.OptIn)]
	[ConfigFile("Controler.json", true, false)]
    [ModInfo("https://github.com/nlyd2496/Radiation-Pill-Usage-Threshold.git", "mmm.png", true)]
    public class TestModSettings
	{
        //--------------------------
        [Option("Radiation Threshold", "喵喵喵", "辐射阈值", Format = "F0")]
        [JsonProperty]
        [Limit(200.0, 1000.0)]
        public float a1 { get; set; } = 200f;
        //--------------------------
    }
}
