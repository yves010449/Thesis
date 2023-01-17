using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskObjectUtil : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.maskInteraction = SpriteMaskInteraction.VisibleInsideMask;
    }


}
