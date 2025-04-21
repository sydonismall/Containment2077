using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PhoneTooltip : MonoBehaviour
{
    public static PhoneTooltip _instance;

    public TextMeshProUGUI textComponent;

    private void Awake()
    {
        if (_instance != null && _instance != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            _instance = this;
        }
    }
}
