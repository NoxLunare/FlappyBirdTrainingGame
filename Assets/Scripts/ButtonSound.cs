using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{ 
    
    public Button button;

    private void Awake()
    {
        if(button == null)
        {
            button = gameObject.GetComponent<Button>();
        }
        button.onClick.AddListener(ClickSound);
    }

    public void ClickSound()
    {
        AudioManager.Instance.PlayButton();
    }
}
