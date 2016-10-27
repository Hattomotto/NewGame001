using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            //altseedの初期化
            asd.Engine.Initialize("Empty", 960, 640, new asd.EngineOption());

            asd.TextureObject2D player = new asd.TextureObject2D();

            player.Texture = asd.Engine.Graphics.CreateTexture2D("Resources/playerfly.png");

            asd.Engine.AddObject2D(player);

            while (asd.Engine.DoEvents()) {

                if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Escape) == asd.KeyState.Push)
                    break;

                asd.Engine.Update();
            }

              
            asd.Engine.Terminate();
        }
    }
}
