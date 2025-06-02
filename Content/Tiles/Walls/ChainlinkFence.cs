using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheAuroraMod.Content.Tiles.Walls
{
	public class ChainlinkFence: ModItem
    {
	public override void SetStaticDefaults()
	{
	//DisplayName.SetDefault("Chain-link Fence");
	
	//Tooltip.SetDefault("''");

        Item.ResearchUnlockCount = 400;

	}
	public override void SetDefaults()
	{
	    Item.width = 24;
	    Item.height = 24;
	    Item.value = Item.sellPrice(gold: 0);
	    Item.rare = ItemRarityID.White;
	    Item.DefaultToPlaceableWall(ModContent.WallType<ChainlinkFencePlaced>());
	}

	public override void AddRecipes()
	{
		CreateRecipe(4)
		.AddIngredient(ItemID.Chain, 5)
		.AddRecipeGroup(RecipeGroupID.IronBar, 3)
		.AddTile(TileID.Anvils)
		.Register();
	}
    }
}