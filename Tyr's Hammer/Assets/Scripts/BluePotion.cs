using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluePotion : MonoBehaviour
{
    [SerializeField] AudioClip drinkSound;
    [SerializeField] float speedTime = 1.5f;
    [SerializeField] float normalTime = 1f;
    [SerializeField] float durationEffect = 1f;
    //    [SerializeField] Player myCharacter;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(drinkSound, Camera.main.transform.position);
        collision.gameObject.GetComponent<Player>().SetRunSpeed(2);

        Destroy(gameObject);
    }

}