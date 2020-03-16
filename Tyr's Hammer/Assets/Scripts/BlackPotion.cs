using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPotion : MonoBehaviour
{
    [SerializeField] AudioClip drinkSound;
    [SerializeField] float scaleSize = 1.2f;
    //    [SerializeField] Player myCharacter;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        AudioSource.PlayClipAtPoint(drinkSound, Camera.main.transform.position);
        Vector3 scaleUp = collision.transform.localScale;
        scaleUp.x *= scaleSize;
        scaleUp.y *= scaleSize;
        collision.transform.localScale = scaleUp;
        Destroy(gameObject);
    }

}
