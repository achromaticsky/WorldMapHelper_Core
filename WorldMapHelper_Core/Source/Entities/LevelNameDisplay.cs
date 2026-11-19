using Celeste.Mod.Entities;
using Microsoft.Xna.Framework;
using Monocle;
namespace Celeste.Mod.WorldMapHelper_Core.Entities
{
    [CustomEntity("WorldMapHelper/LevelNameDisplay")]
    [Tracked]
    class LevelNameDisplay : Entity
    {

        private string Text;
        private string ExitsText;
        private string StrawberriesText;
        public LevelNameDisplay(Vector2 position) : base(position)
        {
            this.AddTag(TagsExt.SubHUD);
            //ExitsText = "Exits: 1/2";
            //StrawberriesText = "Strawberries: 0/5";
        }

        public string Text1 { get => Text; set => Text = value; }
        public string Exits { get => ExitsText; set => ExitsText = value; }

        public string Strawberries { get => ExitsText; set => ExitsText = value; }

        public override void Render()
        {
            
            Fonts.Get("Renogare").DrawOutline(4, Text, new Vector2(1890f, 20f), new Vector2(1, 0), new Vector2(20f, 20f), Color.White, 1f, Color.Black);
            //Fonts.Get("Renogare").DrawOutline(4, ExitsText, new Vector2(1890f, 100f), new Vector2(1, 0), new Vector2(12f, 12f), Color.White, 1f, Color.Black);
            //Fonts.Get("Renogare").DrawOutline(4, StrawberriesText, new Vector2(1890f, 140f), new Vector2(1, 0), new Vector2(12f, 12f), Color.White, 1f, Color.Black);
            //ActiveFont.DrawOutline(Text, new Vector2(20, 20), new Vector2(0, 0), new Vector2(20f, 20f), Color.White, 1f, Color.Black);
            base.Render();
        }


    }

}
