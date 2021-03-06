﻿using System;
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
            // Altseedを初期化する。
            asd.Engine.Initialize("Test", 640, 480, new asd.EngineOption());

            // タイトルのシーンのインスタンスを生成する。
            TestScene scene = new TestScene();

            // シーンを遷移する。
            asd.Engine.ChangeSceneWithTransition(scene, new asd.TransitionFade(0, 1.0f));

            // Altseedのウインドウが閉じられていないか確認する。
            while (asd.Engine.DoEvents())
            {
                // もし、Escキーが押されていたらwhileループを抜ける。
                if (asd.Engine.Keyboard.GetKeyState(asd.Keys.Escape) == asd.KeyState.Push)
                {
                    break;
                }

                // Altseedを更新する。
                asd.Engine.Update();
            }

            // Altseedの終了処理をする。
            asd.Engine.Terminate();
        }
    }


}