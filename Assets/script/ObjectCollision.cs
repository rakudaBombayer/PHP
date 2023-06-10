using System.Collections;
using System.Collections.Generic;
using UnityEngine;





public class ObjectCollision : MonoBehaviour
{   
    public GameObject explosionEffect; // エフェクトのプレハブをアサインする
    public AudioClip collisionSound;    // 衝突時に再生する効果音
    public float soundVolume = 1.0f;    // 効果音の音量

    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = soundVolume;
    }


    private void OnCollisionEnter(Collision collision)
    {
        // 衝突したオブジェクトを非アクティブにする
        collision.gameObject.SetActive(false);

        // エフェクトを生成して再生する
        Instantiate(explosionEffect, collision.transform.position, Quaternion.identity);

        // 効果音を再生する
        audioSource.PlayOneShot(collisionSound);
    }
}

