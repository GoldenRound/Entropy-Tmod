using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items
{
	public class CopperClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Copper Claymore");
			Tooltip.SetDefault("No one uses copper.");
		}
		public override void SetDefaults()
		{
			item.damage = 16;
			item.melee = true;
			item.width = 40;
			item.height = 40;
			item.useTime = 50;
			item.useAnimation = 60;
			item.useStyle = 1;
			item.knockBack = 15;
			item.value = 10;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.CopperBar, 12);
			recipe.AddTile(TileID.Anvils);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
