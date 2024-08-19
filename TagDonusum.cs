using System.Collections;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TagDonusum : MonoBehaviour
{
    public string tasTag = "tas"; 
    public string kagitTag = "kagit";
    public string makasTag = "makas";

    public Sprite makasSprite; // Yeni sprite ("kagit.png" gibi)
    public Sprite tasSprite;
    public Sprite kagitSprite;

    private void Start()
    {


    }




    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "kagit")
        {

            
            if (gameObject.CompareTag(tasTag))
            {
                gameObject.tag = kagitTag;

                if (kagitSprite != null)
                {
                    SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                    if (spriteRenderer != null)
                    {
                        spriteRenderer.sprite = kagitSprite;
                    }
                }
            }

        }


        if (collision.gameObject.tag == "tas")
        {


            if (gameObject.CompareTag(makasTag))
            {
                gameObject.tag = tasTag;

                if (tasSprite != null)
                {
                    SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                    if (spriteRenderer != null)
                    {
                        spriteRenderer.sprite = tasSprite;
                    }
                }
            }

        }






        if (collision.gameObject.tag == "makas")
        {


            if (gameObject.CompareTag(kagitTag))
            {
                gameObject.tag = makasTag;

                if (makasSprite != null)
                {
                    SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
                    if (spriteRenderer != null)
                    {
                        spriteRenderer.sprite = makasSprite;
                    }
                }
            }

        }









    }
}
