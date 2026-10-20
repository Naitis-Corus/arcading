using UnityEngine;

public class bescnoscni_plotformig : MonoBehaviour
{
[SerializeField] GameObject platformi;
[SerializeField]GameObject platformi_pervaia;

[SerializeField] float dinctabci_ot_drugih_plapform =10f;

Vector3 posledina_zodania_platforma;

 Camera camera_main;
    void Awake()
    {
        camera_main =Camera.main;
    }
    void Start()
    {
        posledina_zodania_platforma = platformi_pervaia.transform.position;
    }

    void Update()
    {
        if (camera_main.transform.position.y > posledina_zodania_platforma.y - 8)
        {
            float random_x_btw = Random.Range(-10f,10f);
            while(Mathf.Abs(random_x_btw - posledina_zodania_platforma.x) < 5f )
            {
               random_x_btw = Random.Range(-10f,10f);
            }
          
            Vector3 novi_postion_platfrom = new Vector3(random_x_btw,posledina_zodania_platforma.y + dinctabci_ot_drugih_plapform,0);
            Instantiate(platformi,novi_postion_platfrom,Quaternion.identity);
            posledina_zodania_platforma = novi_postion_platfrom;
        }
    }
}
