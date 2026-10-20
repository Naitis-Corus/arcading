using TMPro;
using UnityEngine;

public class dlia_polzunka : MonoBehaviour
{
    [SerializeField] geroi gghka;
    [SerializeField] RectTransform strelochka;
    [SerializeField] RectTransform dlina_lenii_sleva;
    [SerializeField] TextMeshProUGUI textish;
    int chetcik_visoty = 0;
    float chetchik_poloski = 0;
 

    void Update()
    {
        if (chetcik_visoty <= gghka.transform.position.y)
        {
            chetcik_visoty = (int)gghka.transform.position.y;
        }
        textish.text =$"{chetcik_visoty}" + " M";
        chetchik_poloski = (float)chetcik_visoty / (chetcik_visoty + 1000);
        float realnoe_mesto_v_polocke = chetchik_poloski * dlina_lenii_sleva.rect.height;


        strelochka.anchoredPosition = new Vector2(strelochka.anchoredPosition.x, realnoe_mesto_v_polocke);
    }
}
