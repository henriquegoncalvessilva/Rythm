using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonController : MonoBehaviour
{



    [SerializeField]
    KeyCode key;

    [SerializeField]
    Sprite defaultSprite,pressedSprite;

    [SerializeField]
    SpriteRenderer renderer;

    private void Start()
    {

        renderer = GetComponent<SpriteRenderer>();
    }



    private void Update()
    {
        //rg.velocity = Vector2.down * speed;

        if (Input.GetKeyDown(key))
        {
            renderer.sprite = pressedSprite;

        }

        if (Input.GetKeyUp(key))
        {
            renderer.sprite = defaultSprite;
        }

    }


}
