using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class InfoController : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI placeholder;

    public void LoadTextInPlaceholder(string text)
    {
        placeholder.text = text;
    }

    public void ClearPlaceholder()
    {
        placeholder.text = "";
    }
}
