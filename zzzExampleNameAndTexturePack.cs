using System;
using System.IO;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using imkSushisDataPacksMod;
using zzzExampleNameAndTexturePack;

namespace zzzExampleNameAndTexturePack
{
	class zzzExampleNameAndTexturePack : Mod
	{
		public zzzExampleNameAndTexturePack()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}

		public override void PostSetupContent()
		{
			imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemName(ItemID.TinBar, "Potatoe");
			imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemName(ItemID.CobaltShield, "Shield of Knockbacklessness");
            imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemTexture(ItemID.Excalibur, ModLoader.GetTexture("zzzExampleNameAndTexturePack/Excalibur"));
            imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemTexture(ItemID.Muramasa, ModLoader.GetTexture("zzzExampleNameAndTexturePack/Muramasa"));
            if (ModLoader.GetLoadedMods().Contains("imkSushisMod"))
            {
                imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemName(ModLoader.GetMod("imkSushisMod").ItemType("Cookie"), "Not a Cookie");
            }
            if (ModLoader.GetLoadedMods().Contains("imkSushisMod"))
            {
                imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemName(ModLoader.GetMod("imkSushisMod").ItemType("AnglerAmnesiaPotion"), "Potion of Forgetting");
            }
            if (ModLoader.GetLoadedMods().Contains("imkSushisMod"))
            {
            imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemTexture(ModLoader.GetMod("imkSushisMod").ItemType("Cookie"), ModLoader.GetTexture("zzzExampleNameAndTexturePack/Cookie"));
            }
            if (ModLoader.GetLoadedMods().Contains("imkSushisMod"))
            {
            imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemTexture(ModLoader.GetMod("imkSushisMod").ItemType("ToyTank"), ModLoader.GetTexture("zzzExampleNameAndTexturePack/ToyTank"));
            }
		}
	}
}
