using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    //Use this for initialization
    void Start()
    {

        //【課題】要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化してください
        int[] array = new int[5];

        //代入する
        array[0] = 1;
        array[1] = 2;
        array[2] = 3;
        array[3] = 4;
        array[4] = 5;


        //【課題①】for文を使い、配列の各要素の値を順番に表示してください
        for (int i = 0; i < 5; i++)

        {
            Debug.Log(array[i]);
        }

        //【課題②】for文を使い、配列の各要素の値を逆順に表示してください
        for (int i = 4; i>=0; i--)

        {
            Debug.Log(array[i]);
        }

    }
        // Update is called once per frame
        void Update()
        {
        }


}