using UnityEngine;
using UnityEngine.UI;

public class SliderValue : MonoBehaviour 
{
    public Slider MySlider;
    public Text ValuoOfSlider; 

    void Update()
    {
        PlayerPrefs.SetFloat("GetWordSpeed", MySlider.value);   
    }
}