using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheAuroraMod.Content.Tiles.Walls
{
	public class ChainlinkFencePlaced: ModWall
	{
		public override void SetStaticDefaults() {

		Main.wallLight[Type] = true;
		Main.wallHouse[Type] = false;

		DustType = DustID.Silver;

		AddMapEntry(new Color(153, 153, 153));
	}
    }
}