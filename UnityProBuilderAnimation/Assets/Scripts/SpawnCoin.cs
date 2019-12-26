using System.Collections;
using UnityEngine;

public class SpawnCoin : MonoBehaviour
{
    [Header("金幣")]
    public GameObject coin;
    private AudioSource aud;
    [Header("音效")]
    public AudioClip clip;

    private void Start()
    {
        aud = gameObject.GetComponent<AudioSource>();
    }

    public void Spawn()
    {
        Instantiate(coin, new Vector3(0,0,0), Quaternion.identity);
        aud.PlayOneShot(clip);
    }
}
