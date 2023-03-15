using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollBG : MonoBehaviour
{
    public float scrollSpeed = 0.3f;
    private MeshRenderer meshRenderer;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();

    }

    private void Update()
    {
        Scroll();
    }

    private void Scroll()
    {
        Vector2 offset = meshRenderer.sharedMaterial.GetTextureOffset("_MainTex");
        offset.x += Time.deltaTime * scrollSpeed;
        meshRenderer.sharedMaterial.SetTextureOffset("_MainTex" ,offset);
    }
}
