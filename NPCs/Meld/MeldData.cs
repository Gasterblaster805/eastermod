using Terraria;
using Terraria.Graphics.Shaders;
using Terraria.ModLoader;

namespace eastermod.NPCs.Meld
{
	public class MeldData : ScreenShaderData
	{
		private int MeldIndex;

		public MeldData(string passName)
			: base(passName)
		{
		}

		private void UpdateMeldIndex()
		{
			int MeldType = ModLoader.GetMod("eastermod").NPCType("Meld");
			if (MeldIndex >= 0 && Main.npc[MeldIndex].active && Main.npc[MeldIndex].type == MeldType)
			{
				return;
			}
			MeldIndex = -1;
			for (int i = 0; i < Main.maxNPCs; i++)
			{
				if (Main.npc[i].active && Main.npc[i].type == MeldType)
				{
					MeldIndex = i;
					break;
				}
			}
		}

		public override void Apply()
		{
			UpdateMeldIndex();
			if (MeldIndex != -1)
			{
				UseTargetPosition(Main.npc[MeldIndex].Center);
			}
			base.Apply();
		}
	}
}