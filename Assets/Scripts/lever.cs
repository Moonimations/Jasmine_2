using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class lever : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject waterrad;
    public GameObject waterrad_moving;
    public GameObject fog;
    public AudioClip pull;

    void Start()
    {
        waterrad_moving.SetActive(false);
        GetComponent<AudioSource>().playOnAwake = false;
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            GetComponent<AudioSource>().Play();
            waterrad.SetActive(false);
            waterrad_moving.SetActive(true);
            StartCoroutine("WaitForSec");

        }

    }
    IEnumerator WaitForSec()
    {
        yield return new WaitForSeconds(8);
        waterrad_moving.SetActive(false);
        waterrad.SetActive(true);
        fog.SetActive(false);
    }


}

