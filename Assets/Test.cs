using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    int mp = 53; //マジックポイントを53で初期化する
    int Magicloss = 5; // 魔法消費を5で初期化する

        
    // 魔法攻撃用の関数
    public void Magicattack()

    {
        if (mp > 5) //MPが5以上ある場合

        {
            this.mp -= Magicloss;　//MPを5減らす
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp);

        }
        else　//MPが5未満で足りない場合
        {

            Debug.Log("MPが足りないため、魔法が使えない。");
        }

    }

}　//↑↑↑ここまでがBossクラス↑↑↑

public class Test : MonoBehaviour
{
    void Start()

    {

        // Bossクラスの変動を宣言してインスタンスを代入
        Boss lastboss = new Boss();

        for (int i = 0; i <= 10; i++)

        { 
            //魔法攻撃用の関数を呼び出す
            lastboss.Magicattack();
        }

    }

    //Update is called once per frame
    void Update ()
    {

    }
}
