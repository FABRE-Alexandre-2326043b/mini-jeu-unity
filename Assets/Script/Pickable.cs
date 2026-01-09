using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickable : MonoBehaviour
{
    public AudioClip soundClip;
    [Range(0f, 5f)]
    public float soundVolume = 1f;

    public void pickUp()
    {
        Debug.Log(name + " est récupéré");

        if (name.Contains("Coin"))
            FindObjectOfType<PlayerInventory>().AddCoin(1);

        if (name.Contains("Key"))
            FindObjectOfType<PlayerInventory>().AddKey(1);

        AudioSource.PlayClipAtPoint(soundClip, Camera.main.transform.position, soundVolume);
        Destroy(gameObject);
    }
}
