using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{

    [SerializeField] int firstLevel = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene(firstLevel);
    }

}
