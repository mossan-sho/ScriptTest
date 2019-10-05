using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;          // 体力
    private int power = 25; // 攻撃力
    private int mp = 53;

    // 攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    // 防御用の関数
    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
        // 残りhpを減らす
        this.hp -= damage;
    }

    public void Magic()
    {
        if (mp < 5)
        {
            Debug.Log("MPが足りないために魔法が使えない。");
        }
        else
        {
            mp -= 5;
            Debug.Log("魔法攻撃をした。残りMPは" + this.mp + "。");
        }   
    }

}

public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 4, 2, 7, 8, 5 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int j = array.Length - 1; j >= 0; j--)
        {
            Debug.Log(array[j]);
        }

        Boss lastboss = new Boss();

        lastboss.Magic();

        for (int n=0; n < 10; n++)
        {
            lastboss.Magic();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
