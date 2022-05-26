using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Track : MonoBehaviour{
    public GameObject[] obstacles;
    public Vector2 numObstacles;
    public GameObject[] money;
    public Vector2 amountOfMoney;

    [HideInInspector]
    public List<GameObject> newMoney;



    [HideInInspector]
    public List <GameObject> nObstacles;


    // Start is called before the first frame update
    void Start()
    {
        int newNumObstacles = (int)Random.Range(numObstacles.x, numObstacles.y);

        for (int i = 0; i < newNumObstacles; i++)
        {
            nObstacles.Add(Instantiate(obstacles[Random.Range(0, obstacles.Length)], transform));
            nObstacles[i].SetActive(false);
        }

        LayoutObstacles();

        int newNumMoney = (int)Random.Range(amountOfMoney.x, amountOfMoney.y);

        for (int i = 0; i < newNumMoney; i++)
        {
            newMoney.Add(Instantiate(money, transform));
            newMoney[i].SetActive(false);
        }
        LayoutObstacles();
        LayoutMoney();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void LayoutObstacles()
    {
        for(int i = 0; i < nObstacles.Count; i++)
        {
            float pXmin = (30f / nObstacles.Count) + (30f / nObstacles.Count)*i;
            float pXmax = (30f / nObstacles.Count) + (30f / nObstacles.Count) * i +1;
            nObstacles[i].transform.localPosition = new Vector3(Random.Range(pXmin, pXmax), 0 , 0);
            nObstacles[i].SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Car"))
        {

            transform.position = new Vector3 (0, 0, (transform.position.z + 80 * 2));
        }
    }

    void LayoutMoney()
    {
        float minZP = 10f;
        for (int i = 0; i < newMoney.Count, i++)
        {
            float maxZP = minZP + 5f;
            float randomZP = Random.Range(minZP, maxZP)
            newMoney[i].transform.localPosition = new vector3(transform.position.x, transfrom.position.y, randomZP)
            newMoney[i].SetActive(true);
            minZP = randomZP + 1;

        }


    }


}
