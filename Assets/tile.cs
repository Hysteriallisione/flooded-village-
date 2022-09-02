using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tile : MonoBehaviour
{
    [SerializeField] public Color sand, water;
    [SerializeField] public SpriteRenderer ColorRenderer;
    // Start is called before the first frame update
    public void Init (bool sand)
    {
      //ColorRenderer.color = sand ? sand : water;
    }
}

