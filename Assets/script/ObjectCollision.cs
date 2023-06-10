using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCollision : MonoBehaviour
{   
    public GameObject explosionEffect; // エフェクトのプレハブをアサインする

    private void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトを非アクティブにする
        collision.gameObject.SetActive(false);

        // エフェクトを生成して再生する
        Instantiate(explosionEffect, collision.transform.position, Quaternion.identity);
    }
}

