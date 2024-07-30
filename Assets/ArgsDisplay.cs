using UnityEngine;
using UnityEngine.UIElements;
using System;

public sealed class ArgsDisplay : MonoBehaviour
{
    void Start()
    {
        var text = string.Join("\n", Environment.GetCommandLineArgs());
        var root = GetComponent<UIDocument>().rootVisualElement;
        root.Q<Label>().text = "Command line arguments:\n" + text;
    }
}
