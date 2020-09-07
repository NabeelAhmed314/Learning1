using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scrolling : MonoBehaviour
{
    public MeshRenderer groundRend;

    private void Update()
    {
        groundRend.material.mainTextureOffset += new Vector2(2f * Time.deltaTime,0f);
    }
}
