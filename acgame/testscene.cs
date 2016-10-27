using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace game1
{
    class TestScene : asd.Scene
    {
        protected override void OnRegistered()
        {
            // 2Dを表示するレイヤーのインスタンスを生成する。
            asd.Layer2D layer = new asd.Layer2D();

            // シーンにレイヤーのインスタンスを追加する。
            AddLayer(layer);

            // プレイヤーを表示するオブジェクトのインスタンスを生成する。
            asd.TextureObject2D player = new asd.TextureObject2D();
            player.Texture = asd.Engine.Graphics.CreateTexture2D("Resources/game.png");

            // レイヤーにオブジェクトのインスタンスを追加する。
            layer.AddObject(player);
        }
    }
}
