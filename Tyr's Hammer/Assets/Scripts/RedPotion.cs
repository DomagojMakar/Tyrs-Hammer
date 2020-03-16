using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPotion : MonoBehaviour
{
    [SerializeField] AudioClip drinkSound;
    [SerializeField] float scaleSize = 0.9f;
    //    [SerializeField] Player myCharacter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(drinkSound, Camera.main.transform.position);
        Vector3 scaleDown = collision.transform.localScale;
        scaleDown.x *= scaleSize;
        scaleDown.y *= scaleSize;
        collision.transform.localScale = scaleDown;

        Destroy(gameObject);
    }
}
