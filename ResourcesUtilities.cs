﻿using System;
using UnityEngine;

namespace JimmysUnityUtilities
{
    public static class ResourcesUtilities
    {
        public static string ReadTextFromFile(string filePath)
        {
            var textAsset = Resources.Load<TextAsset>(filePath);
            if (textAsset == null)
                throw new Exception("The file you specified doesn't exist in Resources :(");

            string text = textAsset.text;
            Resources.UnloadAsset(textAsset);

            return text;
        }
    }
}