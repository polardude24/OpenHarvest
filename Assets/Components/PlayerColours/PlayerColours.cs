﻿using BNG;
using System;
using UnityEngine;

public class PlayerColours : MonoBehaviour
{
    public Material skinMaterial;

    public void Refresh()
    {
        if (!GameState.settings.ContainsKey("skinColor"))
        {
            return;
        }

        Color color1;
        ColorUtility.TryParseHtmlString(GameState.settings["skinColor"], out color1);

        skinMaterial.color = color1;
    }
}