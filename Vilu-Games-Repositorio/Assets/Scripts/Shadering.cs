﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shadering : MonoBehaviour
{
    public Material material;

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        Graphics.Blit(source, destination, material);
    }
}
