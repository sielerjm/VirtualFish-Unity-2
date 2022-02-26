using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    public Sprite[] background;
    public SpriteRenderer[] bgRenderer;

    public void changeBackground()
    {
        
    }

    private void backgroundRenderer(SpriteRenderer[] spriteRenderers, Sprite[] sprites)
    {
        

        if (NeedsController.tankClean <= 100 & NeedsController.tankClean > 80)
        {
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                spriteRenderer.sprite = sprites[0];
            }
            
        }
        else if (NeedsController.tankClean <= 80 & NeedsController.tankClean > 60)
        {
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                spriteRenderer.sprite = sprites[1];
            }
        }
        else if (NeedsController.tankClean <= 70 & NeedsController.tankClean > 60)
        {
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                spriteRenderer.sprite = sprites[2];
            }
        }
        else if (NeedsController.tankClean <= 60 & NeedsController.tankClean > 50)
        {
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                spriteRenderer.sprite = sprites[3];
            }
        }
        else if (NeedsController.tankClean <= 50 & NeedsController.tankClean > 40)
        {
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                spriteRenderer.sprite = sprites[4];
            }
        }
        else if (NeedsController.tankClean <= 40 & NeedsController.tankClean > 30)
        {
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                spriteRenderer.sprite = sprites[5];
            }
        }
        else if (NeedsController.tankClean <= 30 & NeedsController.tankClean >= 0)
        {
            foreach (SpriteRenderer spriteRenderer in spriteRenderers)
            {
                spriteRenderer.sprite = sprites[6];
            }
        }
    }
}
