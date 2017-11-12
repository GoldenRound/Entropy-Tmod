using Terraria.ID;
using Terraria.ModLoader;

namespace Entropy.Items
{
	public class WoodenClaymore : ModItem
	{
		public override void SetStaticDefaults()
		{
            DisplayName.SetDefault("Wooden Claymore");
            Tooltip.SetDefault("Still better than a Shortsword.");
		}
		public override void SetDefaults()
		{
            item.damage = 12;
			item.melee = true;
			item.width = 40;
			item.height = 40;
            item.useTime = 50;
			item.useAnimation = 45;
			item.useStyle = 1;
            item.knockBack = 13;
            item.value = 0;
			item.rare = 1;
			item.UseSound = SoundID.Item1;
			item.autoReuse = false;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.Wood, 21);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}
