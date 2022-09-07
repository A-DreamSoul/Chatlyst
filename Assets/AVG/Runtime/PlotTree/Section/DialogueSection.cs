﻿using System;
using UnityEngine;

namespace AVG.Runtime.PlotTree
{
    [Serializable]
    public struct Dialogue
    {
        [DisplayOnly] public string name;
        [DisplayOnly] public string text;
    }

    [Serializable]
    public class DialogueSection : Section
    {
        [Header("Dialogue")]
        // private List<Dialogue> dialogues ;
        [DisplayOnly] public string characterName;
        [DisplayOnly] public string dialogueText;
    }
}