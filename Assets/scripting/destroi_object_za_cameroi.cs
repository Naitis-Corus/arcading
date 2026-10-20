using UnityEngine;

public class destroi_object_za_cameroi : MonoBehaviour
{

static Camera main_camera;
    void Awake()
    {
        if (main_camera == null)
        main_camera = Camera.main;
    }
    void Update()
    {
        if(main_camera.transform.position.y - 10 > transform.position.y)
        {
            Destroy(gameObject);
        }
    }
}
