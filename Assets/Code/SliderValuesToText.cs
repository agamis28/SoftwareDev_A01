using UnityEngine;
using UnityEngine.UI;

public class SliderValuesToText : MonoBehaviour
{
    private Slider slider;

    private void Start()
    {
        slider = GetComponent<Slider>();
    }
    public void ValueToTextPercent(Text text)
    {
        text.text = Mathf.Round(slider.value * 100) + "%";
    }
    public void ValueToTextDirect(Text text)
    {
        text.text = Mathf.Round(slider.value * 100) / 100 + "x";
    }
}
