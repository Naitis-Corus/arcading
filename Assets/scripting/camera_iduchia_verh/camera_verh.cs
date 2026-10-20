using System;
using System.Collections;
using UnityEngine;

public class camera_verh : MonoBehaviour
{
    [SerializeField] geroi ggshka;
    [SerializeField] float scorosty_dvijenia_verh = 1.5f;
    [SerializeField] float vrema_dovedenia_Camere_Do_GG = 2f;
    Vector3 pos_gg;
    float krai_ecrana;
    void Start()
    {
        krai_ecrana = (Camera.main.orthographicSize * Camera.main.aspect) + 1f;
    }
    void Update()
    {

        float transform_icg = transform.position.y;
        if (ggshka.transform.position.y > transform.position.y)
        {
            
                float pos_do_gg = Mathf.Lerp(transform.position.y, ggshka.transform.position.y, vrema_dovedenia_Camere_Do_GG * Time.deltaTime);
                transform_icg = pos_do_gg;
            
        }
        else{

      
        transform_icg = transform_icg + (scorosty_dvijenia_verh * Time.deltaTime);}
        
        transform.position = new Vector3(transform.position.x,transform_icg,transform.position.z);

        if(Mathf.Abs(ggshka.transform.position.x) > krai_ecrana)
        {
            pos_gg = ggshka.transform.position;
            pos_gg.x = pos_gg.x > 0? -krai_ecrana:krai_ecrana;
            ggshka.transform.position = pos_gg;
        }
    }

}

