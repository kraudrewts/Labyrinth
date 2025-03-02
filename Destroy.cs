using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Уничтожаем текущий объект, на котором висит этот скрипт, в начале игры
        Destroy(gameObject);  // Удаляем объект, к которому прикреплен этот скрипт       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
