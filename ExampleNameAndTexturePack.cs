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

namespace ExampleNameAndTexturePack
{
	class ExampleNameAndTexturePack : Mod
	{
		public ExampleNameAndTexturePack()
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
            imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemTexture(ItemID.Excalibur, ModLoader.GetTexture("ExampleNameAndTexturePack/Excalibur"));
            imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemTexture(ItemID.Muramasa, ModLoader.GetTexture("ExampleNameAndTexturePack/Muramasa"));
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
            imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemTexture(ModLoader.GetMod("imkSushisMod").ItemType("Cookie"), ModLoader.GetTexture("ExampleNameAndTexturePack/Cookie"));
            }
            if (ModLoader.GetLoadedMods().Contains("imkSushisMod"))
            {
            imkSushisDataPacksMod.imkSushisDataPacksMod.ChangeItemTexture(ModLoader.GetMod("imkSushisMod").ItemType("ToyTank"), ModLoader.GetTexture("ExampleNameAndTexturePack/ToyTank"));
            }
		}
	}
}
