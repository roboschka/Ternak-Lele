using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerLeve : MonoBehaviour
{
    public GameObject guiObject;
    public string levelToLoad;

    // Start is called before the first frame update
    void Start()
    {
        guiObject.SetActive(false);
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            guiObject.SetActive(true);
            if (guiObject.activeInHierarchy == true && Input.GetButtonDown("Use"))
            {
                Application.LoadLevel(levelToLoad);
            }
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        guiObject.SetActive(false);
    }
}
