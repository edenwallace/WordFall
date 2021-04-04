using UnityEngine;
using UnityEngine.UI;

public class SliderVal : MonoBehaviour 
{
    public Slider MySlider;
    public Text ValuoOfSlider; 

    void Update()
    {
        PlayerPrefs.SetFloat("GetWordSpeed", MySlider.value);   
    }
}