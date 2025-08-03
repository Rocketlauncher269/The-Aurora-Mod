using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheAuroraMod.Content.Projectiles.Tools;

namespace TheAuroraMod.Content.Items.Tools.Drills
{
    public class TheExcavator : ModItem
    {
        public override void SetStaticDefaults()
        {

        }

        public override void SetDefaults()
        {
            Item.damage = 2;
            Item.DamageType = DamageClass.Melee;
            Item.width = 44;
            Item.height = 28;
            Item.useTime = 2;
            Item.useAnimation = 15;
            Item.useStyle = ItemUseStyleID.Shoot;
            Item.channel = true;
            Item.knockBack = 0.5f;
            Item.UseSound = SoundID.Item23;
            Item.autoReuse = true;
            Item.useTurn = true;
            Item.pick = 35;
            Item.noUseGraphic = true;
            Item.noMelee = true;
            Item.shoot = ModContent.ProjectileType<TheExcavatorProjectile>();
            Item.shootSpeed = 32;
        }
    }
}