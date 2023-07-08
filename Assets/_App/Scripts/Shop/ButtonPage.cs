using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPage : MonoBehaviour
{
    public Image image;
    public Sprite chooseImage, unChooseIamge;
    public TextMeshProUGUI choos;
    public Color32 ChooseColor32, unChooseColor;

    void OnValidate()
    {
        choos = GetComponentInChildren<TextMeshProUGUI>();
    }
    
    public void Select()
    {
        //image.sprite = chooseImage;
        image.color = ChooseColor32;
        if(choos) choos.color = ChooseColor32;
    }
    
    public void UnSelect()
    {
        //image.sprite = unChooseIamge;
        image.color = unChooseColor;
        if(choos) choos.color = unChooseColor;
    }
}