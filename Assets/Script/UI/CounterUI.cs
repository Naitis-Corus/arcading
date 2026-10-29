using TMPro;
using UnityEngine;

public class CounterUI : MonoBehaviour
{
    [SerializeField] Player player;
    [SerializeField] RectTransform arrowUI;
    [SerializeField] RectTransform sliderUI;
    [SerializeField] TextMeshProUGUI textUI;
    int playerAltimeter = 0;
    float normalizedAltitude = 0;
 

    void Update()
    {
        if (playerAltimeter <= player.transform.position.y)
        {
            playerAltimeter = (int)player.transform.position.y;
        }
        textUI.text =$"{playerAltimeter} M";
        normalizedAltitude = (float)playerAltimeter / (playerAltimeter + 1000);
        float posForSlider = normalizedAltitude * sliderUI.rect.height;


        arrowUI.anchoredPosition = new Vector2(arrowUI.anchoredPosition.x, posForSlider);
    }
}
